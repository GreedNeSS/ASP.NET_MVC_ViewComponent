using Microsoft.AspNetCore.Mvc;
using System;

namespace GenerateContent.Components
{
    public class Time : ViewComponent
    {
        public IViewComponentResult Invoke()
        {
            return Content(DateTime.Now.ToString("HH:mm:ss"));
        }
    }
}
