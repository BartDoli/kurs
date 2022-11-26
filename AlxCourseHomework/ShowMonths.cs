using AlxCourseHomework.MaterialsAssignements.Enums;

namespace AlxCourseHomework
{
    public class ShowMonths
    {
        public static void Run1()
        {
            foreach (var month in Enum.GetValues(typeof(Months)))
            {
                Console.WriteLine(month);
            }
        }

        public static void Run2()
        {
            List<string> months = new List<string>();
            foreach (var month in Enum.GetValues(typeof(Months)))
            {
                months.Add(month.ToString());
            }
            for (int i = 0; i < months.Count; i++)
            {
                Console.WriteLine(months[i]);
            }
        }
    }
}
