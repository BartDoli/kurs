using AlxCourseHomework.MaterialsAssignements.Homework1;

namespace AlxCourseHomework
{
    public class Exercise2Run
    {
        public static void RunEx2()
        {
            var today = new Date((int)DateTime.Now.DayOfWeek, (int)DateTime.Now.Month, (int)DateTime.Now.Year);

            Date.Today(today.Day, today.Month, today.Year);
        }
    }
}
