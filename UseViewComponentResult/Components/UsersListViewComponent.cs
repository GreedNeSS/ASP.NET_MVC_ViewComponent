using Microsoft.AspNetCore.Mvc;
using System;

namespace UseViewComponentResult.Components
{
    public class UsersListViewComponent : ViewComponent
    {
        List<string> users = new List<string>
        {
            "GreedNeSS",
            "Marcus",
            "Henry"
        };

        public IViewComponentResult Invoke()
        {
            return View(users);
        }
    }
}
