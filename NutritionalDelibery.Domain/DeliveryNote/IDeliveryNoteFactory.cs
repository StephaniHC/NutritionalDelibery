using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NutritionalDelibery.Domain.DeliveryNote
{
    public interface IDeliveryNoteFactory
    {
        DeliveryNote Create(string description, DateTime deliveryDate, string state, string imagePath, Guid pacientId);
    }
}
