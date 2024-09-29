using MediatR;

namespace MediatRSample;

public class NotificarUsuarioHandler : IRequestHandler<UserNotifyCommand>
{
    Task IRequestHandler<UserNotifyCommand>.Handle(UserNotifyCommand request, CancellationToken cancellationToken)
    {
        // Logic to Send Email
        Console.WriteLine($"Email sent to {request.Email}: {request.Message}");
        return Task.FromResult(Unit.Value);
    }
}
