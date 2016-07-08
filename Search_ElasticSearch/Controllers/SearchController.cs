using System.Web.Mvc;

namespace Search_ElasticSearch.Controllers
{
    using Models;
    using SearchProvider;

    public class SearchController : Controller
    {
        private SearchProvider searchProvider;
        public SearchController()
        {
            searchProvider = new SearchProvider();
        }

        // GET: Search
        public ActionResult Index(string currentFilter, int page = 1)
        {
            if (currentFilter != null)
            {
                SearchResult<Product> result = searchProvider.Search(currentFilter, page);
                var model = new SearchViewModel { SearchResult = result,SearchTerm = currentFilter};
                return View("SearchResults", model);                
            }
            return View();
        }

        [HttpPost]
        public ActionResult Index(string searchTerm, string currentFilter, int page=1)
        {
            SearchResult<Product> result = searchProvider.Search(searchTerm);
            var model=new SearchViewModel
            {
                SearchResult = result,
                SearchTerm = searchTerm
            };
            return View("SearchResults",model);
        }
    }
}