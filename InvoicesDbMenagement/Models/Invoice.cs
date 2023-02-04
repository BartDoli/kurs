
namespace InvoicesDbMenagement.Models
{
    class Invoice
    {
        public int Id { get; set; }
        public string SeriesNumber { get; set; }
        public string ClientCompanyName { get; set; }
        public string ClientNip { get; set; }
        public string UserName { get; set; }
        public string UserLastName { get; set; }
        public decimal Amount { get; set; }
    }
}
