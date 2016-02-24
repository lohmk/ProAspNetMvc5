using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace LanguageFeatures.Models
{
    public class Product
    {
        public int ProductID { get; set; }
        private string _name;
        public string Name
        {
            get { return ProductID + _name; }
            set { _name = value; }
        }
        public string Description { get; set; }
        public decimal Price { get; set; }
        public string Category { get; set; }
    }
}