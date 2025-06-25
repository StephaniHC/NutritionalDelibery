using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NutritionalDelibery.Domain.ExitNoteDetail
{
    public class ExitNoteDetailFactory : IExitNoteDetailFactory
    {
        public ExitNoteDetail Create(int quantity, Guid packageId, int exitNoteNumber)
        {
            ExitNoteDetail exitNoteDetail = new ExitNoteDetail(quantity, packageId, exitNoteNumber);
            return exitNoteDetail;
        }
    }
}
