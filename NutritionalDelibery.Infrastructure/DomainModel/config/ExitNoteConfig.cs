using Microsoft.EntityFrameworkCore;
using NutritionalDelibery.Domain.DeliveryRoute;
using NutritionalDelibery.Domain.ExitNote;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NutritionalDelibery.Infrastructure.DomainModel.config
{
    public class ExitNoteConfig : IEntityTypeConfiguration<ExitNote>
    {
        public void Configure(Microsoft.EntityFrameworkCore.Metadata.Builders.EntityTypeBuilder<ExitNote> builder)
        {
            builder.ToTable("ExitNote");

            builder.HasKey(x => x.Id);

            builder.Property(x => x.Id)
                .HasColumnName("Id");

            builder.Property(x => x.Number)
                .HasColumnName("Number");

            builder.Property(x => x.Description)
                .HasColumnName("Description");

            builder.Property(x => x.ExitDate)
                .HasColumnName("ExitDate");

            builder.Property(x => x.DeliveryPersonId)
                .HasColumnName("DeliveryPersonId"); 
        }
    }
}
