using Microsoft.EntityFrameworkCore;
using RewardsApp.SQLite.Entities;
using RewardsApp.SQLite.Utilities;
using RewardsApp.SQLite.Utilities.Enums;
using System.IO;

namespace RewardsApp.SQLite.Data
{
    public class RewardsAppContext : DbContext
    {
        public DbSet<Card> Cards { get; set; }

        public DbSet<Customer> Customers { get; set; }

        public DbSet<Transaction> Transactions { get; set; }

        private string DbPath { get; }

        public RewardsAppContext()
        {
            var localPath = Helper.GetRootPath();
            DbPath = Path.Combine(localPath, "data.db");
        }

        protected override void OnConfiguring(DbContextOptionsBuilder options)
            => options.UseSqlite($"Data Source={DbPath}");

        protected override void OnModelCreating(ModelBuilder builder)
        {
            builder.Entity<Card>(entity =>
            {
                entity.HasIndex(e => e.Number)
                      .IsUnique();
                
                entity.Property(e => e.Status)
                      .HasDefaultValue(GenericEntityStatus.Active);
            });

            builder.Entity<Customer>()
                   .Property(e => e.Status)
                   .HasDefaultValue(GenericEntityStatus.Active);

            builder.Entity<Transaction>(entity =>
            {
                entity.ToTable("Transaction");

                entity.Property(e => e.Status)
                      .HasDefaultValue(GenericEntityStatus.Active);
            });
        }
    }
}
