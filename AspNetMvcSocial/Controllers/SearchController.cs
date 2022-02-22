using Microsoft.AspNetCore.Mvc;

namespace AspNetMvcSocial.Controllers
{
    public class SearchController : Controller
    {
        public IActionResult Index(string query, string order)
        {
            return View();
        }
    }
}
