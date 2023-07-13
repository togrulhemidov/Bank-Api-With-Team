using System.Collections.Generic;

namespace Bank_App_With_Team.Entity
{
    public class Customer
    {
        public int Id { get; set; }
        public string FullName { get; set; }

        public string UserName { get; set; }

        public string  Password { get; set; }

        public ICollection<Order> Orders { get; set; }

        public ICollection<CardCustomer > cardCustomers { get; set; }

    }
}
