using DemoApplication.Requests.ConsumerRequests;
using MediatR;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DemoApplication.RequestHandlers.ConsumerRequestHandlers
{
    public class AddBalanceRequestHandler : IRequestHandler<AddBalanceRequest, bool>
    {
        public async Task<bool> Handle(AddBalanceRequest addBalanceRequest, CancellationToken cancellationToekn)
        {
            return true;
        }
    }
}
