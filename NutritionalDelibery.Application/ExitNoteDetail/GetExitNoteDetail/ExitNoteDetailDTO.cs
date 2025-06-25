using NutritionalDelibery.Application.ExitNoteDetail1.GetExitNote;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NutritionalDelibery.Application.ExitNote.GetExitNoteDetail
{
    public class ExitNoteDetailDTO
    {
        public Guid Id { get; set; } 
        public int Quantity { get; set; } 
        public Guid PackageId { get; set; } 
        public int ExitNoteNumber { get; set; } 
        public virtual ExitNoteDTO ExitNote { get; set; }
    }
}
