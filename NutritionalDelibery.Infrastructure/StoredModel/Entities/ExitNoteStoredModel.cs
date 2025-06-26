using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NutritionalDelibery.Infrastructure.StoredModel.Entities
{

    [Table("ExitNote")]
    public class ExitNoteStoredModel
    {
        [Key]
        [Column("Id")]
        public Guid Id { get; set; }

        [Column("Number")]
        public int Number { get; set; }

        [Required]
        [Column("Description")]
        [StringLength(500)]
        public string Description { get; set; }

        [Required]
        [Column("ExitDate")]
        public DateTime ExitDate { get; set; }

        [Required]
        [Column("DeliveryPersonId")]
        public Guid DeliveryPersonId { get; set; }
         
    }
}
