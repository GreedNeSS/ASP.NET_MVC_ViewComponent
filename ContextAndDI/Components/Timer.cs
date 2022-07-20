using Microsoft.AspNetCore.Mvc;
using ContextAndDI.Services;
using System;

namespace ContextAndDI.Components
{
    [ViewComponent]
    public class Timer
    {
        ITimeService _timeService;

        public Timer(ITimeService timeService)
        {
            _timeService = timeService;
        }

        public string Invoke()
        {
            return _timeService.GetTime();
        }
    }
}
