namespace AlxCourseHomework.CarService
{
    public class CarExtras
    {
        // prywatne pole przechowujące tablicę dodatków
        public string[] extras;

        // konstruktor klasy przyjmujący tablicę dodatków jako argument
        public CarExtras(string[] extras)
        {
            this.extras = extras;
        }

        public static void CarExtrasList(string[] extras, double[] extrasPrice)
        {
            extras[1] = "1";
            extras[2] = "2";
            extras[3] = "3";

            extrasPrice[1] = 50;
            extrasPrice[2] = 150;
            extrasPrice[3] = 450;

            foreach (var item in extras)
            {
                foreach (var itemPrice in extrasPrice)
                {
                    Console.WriteLine(item + itemPrice);
                }
            }
         }

        // metoda obliczająca wartość dopłat za dodatki
        public double CalculateExtraPrice()
        {
            double total = 0;
            foreach (string extra in extras)
            {
                total += Convert.ToDouble(extra);
            }
            return total;
        }
    }
}
