using Microsoft.AspNetCore.Mvc;

namespace web.Controllers
{
    public class ReactDemoController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }
    }
}