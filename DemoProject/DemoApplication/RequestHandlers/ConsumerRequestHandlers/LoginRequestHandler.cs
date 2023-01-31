using DemoApplication.Requests.ConsumerRequests;
using MediatR;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DemoApplication.RequestHandlers.ConsumerRequestHandlers
{
    public class LoginRequestHandler : IRequestHandler<LoginRequest, string>
    {
        public async Task<string> Handle(LoginRequest loginRequest, CancellationToken cancellationToekn)
        {

            return "";
        } 
    }
}
