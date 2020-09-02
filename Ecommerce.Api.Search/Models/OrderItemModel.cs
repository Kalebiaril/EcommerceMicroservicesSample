using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Ecommerce.Api.Search.Models
{
    public class OrderItemModel
    {
        public string ProductName { get; set; }

        public int Price { get; set; }

        public int Quantity { get; set; }
    }
}
