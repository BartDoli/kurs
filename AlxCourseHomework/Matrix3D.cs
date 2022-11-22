namespace AlxCourseHomework
{
    public class Matrix3D
    {
        public static void Run()
        {
            const int MatrixRows = 1;
            const int MatrixColumns = 3;

            double[,] matrix = new double[MatrixRows, MatrixColumns];

            for (int i = 0; i < MatrixRows; i++)
            {
                for (int j = 0; j < MatrixColumns; j++)
                {
                    double input;
                    Console.Write("Enter value for ({0},{1}): ", i, j);
                    while (!double.TryParse(Console.ReadLine(), out input))
                    {
                        Console.Write("Enter correct value for ({0},{1}): ", i, j);
                    }
                    matrix[i, j] = input;
                }
                Console.WriteLine("Its your 3D array :D");
                ShowArray(matrix);
            }
        }

        public static void ShowArray(double[,] array)
        {
            foreach (int i in array)
            {
                Console.Write($" {i} {i} {i} \n");
            }
        }
    }
}
