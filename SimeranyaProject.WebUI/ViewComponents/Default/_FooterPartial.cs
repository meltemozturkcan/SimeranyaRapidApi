﻿using Microsoft.AspNetCore.Mvc;

namespace SimeranyaProject.WebUI.ViewComponents.Default
{
    public class _FooterPartial : ViewComponent
    {
        public IViewComponentResult Invoke()
        {
            return View();
        }
    }
}
