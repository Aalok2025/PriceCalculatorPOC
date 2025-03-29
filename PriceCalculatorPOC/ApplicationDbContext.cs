using Microsoft.EntityFrameworkCore;
using PriceCalculatorPOC.Models;

namespace PriceCalculatorPOC
{
    public class ApplicationDbContext : DbContext
    {
        public ApplicationDbContext(DbContextOptions<ApplicationDbContext> options) : base(options) { }

        public DbSet<InteriorElement> InteriorElements { get; set; }
        public DbSet<CustomizationFeature> CustomizationFeatures { get; set; }
        public DbSet<FixedUnit> FixedUnits { get; set; }
        public DbSet<Room> Rooms { get; set; }
        public DbSet<FeatureField> FeatureFields { get; set; }
        public DbSet<FixedUnitField> FixedUnitFields { get; set; }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            // Define relationships & seed initial data
        }
    }
}
