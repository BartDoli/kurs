namespace AlxCourseHomework.MaterialsAssignements.Homework1
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
            Console.WriteLine("12.1");
            Console.WriteLine("────────────────");
            Console.ForegroundColor = ConsoleColor.Green; Console.BackgroundColor = ConsoleColor.White;
            Console.WriteLine("Personal Info");
            Console.WriteLine($"Name : {name}");
            Console.WriteLine($"Surname : {surname}");
            Console.WriteLine($"Age : {age}");
            Console.WriteLine($"ID : {id}");
            Console.WriteLine($"Height (m) : {height}m");
            Console.WriteLine($"Sex : {sex}");
            Console.ResetColor();
            Console.WriteLine("─────────────────────────────────");
            Console.WriteLine("12.2");
            Console.WriteLine("────────────────");
            Console.ForegroundColor = ConsoleColor.Green; Console.BackgroundColor = ConsoleColor.White;
            Console.WriteLine("Conversed Height");
            Console.ResetColor();
            Console.ForegroundColor = ConsoleColor.White; Console.BackgroundColor = ConsoleColor.DarkGreen;
            Console.WriteLine($"Conversed Height (round up) : {(int)Math.Ceiling(height)}");
            Console.ResetColor();
            Console.ForegroundColor = ConsoleColor.DarkGray;
            Console.WriteLine("If everyone could round up their height like that... XD");
            Console.ResetColor();
        }
    }
}
