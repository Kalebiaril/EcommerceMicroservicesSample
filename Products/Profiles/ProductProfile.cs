using Ecommerce.Api.Products.Db;
using Ecommerce.Api.Products.Models;

namespace Ecommerce.Api.Products.Profiles
{
    public class ProductProfile : AutoMapper.Profile
    {
        public ProductProfile()
        {
            CreateMap<Product, ProductModel>();
        }
    }
}
