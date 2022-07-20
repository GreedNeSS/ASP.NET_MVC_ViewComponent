using System;
namespace Creating.Components
{
    public class TimeViewComponent
    {
        public string Invoke()
        {
            return $"TimeViewComponent => Текущее время: {DateTime.Now.ToString("HH:mm:ss")}";
        }
    }
}
