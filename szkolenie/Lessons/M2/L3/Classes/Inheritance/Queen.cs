using course_alx.Lessons.M2.L3.Classes.Inheritance;

namespace course_alx.Lessons.M2.L3.Classes.Inheritance
{
    public class Queen : ChessPiece
    {
        public void Move()
        {
            Console.WriteLine("The Queen is moving...");
        }

        public void Present()
        {
            Console.WriteLine($"Queen");
            Console.WriteLine($"Color {Color}");
            Console.WriteLine($"X position {XPosition}");
            Console.WriteLine($"Y position {YPosition}");
            Console.WriteLine($"Type : {Type}");
            Console.WriteLine($"Is Alive?\n {IsAlive}");
        }
    }
}
