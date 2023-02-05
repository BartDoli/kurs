namespace WebApi.Models
{
    public class Paycheck
    {
        public Guid Id { get; set; }
        public string PayCheckNumber  { get; set; }
        public decimal PaymentGross { get; set; }
        public decimal PaycheckNet { get; set; }
        public bool IsPaid { get; set; }
        public Guid EmployeeId { get; set; }
    }
}
