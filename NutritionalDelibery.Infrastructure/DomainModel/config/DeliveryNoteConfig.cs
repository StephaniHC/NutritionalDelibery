using Microsoft.EntityFrameworkCore;
using NutritionalDelibery.Domain.DeliveryNote;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NutritionalDelibery.Infrastructure.DomainModel.config
{
    public class DeliveryNoteConfig : IEntityTypeConfiguration<DeliveryNote>
    {
        public void Configure(Microsoft.EntityFrameworkCore.Metadata.Builders.EntityTypeBuilder<DeliveryNote> builder)
        {
            builder.ToTable("DeliveryNote");

            builder.HasKey(x => x.Id);

            builder.Property(x => x.Id)
                .HasColumnName("Id");

            builder.Property(x => x.Description)
                .HasColumnName("Description");

            builder.Property(x => x.DeliveryDate)
                .HasColumnName("DeliveryDate");

            builder.Property(x => x.State)
                .HasColumnName("State");

            builder.Property(x => x.ImagePath)
                .HasColumnName("ImagePath");

            builder.Property(x => x.PacientId)
                .HasColumnName("PacientId");

        }
    }
}
