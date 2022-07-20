using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Html;
using Microsoft.AspNetCore.Mvc.ViewComponents;
using System;

namespace GenerateContent.Components
{
    public class HtmlTime : ViewComponent
    {
        public IViewComponentResult Invoke()
        {
            return new HtmlContentViewComponentResult(
                new HtmlString($"<h2>Текущее время</h2><b>{DateTime.Now.ToLongTimeString()}</b>")
            );
        }
    }
}
