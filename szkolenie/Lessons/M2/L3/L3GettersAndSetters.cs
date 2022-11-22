using course_alx.Lessons.M2.L3.Classes;

namespace course_alx.Lessons.M2.L3
{
    public class L3GettersAndSetters
    {
        public static void Run()
        {
            var computer = new Computer();
            computer.Brand = "Lenovo";
            computer.ProcesorFrequency = 3.6;
            computer.NumberOfCores = 4;
            computer.Name = "My PC";
            Console.WriteLine();
            //ComputerPresent(computer);

            var computer1 = new Computer();
            computer.Brand = "Lenovo";
            computer.ProcesorFrequency = 10;
            computer.NumberOfCores = 4;
            computer.Name = "My PC";
            Console.WriteLine();
            ComputerPresent(computer1);
        }

        private static void ComputerPresent(Computer computer)
        {
            Console.WriteLine($"Name : {computer.Name}");
            Console.WriteLine($"Processor Frequency : {computer.ProcesorFrequency}");
            Console.WriteLine($"Brand : {computer.Brand}");
            Console.WriteLine($"Number of cores : {computer.NumberOfCores}");
        }
    }
}
