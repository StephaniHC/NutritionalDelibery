using MediatR;
using NutritionalDelibery.Application.ExitNote.GetExitNoteDetail;
using NutritionalDelibery.Application.ExitNoteDetail1.GetExitNote;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NutritionalDelibery.Application.ExitNote.CreateExitNoteDetail
{  
    public record CreateExitNoteDetailCommand(int Quantity, Guid PackageId, int ExitNoteNumber) : IRequest<Guid>; 
    
}
