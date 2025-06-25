using NutritionalDelibery.Domain.Abstractions;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Linq;

namespace NutritionalDelibery.Domain.DeliveryRoute
{
    public class DeliveryRoute : AggregateRoot
    {
        public string Name { get; private set; }
        public double LatitudeOrigin { get; private set; }
        public double LongitudeOrigin { get; private set; }
        public double LatitudeDestination { get; private set; }
        public double LongitudeDestination { get; private set; }
        public DeliveryRoute(string name, double latitudeOrigin, double longitudeOrigin, double latitudeDestination, double longitudeDestination) : base(Guid.NewGuid())
        {
            Name = name;
            LatitudeOrigin = latitudeOrigin;
            LongitudeOrigin = longitudeOrigin;
            LatitudeDestination = latitudeDestination;
            LongitudeDestination = longitudeDestination;
        }
    }
}
