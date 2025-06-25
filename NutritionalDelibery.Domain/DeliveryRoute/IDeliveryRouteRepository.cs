using NutritionalDelibery.Domain.Abstractions;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NutritionalDelibery.Domain.DeliveryRoute
{
    public interface IDeliveryRouteRepository : IRepository<DeliveryRoute>
    {
        Task UpdateAsync(DeliveryRoute deliveryRoute);
        Task DeleteAsync(Guid id);
    }
}
