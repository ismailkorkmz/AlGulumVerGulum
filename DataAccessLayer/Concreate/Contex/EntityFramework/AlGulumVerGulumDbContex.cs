using DataAccessLayer.Mapping;
using Entity.POCO;
using Microsoft.AspNetCore.Identity.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace DataAccessLayer.Concreate.Contex.EntityFramework
{
    public class AlGulumVerGulumDbContex:IdentityDbContext<AppUser, AppRole, int>
    {
        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            optionsBuilder.UseSqlServer("Server=(localdb)\\MSSQLLocalDB;Database=AlGulumVerGulum;Trusted_Connection=True;MultipleActiveResultSets=true;");
            base.OnConfiguring(optionsBuilder);
        }
        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            foreach (var item in modelBuilder.Model.GetEntityTypes().SelectMany(x=>x.GetForeignKeys()))
            {
                item.DeleteBehavior = DeleteBehavior.Restrict;
            }
            modelBuilder.Entity<ProductCategory>().HasKey(x => new { x.CategoryId, x.ProductId });
            modelBuilder.ApplyConfiguration(new CategoryMap());
            modelBuilder.ApplyConfiguration(new ProductMap());
            modelBuilder.ApplyConfiguration(new ProductImageMap());
            base.OnModelCreating(modelBuilder);
        }
        
        public DbSet<Category> Category { get; set; }
        public DbSet<Product> Product { get; set; }
        public DbSet<ProductCategory> ProductCategory { get; set; }
        public DbSet<ProductImage> ProductImage { get; set; }
    }
}
