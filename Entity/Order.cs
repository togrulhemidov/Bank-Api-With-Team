using System;

namespace Bank_App_With_Team.Entity
{
    public class Order
    {
        public int Id { get; set; }
        public int customerId { get; set; }
        public Customer customer { get; set; }
        public int CardId { get; set; }
        public Card card { get; set; }
        public string  status { get; set; }

        public  DateTime  OrderCreateDate { get; set; }

    }
}
