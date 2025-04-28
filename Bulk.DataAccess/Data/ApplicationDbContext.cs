using BulkyBook.Models;
using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Identity.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore;

namespace BulkyBook.DataAccess.Data
{
    public class ApplicationDbContext : IdentityDbContext<IdentityUser>
    {
        public ApplicationDbContext (DbContextOptions<ApplicationDbContext> options) : base(options) 
        { 

        }
        public DbSet<Category> Categories { get; set; }
        public DbSet<Product> Products { get; set; }
        public DbSet<ApplicationUser> ApplicationUsers { get; set; }
        public DbSet<Company> Companies { get; set; }
        public DbSet<ShoppingCart> ShoppingCarts { get; set; }
        public DbSet<OrderHeader> OrderHeaders { get; set; }
        public DbSet<OrderDetail> OrderDetails { get; set; }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            base.OnModelCreating(modelBuilder);
            modelBuilder.Entity<Category>().HasData(
                new Category { Id=1, Name="Action",DisplayOrder= 1},              
                new Category { Id=2, Name="Sci",DisplayOrder= 2},               
                new Category { Id=3, Name="Fric",DisplayOrder= 3}        
                );

            modelBuilder.Entity<Company>().HasData(

     new Company { Id = 1, Name = "Tech Solution", StreetAddress="123 Tech st", City="Tech City",PostalCode="1212",State="IL",PhoneNumber="9824644545"},
     new Company { Id = 2, Name = "foundation Solution", StreetAddress="46 fjf st", City="ktm City",PostalCode="5656",State="KLL",PhoneNumber="657632111"},
     new Company { Id = 3, Name = "Extra tech Solution", StreetAddress="Buddanagar", City=" Btl",PostalCode="986",State="Lumbini",PhoneNumber="9865456232"}

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
