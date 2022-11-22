using CommonFunctinalitie.Services;

namespace course_alx.Lessons.M2.L3
{
    internal class L3Encapsulation
    {
        public static void Run()
        {
            var taxService = new TaxService();
            var income = 5000;
            var tax = taxService.CalculateTax(income);
            Present(tax, income);
        }

        private static void Present(double tax, double income)
        {
            Console.WriteLine($"Income : {income}");
            Console.WriteLine($"Tax : {tax}");
            Console.WriteLine($"Netto : {income - tax}");
        }
    }
}
