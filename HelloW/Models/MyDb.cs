using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Threading.Tasks;

namespace HelloW.Models
{
    public class MyDb : DbContext
    {
        public MyDb(DbContextOptions<MyDb> option)
            : base(option)
        {

        }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<Category>.HasData(
                new Category()
                {
                    Id = 1,
                    Name = "Đồ Nữ"
                },
                new Category()
                {
                    Id = 2,
                    Name = "Đồ Nam"
                });
            base.OnModelCreating(modelBuilder);
        }

        public DbSet<Product> Products { get; set; }
        public DbSet<Category> Categories { get; set; }
    }
    public class Category
    {
       [DatabaseGenerated(DatabaseGeneratedOption.None)]
        public long Id { get; set; }
        public string Name { get; set; }
        public List<Product> ListProducts { get; set; }
    }

    public class Product
    {
        public long Id { get; set; }
        public string Name { get; set; }
        public string Price { get; set; }

        public long CategoryId { get; set; }
        
        public Category Category { get; set; }
    }
}
