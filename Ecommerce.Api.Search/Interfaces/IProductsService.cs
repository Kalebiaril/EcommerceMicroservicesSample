﻿using Ecommerce.Api.Search.Models;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace Ecommerce.Api.Search.Interfaces
{
    public interface IProductsService
    {
        Task<(bool IsSucess, IEnumerable<ProductModel> Products)> GetProductsAsync();
    }
}
