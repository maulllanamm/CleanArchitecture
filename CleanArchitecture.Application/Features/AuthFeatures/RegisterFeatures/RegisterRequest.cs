﻿using MediatR;

namespace CleanArchitecture.Application.Features.AuthFeatures.RegisterFeatures
{
    public sealed record RegisterRequest
    (
        string Username,
        string Password,
        string Email,
        string Fullname,
        string PhoneNumber,
        string Address
    ) : IRequest<RegisterResponse>;
}
