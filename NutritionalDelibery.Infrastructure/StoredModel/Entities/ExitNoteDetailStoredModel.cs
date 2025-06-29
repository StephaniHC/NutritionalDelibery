using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NutritionalDelibery.Infrastructure.StoredModel.Entities
{
    [Table("ExitNoteDetail")]
    public class ExitNoteDetailStoredModel
    {
        [Key]
        [Column("Id")]
        public Guid Id { get; set; }

        [Required]
        [Column("Quantity")]
        public int Quantity { get; set; }

        [Required]
        [Column("PackageId")]
        public Guid PackageId { get; set; }

        [Required]
        [Column("ExitNoteId")]
        public Guid ExitNoteId { get; set; }
         
    }
}
