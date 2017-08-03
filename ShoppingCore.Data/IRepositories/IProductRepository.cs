using ShoppingCore.Data.Entities;
using ShoppingCore.Infrastructure.Interfaces;
using System;
using System.Collections.Generic;
using System.Text;

namespace ShoppingCore.Data.IRepositories
{
    public interface IProductRepository : IRepository<Product, int>
    {
        List<Product> GetProductByCategory(int categoryId);
    }
}
