namespace Search_ElasticSearch.SearchProvider
{
    using System.Collections.Generic;
    using Models;

    public interface ISearchService<T>
    {
        SearchResult<T> Search(string query, int page, int pageSize);

        SearchResult<Product> SearchByCategory(string query, IEnumerable<string> tags, int page, int pageSize);

        IEnumerable<string> Autocomplete(string query, int count);

    }
}
