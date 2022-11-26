using AlxCourseHomework.MaterialsAssignements.Store;

namespace AlxCourseHomework
{
    public class StoreTest1
    {
        public static void Run()
        {
            Console.WriteLine("Welcome to The Store!\nWhat would You like to buy?");

            string[] goods = new string[4] {"Eggs","Milk","Flour","Butter"};
            StoreService.ShowGoods(goods);
            Console.Write("\n");
            double[] bruttoPrice = new double[4] {5.99, 3.49, 2.49, 5.99};
            StoreService.ShowPrice(bruttoPrice);
            Console.Write("\n");
            Choice();
        }

        public static void Choice()
        {
            var goods = new string[4] { "Eggs", "Milk", "Flour", "Butter" };
            var bruttoPrice = new double[4] { 5.99, 3.49, 2.49, 5.99 };
            string[ , ] shoppingCart = new string[ 4, 4];

            Console.WriteLine("Choose which tag of goods you want to see :");
            var choice = Console.ReadLine();
            for (int i = 0; i < goods.GetLength(0); i++)
            {
                if (choice.ToLower() == goods[i].ToLower())
                {
                    Console.WriteLine($"Your Choice is {goods[i]}");
                    Console.WriteLine($"Brutto price : {bruttoPrice[i]}");
                    Console.WriteLine($"Netto price : {Math.Round(bruttoPrice[i] / 1.23, 2)}");
                }
            }
        }
    }
}
