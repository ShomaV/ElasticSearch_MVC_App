using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace Search_ElasticSearch.Controllers
{
    using Models;
    using Nest;
    using SearchProvider;

    public class SearchController : Controller
    {
        private SearchProvider searchProvider;
        public SearchController()
        {
            searchProvider = new SearchProvider();
        }

        // GET: Search
        public ActionResult Index()
        {
            return View();
        }

        [HttpPost]
        public ActionResult Index(string searchTerm)
        {
            SearchResult<Product> result = searchProvider.Search(searchTerm);
            var model = new SearchViewModel {SearchResult = result};
            return View("SearchResults",model);
        }
    }
}