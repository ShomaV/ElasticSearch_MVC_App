using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace Search_ElasticSearch.SearchProvider
{
    using Models;
    using Nest;

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