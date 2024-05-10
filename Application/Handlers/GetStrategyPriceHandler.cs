using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using CarRentail.Application.Requests;
using CarRentail.Application.Strategy;
using MediatR;

namespace CarRentail.Application.Handlers
{
    public class GetStrategyPriceHandler : IRequestHandler<GetStrategyPriceRequest, int>
    {
        private readonly RentalService _rentalService;

        public GetStrategyPriceHandler(RentalService rentalService)
        {
            _rentalService = rentalService;
        }

        public Task<int> Handle(GetStrategyPriceRequest request, CancellationToken cancellationToken)
        {
            int price = _rentalService.CalculateRentalPrice(request.Days);
            return Task.FromResult(price);
        }
    }
}
