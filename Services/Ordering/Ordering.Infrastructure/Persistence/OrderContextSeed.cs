using Microsoft.Extensions.Logging;
using Ordering.Domain.Entities;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Ordering.Infrastructure.Persistence
{
    public class OrderContextSeed
    {
        public static async Task SeedAsync(OrderContext orderContext, ILogger<OrderContextSeed> logger)
        {
            if (!orderContext.Orders.Any())
            {
                orderContext.Products.AddRange(GetPreconfiguredOrders());
                await orderContext.SaveChangesAsync();
                logger.LogInformation("Seed database associated with context {DbContextName}", typeof(OrderContext).Name);
            }
        }

        private static IEnumerable<Product> GetPreconfiguredOrders()
        {
            return new List<Product>
            {
                new Product()
                {
                   Name ="Product 1",
                   Price=5,
                   Sku="sku1",
                   Description="Product 1",
                   Stock=190
                },
                 new Product()
                {
                   Name ="Product 2",
                   Price=15,
                   Sku="sku2",
                   Description="Product 2",
                   Stock=190
                },
                  new Product()
                {
                   Name ="Product 3",
                   Price=25,
                   Sku="sku3",
                   Description="Product 3",
                   Stock=190
                },
                   new Product()
                {
                   Name ="Product 4",
                   Price=35,
                   Sku="sku4",
                   Description="Product 4",
                   Stock=190
                },
                   new Product()
                {
                   Name ="Product 5",
                   Price=45,
                   Sku="sku5",
                   Description="Product 5",
                   Stock=190
                }

            };
        }

    }
}
