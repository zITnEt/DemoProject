using DemoApplication.Requests.ConsumerRequests;
using MediatR;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DemoApplication.RequestHandlers.ConsumerRequestHandlers
{
    public class OrderItemRequestHandler: IRequestHandler<OrderItemRequest, bool>
    {
        public async Task<bool> Handle(OrderItemRequest orderItemRequest, CancellationToken cancellationToekn)
        {
            return false;
        }
    }
}
