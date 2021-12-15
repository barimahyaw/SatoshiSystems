using Microsoft.EntityFrameworkCore;
using Satoshi.Core.Shared;
using Sotashi.Core.Infastructure.Entities;
using System;

namespace Sotashi.Core.Infastructure.DbContexts
{
    public class AppDbContext : DbContext
    {
        public AppDbContext(DbContextOptions options)
            : base(options)
        {
        }
        public DbSet<Product> Products { get; set; }
        public DbSet<Customer> Customers { get; set; }
        public DbSet<Sale> Sales { get; set; }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            base.OnModelCreating(modelBuilder);

            #region Product Seeder
            var laptopGuid = Guid.Parse("{CFB88E29-4744-48C0-94FA-B25B92DEA314}");
            modelBuilder.Entity<Product>().HasData(new Product
            {
                Id = laptopGuid,
                Name = "Laptop",
                CreatedBy = DatabaseSeeder.AdminId,
                CreatedOn = DateTime.UtcNow,
                LastModifiedBy = DatabaseSeeder.AdminId,
                LastModifiedOn = DateTime.UtcNow
            });

            var keyboarGuid = Guid.Parse("{CFB88E29-4744-48C0-94FA-B25B92DEA315}");
            modelBuilder.Entity<Product>().HasData(new Product
            {
                Id = keyboarGuid,
                Name = "Keyboard",
                CreatedBy = DatabaseSeeder.AdminId,
                CreatedOn = DateTime.UtcNow,
                LastModifiedBy = DatabaseSeeder.AdminId,
                LastModifiedOn = DateTime.UtcNow
            });

            var paperGuid = Guid.Parse("{CFB88E29-4744-48C0-94FA-B25B92DEA316}");
            modelBuilder.Entity<Product>().HasData(new Product
            {
                Id = paperGuid,
                Name = "Paper",
                CreatedBy = DatabaseSeeder.AdminId,
                CreatedOn = DateTime.UtcNow,
                LastModifiedBy = DatabaseSeeder.AdminId,
                LastModifiedOn = DateTime.UtcNow
            });
            #endregion

            #region Customer Seeder
            var daveGuid = Guid.Parse("{CFB88E29-4744-48C0-94FA-B25B92DEA317}");
            modelBuilder.Entity<Customer>().HasData(new Customer
            {
                Id = daveGuid,
                Name ="Dave",
                CreatedBy = DatabaseSeeder.AdminId,
                CreatedOn = DateTime.UtcNow,
                LastModifiedBy = DatabaseSeeder.AdminId,
                LastModifiedOn = DateTime.UtcNow
            });

            var georgeGuid = Guid.Parse("{CFB88E29-4744-48C0-94FA-B25B92DEA318}");
            modelBuilder.Entity<Customer>().HasData(new Customer
            {
                Id = georgeGuid,
                Name = "George",
                CreatedBy = DatabaseSeeder.AdminId,
                CreatedOn = DateTime.UtcNow,
                LastModifiedBy = DatabaseSeeder.AdminId,
                LastModifiedOn = DateTime.UtcNow
            });

            var fionaGuid = Guid.Parse("{CFB88E29-4744-48C0-94FA-B25B92DEA319}");
            modelBuilder.Entity<Customer>().HasData(new Customer
            {
                Id = fionaGuid,
                Name = "Fiona",
                CreatedBy = DatabaseSeeder.AdminId,
                CreatedOn = DateTime.UtcNow,
                LastModifiedBy = DatabaseSeeder.AdminId,
                LastModifiedOn = DateTime.UtcNow
            });

            var roryGuid = Guid.Parse("{CFB88E29-4744-48C0-94FA-B25B92DEA320}");
            modelBuilder.Entity<Customer>().HasData(new Customer
            {
                Id = roryGuid,
                Name = "Rory",
                CreatedBy = DatabaseSeeder.AdminId,
                CreatedOn = DateTime.UtcNow,
                LastModifiedBy = DatabaseSeeder.AdminId,
                LastModifiedOn = DateTime.UtcNow
            });

            var oliviaGuid = Guid.Parse("{CFB88E29-4744-48C0-94FA-B25B92DEA321}");
            modelBuilder.Entity<Customer>().HasData(new Customer
            {
                Id = oliviaGuid,
                Name = "Olivia",
                CreatedBy = DatabaseSeeder.AdminId,
                CreatedOn = DateTime.UtcNow,
                LastModifiedBy = DatabaseSeeder.AdminId,
                LastModifiedOn = DateTime.UtcNow
            });
            #endregion

            #region Sale Seeder
            modelBuilder.Entity<Sale>().HasData(new Sale
            {
                Id = Guid.Parse("{CFB88E29-4744-48C0-94FA-B25B92DEA322}"),
                Price = 900,
                CustomerId = daveGuid,
                ProductId = laptopGuid,
                CreatedBy = DatabaseSeeder.AdminId,
                CreatedOn = DateTime.UtcNow,
                LastModifiedBy = DatabaseSeeder.AdminId,
                LastModifiedOn = DateTime.UtcNow
            });

            modelBuilder.Entity<Sale>().HasData(new Sale
            {
                Id = Guid.Parse("{CFB88E29-4744-48C0-94FA-B25B92DEA323}"),
                Price = 35,
                CustomerId = georgeGuid,
                ProductId = keyboarGuid,
                CreatedBy = DatabaseSeeder.AdminId,
                CreatedOn = DateTime.UtcNow,
                LastModifiedBy = DatabaseSeeder.AdminId,
                LastModifiedOn = DateTime.UtcNow
            });

            modelBuilder.Entity<Sale>().HasData(new Sale
            {
                Id = Guid.Parse("{CFB88E29-4744-48C0-94FA-B25B92DEA324}"),
                Price = 5,
                CustomerId = fionaGuid,
                ProductId = paperGuid,
                CreatedBy = DatabaseSeeder.AdminId,
                CreatedOn = DateTime.UtcNow,
                LastModifiedBy = DatabaseSeeder.AdminId,
                LastModifiedOn = DateTime.UtcNow
            });

            modelBuilder.Entity<Sale>().HasData(new Sale
            {
                Id = Guid.Parse("{CFB88E29-4744-48C0-94FA-B25B92DEA325}"),
                Price = 3,
                CustomerId = roryGuid,
                ProductId = paperGuid,
                CreatedBy = DatabaseSeeder.AdminId,
                CreatedOn = DateTime.UtcNow,
                LastModifiedBy = DatabaseSeeder.AdminId,
                LastModifiedOn = DateTime.UtcNow
            });

            modelBuilder.Entity<Sale>().HasData(new Sale
            {
                Id = Guid.Parse("{CFB88E29-4744-48C0-94FA-B25B92DEA326}"),
                Price = 600,
                CustomerId = oliviaGuid,
                ProductId = laptopGuid,
                CreatedBy = DatabaseSeeder.AdminId,
                CreatedOn = DateTime.UtcNow,
                LastModifiedBy = DatabaseSeeder.AdminId,
                LastModifiedOn = DateTime.UtcNow
            });
            #endregion
        }
    }
}
