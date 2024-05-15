using CarRentail.Application.Requests;
using CarRentail.Application.Services;
using CarRentail.Domain.Entities.Auth;
using MediatR;

namespace CarRentail.Application.Handlers
{
    public class SendExceptionHandler : IRequestHandler<SendExceptionRequest, string>
    {
        private LogsSingleton logger;

        public SendExceptionHandler()
        {
            logger = LogsSingleton.Instance;
        }
        public async Task<string> Handle(SendExceptionRequest request, CancellationToken cancellationToken)
        {
            try
            {
                logger.SetCredentials(new EmailCredentials
                {
                    Email = "misterco2002@gmail.com",
                    Password = "vtht tuyh rktv drbr"
                });
                logger.LogException(request.exception);
                return "Email trimis cu succes";
            }
            catch (Exception ex)
            {
                return  $"Eroare la trimitere email {ex.Message}";
            }
        }
    }
}
