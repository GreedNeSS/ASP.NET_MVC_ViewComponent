using Microsoft.AspNetCore.Mvc;
using System;

namespace Creating.Components
{
    [ViewComponent]
    public class Header
    {
        public async Task<string> InvokeAsync()
        {
            using (StreamReader reader = new StreamReader("Files/Header.txt"))
            {
                return await reader.ReadToEndAsync();
            }
        }
    }
}
