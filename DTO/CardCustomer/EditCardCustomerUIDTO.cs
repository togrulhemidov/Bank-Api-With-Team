using System;

namespace Bank_App_With_Team.DTO
{
    public class EditCardCustomerUIDTO
    {
        public int ID { get; set; }
        public long FullNumber { get; set; }
        public int Cvv { get; set; }
 
        public DateTime ExpiereDate { get; set; }

    }
}
