using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Linq;

namespace NutritionalDelibery.Domain.DeliveryNote
{
    public class DeliveryNoteFactory : IDeliveryNoteFactory
    {
        public DeliveryNote Create(string description, DateTime deliveryDate, string state, string imagePath, Guid pacientId)
        {
            DeliveryNote deliveryNote = new DeliveryNote(description, deliveryDate, state, imagePath, pacientId);
            return deliveryNote;
        }
    }
}
