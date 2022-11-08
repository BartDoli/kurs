namespace AlxCourseHomework.Nowy_folder
{
    public class EmailService
    {
        public static void SendEmail (Email email)
        {
            var from =  email.From;
            var to = email.To;
            var subject = email.Subject;
            var messege = email.Messege;

            if (from != null)
            { 
                from = "User not found.";
            }

            if (to != null)
            {
                to = "User not found.";
            }

            if (subject != null)
            {
                subject = "Not specified.";
            }

            if (messege != null)
            {
                messege = "Messege not found.";
            }

            Console.WriteLine($"from : {from}\n To : {to}\n Subject : {subject}\n Messege : {messege}");
            Console.WriteLine("The email has been sent");
        }
    }
}
