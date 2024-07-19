using Microsoft.AspNetCore.Mvc;

namespace SimeranyaProject.WebUI.Controllers
{
    public class RoomController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }
    }
}
