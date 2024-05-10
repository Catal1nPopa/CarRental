using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using MediatR;

namespace CarRentail.Application.Requests
{
    public class GetStrategyPriceRequest : IRequest<int>
    {
        public int Days { get; set; }

        public GetStrategyPriceRequest(){}

        public GetStrategyPriceRequest(int days)
        {
            Days = days;
        }
    }
}
