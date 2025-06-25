using MediatR;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NutritionalDelibery.Application.DeliveryRoute.CreateDeliveryRoute
{  
    public record CreateDeliveryRouteCommand(string Name, double LatitudeOrigin, double LongitudeOrigin, double LatitudeDestination, double LongitudeDestination) : IRequest<Guid>;
    
}
