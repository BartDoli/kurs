    using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Cryptography.X509Certificates;
using System.Text;
using System.Threading.Tasks;

namespace course_alx.Lessons.M1.L1.Classes
{
    public class Dog
    {
        public string Name;
        public int Age;
        public string Race;
        public bool GoodBoi;

        public void Jump()
        {
            Console.WriteLine("Boing!, Boing!");
        }
        public void Bark()
        {
            Console.WriteLine("Woof!, Woof!");
        }

        public static void Eat()
        {
            Console.WriteLine("Yum.. Yum..");
        }

        public DogOffspringStats Breed()
        {
            DogOffspringStats stats = new DogOffspringStats();
            stats.NumberOfMalePups = 5;
            stats.NumberOfFemalePups = 6;
            return stats;
        }
        public void Present()
        {
            Console.WriteLine("Attention here is " + Name);
            Console.WriteLine("Race:" + Race);
            Console.WriteLine("Age:" + Age);
            Console.WriteLine("Is he a good boi?: " + GoodBoi);
        }
    }
}
