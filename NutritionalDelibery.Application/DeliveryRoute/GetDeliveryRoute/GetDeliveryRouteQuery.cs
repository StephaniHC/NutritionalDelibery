using MediatR;
using NutritionalDelibery.Application.DeliveryNote.GetDeliveryNote;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NutritionalDelibery.Application.DeliveryRoute.GetDeliveryRoute
{ 
    public record GetDeliveryRouteQuery(string SearchTerm) : IRequest<IEnumerable<DeliveryRouteDTO>>;
}
