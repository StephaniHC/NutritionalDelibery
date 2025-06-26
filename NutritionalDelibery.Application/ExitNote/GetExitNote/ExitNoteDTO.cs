using NutritionalDelibery.Application.ExitNote.GetExitNoteDetail;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NutritionalDelibery.Application.ExitNoteDetail1.GetExitNote
{
    public class ExitNoteDTO
    {
        public Guid Id { get; set; }
        public int Number { get; set; }
        public string Description { get; set; }
        public DateTime ExitDate { get; set; }
        public Guid DeliveryPersonId { get; set; }

    }
}
