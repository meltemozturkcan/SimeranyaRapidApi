﻿using Microsoft.AspNetCore.Mvc;

namespace SimeranyaProject.WebUI.ViewComponents.Default
{
    public class _SpinnerPartial : ViewComponent
    {
        public IViewComponentResult Invoke()
        {
            return View();
        }
    }
}
