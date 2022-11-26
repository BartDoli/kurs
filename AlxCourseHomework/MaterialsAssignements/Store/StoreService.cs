namespace AlxCourseHomework.MaterialsAssignements.Store
{
    public class StoreService
    {
        public static void ShowGoods(string[] array)
        {
            foreach (string item in array)
            {
                
                Console.Write($"  {item}  ");
            }
        }

        public static void ShowPrice(double [] array)
        {
            foreach (double item in array)
            {
                Console.Write($" {item} PLN");
            }
        }
    }
}
