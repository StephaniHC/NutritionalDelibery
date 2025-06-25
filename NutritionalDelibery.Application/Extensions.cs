using Microsoft.Extensions.DependencyInjection;
using NutritionalDelibery.Domain.DeliveryNote;
using NutritionalDelibery.Domain.DeliveryRoute;
using NutritionalDelibery.Domain.ExitNote;
using NutritionalDelibery.Domain.ExitNoteDetail;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection;
using System.Text;
using System.Threading.Tasks;

namespace NutritionalDelibery.Application
{
    public static class Extensions
    {
        public static IServiceCollection AddAplication(this IServiceCollection services)
        {
            services.AddMediatR(config =>
                config.RegisterServicesFromAssembly(Assembly.GetExecutingAssembly())
            );

            services.AddSingleton<IDeliveryNoteFactory, DeliveryNoteFactory>();
            services.AddSingleton<IDeliveryRouteFactory, DeliveryRouteFactory>();
            services.AddSingleton<IExitNoteFactory, ExitNoteFactory>();
            services.AddSingleton<IExitNoteDetailFactory, ExitNoteDetailFactory>();

            return services;
        }
    }
}
