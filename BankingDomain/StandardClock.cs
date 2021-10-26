using System;

namespace BankingDomain
{
    public class StandardClock : IProvideBusinessClock
    {
        private readonly ISystemTime _systemTime;

        public StandardClock(ISystemTime systemTime)
        {
            _systemTime = systemTime;
        }

        public bool OutsideBusinessHours()
        {

            if (IsDuringBusinessHours())
            {
                return false;
            }
            else
            {
                return true;
            }
        }

        // "Never type "private" always refactor to it.
        private bool IsDuringBusinessHours()
        {
            return _systemTime.GetCurrent().Hour >= 9 && _systemTime.GetCurrent().Hour < 17;
        }
    }
}