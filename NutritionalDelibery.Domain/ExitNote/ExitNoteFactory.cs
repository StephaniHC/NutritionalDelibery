using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NutritionalDelibery.Domain.ExitNote
{
    public class ExitNoteFactory : IExitNoteFactory
    {
        public ExitNote Create(int number, string description, DateTime exitDate, Guid deliveryPersonId)
        {
            ExitNote exitNote = new ExitNote(number, description, exitDate, deliveryPersonId);
            return exitNote;
        }
    }
}
