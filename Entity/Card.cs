using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;

namespace Bank_App_With_Team.Entity
{
    public class Card
    {
        public int id { get; set; }
        
        public int BankId { get; set; }

        public int FirstEightNumber { get; set; }
        
        public decimal  CashBack { get; set; }

        public int Expiereyear { get; set; }
        public bool IsActive { get; set; }

        public Bank Bank { get; set; }

        public ICollection <CardCustomer> Customer { get; set; }
    }
}
