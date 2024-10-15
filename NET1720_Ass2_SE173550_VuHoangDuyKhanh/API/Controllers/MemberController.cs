using Microsoft.AspNetCore.Mvc;

namespace API.Controllers
{
    public class MemberController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }
    }
}
