using Microsoft.AspNetCore.Mvc;
using ContextAndDI.Models;
using System;

namespace ContextAndDI.Components
{
    [ViewComponent]
    public class PersonInfo
    {
        public string Invoke(Person person)
        {
            return $"Id: {person.Id};\n Name: {person.Name}; Age: {person.Age}";
        }
    }
}
