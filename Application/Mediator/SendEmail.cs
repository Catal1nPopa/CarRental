using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using CarRentail.Application.Requests;
using MediatR;

namespace CarRentail.Application.Mediator
{
    public class SendEmail
    {
        public static async Task SendEmailException(Exception ex, IMediator mediator)
        {
            SendExceptionRequest exceprion = new SendExceptionRequest();
            exceprion.exception = new Exception(ex + "\n Exceptie la Logare");
            mediator.Send(exceprion);
        }
    }
}
