namespace Search_ElasticSearch.Models
{
    using System.ComponentModel.DataAnnotations;
    using SearchProvider;

    public class SearchViewModel
    {
        [DataType(DataType.Text)]
        [Display(Name="Enter your Search term")]
        public string SearchTerm { get; set; }
        public SearchResult<Product> SearchResult { get; set; }
    }
}