using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Text;
using System.Threading.Tasks;
using DemoApplication.Models;
using MediatR;

namespace DemoApplication.Requests.ConsumerRequests
{
    public class LoginRequest : IRequest<string>
    {
        public LoginRequestModel LoginRequestModel { get; set; }
    }
}
