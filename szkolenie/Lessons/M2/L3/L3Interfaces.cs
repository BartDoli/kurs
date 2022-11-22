using course_alx.Lessons.M2.L3.Classes;
using course_alx.Lessons.M2.L3.Interfaces;

namespace course_alx.Lessons.M2.L3
{
    public class L3Interfaces
    {
        public static void Run()
        {
            IHello helloService = new PolishHello();
            helloService.SayGoodMorning();
            helloService.SayGoodMorning("Andrzej");
            helloService.SayHello();
            helloService.SayHello("Andrzej");

            helloService = new Hello();
            helloService.SayGoodMorning();
            helloService.SayGoodMorning("Andrzej");
            helloService.SayHello();
            helloService.SayHello("Andrzej");
        }
    }
}
