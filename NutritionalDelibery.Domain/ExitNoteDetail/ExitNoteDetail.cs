using NutritionalDelibery.Domain.Abstractions;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NutritionalDelibery.Domain.ExitNoteDetail
{
    public class ExitNoteDetail : AggregateRoot
    {
        public int Quantity { get; private set; }
        public Guid PackageId { get; private set; }
        public int ExitNoteNumber { get; private set; }
        //public virtual ExitNote ExitNote { get; private set; }
        public ExitNoteDetail(int quantity, Guid packageId, int exitNoteNumber/*, ExitNote exitNote*/) : base(Guid.NewGuid())
        {
            Quantity = quantity;
            PackageId = packageId;
            ExitNoteNumber = exitNoteNumber;
        }
    }
}
