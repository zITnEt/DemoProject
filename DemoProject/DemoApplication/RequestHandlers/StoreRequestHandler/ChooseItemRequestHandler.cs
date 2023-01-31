using DemoApplication.Requests.ConsumerRequests;
using DemoApplication.Requests.StoreRequests;
using MediatR;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DemoApplication.RequestHandlers.StoreRequestHandler
{
    public class ChooseItemRequestHandler: IRequestHandler<ChooseItemRequest, bool>
    {
        public async Task<bool> Handle(ChooseItemRequest laddItemRequest, CancellationToken cancellationToekn)
        {

            return true;
        }
    }
}
