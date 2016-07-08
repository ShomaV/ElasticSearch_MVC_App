namespace Search_ElasticSearch.SearchProvider
{
    using System;
    using System.Collections.Generic;
    using Models;
    using Nest;

    public class SearchProvider : ISearchService<Product>
    {
        private const int ResultsPerPage=5;
        private static ElasticClient ElasticClient
        {
            get
            {
                var node = new Uri("http://localhost:9200");

                var settings = new ConnectionSettings(
                    node
                );
                settings.DefaultIndex("ecommerce");
                var client = new ElasticClient(settings);
                return client;
            }
        }

        public SearchResult<Product> Search(string queryString, int page=1, int pSize= ResultsPerPage)
        {
            var from = (page - 1)*pSize;
            var result = ElasticClient.Search<Product>(body => body
            .Query(query =>query
            .MultiMatch(qs => qs
            .Query(queryString)
            .Fields(f=>f
            .Fields(f1=>f1.Name,f2=>f2.Description,f3=>f3.Tags))))
            .Size(pSize)
            .From(from));

            var to = page*pSize;
            return new SearchResult<Product>
            {
                Total = (int)result.Total,
                Page = page,
                From = from,
                Results = result.Documents,                
                ElapsedMilliseconds = result.Took,
                TotalOnPage = (to > (int)result.Total)? (int)result.Total:to,                
            };
        }

        public SearchResult<Product> SearchByCategory(string query, IEnumerable<string> tags, int page, int pageSize)
        {
            throw new NotImplementedException();
        }

        public IEnumerable<string> Autocomplete(string query, int count)
        {
            throw new NotImplementedException();
        }
    }
}