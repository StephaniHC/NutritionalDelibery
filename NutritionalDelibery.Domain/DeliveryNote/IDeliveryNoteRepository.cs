using NutritionalDelibery.Domain.Abstractions;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NutritionalDelibery.Domain.DeliveryNote
{
    public interface IDeliveryNoteRepository : IRepository<DeliveryNote>
    {
        Task UpdateAsync(DeliveryNote deliveryNote);
        Task DeleteAsync(Guid id);
    }
}
