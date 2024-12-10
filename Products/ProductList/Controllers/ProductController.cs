using Microsoft.AspNetCore.Mvc;
using ProductList.Models;

namespace ProductList.Controllers
{
    public class ProductController : Controller
    {
        public IActionResult ProductDetail(string slugLink)
        {
            Product? product = DataBase.GetProduct(slugLink);
            if (product == null)
            {
                return NotFound();
            }
            return View(product);
        }
    }
}
