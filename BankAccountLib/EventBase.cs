namespace BankAccountLib;

public abstract class EventBase
{	
    public DateTime EventDate { get; set; } = DateTime.Now;
}