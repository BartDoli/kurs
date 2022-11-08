namespace AlxCourseHomework.MaterialsAssignements
{
    public class PersonalInfo
    {
        public string Name;
        public string Surname;
        public int Age;
        public long Id;
        public double Height;
        public string Sex;

        public PersonalInfo(string name, string surname, int age, long id, double height, string sex)
        {
            Name = name;
            Surname = surname;
            Age = age;
            Id = id;
            Height = height;
            Sex = sex;
        }

        public static void Present(string name, string surname, int age, long id, double height, string sex)
        {
            Console.WriteLine("˚　　　　✦　\U0001fa90　　.　　. 　 ˚　.　　　　 🌀　 . ✦　　　 　˚　　　　 .\r\n　🚀　　.   　　˚　　 　　*　　 　　✦　--Personal Info--　　.　　.　　　✦　˚ 　☄️ 　　　 ˚🌒　.˚　　　　✦　　　.　　. 　 ˚　.　　　　 　　 　🌀　　　 ✦　　.　");
            Console.WriteLine($"Full name : {name} {surname}");
            Console.WriteLine($"Age : {age}");
            Console.WriteLine($"ID : {id}");
            Console.WriteLine($"Height (m) : {height}m");
            Console.WriteLine($"Sex : {sex}");
            Console.WriteLine("˚　　　　✦　\U0001fa90　　.　　. 　 ˚　.　　　　 🌀　 . ✦　　　 　˚　　　　 .\r\n　🚀　　.   　　˚　　 　　*　　 　　✦　--Conversed Height--　　.　　.　　　✦　˚ 　☄️ 　　　 ˚🌒　.˚　　　　✦　　　.　　. 　 ˚　.　　　　 　　 　🌀　　　 ✦　　.　");
            Console.WriteLine($"Conversed Height (round up) : {(int)Math.Ceiling(height)}");
         }
    }
}
