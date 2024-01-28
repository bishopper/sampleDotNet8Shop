using Microsoft.AspNetCore.Mvc;
using sampleDotNet8Shop.ShopUI.Models;

namespace sampleDotNet8Shop.ShopUI.Controllers
{
    public class HomeController : Controller
    {
        private readonly IProductRepository productRepository;
        private int pageSize = 4;

        public HomeController(IProductRepository productRepository)
        {
            this.productRepository = productRepository;
        }
        public IActionResult Index(int pageNumber = 1)
        {
            return View(productRepository.GetAll(pageNumber, pageSize));
        }
    }
}
