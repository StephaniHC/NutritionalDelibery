using NutritionalDelibery.Domain.ExitNote;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NutritionalDelibery.Domain.DeliveryRoute
{
    public class DeliveryRouteFactory : IDeliveryRouteFactory
    {
        public DeliveryRoute Create(string name, double latitudeOrigin, double longitudeOrigin, double latitudeDestination, double longitudeDestination)
        {
            DeliveryRoute deliveryRoute = new DeliveryRoute(name, latitudeOrigin, longitudeOrigin, latitudeDestination, longitudeDestination);
            return deliveryRoute;
        }
    }
}
