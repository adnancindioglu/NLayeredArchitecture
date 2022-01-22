using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace NLayeredArchitecture.API.DTOs
{
    public class CategoryWithProductDto: CategoryDto
    {
        public ICollection<ProductDto> Products { get; set; }
    }
}
