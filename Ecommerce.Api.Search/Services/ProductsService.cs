using Ecommerce.Api.Search.Interfaces;
using Ecommerce.Api.Search.Models;
using Microsoft.Extensions.Logging;
using System;
using System.Collections.Generic;
using System.Net.Http;
using System.Text.Json;
using System.Threading.Tasks;

namespace Ecommerce.Api.Search.Services
{
    public class ProductsService : IProductsService
    {
        private readonly IHttpClientFactory _httpClientFactory;
        private readonly ILogger<ProductsService> _logger;

        public ProductsService(IHttpClientFactory httpClientFactory, ILogger<ProductsService> logger)
        {
            _httpClientFactory = httpClientFactory;
            _logger = logger;
        }

        public Task<(bool IsSuccess, ProductModel Product)> GetProductAsync(int id)
        {
            throw new NotImplementedException();
        }

        public async Task<(bool IsSuccess, IEnumerable<ProductModel> Products)> GetProductsAsync()
        {
            try
            {
                var client = _httpClientFactory.CreateClient("Products");
                var response = await client.GetAsync("/api/products");
                if (response.IsSuccessStatusCode)
                {
                    var content = await response.Content.ReadAsStringAsync();
                    var options = new JsonSerializerOptions() { PropertyNameCaseInsensitive = true };

                    var result = JsonSerializer.Deserialize<IEnumerable<ProductModel>>(content, options);
                    return (true, result);
                }
                return (false, null);
            }
            catch (Exception ex)
            {
                _logger.LogError(ex, ex.Message);
                return (false, null);
            }
        }
    }
}
