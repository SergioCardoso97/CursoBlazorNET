using Microsoft.EntityFrameworkCore;
using Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataAccess
{
    public class InventaryContext : DbContext
    {
        public DbSet<Product>? Products { get; set; }
        public DbSet<Category>? Categories { get; set; }
        public DbSet<InputOutput>? InOuts { get; set; }
        public DbSet<Warehouse>? Warehouses { get; set; }
        public DbSet<Storage>? Storages { get; set; }
        protected override void OnConfiguring(DbContextOptionsBuilder options)
        {
            if (!options.IsConfigured)
            {
                options.UseSqlServer("Server=DESKTOP-NLQ15UU\\SERVERSERGIO; Database=InventoryDb;User Id=sa; Password= Cecyt100!!;");
            }
        }
        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            base.OnModelCreating(modelBuilder);
            modelBuilder.Entity<Category>().HasData(
                new Category { CategoryId = "ASH", CategoryName = "Aseo Hogar" },
                new Category { CategoryId = "ASP", CategoryName = "Aseo Personal" },
                new Category { CategoryId = "HGR", CategoryName = "Hogar" },
                new Category { CategoryId = "PRF", CategoryName = "Perfumería" },
                new Category { CategoryId = "SLD", CategoryName = "Salud" },
                new Category { CategoryId = "VDJ", CategoryName = "Video Juegos" }
                );

            modelBuilder.Entity<Warehouse>().HasData(
                new Warehouse { WarehouseId = Guid.NewGuid().ToString(), WarehouseName = "Bodega Central", WarehouseAddress = "Calle 8 con 23" },
                new Warehouse { WarehouseId = Guid.NewGuid().ToString(), WarehouseName = "Bodega Norte", WarehouseAddress = "Calle norte con occidente" }
                );
        }
    }
}
