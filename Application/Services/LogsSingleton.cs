using CarRentail.Domain.Entities.Auth;
using System.Net.Mail;
using System.Net;
using CarRentail.Application.Models;
using CarRentail.Domain.Entities;
using System.Net.Mime;
using CarRentail.Application.Requests;

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

        public void EmailConfirmation(RentModel rentalData, Vehicle carData, RentCarRequest carRequest)
        {
            if (storedCredentials != null)
            {
                try
                {
                    MailMessage mail = new MailMessage();
                    SmtpClient SmtpServer = new SmtpClient("smtp.gmail.com");

                    mail.From = new MailAddress(storedCredentials.Email);
                    mail.To.Add("catalin.p2002@gmail.com");
                    mail.Subject = "Vehicol arendat";

                    // Create a styled HTML body
                    string htmlBody = $@"
                <html>
                <head>
                    <style>
                        body {{
                            font-family: Arial, sans-serif;
                            background-color: #f4f4f4;
                            margin: 0;
                            padding: 0;
                            color: #333;
                        }}
                        .container {{
                            width: 80%;
                            margin: 0 auto;
                            background-color: #fff;
                            padding: 20px;
                            border-radius: 10px;
                            box-shadow: 0 2px 4px rgba(0,0,0,0.1);
                        }}
                        .header {{
                            font-size: 24px;
                            font-weight: bold;
                            color: #444;
                            margin-bottom: 20px;
                        }}
                        .content {{
                            font-size: 16px;
                            line-height: 1.6;
                        }}
                        .exception-details {{
                            background-color: #ffdddd;
                            border-left: 6px solid #f44336;
                            margin: 20px 0;
                            padding: 10px;
                            font-family: monospace;
                            white-space: pre-wrap;
                        }}
.rent-details {{{{
    background-color: #red;
    border-left: 6px solid #f44336;
    margin: 20px 0;
    padding: 10px;
    font-family: monospace;
    white-space: pre-wrap;
}}}}
                        .vehicle-image {{{{
                            margin-top: 20px;
                            text-align: center;
                        }}}}
                        .vehicle-image img {{{{
                            max-width: 100%;
                            height: auto;
                            border: 1px solid #ddd;
                            border-radius: 10px;
                            box-shadow: 0 2px 4px rgba(0,0,0,0.1);
                        }}}}
                    </style>
                </head>
                <body>
                    <div class='container'>
                        <div class='header'>Notificare arenda</div>
                        <div class='content'>
                            O noua masina a fost arendata
                            <div class='exception-details'>
                                <h5>Clinet Id : {rentalData.CustomerId} </h5>
                                <h5>Vehicol Id : {rentalData.idCar} </h5>
                                <h5>Zile arenda : {rentalData.rentalDays} zile</h5>
                                <h5>Model : {carData.Model} </h5>
                                <h5>Brand : {carData.Brand} </h5>
                                <h5>Număr mașină : {carData.CarNumber} </h5>
                                <h5>Anul producției : {carData.Year} </h5>
                                <h5>Preț/zi : {carData.Price}</h5>
                            </div>
                            <div class='rent-detail'>
                                <h5>Start Date : {carRequest.StarTime} </h5>
                                <h5>End Date : {carRequest.EndTime} zile</h5>
                                <h5>Preț total : {carRequest.TotalPrice} </h5>
                            </div>
                        </div>
                    </div>
                </body>
                </html>";

                    byte[] imageBytes = Convert.FromBase64String(carData.Photo);
                    Attachment attachment = new Attachment(new System.IO.MemoryStream(imageBytes), "vehicle.jpg", MediaTypeNames.Image.Jpeg);

         
                    mail.Attachments.Add(attachment);

                    mail.Body = htmlBody;
                    mail.IsBodyHtml = true;

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
