using Microsoft.AspNetCore.Mvc;

namespace AspNetMvcSocial.Controllers
{
    public class PostController : Controller
    {
        public IActionResult Detail(int id)
        {
           
            return View();
        }
    }
}
