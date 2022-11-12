namespace course_alx.Lessons.M2.L1
{
    public class L1Loops
    {
        public static void RunForeach()
        {
            List<string> names = new List<string>();
            names.Add("Adrian");
            names.Add("Mateusz");
            names.Add("Monika");
            names.Add("Andrzej");

            foreach (string name in names)
            {
                Console.WriteLine(name.ToLower() + " kursant ");
                Console.WriteLine(name);
            }
        }

        public static void RunFor()
        {
            int[] numbers = new int[12] { 1, 2, 4, 5, 6, 7, 3, 4, 5, 66, 5, 4 };

            for(int i = 0; i < numbers.Length; i += 2)
            {
                Console.Write(numbers[i] + " ");
            }
            Console.WriteLine();

            for (int i = 0; i < numbers.Length; i += 2)
            {
                Console.Write(numbers[i] + " ");
            }
            Console.WriteLine();

            for (int i = numbers.Length-1; i >= 0; i --)
            {
                Console.Write(numbers[i] + " ");
            }
            Console.WriteLine();

            for (int i = numbers.Length - 1; i >= 0;  i --)
            {
                numbers[i] = numbers[i] % 2;
                Console.Write(numbers[i] + " ");
            }
            Console.WriteLine();
        }

        public static void RunWhile()
        {
            char c = 'q';
            while(c != 'n')
            {
                Console.WriteLine("still in the loop!");
                Console.Write("Write a character");
                c = Console.ReadKey().KeyChar;
                Console.WriteLine();
            }
            Console.WriteLine("Outside of the loop.");

            string numberFromKeyboard = "0";
            while (Int32.Parse(numberFromKeyboard) < 100000)
            {
                Console.WriteLine("Still in the loop!");
                Console.WriteLine("Write a number: ");
                numberFromKeyboard = Console.ReadLine();
                Console.WriteLine();
            }
            Console.WriteLine("Outside of the loop.");
        }
        public static void RunDoWhile()
        {
            Char c = 'q';

            do
            {
                Console.WriteLine("still in the loop!");
                Console.Write("Write a character");
                c = Console.ReadKey().KeyChar;
                Console.WriteLine();
            } while (c != 'n');
            Console.WriteLine("Outside of the loop.");
        }
        public static void RunWhile2()
        {
            while (true)
            {
                var rnd = new Random();
                var number = rnd.Next(0, 9);
                var number1 = rnd.Next(0, 9);
                Console.Write(number1.ToString() + number.ToString());
            }
            Console.WriteLine();
        }

        public static void RunWhileInfinite()
        {
            while(true)
            {
                var rnd = new Random();
                var number = rnd.Next(0, 9);
                var number1 = rnd.Next(0, 9);
                Console.Write(number1.ToString() + number.ToString ());
            }
            Console.WriteLine();
        }
    }
}
