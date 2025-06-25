using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NutritionalDelibery.Infrastructure.StoredModel.Entities
{

    [Table("DeliveryNote")]
    public class DeliveryNoteStoredModel
    {
        [Key]
        [Column("Id")]
        public Guid Id { get; set; }

        [Required]
        [Column("Description")]
        [StringLength(500)]
        public string Description { get; set; }

        [Required]
        [Column("DeliveryDate")]
        public DateTime DeliveryDate { get; set; }

        [Required]
        [Column("State")]
        [StringLength(100)]
        public string State { get; set; }

        [Column("ImagePath")]
        [StringLength(1000)]
        public string ImagePath { get; set; }

        [Required]
        [Column("PacientId")]
        public Guid PacientId { get; set; }
    }
}
