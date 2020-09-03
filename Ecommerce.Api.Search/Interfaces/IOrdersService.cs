using Ecommerce.Api.Search.Models;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace Ecommerce.Api.Search.Interfaces
{
    public interface IOrdersService
    {
        Task<(bool IsSuccess, IEnumerable<OrderModel> Orders)> GetOrdersAsync(int customerId);
    }
}
