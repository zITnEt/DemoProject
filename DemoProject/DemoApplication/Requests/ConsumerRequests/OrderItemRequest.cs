using DemoApplication.Models;
using MediatR;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DemoApplication.Requests.ConsumerRequests
{
    public class OrderItemRequest: IRequest<bool>
    {
        public OrderItemModel OrderItemModel { get; set; }
    }
}
