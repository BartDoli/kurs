using course_alx.Lessons.M1.L2.Enums;

namespace course_alx.Lessons.M2.L3.Classes.Inheritance
{
    public abstract class ChessPiece
    {
        public ChessColor? Color { get; set; }
        public ChessFigureType? Type { get; set; }
        public int XPosition { get; set; }
        public int YPosition { get; set; }
        public bool IsAlive { get; set; }

        public ChessPiece()
        {
            IsAlive = true;
        }

        public void Move()
        {
            Console.WriteLine("Chess Piece is moving...");
        }

        public void Present()
        {
            Console.WriteLine($"Color: {Color}");
            Console.WriteLine($"X position: {XPosition}");
            Console.WriteLine($"Y position: {YPosition}");
            Console.WriteLine($"Type : {Type}");
            Console.WriteLine($"Is Alive?\n {IsAlive}");
        }
    }
}