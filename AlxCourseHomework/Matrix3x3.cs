namespace AlxCourseHomework
{
    public class Matrix3x3
    {
        public static void Run()
        {
            int[,] matrix = new int[3, 3];
            Console.WriteLine("Enter array elements...");
            for (int i = 0; i < 3; i++)
            {
                for (int j = 0; j < 3; j++)
                {
                    Console.Write("Element ({0}, {1}) - ", i, j);
                    matrix[i, j] = Convert.ToInt32(Console.ReadLine());
                }
            }

            Console.WriteLine("Array in matrix");
            for (int i = 0; i < 3; i++)
            {
                for (int j = 0; j < 3; j++)
                {
                    Console.Write(" {0} ", matrix[i, j]);
                }
                Console.WriteLine();
            }
        }
    }
}
