using MediatR;

namespace CleanArchitecture.Application.Features.UserFeatures.Query.GetById
{
    public sealed record GetByIdUserRequest(Guid id) : IRequest<GetByIdUserResponse>;
}
