using Ordering.Application.Contracts.Persistence;
using Ordering.Domain.Entities;
using Ordering.Infrastructure.Persistence;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ordering.Infrastructure.Repositories
{
    
    public class ProductRepository : RepositoryBase<Product>, IProductRepository
    {
        public ProductRepository(OrderContext dbContext) : base(dbContext)
        {

        }

       
    }
}
