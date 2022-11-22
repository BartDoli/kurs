namespace AlxCourseHomework
{
    public class NumberDivisions
    {
        public static void Run()
        {
            int number;
            Console.WriteLine("Enter the natural number to proceed...");
            number = Convert.ToInt32(Console.ReadLine());

            Console.WriteLine("The divisors of the number {0} are", number);
            Console.Write(" {0} {1} ",1, number);
            for (int divisor = 2; divisor <= (number / 2); divisor++)
            {
                if ((number % divisor) == 0)
                    Console.Write(" {0} " , divisor);
            }
            Console.WriteLine();
        }
    }
}
