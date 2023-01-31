using DemoApplication.Requests.ConsumerRequests;
using MediatR;


namespace DemoApplication.RequestHandlers.ConsumerRequestHandlers
{
    public class RegisterRequestHandler : IRequestHandler<RegisterRequest, bool>
    {
        public async Task<bool> Handle(RegisterRequest loginRequest, CancellationToken cancellationToekn)
        {

            return true;
        }
    }
}
