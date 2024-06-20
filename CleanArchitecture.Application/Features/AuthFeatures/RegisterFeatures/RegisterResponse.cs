﻿namespace CleanArchitecture.Application.Features.AuthFeatures.RegisterFeatures
{
    public sealed class RegisterResponse
    {
        public string Username { get; init; }
        public string Email { get; init; }
        public string FullName { get; init; }
        public string PhoneNumber { get; init; }
        public string Address { get; init; }
    }
}
