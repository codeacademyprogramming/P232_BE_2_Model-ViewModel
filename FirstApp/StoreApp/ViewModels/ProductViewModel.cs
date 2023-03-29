using StoreApp.Models;
using System.Collections.Generic;

namespace StoreApp.ViewModels
{
    public class ProductViewModel
    {
        public List<Product> Products { get; set; }
        public List<Brand> Brands { get; set; }
        public List<Category>   Categories { get; set; }    
    }
}
