using DemoApplication.Models;
using DemoApplication.Providers;
using DemoApplication.Requests.ConsumerRequests;
using Infrastructure;
using MediatR;
using DemoDomain.Entity;
using Auth.Dars1.Services;

namespace DemoApplication.RequestHandlers.ConsumerRequestHandlers
{
    public class LoginRequestHandler : IRequestHandler<LoginRequest, string>
    {
        public async Task<string> Handle(LoginRequest loginRequest, CancellationToken cancellationToken)
        {
            JWTService jWTService = new JWTService(loginRequest.configuration);
            LoginRequestModel loginRequestModel = loginRequest.LoginRequestModel;
            ApplicationDbContext dbContext = (ApplicationDbContext)loginRequest.dbContext;
            User user = dbContext.Users.First(x => x.PasswordHash == HashProvider.HashPasword(loginRequestModel.Password) && x.Email == loginRequestModel.Email);
            if (user == null)
            {
                throw new Exception("User is not found!");
            }
            return jWTService.Generate(user);
        } 
    }
}
