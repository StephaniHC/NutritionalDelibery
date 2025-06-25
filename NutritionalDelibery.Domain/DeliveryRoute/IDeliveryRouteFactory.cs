using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NutritionalDelibery.Domain.DeliveryRoute
{
    public interface IDeliveryRouteFactory
    {
        DeliveryRoute Create(string name, double latitudeOrigin, double longitudeOrigin, double latitudeDestination, double longitudeDestination);
    }
}
