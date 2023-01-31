using DemoApplication.Models;
using MediatR;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DemoApplication.Requests.StoreRequests
{
    public class AddItemRequest : IRequest<bool>
    {
        public Item Item { get; set; } 
    }
}
