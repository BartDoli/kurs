using course_alx.Lessons.M1.L1.Classes;

namespace course_alx.Lessons.M2.L1
{
    internal class L1Arrays
    {
        public static void Run()
        {
            int[]  intArray = { 0, 1, 2, 3, 4};
            int[] intArray1 = new int[5];
            ShowArray(intArray);

            intArray1[2] = 2;
            ShowArray(intArray1);

            int[] intArray2 = new int[3] { 1, 2, 3};
            ShowArray(intArray2);

            int[ , ] intMatrix = new int[3, 2];
            int[,] intMatrix1 = { { 1, 2 } , { 3, 4 } };

            int[][] intMultiArray = new int [3][];
            intMultiArray[0] = new int[7];
            intMultiArray[1] = new int [80];
            intMultiArray[2] = new int[12];

            Dog[] dogs = new Dog[3];
            dogs[0] = new Dog();
        }

        public static void Run1()
        {
            string[] shoppingArray = new string[6];
            shoppingArray[0] = "milk"; 
            ShowArray(shoppingArray);
            shoppingArray[1] = "butter";
            ShowArray(shoppingArray);
            shoppingArray[5] = "apple juice";
            ShowArray(shoppingArray);
        }

        public static void Run3()
        {
            int[,] intMatrix = new int[3, 2];
            int[,] intMatrix1 = { { 1, 2 }, { 3, 4 } };
            int[,] intMatrix2 = { { 1, 2, 3 }, { 3, 4, 5 }, { 2, 6, 8 }, { 2, 7, 4} };
            Show2DArray(intMatrix2);
        }

        public static void ShowArray(string[] array)
        {
            Console.WriteLine($"Number of elements: {array.Length}");
            foreach (string item in array)
            {
                Console.WriteLine(item);
            }
        }

        public static void ShowArray(int[] array)
        {
            foreach(int i in array)
            {
                Console.Write($"{i} ");
            }
            Console.WriteLine();
        }

        public static void Show2DArray(int[,] matrix)
        {
            for (int interator = 0; interator < matrix.GetLength(0); interator++)
            {
                for (int interator1 = 0; interator1 < matrix.GetLength(1); interator1++)
                {
                    Console.Write($"{matrix[interator, interator1]} ");
                }
                Console.WriteLine();
            }
        }
    }
}
