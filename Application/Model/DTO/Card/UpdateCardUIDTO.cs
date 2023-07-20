namespace Bank_App_With_Team.Application.Model.DTO.Card
{
    public class UpdateCardUIDTO
    {
        public int id { get; set; }

        public int BankId { get; set; }

        public int FirstEightNumber { get; set; }

        public decimal CashBack { get; set; }

        public int Expiereyear { get; set; }
    }
}
