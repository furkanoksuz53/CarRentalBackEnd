using Core.Entities.Concrete;
using Entities.Concrete;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;

using System.Linq;
using System.Text;
using System.Threading.Tasks;
using CoreUser = Core.Entities.Concrete.CoreUser;
//Server=localhost;Database=master;Trusted_Connection=True;

namespace DataAccess.Concrete.EntityFramework
{
    public class CarsContext:DbContext
    {
        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            object value = optionsBuilder.UseSqlServer(@"Server = DESKTOP-AIRQGAV; Database =ReCapDb; Trusted_Connection = true");
           
        }
        public DbSet<Car> Cars { get; set; }
        public DbSet<Brand> Brands { get; set; }
        public DbSet<Color> Colors { get; set; }
        public DbSet<User> Users { get; set; }
        public DbSet<Customer> Customers { get; set; }
        public DbSet<Rental> Rentals { get; set; }
        public DbSet<CreditCard> CreditCards { get; set; }
        public DbSet<Payment> Payments { get; set; }
        public DbSet<CarImage>CarImages { get; set; }
        public DbSet<OperationClaim> OperationClaims { get; set; }
        public DbSet<CoreUser> CoreUsers { get; set; }
        public DbSet<UserOperationClaim> UserOperationClaims { get; set; }
    }
}
