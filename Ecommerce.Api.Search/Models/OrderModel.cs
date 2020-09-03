﻿using System;
using System.Collections.Generic;

namespace Ecommerce.Api.Search.Models
{
    public class OrderModel
    {

        public int Id { get; set; }
        public DateTime OrderDate { get; set; }
        public decimal Total { get; set; }
        public List<OrderItemModel> Items { get; set; }
    }
}
