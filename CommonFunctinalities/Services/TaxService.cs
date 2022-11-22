using CommonFunctinalities.Services.Interfaces;

namespace CommonFunctinalitie.Services
{
    public class TaxService : ITaxService
    {
        private const double VatPercentage = 0.23;
        private const double GovermentPercentage = 0.17;

        public double CalculateTax(double income)
        {
            var tax = 0.0;
            var vatTax = CalculateVat(income);
            var GovermentTax = CalculateGovermentTax(income, vatTax);
            return vatTax +  GovermentTax;
        }

        private double CalculateGovermentTax(double income, double vatTax)
        {
            return (income - vatTax) * GovermentPercentage;
        }

        private double CalculateVat(double income)
        {
            return income * VatPercentage;
        }
    }
}
