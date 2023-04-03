using DrilldownFunctions.Data.Models;
using Microsoft.EntityFrameworkCore;

namespace DrilldownFunctions.Data
{
    public class DrilldownDbContext : DbContext
    {
        public DrilldownDbContext(DbContextOptions<DrilldownDbContext> options)
            : base(options)
        {
        }
        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<NationalIncome>()
                .HasNoDiscriminator()
                .ToContainer(nameof(NationalIncome))
                .HasNoKey();
        }

        public DbSet<NationalIncome> NationalIncome { get; set; }
    }
}
