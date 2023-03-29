using Microsoft.AspNetCore.Mvc;
using StoreApp.Models;
using StoreApp.ViewModels;
using System.Collections.Generic;

namespace StoreApp.Controllers
{
    public class ProductController : Controller
    {
        List<Product> _products;
        List<Brand> _brands;
        public ProductController()
        {
            _products = new List<Product>
            {
                new Product{Id = 1,Name = "Product 1",Price = 10,Count=50},
                new Product{Id = 2,Name = "Product 2",Price = 40,Count=0},
                new Product{Id = 3,Name = "Product 3",Price = 125,Count=55},
                new Product{Id = 4,Name = "Product 4",Price = 43,Count=150},
            };

            _brands = new List<Brand> { new Brand { Id = 1, Name = "Apple" }, new Brand { Id = 2, Name = "Xiaomi" }, new Brand { Id = 3, Name = "Samsung" } };
        }
        public IActionResult Index()
        {
            //ViewBag.Products = _products;
            //ViewBag.Brands = _brands;

            ProductViewModel productVM = new ProductViewModel
            {
                Brands = _brands,
                Products = _products,
            };

            return View(productVM);
        }

        public IActionResult Detail(int id)
        {
            Product pr = _products.Find(x => x.Id == id);

            if (pr == null)
                return View("Error");

            return View(pr);
        }
    }
}
