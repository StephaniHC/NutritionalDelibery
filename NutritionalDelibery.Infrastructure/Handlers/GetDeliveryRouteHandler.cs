using MediatR; 
using NutritionalDelibery.Application.DeliveryRoute.GetDeliveryRoute;
using NutritionalDelibery.Infrastructure.StoredModel;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NutritionalDelibery.Infrastructure.Handlers
{
    public class GetDeliveryRouteHandler : IRequestHandler<GetDeliveryRouteQuery, IEnumerable<DeliveryRouteDTO>>
    {
        private readonly StoredDbContext _dbContext;
        public GetDeliveryRouteHandler(StoredDbContext dbContext)
        {
            _dbContext = dbContext;
        }

        public async Task<IEnumerable<DeliveryRouteDTO>> Handle(GetDeliveryRouteQuery request, CancellationToken cancellationToken)
        {
            return await _dbContext.DeliveryRoute.AsNoTracking().
            Select(d => new DeliveryRouteDTO()
            {
                Id = d.Id,
                Name = d.Name,
                LatitudeOrigin = d.LatitudeOrigin,
                LongitudeOrigin = d.LongitudeOrigin,
                LatitudeDestination = d.LatitudeDestination,
                LongitudeDestination = d.LongitudeDestination
            }).
            ToListAsync(cancellationToken);
        }  
    }
}