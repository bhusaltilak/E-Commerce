using BulkyBook.Models;
using Microsoft.EntityFrameworkCore;

namespace BulkyBook.DataAccess.Data
{
    public class ApplicationDbContext :DbContext
    {
        public ApplicationDbContext (DbContextOptions<ApplicationDbContext> options) : base(options) 
        { 

        }
        public DbSet<Category> Categories { get; set; }
        public DbSet<Product> Products { get; set; }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<Category>().HasData(
                new Category { Id=1, Name="Action",DisplayOrder= 1},              
                new Category { Id=2, Name="Sci",DisplayOrder= 2},               
                new Category { Id=3, Name="Fric",DisplayOrder= 3}        
                );

            modelBuilder.Entity<Product>().HasData(
                new Product
                {
                    Id = 1,
                    Title = "Atomic habit",
                    Auther = "James ",
                    Description = "Daily habits that changes your life",
                    ISBN= "w933",
                    ListPrice = 99,
                    Price = 90,
                    Price50 = 85,
                    Price100 = 80,
                    CategoryId = 1,
                    ImageUrl = ""
                },
                 new Product
                 {
                     Id = 2,
                     Title = "Think and Grow Rich",
                     Auther = "Nepohelan Hills ",
                     Description = "The way you think that you become",
                     ISBN = "w933",
                     ListPrice = 99,
                     Price = 90,
                     Price50 = 85,
                     Price100 = 80,
                     CategoryId = 1,
                     ImageUrl = ""
                 },
                  new Product
                  {
                      Id = 3,
                      Title = "80/20 principle",
                      Auther = "Richard",
                      Description = "80% of outcomes or results come from 20% of causes or inputs",
                      ISBN = "w933",
                      ListPrice = 99,
                      Price = 90,
                      Price50 = 85,
                      Price100 = 80,
                      CategoryId = 2,
                      ImageUrl=""
                  }
                ); 
        }
    }
}
