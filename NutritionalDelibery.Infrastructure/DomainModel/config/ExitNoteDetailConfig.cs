using Microsoft.EntityFrameworkCore;
using NutritionalDelibery.Domain.ExitNote;
using NutritionalDelibery.Domain.ExitNoteDetail;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NutritionalDelibery.Infrastructure.DomainModel.config
{
    public class ExitNoteDetailConfig : IEntityTypeConfiguration<ExitNoteDetail>
    {
        public void Configure(Microsoft.EntityFrameworkCore.Metadata.Builders.EntityTypeBuilder<ExitNoteDetail> builder)
        {
            builder.ToTable("ExitNoteDetail");

            builder.HasKey(x => x.Id);

            builder.Property(x => x.Id)
                .HasColumnName("Id");

            builder.Property(x => x.Quantity)
                .HasColumnName("Quantity");

            builder.Property(x => x.PackageId)
                .HasColumnName("PackageId");

            builder.Property(x => x.ExitNoteNumber)
                .HasColumnName("ExitNoteNumber"); 
        }
    }
}
