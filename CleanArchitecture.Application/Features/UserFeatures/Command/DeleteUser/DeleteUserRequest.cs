using MediatR;

namespace CleanArchitecture.Application.Features.UserFeatures.Command.DeleteUser
{
    public sealed record DeleteUserRequest
    (
        Guid id
    ) : IRequest<bool>;
}
