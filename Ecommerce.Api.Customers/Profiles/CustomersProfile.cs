using Ecommerce.Api.Customers.Db;
using Ecommerce.Api.Customers.Models;

namespace Ecommerce.Api.Customers.Profiles
{
    public class CustomersProfile : AutoMapper.Profile
    {
        public CustomersProfile()
        {
            CreateMap<Customer, CustomerModel>();
        }
    }
}
