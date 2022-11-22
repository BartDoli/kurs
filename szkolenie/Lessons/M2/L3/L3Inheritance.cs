using course_alx.Lessons.M1.L2.Enums;
using course_alx.Lessons.M2.L3.Classes.Inheritance;

namespace AFALXCourse.Lessons.M2.L3
{
    public class L3Inheritance
    {
        public static void Run()
        {
            ChessPiece chessPiece = new King();
            chessPiece.XPosition = 1;
            chessPiece.YPosition = 1;
            chessPiece.Color = ChessColor.WHITE;
            chessPiece.Move();
            chessPiece.Present();

            Queen queen = new Queen();
            queen.Move();
            queen.XPosition = 1;
            queen.YPosition = 1;
            queen.Color = ChessColor.WHITE;
            queen.Present();

        }
    }
}