using Ecommerce.Api.Search.Models;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace Ecommerce.Api.Search.Interfaces
{
    public interface IProductsService
    {
        Task<(bool IsSuccess, IEnumerable<ProductModel> Products)> GetProductsAsync();

        Task<(bool IsSuccess, ProductModel Product)> GetProductAsync(int id);
    }
}
