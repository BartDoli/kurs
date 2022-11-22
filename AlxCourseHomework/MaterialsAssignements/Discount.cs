namespace AlxCourseHomework.MaterialsAssignements
{
    public class Discount{
        public int GetDiscount;

        public Discount(int getDiscount){
            GetDiscount = getDiscount;
        }
        public static int IfGet(int basket){
            int discount = 0;
            if (basket > 99) {
                discount = 15;
                Console.ForegroundColor = ConsoleColor.White;
                Console.BackgroundColor = ConsoleColor.Green;
                Console.WriteLine($"Your discount is: {discount}%");
                Console.ResetColor();
            } else if (basket < 61) {
                Console.ForegroundColor = ConsoleColor.White;
                Console.BackgroundColor = ConsoleColor.Red;
                Console.WriteLine($"No discount :(");
                Console.ResetColor();
            } else {
                discount = 5;
                Console.ForegroundColor = ConsoleColor.White;
                Console.BackgroundColor = ConsoleColor.Blue;
                Console.WriteLine($"Your discount is : {discount}%");
                Console.ResetColor();
            }
            return discount;
        }
        public static int SwitchGet(int basket){
            int discount = 0;
            switch (basket){
                case > 99:
                    discount = 15;
                    Console.ForegroundColor = ConsoleColor.White;
                    Console.BackgroundColor = ConsoleColor.Green;
                    Console.WriteLine($"Your discount is : {discount}%");
                    Console.ResetColor();
                    break;
                case < 61:
                    Console.ForegroundColor = ConsoleColor.White;
                    Console.BackgroundColor = ConsoleColor.Red;
                    Console.WriteLine("No discount :(");
                    Console.ResetColor();
                    break;
                default:
                    Console.ForegroundColor = ConsoleColor.White;
                    Console.BackgroundColor = ConsoleColor.Blue;
                    Console.WriteLine($"Your discount is : {discount}%");
                    Console.ResetColor();
                    break;
            }
            return discount;
        }
    }
}
