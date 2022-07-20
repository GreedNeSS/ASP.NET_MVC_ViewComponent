using Microsoft.AspNetCore.Mvc;

namespace Creating.Components
{
    [ViewComponent]
    public class TimeWithAttribute
    {
        public string Invoke()
        {
            return $"[ViewComponent]TimeWithAttribute => Текущее время: {DateTime.Now.ToString("HH:mm:ss")}";
        }
    }
}
