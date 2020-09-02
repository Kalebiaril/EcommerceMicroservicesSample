using Ecommerce.Api.Search.Models;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace Ecommerce.Api.Search.Interfaces
{
    public interface IOrdersService
    {
        Task<(bool IsSucess, IEnumerable<OrderModel> Orders)> GetOrdersAsync();
    }
}
