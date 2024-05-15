using CarRentail.Domain.Entities.Auth;
using System.Net.Mail;
using System.Net;

namespace CarRentail.Application.Services
{
    public class LogsSingleton
    {
        private static LogsSingleton instance;
        private static EmailCredentials storedCredentials;

        private LogsSingleton() { }

        public static LogsSingleton Instance
        {
            get
            {
                if (instance == null)
                {
                    instance = new LogsSingleton();
                }
                return instance;
            }
        }

        public void SetCredentials(EmailCredentials credentials)
        {
            storedCredentials = credentials;
        }

        public void LogException(Exception exception)
        {
            if (storedCredentials != null)
            {
                try
                {
                    MailMessage mail = new MailMessage();
                    SmtpClient SmtpServer = new SmtpClient("smtp.gmail.com");

                    mail.From = new MailAddress(storedCredentials.Email);
                    mail.To.Add("catalin.p2002@gmail.com");
                    mail.Subject = "Exception occurred in Controller CarRental";
                    mail.Body = exception.ToString();

                    SmtpServer.Port = 587;
                    SmtpServer.Credentials = new NetworkCredential(storedCredentials.Email, storedCredentials.Password);
                    SmtpServer.EnableSsl = true;

                    SmtpServer.Send(mail);
                }
                catch (Exception ex)
                {
                    Console.WriteLine("Error sending email: " + ex.Message);
                }
            }
            else
            {
                Console.WriteLine("Credentials not set. Cannot send email.");
            }
        }
    }
}
