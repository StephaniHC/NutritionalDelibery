using NutritionalDelibery.Domain.Abstractions;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NutritionalDelibery.Domain.ExitNote
{
    public class ExitNote : AggregateRoot
    { 
        public int Number { get; private set; }
        public string Description { get; private set; }
        public DateTime ExitDate { get; private set; }
        public Guid DeliveryPersonId { get; private set; } 
        public ExitNote(int number, string description, DateTime exitDate, Guid deliveryPersonId ) : base(Guid.NewGuid())
        {
            Number = number;
            Description = description;
            ExitDate = exitDate;
            DeliveryPersonId = deliveryPersonId;
        }
    }
}
