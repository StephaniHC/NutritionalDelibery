using Microsoft.EntityFrameworkCore;
using NutritionalDelibery.Infrastructure.StoredModel.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NutritionalDelibery.Infrastructure.StoredModel
{
    public class StoredDbContext : DbContext
    {
        public virtual DbSet<DeliveryNoteStoredModel> DeliveryNote { get; set; }
        public virtual DbSet<DeliveryRouteStoredModel> DeliveryRoute { get; set; }
        public virtual DbSet<ExitNoteStoredModel> ExitNote { get; set; }
        public virtual DbSet<ExitNoteDetailStoredModel> ExitNoteDetail { get; set; } 

        public StoredDbContext(DbContextOptions<StoredDbContext> options) : base(options)
        {

        }
    }
}
