using course_alx.Lessons.M1.L2.Enums;
using course_alx.Lessons.M2.L3.Classes.Inheritance;

namespace course_alx.Lessons.M2.L2.Classes.Inheritance
{
    public class Knight : ChessPiece
    {
        public Knight() : base()
        {
            Type = ChessFigureType.KNIGHT;
        }

        //override
        public void Move()
        {
            Console.WriteLine("The Knight is moving...");
        }
    }
}