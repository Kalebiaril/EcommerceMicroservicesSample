using Ecommerce.Api.Orders.Db;
using Ecommerce.Api.Orders.Models;

namespace Ecommerce.Api.Orders.Profiles
{
    public class OrdersProfile : AutoMapper.Profile
    {
        public OrdersProfile()
        {
            CreateMap<Order, OrderModel>();
            CreateMap<OrderItem, OrderItemModel>();
        }
    }
}
