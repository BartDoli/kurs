namespace AlxCourseHomework.MaterialsAssignements.Homework1
{
    public class Maths
    {
        public int A;
        public int B;
        public int C;

        public Maths(int a, int b, int c)
        {
            A = a;
            B = b;
            C = c;
        }

        public static void Operation(int a, int b, int c)
        {
            Console.WriteLine("17.1a");
            Console.WriteLine("────────────────");
            Console.ForegroundColor = ConsoleColor.DarkGreen; Console.BackgroundColor = ConsoleColor.White;
            Console.WriteLine("Mathematical Operation for ((a ^ b) / 2) % c");
            Console.WriteLine($"Variable a = {a}");
            Console.WriteLine($"Variable b = {b}");
            Console.WriteLine($"Variable c = {c}");
            Console.WriteLine($"The answer is : ((a ^ b) / 2) % c = {(a ^ b) / 2 % c}");
            Console.ResetColor();
            Console.WriteLine("─────────────────────────────────");
            Console.WriteLine("17.1b");
            Console.WriteLine("────────────────");
            Console.ForegroundColor = ConsoleColor.DarkGreen; Console.BackgroundColor = ConsoleColor.White;
            Console.WriteLine("Mathematical operation Check");
            bool checkA = a + 5 > a;
            Console.WriteLine($"Check if a + 5 > a");
            if (checkA == true)
            {
                Console.ForegroundColor = ConsoleColor.White; Console.BackgroundColor = ConsoleColor.Green;
                Console.WriteLine($"Check was succesfully True");
                Console.ResetColor();
            }
            else
            {
                Console.ForegroundColor = ConsoleColor.White; Console.BackgroundColor = ConsoleColor.Red;
                Console.WriteLine($"Check was unsuccesfully :(");
                Console.ResetColor();
            }
            Console.ForegroundColor = ConsoleColor.DarkGreen; Console.BackgroundColor = ConsoleColor.White;
            Console.WriteLine("Check finish");
            Console.ResetColor();
            Console.WriteLine("─────────────────────────────────");
        }
        public static bool DeMorganRun()
        {
            Console.WriteLine("17.2");
            Console.WriteLine("────────────────");
            bool A = true;
            bool B = false;
            bool A1 = true;
            bool B1 = false;
            bool check1 = !(A || A1) == (!A && !A1);
            bool check2 = !(A && A1) == (!A || !A1);
            bool check3 = !(A || B1) == (!A && !B1);
            bool check4 = !(A && B1) == (!A || !B1);
            bool check5 = !(B || A1) == (!B && !A1);
            bool check6 = !(B && A1) == (!B || !A1);
            bool check7 = !(B || B1) == (!B && !B1);
            bool check8 = !(B && B1) == (!B || !B1);
            bool check9 = check1 == true && check2 == true && check3 == true && check4 == true && check5 == true && check6 == true && check7 == true && check8 == true;
            Console.ForegroundColor = ConsoleColor.DarkGreen;
            Console.BackgroundColor = ConsoleColor.White;
            Console.WriteLine($"Is ~(p v q)= ~p ^ ~q if p=true and q=true, true? - {check1}");
            Console.WriteLine($"Is ~(p ^ q)= ~p v ~q if p=true and q=true, true? - {check2}");
            Console.WriteLine($"Is ~(p v q)= ~p ^ ~q if p=true and q=false, true? - {check3}");
            Console.WriteLine($"Is ~(p ^ q)= ~p v ~q if p=true and q=false, true? - {check4}");
            Console.WriteLine($"Is ~(p v q)= ~p ^ ~q if p=false and q=true, true? - {check5}");
            Console.WriteLine($"Is ~(p ^ q)= ~p v ~q if p=false and q=true, true? - {check6}");
            Console.WriteLine($"Is ~(p v q)= ~p ^ ~q if p=false and q=flase, true? - {check7}");
            Console.WriteLine($"Is ~(p ^ q)= ~p v ~q if p=false and q=false, true? - {check8}");
            Console.WriteLine($"Is all above true? - {check9}");
            Console.ResetColor();
            Console.WriteLine("─────────────────────────────────");
            if (check9 == true)
            {
                Console.ForegroundColor = ConsoleColor.White;
                Console.BackgroundColor = ConsoleColor.Green;
                Console.WriteLine($"The negation of a disjunction is the conjunction of the negations and The negation of a conjunction is the disjunction of the negations"); Console.ResetColor();
            }
            else { Console.BackgroundColor = ConsoleColor.Red; Console.WriteLine($"It won't happen"); }
            return A;
        }
    }
}
