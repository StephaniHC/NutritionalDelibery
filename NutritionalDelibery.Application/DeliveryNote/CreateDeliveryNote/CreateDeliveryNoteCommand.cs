using MediatR;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NutritionalDelibery.Application.DeliveryNote.CreateDeliveryNote
{ 
    public record CreateDeliveryNoteCommand(string Description, DateTime DeliveryDate, string State, string ImagePath, Guid PacientId ) : IRequest<Guid>;
}
