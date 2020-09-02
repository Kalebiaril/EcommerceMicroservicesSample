using Ecommerce.Api.Search.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Ecommerce.Api.Search.Services
{
    public class SearchService : ISearchService
    {
        public SearchService()
        {

        }
        public async Task<(bool IsSuccess, dynamic SearchResult)> Search()
        {
            await Task.Delay(TimeSpan.FromSeconds(2));
            return (true, "Hello");
        }
    }
}
