using AlxCourseHomework.MaterialsAssignements.Enums;
namespace AlxCourseHomework.MaterialsAssignements
{
    public class Date
    {
        public int Day;
        public int Month;
        public int Year;

        public Date(int day, int month, int year)
        {
            Day = day;
            Month = month;
            Year = year;
        }

        public static void Today(int day, int month, int year)
        {
            Days dayName = (Days)day;
            Months monthName = (Months)month;
            Console.WriteLine("─────────────────────────────────");
            Console.WriteLine("12.3");
            Console.WriteLine("────────────────");
            Console.ForegroundColor = ConsoleColor.DarkGreen; Console.BackgroundColor = ConsoleColor.White;
            Console.WriteLine("Get today's date");
            Console.WriteLine(dayName.ToString());
            Console.WriteLine(monthName.ToString());
            Console.WriteLine(year);
            Console.ResetColor();
            Console.ForegroundColor = ConsoleColor.White; Console.BackgroundColor = ConsoleColor.DarkGreen;
            Console.WriteLine("Hope your day going well :D");
            Console.ResetColor();
        }
    }
}
