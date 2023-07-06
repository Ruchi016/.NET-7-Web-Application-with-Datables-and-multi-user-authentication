using Microsoft.AspNetCore.Mvc;

namespace DTWebApp.Controllers
{
    public class LoginController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }
    }
}
