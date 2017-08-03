using ShoppingCore.Data.Entities;
using ShoppingCore.Data.IRepositories;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace ShoppingCore.Data.EF.Repositories
{
    public class ProductRepository : EFRepository<Product>, IProductRepository
    {
        public ProductRepository(AppDbContext dbContext) : base(dbContext)
        {
        }

        public List<Product> GetProductByCategory(int categoryId)
        {
            return _dbContext.Products.Where(x => x.Id == categoryId).ToList();
        }
    }
}
