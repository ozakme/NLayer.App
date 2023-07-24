using NLayerCore.DTOs;
using NLayerCore.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NLayerCore.Services
{
    public interface IProductService:IService<Product>
    {
        Task<List<ProductWithCategoryDto>> GetProductsWithCategory();
    }
}
