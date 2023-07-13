using Bank_App_With_Team.Entity;
using Microsoft.EntityFrameworkCore;

namespace Bank_App_With_Team.Data
{
    public class BankDBContext:DbContext
    {
        public BankDBContext(DbContextOptions<BankDBContext> options):base (options )
        {
            
        }
        public DbSet<Bank> Banks { get; set; }
        public DbSet<Card> Cards { get; set; }
        public DbSet<Customer> Customers { get; set; }
        public DbSet<CardCustomer > CardCustomers { get; set; }      
        public DbSet<Order> orders { get; set; }

    }
}
