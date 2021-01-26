using Microsoft.EntityFrameworkCore;
using CoffeeMaker.Core.DomainModels;
using System;
using System.Collections.Generic;
using System.Text;

namespace CoffeeMaker.Core.Persistence
{
    public class CoffeeMakerDbContext : DbContext
    {
        public DbSet<CoffeePodEntity> CoffeePods { get; set; }
        public DbSet<CoffeeMachineEntity> CoffeeMachines { get; set; }

        public CoffeeMakerDbContext(DbContextOptions<CoffeeMakerDbContext> options) : base(options)
        {

        }
        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            if (!optionsBuilder.IsConfigured)
            {
                optionsBuilder
               .UseSqlServer(
                "Server = (localdb)\\mssqllocaldb; Database = CoffeeMaker; Trusted_Connection = True; ")
                .EnableSensitiveDataLogging(true);
            }

        }
        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<CoffeeMachineEntity>()
        .HasIndex(u => u.MachineSKU)
        .IsUnique();

            modelBuilder.Entity<CoffeePodEntity>()
            .HasIndex(u => u.PodSKU)
            .IsUnique();

            DataSeedingManager.Seed(modelBuilder);
            base.OnModelCreating(modelBuilder);
        }

    }
}
