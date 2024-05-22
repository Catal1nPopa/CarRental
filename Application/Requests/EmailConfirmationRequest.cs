using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using CarRentail.Application.Models;
using CarRentail.Domain.Entities;
using MediatR;

namespace CarRentail.Application.Requests
{
    public class EmailConfirmationRequest : IRequest<string>
    {
        public RentModel dataRental { get; set; }
        public Vehicle carData { get; set; }
        public RentCarRequest carRequest { get; set; }
        public EmailConfirmationRequest(){}

        public EmailConfirmationRequest(RentModel dataRental, Vehicle carData, RentCarRequest carRequest)
        {
            this.dataRental = dataRental;
            this.carData = carData;
            this.carRequest = carRequest;
        }
    }
}
