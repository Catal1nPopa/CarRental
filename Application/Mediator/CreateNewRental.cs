using MediatR;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using CarRentail.Application.Models;
using Microsoft.AspNetCore.Mvc;
using CarRentail.Application.Requests;
using CarRentail.Domain.Entities;

namespace CarRentail.Application.Mediator
{
    public class CreateNewRental
    {
        //private static IMediator _mediator;

        //public CreateNewRental(IMediator mediator)
        //{
        //    _mediator = mediator;
        //}

        public static async Task<bool> Create(RentModel dataRental, IMediator _mediator)
        {
            if (dataRental.rentalDays > 0)
            {
                    var checkResponse =
                        await GetVehicleData.getVehicle(dataRental.idCar, dataRental.vehicleTypes, _mediator);

                    var request = new GetRentailsRequest();
                    var rentals = await _mediator.Send(request);

                    foreach (var rent in rentals)
                    {
                        if (rent.VehicleId == dataRental.idCar && rent.VehicleType == dataRental.vehicleTypes &&
                            rent.EndTime > DateTime.Now)
                        {
                            return false;
                        }
                    }

                    RentCarRequest dataRent = new RentCarRequest();
                    dataRent.CustomerId = dataRental.CustomerId;
                    dataRent.CarNumber = checkResponse.CarNumber;
                    dataRent.VehicleId = dataRental.idCar;
                    dataRent.VehicleType = dataRental.vehicleTypes;
                    dataRent.StarTime = DateTime.Today;
                    dataRent.EndTime = DateTime.Today.AddDays(dataRental.rentalDays);
                    dataRent.TotalPrice = await _mediator.Send(new GetStrategyPriceRequest(dataRental.rentalDays));
                    
                    await _mediator.Send(dataRent);

                    UpdateVehicleStatusRequest dataUpdate = new UpdateVehicleStatusRequest();
                    dataUpdate.idCar = dataRental.idCar;
                    dataUpdate.vehicleTypes = dataRental.vehicleTypes;

                    await _mediator.Send(dataUpdate);

                    await SendEmail.SendEmailConfirmation(dataRental, checkResponse, dataRent, _mediator);
                    return true;
            }
            return false;
        }
    }
}
