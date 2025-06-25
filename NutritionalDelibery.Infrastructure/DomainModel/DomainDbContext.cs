using Microsoft.EntityFrameworkCore;
using NutritionalDelibery.Domain.DeliveryNote;
using NutritionalDelibery.Domain.DeliveryRoute;
using NutritionalDelibery.Domain.ExitNote;
using NutritionalDelibery.Domain.ExitNoteDetail;
using System.Reflection.Emit;

namespace NutritionalDelibery.Infrastructure.DomainModel
{
    public class DomainDbContext(DbContextOptions<DomainDbContext> options) : DbContext(options)
    {
        public virtual DbSet<DeliveryNote> DeliveryNote { get; set; }
        public virtual DbSet<DeliveryRoute> DeliveryRoute { get; set; }
        public virtual DbSet<ExitNote> ExitNote { get; set; }
        public virtual DbSet<ExitNoteDetail> ExitNoteDetail { get; set; } 

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.ApplyConfigurationsFromAssembly(typeof(DomainDbContext).Assembly);
            base.OnModelCreating(modelBuilder);
        }
    }
}
