using AlxCourseHomework.MaterialsAssignements.Homework1;

namespace AlxCourseHomework
{
    public class Exercise3Run
    {
        public static void RunEx3()
        {
            var maths1 = new Maths(2, 6, 15);

            Maths.Operation(maths1.A, maths1.B, maths1.C);
            Maths.DeMorganRun();
        }
    }
}
