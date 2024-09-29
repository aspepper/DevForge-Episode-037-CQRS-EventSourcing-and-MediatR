using MediatR;

namespace MediatRSample;

public class UserNotifyCommand : IRequest
{
    public string Email { get; set; } = string.Empty;
    public string Message { get; set; } = string.Empty;
}