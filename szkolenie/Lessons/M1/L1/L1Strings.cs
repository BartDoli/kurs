﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace course_alx.Lessons.M1.L1
{
    internal class L1Strings
    {
        public static void Test()
        {
            string name = "Mateusz";
            Console.WriteLine(name);
            name = "ala";
            Console.WriteLine(name);
            name = name + " ma kota";
            Console.WriteLine(name);

            ExpandString(name, "hello");
            Console.WriteLine(name);

            ExpandString(name, "world");
            Console.WriteLine(name);

            ExpandString(name, "something");
            Console.WriteLine(name);
        }
        public static void ExpandString(string word, string extension)
        {
            word = word + extension;
        }

        public static void ConcatenationTest()
        {
            string word1 = "ala ma ";
            string word2 = "koty dwa ";

            string concat1 = word1 + word2;
            Console.WriteLine(concat1);

            string concat2 = word1 + " " + word2;
            Console.WriteLine(concat2);

            //string interpolation
            string concat3 = $"{word1}{word2}i dobrze się ma";
            Console.WriteLine(concat3);
        }

    }
}
