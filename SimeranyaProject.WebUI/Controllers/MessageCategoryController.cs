using Microsoft.AspNetCore.Mvc;

namespace SimeranyaProject.WebUI.Controllers
{
    public class MessageCategoryController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }
    }
}
