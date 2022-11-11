using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace catalog.WebUI.Entity
{
    public class Product
    {
        public int Id { get; set; }
        public String Name { get; set; }
        public String Description { get; set; }
        public double Price { get; set; }
        public int Stock { get; set; }
        public bool IsAprovved { get; set; }
        public bool IsHome{ get; set; }
        public int CategoryId { get; set; }
        public Category Category { get; set; }
    }
}