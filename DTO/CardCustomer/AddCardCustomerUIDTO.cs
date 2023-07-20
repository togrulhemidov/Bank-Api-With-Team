using Bank_App_With_Team.Entity;
using System;

namespace Bank_App_With_Team.DTO
{
    public class AddCardCustomerUIDTO
    {

        public int CardId { get; set; }

        public int Cvv { get; set; }

        public int CustomerId { get; set; }

        public DateTime CreateDate { get; set; }
    }
}
