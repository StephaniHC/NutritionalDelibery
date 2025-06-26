using NutritionalDelibery.Domain.DeliveryNote;
using NutritionalDelibery.Infrastructure.DomainModel;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NutritionalDelibery.Infrastructure.Repositories
{
    public class DeliveryNoteRepository : IDeliveryNoteRepository
    {
        private readonly DomainDbContext _dbContext;

        public DeliveryNoteRepository(DomainDbContext dbContext)
        {
            _dbContext = dbContext;
        }
        public async Task AddAsync(DeliveryNote entity)
        {
            await _dbContext.DeliveryNote.AddAsync(entity);
        }

        public Task DeleteAsync(Guid id)
        {
            throw new NotImplementedException();
        }

        public Task<DeliveryNote?> GetByIdAsync(Guid id, bool readOnly = false)
        {
            throw new NotImplementedException();
        }

        public Task UpdateAsync(DeliveryNote deliveryNote)
        {
            throw new NotImplementedException();
        }
    }
}
