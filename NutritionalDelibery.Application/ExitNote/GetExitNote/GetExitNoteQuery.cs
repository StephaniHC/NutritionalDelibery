using MediatR;
using NutritionalDelibery.Application.DeliveryRoute.GetDeliveryRoute;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NutritionalDelibery.Application.ExitNoteDetail1.GetExitNote
{ 
    public record GetExitNoteQuery(string SearchTerm) : IRequest<IEnumerable<ExitNoteDTO>>;
}
