namespace BankingDomain
{
    public interface IProvideBusinessClock
    {
        bool OutsideBusinessHours();
    }
}