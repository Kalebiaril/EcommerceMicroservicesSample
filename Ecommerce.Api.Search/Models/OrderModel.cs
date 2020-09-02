using System.Collections.Generic;

namespace Ecommerce.Api.Search.Models
{
    public class OrderModel
    {
        public IEnumerable<OrderItemModel> OrderItems { get; set; }

        public string CustomerName { get; set; }
    }
}
