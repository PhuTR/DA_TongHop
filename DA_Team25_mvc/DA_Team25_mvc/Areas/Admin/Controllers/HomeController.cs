using Microsoft.AspNetCore.Mvc;

namespace DA_Team25_mvc.Areas.Admin.Controllers
{
    [Area("Admin")]
    public class HomeController : Controller
    {
        public IActionResult Index()
        {

            return View();
        }
    }
}
