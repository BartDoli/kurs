using AlxCourseHomework.MaterialsAssignements.Homework1;

namespace AlxCourseHomework
{
    public class Exercise1Run
    {
        public static void RunEx1()
        {
            var personalInfo1 = new PersonalInfo("Bartosz", "D.", 22, 10203040506, 1.81, "Male");

            PersonalInfo.Present(personalInfo1.Name, personalInfo1.Surname, personalInfo1.Age, personalInfo1.Id, personalInfo1.Height, personalInfo1.Sex);
        }
    }
}
