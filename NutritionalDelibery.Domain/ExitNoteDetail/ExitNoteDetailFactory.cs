using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NutritionalDelibery.Domain.ExitNoteDetail
{
    public class ExitNoteDetailFactory : IExitNoteDetailFactory
    {
        public ExitNoteDetail Create(int quantity, Guid packageId, Guid exitNoteId)
        {
            ExitNoteDetail exitNoteDetail = new ExitNoteDetail(quantity, packageId, exitNoteId);
            return exitNoteDetail;
        }
    }
}
