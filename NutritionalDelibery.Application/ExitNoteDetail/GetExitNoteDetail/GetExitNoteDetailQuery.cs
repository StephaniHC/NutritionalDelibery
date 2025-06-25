using MediatR;
using NutritionalDelibery.Application.ExitNoteDetail1.GetExitNote;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NutritionalDelibery.Application.ExitNote.GetExitNoteDetail
{ 
    public record GetExitNoteDetailQuery(string SearchTerm) : IRequest<IEnumerable<ExitNoteDetailDTO>>;
}
