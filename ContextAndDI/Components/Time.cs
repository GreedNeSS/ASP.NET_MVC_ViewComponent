using Microsoft.AspNetCore.Mvc;
using System;

namespace ContextAndDI.Components
{
    [ViewComponent]
    public class Time
    {
        public string Invoke(bool includeSeconds = true, bool format24 = true)
        {
            string pattern = format24 ? "HH" : "hh";
            pattern += ":mm";
            pattern += includeSeconds ? ":ss" : "";
            return DateTime.Now.ToString(pattern);
        }
    }
}
