namespace AlxCourseHomework
{
    public class MultipledArray
    {
        public static void Run()
        {
            Console.WriteLine("Start your array by defeying count of numbers :");
            var count = Int32.Parse(Console.ReadLine());
            double[] numbers = new double[count];

            Console.WriteLine("By how many times you want to multiple array?\n (enter number):");
            var multiplier = Double.Parse(Console.ReadLine());

            Console.WriteLine($"Write {count} numbers that will be multiplied by {multiplier} and added to list:");
            for (int i = 0; i < count; i++)
            {
                numbers[i] = Double.Parse(Console.ReadLine());
            }
            Console.WriteLine($"Numbers multiplied by {multiplier}:");
            foreach (double i in numbers)
            {
                Console.WriteLine(i * multiplier);
            }
        }
    }
}
