using Microsoft.AspNetCore.Mvc;

namespace FirstMVCProject.Controllers
{
    public class MovieController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }
    }
}
