using MediatR;

namespace CompleteSample;

public class Sample
{
    // Using MediatR to send the commmand
    public async Task OrderProcessor(IMediator mediator)
    {
        var command = new CreateOrderCommand
        {
            CustomerId = new Guid(),
            ProductsIds = [1, 2, 3]
        };

        var result = await mediator.Send(command);
        Console.WriteLine(result);
    }

}
