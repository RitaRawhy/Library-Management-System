using Domain.Entities;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Persistence.Context
{
    public class LibraryDbContext : DbContext
    {
        public LibraryDbContext(DbContextOptions<LibraryDbContext> options) : base(options)
        {
        }

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            optionsBuilder.UseSqlServer(@"Data Source=(localdb)\ProjectModels;Initial Catalog=LibraryDB;Integrated Security=True");
        }

        public DbSet<Book> Books { get; set;}
        public DbSet<Employee> Employees { get; set; }
        public DbSet<Attendence> Attendence { get; set; } 
        public DbSet<Vacation> Vacations { get; set; }
        public DbSet<Payroll> Payrolls { get; set; }
        public DbSet<Author> Authors { get; set; }
        public DbSet<Publisher> Publishers { get; set; }
        public DbSet<Customer> Customers { get; set; }
        public DbSet<BannedCustomer> BannedCustomers { get; set;}
        public DbSet<Borrow> Borrows { get; set; }
        public DbSet<Order> orders { get; set; }
        public DbSet<OrderBooks> ordersBooks { get; set; }
    }
}
