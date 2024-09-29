namespace CompleteSample;

public class OrderCreated : EventBase
{
    public int OrderId { get; set; }
    public Guid CustomerId { get; set; }
    public List<int> ProductsId { get; set; } = [];
}
