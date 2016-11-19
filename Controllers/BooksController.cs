using Microsoft.AspNetCore.Mvc;

namespace Blog.DotNetPlayground.Controllers
{
    public class BooksController : Controller
    {
        public IActionResult BestSeller()
        {
            return View();
        }
    }
}
