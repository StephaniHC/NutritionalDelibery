# Usa la imagen base de .NET 8.0 SDK para compilar la aplicación
FROM mcr.microsoft.com/dotnet/aspnet:8.0 AS base
WORKDIR /app
ENV ASPNETCORE_URLS=http://+:5085
ENV ASPNETCORE_ENVIRONMENT=Development
EXPOSE 5085
 
FROM mcr.microsoft.com/dotnet/sdk:8.0 AS build
WORKDIR /src

# Copia los archivos de la solución y restaura las dependencias

COPY ["NutritionalDelibery.sln", "."]
COPY ["NutritionalDelibery.Domain/NutritionalDelibery.Domain.csproj", "NutritionalDelibery.Domain/"]
COPY ["NutritionalDelibery.Application/NutritionalDelibery.Application.csproj", "NutritionalDelibery.Application/"]
COPY ["NutritionalDelibery.Infrastructure/NutritionalDelibery.Infrastructure.csproj", "NutritionalDelibery.Infrastructure/"] 
COPY ["NutritionalDelibery.WebApi/NutritionalDelibery.WebApi.csproj", "NutritionalDelibery.WebApi/"]
COPY ["NutritionalDelibery.Integration/NutritionalDelibery.Integration.csproj", "NutritionalDelibery.Integration/"] 

# Restaura los paquetes NuGet
RUN dotnet restore "./NutritionalDelibery.WebApi/NutritionalDelibery.WebApi.csproj" 																					 

# Copia todo el código fuente
COPY . . 
WORKDIR "/src/NutritionalDelibery.WebApi"
RUN dotnet build "NutritionalDelibery.WebApi.csproj" -c Release -o /app/build/webapi
  
FROM build AS publish
WORKDIR "/src/NutritionalDelibery.WebApi"
RUN dotnet publish "./NutritionalDelibery.WebApi.csproj" -c Release -o /app/publish/webapi /p:UseAppHost=false
 
# Crea la imagen final
FROM base AS final
WORKDIR /app
COPY --from=publish /app/publish/webapi . 

# Crea el script de inicio
RUN echo '#!/bin/bash \n\
dotnet /app/NutritionalDelibery.WebApi.dll \n\ 
wait' > /app/entrypoint.sh && \
chmod +x /app/entrypoint.sh

ENTRYPOINT ["/bin/bash", "/app/entrypoint.sh"] 