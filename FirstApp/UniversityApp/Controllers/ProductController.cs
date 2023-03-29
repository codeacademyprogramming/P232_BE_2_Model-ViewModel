using Microsoft.AspNetCore.Mvc;

namespace UniversityApp.Controllers
{
    public class ProductController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }
    }
}
