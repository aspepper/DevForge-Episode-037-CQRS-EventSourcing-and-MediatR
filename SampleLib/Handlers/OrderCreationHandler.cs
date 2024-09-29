using SampleLib.Commands;

namespace SampleLib.Handlers;

public class OrderCreationHandler
{
    public void Handle(OrderCreationCommand command)
    {
        // Logic to create the order in the database
        Console.WriteLine("Order has been created successfully.");
    }
}