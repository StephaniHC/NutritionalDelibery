using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NutritionalDelibery.Infrastructure.StoredModel.Entities
{
    [Table("DeliveryRoute")]
    public class DeliveryRouteStoredModel
    {
        [Key]
        [Column("Id")]
        public Guid Id { get; set; }

        [Required]
        [Column("Name")]
        [StringLength(250)]
        public string Name { get; set; }

        [Required]
        [Column("LatitudeOrigin")]
        public double LatitudeOrigin { get; set; }

        [Required]
        [Column("LongitudeOrigin")]
        public double LongitudeOrigin { get; set; }

        [Required]
        [Column("LatitudeDestination")]
        public double LatitudeDestination { get; set; }

        [Required]
        [Column("LongitudeDestination")]
        public double LongitudeDestination { get; set; }

    }
}
