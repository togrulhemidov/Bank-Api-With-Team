using Bank_App_With_Team.Entity;
using Microsoft.EntityFrameworkCore;

using System.Reflection.Metadata;




namespace Bank_App_With_Team.Data
{
    public class BankDBContext:DbContext
    {
        public BankDBContext(DbContextOptions<BankDBContext> options):base (options )
        {
            
        }
        public DbSet<Bank> Banks { get; set; }
        public DbSet<Card> Cards { get; set; }




        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<Bank>()
                .HasData(new Bank()
                {
                    id = 1,
                    Name = "Kapital Bank"
                });
            modelBuilder.Entity<Card>()
                .Property(b => b.CashBack)
                .HasPrecision(14, 2);

        }
        public DbSet<Customer> Customers { get; set; }
        public DbSet<CardCustomer > CardCustomers { get; set; }      
        public DbSet<Order> orders { get; set; }

    }
}
