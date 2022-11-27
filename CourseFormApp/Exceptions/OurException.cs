using System.Runtime.Serialization;

namespace CourseFormApp.Exceptions
{
    public class OurException : Exception
    {
        public OurException()
        {
        }

        public OurException(string? message) : base(message)
        {
        }

        public OurException(string? message, Exception? innerException) : base(message, innerException)
        {
        }
    }
}
