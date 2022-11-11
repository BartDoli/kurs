namespace AlxCourseHomework.Nowy_folder
{
    public class Homework1Test
    {
        public static void Run()
        {
            var emailService = new EmailService();

            Console.WriteLine("Email #1");
            var email1 = new Email("EmailA@gmail.com", "EmailB@gmail.com", "Subject1", "Messege1");
            EmailService.SendEmail(email1);
            Console.WriteLine("─────────────────────────────────");
            Console.WriteLine("Email #2");
            var email2 = new Email("EmailA@gmail.com", "EmailB@gmail.com", "Subject2", "Messege2");
            EmailService.SendEmail(email2);
            Console.WriteLine("─────────────────────────────────");
            Console.WriteLine("Email #3");
            var email3 = new Email("EmailA@gmail.com", "EmailB@gmail.com", "Subject3", "Messege3");
            EmailService.SendEmail(email3);
            Console.WriteLine("─────────────────────────────────");
            Console.WriteLine("Email #4");
            var email4 = new Email("EmailA@gmail.com", "EmailB@gmail.com", "Subject4", "Messege4");
            EmailService.SendEmail(email4);
            Console.WriteLine("─────────────────────────────────");
            Console.WriteLine("Email #5");
            var email5 = new Email("EmailA@gmail.com", "EmailB@gmail.com", "Subject5", "Messege5");
            EmailService.SendEmail(email5);
            Console.WriteLine("─────────────────────────────────");
        }
    }
}
