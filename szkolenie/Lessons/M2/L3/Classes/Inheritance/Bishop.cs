using course_alx.Lessons.M1.L2.Enums;

namespace course_alx.Lessons.M2.L3.Classes.Inheritance
{
    public class Bishop : ChessPiece
    {
        public Bishop() : base()
        {
            Type = ChessFigureType.BISHOP;
        }

        //override
        public void Move()
        {
            Console.WriteLine("The Bishop is moving...");
        }
    }
}