using course_alx.Lessons.M1.L1.Classes;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace course_alx.lessons.M1.L1
{
    public static class L1ObjectVariables
    {
        public static void Test1()
        {
            Console.WriteLine("Variables");
            Dog dog = new Dog();
            dog.Jump();
            dog.Bark();
            dog.Name = "Burek";
            dog.Race = "Golden Retriever";
            dog.Age = 2;
            Console.WriteLine("Attention here is " + dog.Name);
            Console.WriteLine("Race:" + dog.Race);
            Console.WriteLine("Age:" + dog.Age);
            Dog.Eat();
        }

        public static void Test2()
        {
            Dog westieDog = new Dog();
            westieDog.Race = "WHWT";
            westieDog.Age = 4;
            westieDog.Name = "Skipper";
            westieDog.GoodBoi = true;
            westieDog.Present();

            DogOffspringStats stats = westieDog.Breed();
            Console.WriteLine("Number of female pups:" + stats.NumberOfFemalePups);
            Console.WriteLine("Number of male pups:" + stats.NumberOfMalePups);
            westieDog.Jump();
            westieDog.Bark();
        }
        public static void Something()
        {
            Console.WriteLine("Something...");
        }
    }
}
