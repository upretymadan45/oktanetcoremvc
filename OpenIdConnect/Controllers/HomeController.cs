using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;

namespace OpenIdConnect.Controllers
{
    public class HomeController : Controller
    {
        [Authorize(Roles ="Everybone")]
        public IActionResult Index()
        {
            var user = HttpContext.User.Identity.Name;
            return View();
        }
    }
}
