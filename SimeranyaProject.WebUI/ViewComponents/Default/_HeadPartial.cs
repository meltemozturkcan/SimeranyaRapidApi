﻿using Microsoft.AspNetCore.Mvc;

namespace SimeranyaProject.WebUI.ViewComponents.Default
{
    public class _HeadPartial : ViewComponent
    {
        public IViewComponentResult Invoke()
        {
            return View();
        }
    }
}
