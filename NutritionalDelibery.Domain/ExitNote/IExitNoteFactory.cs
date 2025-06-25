using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NutritionalDelibery.Domain.ExitNote
{
    public interface IExitNoteFactory
    { 
        ExitNote Create(int number, string description, DateTime exitDate, Guid deliveryPersonId);
    }
}
