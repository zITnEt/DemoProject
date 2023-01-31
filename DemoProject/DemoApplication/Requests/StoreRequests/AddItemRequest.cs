using MediatR;
using DemoDomain.Entity;

namespace DemoApplication.Requests.StoreRequests
{
    public class AddItemRequest : IRequest<bool>
    {
        public Product Item { get; set; } 
    }
}
