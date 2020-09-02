using Ecommerce.Api.Orders.Models;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace Ecommerce.Api.Orders.Interfaces
{
    public interface IOrdersProvider
    {
        Task<(bool IsSuccess, IEnumerable<OrderModel> Orders, string ErrorMessage)> GetAllOrdersAsync(int customerId);
    }
}
