namespace BankAccountLib;

public class BankAccount
{
    private readonly List<EventBase> eventList = [];
    
    public decimal Balance { get; private set; } = 0;

    public void Deposit(decimal value)
    {
        var eventDeposit = new DepositMade { Value = value };
        Apply(eventDeposit);
        eventList.Add(eventDeposit);
    }

    public void Withdraw(decimal value)
    {
        var eventWithdraw = new WithdrawMade { Value = value };
        Apply(eventWithdraw);
        eventList.Add(eventWithdraw);
    }

    private void Apply(EventBase eventToApply)
    {
        if (eventToApply is DepositMade deposit)
        {
            Balance += deposit.Value;
        }
        else if (eventToApply is WithdrawMade withdraw)
        {
            Balance -= withdraw.Value;
        }
    }
}