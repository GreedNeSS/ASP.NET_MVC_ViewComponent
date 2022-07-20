using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.ViewComponents;
using System;

namespace GenerateContent.Components
{
    [ViewComponent]
    public class Timer
    {
        public IViewComponentResult Invoke()
        {
            return new ContentViewComponentResult(DateTime.Now.ToString("HH:mm:ss"));
        }
    }
}
