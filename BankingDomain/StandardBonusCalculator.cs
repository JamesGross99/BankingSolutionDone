using System;

namespace BankingDomain
{
    public class StandardBonusCalculator : ICalculateDepositBonusesForAccounts
    {
        private readonly IProvideBusinessClock _businessClock;

        public StandardBonusCalculator(IProvideBusinessClock businessClock)
        {
            _businessClock = businessClock;
        }
        public decimal GetBonusFor(decimal balance, decimal amountOfDeposit)
        {
            // WTCYWYH (Corey Haines)
            if(_businessClock.OutsideBusinessHours())
            {
                return 0;
            }

            if (balance >= 5000M)
            {
                return amountOfDeposit * .10M;
            }
            else if (balance >= 1000M & balance < 5000)
            {
                return amountOfDeposit * .05M;
            }
            else
            {
                return 0;
            }
        }
    }
}