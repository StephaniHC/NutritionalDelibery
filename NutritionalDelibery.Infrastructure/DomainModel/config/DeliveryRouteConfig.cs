using Microsoft.EntityFrameworkCore;
using NutritionalDelibery.Domain.DeliveryNote;
using NutritionalDelibery.Domain.DeliveryRoute;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NutritionalDelibery.Infrastructure.DomainModel.config
{
    public class DeliveryRouteConfig : IEntityTypeConfiguration<DeliveryRoute>
    {
        public void Configure(Microsoft.EntityFrameworkCore.Metadata.Builders.EntityTypeBuilder<DeliveryRoute> builder)
        {
            builder.ToTable("DeliveryRoute");

            builder.HasKey(x => x.Id);

            builder.Property(x => x.Id)
                .HasColumnName("Id");

            builder.Property(x => x.Name)
                .HasColumnName("Name");

            builder.Property(x => x.LatitudeOrigin)
                .HasColumnName("LatitudeOrigin");

            builder.Property(x => x.LongitudeOrigin)
                .HasColumnName("LongitudeOrigin");

            builder.Property(x => x.LatitudeDestination)
                .HasColumnName("LatitudeDestination");

            builder.Property(x => x.LongitudeDestination)
                .HasColumnName("LongitudeDestination"); 

        }
    }
}
