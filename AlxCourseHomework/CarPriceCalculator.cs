using AlxCourseHomework.CarService;
using System;
using System.Linq;

namespace AlxCourseHomework
{
    public class CarPriceCalculator
    {
        const double VAT_RATE = 0.23; // stawka VAT w Polsce wynosi 23%
        public static void Run()
        {
            // tworzymy tablicę z cenami dodatków
            double[] extrasPrices = { 150, 300, 400, 900, 1200 };
            foreach (var items in extrasPrices)
            {
                Console.WriteLine(items);
            }

            bool continueCalculating = true;

            while (continueCalculating)
            {

                Console.WriteLine("Wybierz dodatki z listy (oddzielone przecinkiem):");
                string optionalExtrasString = Console.ReadLine();
                string[] optionalExtras = optionalExtrasString.Split(',');

                double extrasTotal = 0;
                foreach (string optionalExtra in optionalExtras)
                {
                    int optionalExtraInt = Convert.ToInt32(optionalExtra);
                    extrasTotal += (new double[] { 150, 300, 400, 900, 1200 })[optionalExtraInt - 1];
                }

                Console.WriteLine("Wprowadź cenę netto samochodu:");
                double netPrice = Convert.ToDouble(Console.ReadLine());

                const double VAT_RATE = 0.23;
                double grossPrice = ( netPrice + extrasTotal ) + (netPrice + extrasTotal) * VAT_RATE;

                Console.WriteLine("Cena brutto samochodu (z uwzględnieniem VAT i dodatków): " + grossPrice);

                Console.WriteLine("Continue? (yes/no)");
                string continueString = Console.ReadLine();
                if (continueString == "no")
                {
                    continueCalculating = false;
                }
            }
        }
    }
}
