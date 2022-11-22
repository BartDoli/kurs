﻿using course_alx.Lessons.M2.L3.Interfaces;

namespace course_alx.Lessons.M2.L3.Classes
{
    public class Hello : IHello
    {
        public void SayGoodMorning()
        {
            Console.WriteLine("Good Morning!");
        }

        public void SayGoodMorning(string name)
        {
            Console.WriteLine($"Good Morning {name}!");
        }

        public void SayHello()
        {
            Console.WriteLine("Hello!");
        }

        public void SayHello(string name)
        {
            Console.WriteLine($"Hello {name}!");
        }
    }
}
