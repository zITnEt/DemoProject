using DemoApplication.Models;
using MediatR;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Configuration;

namespace DemoApplication.Requests.ConsumerRequests
{
    public class LoginRequest : IRequest<string>
    {
        public readonly DbContext dbContext;
        public LoginRequestModel LoginRequestModel { get; set; }
        public readonly IConfiguration configuration;
        public LoginRequest(DbContext db, LoginRequestModel loginRequestModel, IConfiguration configuration)
        {
            dbContext = db;
            LoginRequestModel = loginRequestModel;
            this.configuration = configuration;
        }

    }
}
