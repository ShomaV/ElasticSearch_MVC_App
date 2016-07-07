using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace Search_ElasticSearch.Models
{
    using Nest;

    public class Product
    {
        public string Id { get; set; }
        public int? Quantity { get; set; }
        public string Name { get; set; }
        public string Description { get; set; }
        public double Price { get; set; }
        public string Status { get; set; }
        public IEnumerable<string> Tags { get; set; }
        //[Completion]
        public IEnumerable<Name> Categories { get; set; }
    }
}