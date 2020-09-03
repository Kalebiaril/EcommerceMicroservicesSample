using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Ecommerce.Api.Search.Interfaces;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace Ecommerce.Api.Search.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class SearchController : ControllerBase
    {
        private readonly ISearchService _searchService;

        public SearchController(ISearchService searchService)
        {
            _searchService = searchService;
        }

        [HttpGet("{id}", Name ="Get" )]
        public async Task<ActionResult> Get(int id)
        {
            var result = await _searchService.Search(id);
            if (result.IsSuccess)
            {
                return Ok(result.SearchResult);
            }
            return NotFound();
        }        
    }
}