﻿using FluentValidation;

namespace CleanArchitecture.Application.Features.AuthFeatures.VerifyFeatures
{
    public class VerifyValidation : AbstractValidator<VerifyRequest>
    {
        public VerifyValidation()
        {
            RuleFor(x => x.VerifyToken).NotEmpty();
        }
    }
}
