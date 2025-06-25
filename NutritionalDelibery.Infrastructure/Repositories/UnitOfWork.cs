using NutritionalDelibery.Domain.Abstractions;
using NutritionalDelibery.Infrastructure.DomainModel;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NutritionalDelibery.Infrastructure.Repositories
{
    public class UnitOfWork : IUnitOfWork
    {
        private readonly DomainDbContext _dbContext;

        public UnitOfWork(DomainDbContext dbContext)
        {
            _dbContext = dbContext;
        }

        public async Task CommitAsync(CancellationToken cancellationToken = default)
        {
            await _dbContext.SaveChangesAsync(cancellationToken);
        }
    }
}
