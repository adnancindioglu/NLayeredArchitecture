using Microsoft.EntityFrameworkCore;
using NLayeredArchitecture.Core.Models;
using NLayeredArchitecture.Core.Repositories;
using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;

namespace NLayeredArchitecture.Data.Repositories
{
    public class CategoryRepository:Repository<Category>,ICategoryRepository
    {
        private AppDbContext _appDbContext { get => _context as AppDbContext; }
        public CategoryRepository(AppDbContext context):base(context)
        {

        }

        public async Task<Category> GetWithProductsByCategoryIdAsync(int categoryId)
        {
            return await _appDbContext.Categories.Include(x => x.Products).SingleOrDefaultAsync(x => x.Id == categoryId);
        }
    }
}
