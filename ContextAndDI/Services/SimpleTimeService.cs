namespace ContextAndDI.Services
{
    public class SimpleTimeService : ITimeService
    {
        public string GetTime()
        {
            return DateTime.Now.ToString("HH:mm:ss:fff");
        }
    }
}
