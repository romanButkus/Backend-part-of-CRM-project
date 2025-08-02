using backend.Models;
using Microsoft.EntityFrameworkCore;

namespace backend.Data.Context
{
    public class AppDbContext : DbContext
    {
        public AppDbContext(DbContextOptions<AppDbContext> options)
            : base(options) { }

        protected override void OnConfiguring(DbContextOptionsBuilder options) =>
            options.UseSqlite($"Data Source={"Data/DataBase/crmDataBase.db"}");

        public DbSet<Outlet> Outlets { get; set; }
        public DbSet<Employee> Employers { get; set; }
        public DbSet<Product> Products { get; set; }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            base.OnModelCreating(modelBuilder);

            modelBuilder.Entity<Outlet>(o =>
            {
                o.ToTable("Outlets");
                o.HasMany(e => e.Employers)
                    .WithOne(o => o.Outlet)
                    .HasForeignKey(o => o.OutletId)
                    .OnDelete(DeleteBehavior.Cascade);

                o.HasMany(o => o.Products)
                    .WithOne(p => p.Outlet)
                    .HasForeignKey(p => p.OutletId)
                    .OnDelete(DeleteBehavior.Cascade);

                o.Property(x => x.Name).HasMaxLength(20).IsRequired(true);
            });

            modelBuilder.Entity<Employee>(e =>
            {
                e.ToTable("Employers").Property(x => x.Name).HasMaxLength(20).IsRequired(true);
                e.Property(x => x.LastName).HasMaxLength(20).IsRequired(true);
                e.Property(x => x.PhoneNumber).HasMaxLength(20).IsRequired(true);
            });
        }
    }
}
