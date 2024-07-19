using Microsoft.AspNetCore.Mvc;

namespace SimeranyaProject.WebUI.ViewComponents.Default
{
    public class _NavbarPartial : ViewComponent
    {
        public IViewComponentResult Invoke()
        {
            return View();
        }
    }
}
