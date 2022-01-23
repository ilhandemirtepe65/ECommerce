using AutoMapper;
using MediatR;
using Microsoft.Extensions.Logging;
using Ordering.Application.Contracts.Persistence;
using Ordering.Domain.Entities;
using RabbitMQ.Client;
using System;
using System.Text;
using System.Text.Json;
using System.Threading;
using System.Threading.Tasks;

namespace Ordering.Application.Features.Orders.Commands.CheckoutOrder
{
    public class CheckoutOrderCommandHandler : IRequestHandler<CheckoutOrderCommand, Order>
    {
        private readonly IOrderRepository _orderRepository;

        private readonly IMapper _mapper;
        private readonly ILogger<CheckoutOrderCommandHandler> _logger;
        private readonly IProductRepository _productRepository;



        public CheckoutOrderCommandHandler(IOrderRepository orderRepository, IMapper mapper, ILogger<CheckoutOrderCommandHandler> logger, IProductRepository productRepository)
        {
            _orderRepository = orderRepository ?? throw new ArgumentNullException(nameof(orderRepository));
            _mapper = mapper ?? throw new ArgumentNullException(nameof(mapper));
            _logger = logger ?? throw new ArgumentNullException(nameof(logger));
            _productRepository = productRepository ?? throw new ArgumentNullException(nameof(productRepository));

        }

        public async Task<Order> Handle(CheckoutOrderCommand request, CancellationToken cancellationToken)
        {
            var orderEntity = _mapper.Map<Order>(request);
            Product product = await _productRepository.GetByIdAsync(request.ProductId);
            if (product != null)
            {
                if (product.Stock >= request.Quantity)
                {
                    product.Stock = product.Stock - request.Quantity;
                    await _productRepository.UpdateAsync(product);
                    var newOrder = await _orderRepository.AddAsync(orderEntity);
                    _logger.LogInformation($"Order {newOrder.Id} is successfully created.");
                    return newOrder;
                }
                else
                {
                    _logger.LogInformation($"You can maks get  {product.Stock} !");
                    return null;
                }

            }
            else
            {
                _logger.LogInformation($"Product not found.");
                return null;
            }    
        }
    }
}
