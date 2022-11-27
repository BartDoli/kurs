using CourseFormApp.Exceptions;
using System.Windows.Forms;

namespace CourseFormApp
{
    public class ThrowExceptionExample
    {
        public void Run()
        {
            MessageBox.Show("Throwing exception");
            throw new OurException("System not responding, try restart!");
        }
    }
}
