namespace AlxCourseHomework.MaterialsAssignements
{
    public class Exercise1
    {
        public static void RunExercise1()
        {
            var personalInfo1 = new PersonalInfo("Bartosz", "D.", 22, 10203040506 , 1.81  , "Male");

            PersonalInfo.Present(personalInfo1.Name, personalInfo1.Surname, personalInfo1.Age, personalInfo1.Id, personalInfo1.Height, personalInfo1.Sex);

        }
    }
}
