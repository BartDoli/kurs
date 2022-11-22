using course_alx.Lessons.M2.L3.Interfaces;

namespace course_alx.Lessons.M2.L3.Classes
{
    internal class PolishHello : IHello
    {
        public void SayGoodMorning()
        {
            Console.WriteLine("Dzień dobry!");
        }

        public void SayGoodMorning(string name)
        {
            Console.WriteLine($"Dzień dobry {name}!");
        }

        public void SayHello()
        {
            Console.WriteLine("Cześć!");
        }

        public void SayHello(string name)
        {
            Console.WriteLine($"Cześć {name}!");
        }
    }
}
