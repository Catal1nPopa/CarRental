using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using MediatR;

namespace CarRentail.Application.Requests
{
    public class SendExceptionRequest : IRequest<string>
    {
        public Exception exception { get; set; }

        public SendExceptionRequest() { }

        public SendExceptionRequest(Exception exception)
        {
            this.exception = exception;
        }
    }
}
