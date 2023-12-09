
namespace TestApp.Services
{
    public class ClockService : IClockService
    {
        private static DateTime _dateOfInit;
        public ClockService()
        {
            _dateOfInit = DateTime.Now;
        }
        public DateTime GetDate()
        {
            return _dateOfInit;
        }

    }


}