using MediatR;
using Ordering.Domain.Entities;

namespace Ordering.Application.Features.Orders.Commands.CheckoutOrder
{
    public class CheckoutOrderCommand : IRequest<Order>
    {
        public int ProductId { get; set; }
        public string UserName { get; set; }
        public int Quantity { get; set; }
        public string Status { get; set; }
        public Customer Customer { get; set; }
        public Billing Billing { get; set; }
    }
}
