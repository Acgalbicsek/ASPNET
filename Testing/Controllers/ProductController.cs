using Microsoft.AspNetCore.Mvc;

namespace Testing.Controllers
{
    public class ProductController : Controller
    {
        private readonly iProductRepository repo;

        public ProductController(iProductRepository repo)
        {
            this.repo = repo;
        }
        public IActionResult Index()
        {
            return View();
        }
    }
}
