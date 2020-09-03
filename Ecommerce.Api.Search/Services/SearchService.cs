using Ecommerce.Api.Search.Interfaces;
using System.Linq;
using System.Threading.Tasks;

namespace Ecommerce.Api.Search.Services
{
    public class SearchService : ISearchService
    {
        private readonly ICustomersService _customersService;
        private readonly IOrdersService _ordersService;
        private readonly IProductsService _productsService;

        public SearchService(ICustomersService customersService, IOrdersService ordersService, IProductsService productsService)
        {
            _customersService = customersService;
            _ordersService = ordersService;
            _productsService = productsService;
        }
        public async Task<(bool IsSuccess, dynamic SearchResult)> Search(int id)
        {
            var customersTask =  _customersService.GetCustomerAsync(id);
            var ordersTask = _ordersService.GetOrdersAsync(id);
            var productsTask = _productsService.GetProductsAsync();
            var customerResult = await customersTask;
            var ordersResult = await ordersTask;
            var productsResult = await productsTask;
            if (ordersResult.IsSuccess)
                {
                    foreach (var orders in ordersResult.Orders)
                    {
                        foreach (var item in orders.Items)
                        {
                            item.ProductName = productsResult.IsSuccess ?
                                productsResult.Products.FirstOrDefault(p => p.Id == item.ProductId)?.Name :
                                "Product information is not available";
                        }
                    }
                    var result = new
                    {
                        Customer = customerResult.IsSuccess ?
                                    customerResult.Customer :
                                    null,
                        Orders = ordersResult.Orders
                    };

                    return (true, result);
                }
                return (false, null);
            }
    }
}
