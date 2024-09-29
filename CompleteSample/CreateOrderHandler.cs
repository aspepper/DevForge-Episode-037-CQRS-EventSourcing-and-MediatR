using MediatR;

namespace CompleteSample;

public class CreateOrderHandler : IRequestHandler<CreateOrderCommand, GenericCommandResult>
{
    public async Task<GenericCommandResult> Handle(CreateOrderCommand command, CancellationToken cancellationToken)
    {
        command.Validate();

        if (!command.IsValid)
        {
            return await Task.FromResult(new GenericCommandResult(false, "Order with errors!", command.Notifications));
        }

        // 1. Create Order on Database (CQRS - comando)
        // 2. Publish Event OrderCreated (Event Sourcing)
        // 3. Handler is managed by MediatR

        return await Task.FromResult(new GenericCommandResult(true, "Order created and event registred!", new { }));
    }
}