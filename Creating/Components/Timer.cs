using Microsoft.AspNetCore.Mvc;

namespace Creating.Components
{
    public class Timer : ViewComponent
    {
        public string Invoke()
        {
            return $"Timer : ViewComponent => Текущее время: {DateTime.Now.ToString("HH:mm:ss")}";
        }
    }
}
