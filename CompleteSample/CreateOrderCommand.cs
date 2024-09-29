using Flunt.Notifications;
using Flunt.Validations;
using MediatR;

namespace CompleteSample;

public class CreateOrderCommand : Notifiable<Notification>, IRequest<GenericCommandResult>
{
    public Guid CustomerId { get; set; }
    public List<int> ProductsIds { get; set; } = [];

    public void Validate()
    {
        AddNotifications(
            new Contract<Notification>()
                .Requires()
                .IsNotEmpty(CustomerId, "Customer Id", "Custom Id not informed.")
                .IsNotEmpty(ProductsIds, "List of Products", "No product items.")
        );
    }
}
