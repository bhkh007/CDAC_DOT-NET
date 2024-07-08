using Microsoft.AspNetCore.Mvc;

namespace MotionMint.Controllers
{
    public class UsersController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }
    }
}
