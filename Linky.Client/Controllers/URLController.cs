using Microsoft.AspNetCore.Mvc;

namespace Linky.Client.Controllers
{
    public class URLController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }
    }
}
