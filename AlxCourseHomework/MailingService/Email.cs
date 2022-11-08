using System.Security.Cryptography;

namespace AlxCourseHomework.Nowy_folder
{
    public class Email
    {
        public string From; 
        public string To;
        public string Subject;
        public string Messege;

        public Email()
        {

        }
        public Email(string from, string to, string subject, string messege)
        {
            From = from;
            To = to;
            Subject = subject; 
            Messege = messege;
        }
    }
}
