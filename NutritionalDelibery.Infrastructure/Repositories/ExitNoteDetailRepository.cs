using NutritionalDelibery.Domain.DeliveryRoute;
using NutritionalDelibery.Domain.ExitNoteDetail;
using NutritionalDelibery.Infrastructure.DomainModel;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NutritionalDelibery.Infrastructure.Repositories
{
    public class ExitNoteDetailRepository : IExitNoteDetailRepository
    {
        private readonly DomainDbContext _dbContext;

        public ExitNoteDetailRepository(DomainDbContext dbContext)
        {
            _dbContext = dbContext;
        }
        public async Task AddAsync(ExitNoteDetail entity)
        {
            await _dbContext.ExitNoteDetail.AddAsync(entity);
        }

        public Task DeleteAsync(Guid id)
        {
            throw new NotImplementedException();
        }

        public Task<ExitNoteDetail?> GetByIdAsync(Guid id, bool readOnly = false)
        {
            throw new NotImplementedException();
        }

        public Task UpdateAsync(ExitNoteDetail exitNoteDetail)
        {
            throw new NotImplementedException();
        }
    }
}
