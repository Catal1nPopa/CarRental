using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using CarRentail.Application.Models;
using CarRentail.Application.Requests;
using CarRentail.Domain.Entities;
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

        public static async Task SendEmailConfirmation(RentModel dataRent, Vehicle dataVehicle, RentCarRequest dataRents, IMediator mediator)
        {
            EmailConfirmationRequest confirmation = new EmailConfirmationRequest();
            confirmation.carData = dataVehicle;
            confirmation.dataRental = dataRent;
            confirmation.carRequest = dataRents;
            mediator.Send(confirmation);
        }
    }
}
