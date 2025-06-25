using MediatR;
using NutritionalDelibery.Application.ExitNote.GetExitNoteDetail;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NutritionalDelibery.Application.ExitNoteDetail.CreateExitNote
{  
    public record CreateExitNoteCommand(int Number, string Description, DateTime ExitDate, Guid DeliveryPersonId, ICollection<ExitNoteDetailDTO> ExitNoteDetails) : IRequest<Guid>;
    
}
