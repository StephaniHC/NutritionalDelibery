using NutritionalDelibery.Domain.Abstractions;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NutritionalDelibery.Domain.ExitNote
{
    public interface IExitNoteRepository : IRepository<ExitNote>
    {
        Task UpdateAsync(ExitNote exitNote);
        Task DeleteAsync(Guid id);
    }
}
