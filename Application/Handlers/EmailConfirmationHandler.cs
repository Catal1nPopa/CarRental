using CarRentail.Application.Requests;
using CarRentail.Application.Services;
using CarRentail.Domain.Entities.Auth;
using MediatR;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CarRentail.Application.Handlers
{
    public class EmailConfirmationHandler : IRequestHandler<EmailConfirmationRequest, string>
    {
        private LogsSingleton logger;

        public EmailConfirmationHandler()
        {
            logger = LogsSingleton.Instance;
        }
        public async Task<string> Handle(EmailConfirmationRequest request, CancellationToken cancellationToken)
        {
            try
            {
                logger.SetCredentials(new EmailCredentials
                {
                    Email = "misterco2002@gmail.com",
                    Password = "vtht tuyh rktv drbr"
                });
                logger.EmailConfirmation(request.dataRental, request.carData, request.carRequest);
                return "Email trimis cu succes";
            }
            catch (Exception ex)
            {
                return $"Eroare la trimitere email {ex.Message}";
            }
        }
    }
}
