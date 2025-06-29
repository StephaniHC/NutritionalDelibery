using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NutritionalDelibery.Domain.ExitNoteDetail
{
    public interface IExitNoteDetailFactory
    {
        ExitNoteDetail Create(int quantity, Guid packageId, Guid exitNoteId);
    }
}
