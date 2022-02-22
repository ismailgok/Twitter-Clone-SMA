using Microsoft.AspNetCore.Mvc;

namespace AspNetMvcSocial.Controllers
{
    public class ExploreController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }
    }
}
