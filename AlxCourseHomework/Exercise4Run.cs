using AlxCourseHomework.MaterialsAssignements.Homework1;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AlxCourseHomework
{
    public class Exercise4Run
    {
        public static void RunEx4()
        {
            Console.ForegroundColor = ConsoleColor.DarkGreen; Console.BackgroundColor = ConsoleColor.White;
            Console.WriteLine($"If Method");
            Console.Write("Enter total sum in basket : ");
            int Basket = Int32.Parse(Console.ReadLine());
            Discount.IfGet(Basket);
            Console.ResetColor();
            Console.WriteLine("────────────────");
            Console.ForegroundColor = ConsoleColor.DarkGreen; Console.BackgroundColor = ConsoleColor.White;
            Console.WriteLine($"Switch Method");
            Console.Write("Enter total sum in basket : ");
            int basket = Int32.Parse(Console.ReadLine());
            Discount.SwitchGet(basket);
            Console.ResetColor();
            Console.WriteLine("────────────────");
        }
    }
}
