using NutritionalDelibery.Domain.Abstractions;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NutritionalDelibery.Domain.DeliveryNote
{
    public class DeliveryNote : AggregateRoot
    {
        public string Description { get; private set; }
        public DateTime DeliveryDate { get; private set; }
        public string State { get; private set; }
        public string ImagePath { get; private set; }
        public Guid PacientId { get; private set; }
        public DeliveryNote(string description, DateTime deliveryDate, string state, string imagePath, Guid pacientId) : base(Guid.NewGuid())
        {
            Description = description;
            DeliveryDate = deliveryDate;
            State = state;
            ImagePath = imagePath;
            PacientId = pacientId;
        }
    }
}
