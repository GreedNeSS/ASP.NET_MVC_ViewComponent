using Microsoft.AspNetCore.Mvc;

namespace ViewComponentContext.Components
{
    public class UsersListViewComponent : ViewComponent
    {
        List<string> users = new List<string>
        {
            "GreedNeSS", "Marcus", "Henry", "Ruslan", "Kate"
        };

        public IViewComponentResult Invoke() 
        {
            int number = users.Count;

            if (Request.Query.ContainsKey("number"))
            {
                int.TryParse(Request.Query["number"], out number);
            }

            ViewBag.Users = users.Take(number);
            ViewData["Header"] = $"Количество пользователей: {number}";
            return View();
        }
    }
}
