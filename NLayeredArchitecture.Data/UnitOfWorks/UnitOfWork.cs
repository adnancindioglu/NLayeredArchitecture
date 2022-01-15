using Microsoft.EntityFrameworkCore;
using NLayeredArchitecture.Core.Repositories;
using NLayeredArchitecture.Core.UnitOfWorks;
using NLayeredArchitecture.Data.Repositories;
using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;

namespace NLayeredArchitecture.Data.UnitOfWork
{
    public class UnitOfWork : IUnitOfWork
    {
        private readonly AppDbContext _appDbContext;
        private ProductRepository _productRepository;
        private CategoryRepository _categoryRepository;
        public IProductRepository Products => _productRepository = _productRepository ?? new ProductRepository(_appDbContext);

        public ICategoryRepository Categories => _categoryRepository = _categoryRepository ?? new CategoryRepository(_appDbContext);

        public UnitOfWork(AppDbContext appDbContext)
        {
            _appDbContext = appDbContext;
        }
        public void Commit()
        {
            _appDbContext.SaveChanges();
        }

        public async Task CommitAsync()
        {
            await _appDbContext.SaveChangesAsync();
        }
    }
}
