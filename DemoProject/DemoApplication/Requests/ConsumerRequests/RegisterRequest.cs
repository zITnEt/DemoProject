using DemoApplication.Models;
using MediatR;
using Microsoft.Extensions.Configuration;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DemoApplication.Requests.ConsumerRequests
{
    public class RegisterRequest : IRequest<bool>
    {
        public RegisterRequestModel RegisterRequestModel { get; set; }
        public IConfiguration configuration { get; set; }
    }
}
