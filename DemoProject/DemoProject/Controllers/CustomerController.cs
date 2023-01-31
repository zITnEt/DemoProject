using Auth.Dars1.Services;
using DemoApplication.Services;
using Microsoft.AspNetCore.Mvc;
using MediatR;
using DemoApplication.Requests.ConsumerRequests;
using DemoApplication.Models;
using Microsoft.EntityFrameworkCore;

namespace DemoProject.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class CustomerController : ControllerBase
    {
        private readonly IConfiguration _configuration;
        private readonly IMediator _mediator;
        private readonly DbContext dbContext;
        public CustomerController(IConfiguration configuration, IMediator mediator)
        {
            _configuration = configuration;
            _mediator = mediator;
        }

        [HttpGet("register")]
        public async Task<string> Register(LoginRequestModel loginRequestModel)
        {
            var tokenService = new JWTService(_configuration);
            return await _mediator.Send(new LoginRequest(dbContext, loginRequestModel, _configuration));

/*            return tokenService.Generate(new User()
            {
                Name = "Zafar",
                Role = Role.Customer
            });*/
        }
    }
}
