using AutoMapper;
using Ecommerce.Api.Products.Db;
using Ecommerce.Api.Products.Interfaces;
using Ecommerce.Api.Products.Models;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Logging;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Ecommerce.Api.Products.Providers
{
    public class ProductsProvider : IProductsProvider
    {
        private readonly ProductsContext _context;
        private readonly ILogger _logger;
        private readonly IMapper _mapper;

        public ProductsProvider(ProductsContext context, ILogger<ProductsProvider> logger, IMapper mapper)
        {
            _context = context;
            _logger = logger;
            _mapper = mapper;
            SeedData();
        }

        private void SeedData()
        {
            if (!_context.Products.Any())
            {
                _context.Products.Add(new Db.Product() { Id = 1, Name = "Keyboard", Price = 20, Inventory = 100 });
                _context.Products.Add(new Db.Product() { Id = 2, Name = "Mouse", Price = 5, Inventory = 200 });
                _context.Products.Add(new Db.Product() { Id = 3, Name = "Monitor", Price = 150, Inventory = 1000 });
                _context.Products.Add(new Db.Product() { Id = 4, Name = "CPU", Price = 200, Inventory = 2000 });
                _context.SaveChanges();
            }
        }

        public async Task<(bool IsSuccess, IEnumerable<ProductModel> Products, string ErrorMessage)> GetAllProductsAsync()
        {
            try
            {
                _logger.LogInformation("Getting all products");
                var products = await _context.Products.ToListAsync();
                if (products != null && products.Any())
                {
                    _logger.LogInformation($"{ products.Count} product(s) found");
                    var result = _mapper.Map<IEnumerable<ProductModel>>(products);
                    return (true, result, null);
                }
                return (false, null, "Not found");
            }
            catch (Exception ex)
            {
                _logger.LogError(ex.Message, ex);
                return (false, null, ex.Message);               
            }
        }

        public async Task<(bool IsSuccess, ProductModel Product, string ErrorMessage)> GetProductAsync(int id)
        {
            try
            {
                _logger.LogInformation("Getting all products");
                var product = await _context.Products.FirstOrDefaultAsync(x => x.Id == id);
                if (product != null)
                {
                    _logger.LogInformation($"{ product.Name} product found");
                    var result = _mapper.Map<ProductModel>(product);
                    return (true, result, null);
                }
                return (false, null, "Not found");
            }
            catch (Exception ex)
            {
                _logger.LogError(ex.Message, ex);
                return (false, null, ex.Message);
            }
        }
    }
}
