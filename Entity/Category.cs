using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace catalog.WebUI.Entity
{
    public class Category
    {
        public int Id { get; set; }
        public String Name { get; set; }
        public String Description { get; set; }
        public List<Product> Products { get; set; }
    }
}