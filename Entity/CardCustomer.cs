using System;

namespace Bank_App_With_Team.Entity
{
    public class CardCustomer
    {
        public int Id { get; set; }

        public int FullNumber { get; set; }

        public int CardId { get; set; }


        public Card card { get; set; }

        public int Cvv { get; set; }

        public int CustomerId { get; set; }


        public DateTime  ExpiereDate { get; set; }

        public DateTime CreateDate { get; set;}
    }
}
