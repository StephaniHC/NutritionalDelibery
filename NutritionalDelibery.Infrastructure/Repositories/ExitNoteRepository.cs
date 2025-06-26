using NutritionalDelibery.Domain.ExitNote;
using NutritionalDelibery.Domain.ExitNoteDetail;
using NutritionalDelibery.Infrastructure.DomainModel;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NutritionalDelibery.Infrastructure.Repositories
{
    public class ExitNoteRepository : IExitNoteRepository
    {
        private readonly DomainDbContext _dbContext;

        public ExitNoteRepository(DomainDbContext dbContext)
        {
            _dbContext = dbContext;
        }
        public async Task AddAsync(ExitNote entity)
        {
            await _dbContext.ExitNote.AddAsync(entity);
        }

        public Task DeleteAsync(Guid id)
        {
            throw new NotImplementedException();
        }

        public Task<ExitNote?> GetByIdAsync(Guid id, bool readOnly = false)
        {
            throw new NotImplementedException();
        }

        public Task UpdateAsync(ExitNote exitNote)
        {
            throw new NotImplementedException();
        }
    }
}
