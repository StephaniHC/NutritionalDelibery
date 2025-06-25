using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NutritionalDelibery.Application.DeliveryNote.GetDeliveryNote
{
    public class DeliveryNoteDTO
    {
        public Guid Id { get; set; } 
        public string Description { get; set; } 
        public DateTime DeliveryDate { get; set; }
        public string State { get; set; }
        public string ImagePath { get; set; }
        public Guid PacientId { get; set; }
    }
}
