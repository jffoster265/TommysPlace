using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace Tommys_Place.Models
{
    public class Product
    {
        public int id { get; set; }
        public int categoryId { get; set; }
        public double price { get; set; }
        public String manufacturer { get; set; }
        public String requiredItems { get; set; }
        public String additionalInfo { get; set; }
        public String name { get; set; }
        public String description { get; set; }
        public String priceAsString { get; set; }
        public int quantity { get; set; }
        public String image { get; set; }
        public bool active { get; set; }
        public int productStatusId { get; set; }
    }
}