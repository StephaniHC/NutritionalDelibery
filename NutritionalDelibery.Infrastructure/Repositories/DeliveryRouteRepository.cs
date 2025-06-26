using NutritionalDelibery.Domain.DeliveryNote;
using NutritionalDelibery.Domain.DeliveryRoute;
using NutritionalDelibery.Infrastructure.DomainModel;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NutritionalDelibery.Infrastructure.Repositories
{
    public class DeliveryRouteRepository : IDeliveryRouteRepository
    {
        private readonly DomainDbContext _dbContext;

        public DeliveryRouteRepository(DomainDbContext dbContext)
        {
            _dbContext = dbContext;
        }
        public async Task AddAsync(DeliveryRoute entity)
        {
            await _dbContext.DeliveryRoute.AddAsync(entity);
        } 

        public Task DeleteAsync(Guid id)
        {
            throw new NotImplementedException();
        }

        public Task<DeliveryRoute?> GetByIdAsync(Guid id, bool readOnly = false)
        {
            throw new NotImplementedException();
        }

        public Task UpdateAsync(DeliveryRoute deliveryRoute)
        {
            throw new NotImplementedException();
        }
    }
}
