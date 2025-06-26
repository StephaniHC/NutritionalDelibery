using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NutritionalDelibery.Application.DeliveryRoute.GetDeliveryRoute
{
    public class DeliveryRouteDTO
    {
        public Guid Id { get; set; }
        public string Name { get; set; }
        public double LatitudeOrigin { get; set; }
        public double LongitudeOrigin { get; set; }
        public double LatitudeDestination { get; set; }
        public double LongitudeDestination { get; set; }
    }
}
