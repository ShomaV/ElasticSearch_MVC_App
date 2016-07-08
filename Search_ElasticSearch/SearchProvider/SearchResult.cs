using System.Collections.Generic;

namespace Search_ElasticSearch.SearchProvider
{
    public class SearchResult<T>
    {
        public int Total { get; set; }
        public int TotalOnPage { get; set; }
        public int Page { get; set; }
        public int From { get; set; }
        public IEnumerable<T> Results { get; set; }
        public int Hits { get; set; }
        public int ElapsedMilliseconds { get; set; }
    }
}