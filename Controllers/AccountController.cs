using Microsoft.AspNetCore.Mvc;

namespace Blog.DotNetPlayground.Controllers
{
    public class AccountController : Controller
    {
        public IActionResult Login()
        {
            return View();
        }

        public IActionResult LoginNoTagHelper(){
            return View();
        }
    }
}
