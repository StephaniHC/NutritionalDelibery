using NutritionalDelibery.Domain.Abstractions;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NutritionalDelibery.Domain.ExitNoteDetail
{
    public interface IExitNoteDetailRepository : IRepository<ExitNoteDetail>
    {
        Task UpdateAsync(ExitNoteDetail exitNoteDetail);
        Task DeleteAsync(Guid id);
    }
}
