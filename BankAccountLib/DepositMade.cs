namespace BankAccountLib;

public class DepositMade : EventBase
{
    public decimal Value { get; set; }
}