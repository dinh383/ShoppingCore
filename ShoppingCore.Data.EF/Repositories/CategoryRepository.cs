using ShoppingCore.Data.Entities;
using ShoppingCore.Data.IRepositories;
using System;
using System.Collections.Generic;
using System.Text;

namespace ShoppingCore.Data.EF.Repositories
{
    public class CategoryRepository : EFRepository<Category, int>, ICategoryRepository
    {
        public CategoryRepository(AppDbContext dbContext) : base(dbContext)
        {
        }
    }
}
