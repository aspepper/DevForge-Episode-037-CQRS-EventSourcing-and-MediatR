namespace SampleLib.Commands;

public class OrderCreationCommand
{
    public int CustomerId { get; set; }
    public List<int>? ProductsIds { get; set; }
}