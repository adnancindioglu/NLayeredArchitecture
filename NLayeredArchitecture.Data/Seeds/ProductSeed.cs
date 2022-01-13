using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using NLayeredArchitecture.Core.Models;
using System;
using System.Collections.Generic;
using System.Text;

namespace NLayeredArchitecture.Data.Seeds
{
    class ProductSeed : IEntityTypeConfiguration<Product>
    {
        private readonly int[] _ids;

        public ProductSeed(int[] ids)
        {
            _ids = ids;
        }

        public void Configure(EntityTypeBuilder<Product> builder)
        {
            builder.HasData(
                new Product
                {
                    Id=1,
                    Name="Asus",
                    Price=10000,
                    Stock = 50,
                    CategoryId = _ids[0]
                },
                new Product
                {
                    Id = 2,
                    Name = "Casper",
                    Price = 8000,
                    Stock = 50,
                    CategoryId = _ids[0]
                },
                new Product
                {
                    Id = 3,
                    Name = "Toshiba",
                    Price = 9000,
                    Stock = 50,
                    CategoryId = _ids[0]
                },
                new Product
                {
                    Id = 4,
                    Name = "IPhone",
                    Price = 6000,
                    Stock = 100,
                    CategoryId = _ids[1]
                },
                new Product
                {
                    Id = 5,
                    Name = "Samsung",
                    Price = 4500,
                    Stock = 100,
                    CategoryId = _ids[1]
                }
            );
        }
    }
}
