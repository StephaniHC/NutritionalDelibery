using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;
using Microsoft.Extensions.Hosting;
using NutritionalDelibery.Application;
using NutritionalDelibery.Domain.Abstractions;
using NutritionalDelibery.Domain.DeliveryNote;
using NutritionalDelibery.Domain.DeliveryRoute;
using NutritionalDelibery.Domain.ExitNote;
using NutritionalDelibery.Domain.ExitNoteDetail;
using NutritionalDelibery.Infrastructure.DomainModel;
using NutritionalDelibery.Infrastructure.Extension;
using NutritionalDelibery.Infrastructure.Repositories;
using NutritionalDelibery.Infrastructure.StoredModel;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection;
using System.Text;
using System.Threading.Tasks;

namespace NutritionalDelibery.Infrastructure
{
    public static class DependencyInjection
    {
        public static IServiceCollection AddInfrastructure(this IServiceCollection services, IConfiguration configuration, IHostEnvironment environment)
        {
            services.AddMediatR(config =>
                    config.RegisterServicesFromAssembly(Assembly.GetExecutingAssembly())
                );
            var connectionString = configuration.GetConnectionString("DefaultConnection");
            services.AddDbContext<StoredDbContext>(context =>
                    context.UseNpgsql(connectionString));
            services.AddDbContext<DomainDbContext>(context =>
                    context.UseNpgsql(connectionString));

            services.AddScoped<IDeliveryNoteRepository, DeliveryNoteRepository>();
            services.AddScoped<IDeliveryRouteRepository, DeliveryRouteRepository>();
            services.AddScoped<IExitNoteRepository, ExitNoteRepository>();
            services.AddScoped<IExitNoteDetailRepository, ExitNoteDetailRepository>(); 
            services.AddScoped<IUnitOfWork, UnitOfWork>();

            services.AddAplication()
                .AddSecrets(configuration, environment)
                .AddRabbitMQ();

            return services;
        }
    }
}
