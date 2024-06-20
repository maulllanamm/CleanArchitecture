﻿using AutoMapper;
using CleanArchitecture.Application.Common.Behaviors;
using CleanArchitecture.Application.Helper.Interface;
using CleanArchitecture.Application.Repositories;
using MediatR;

namespace CleanArchitecture.Application.Features.AuthFeatures.LoginFeatures
{
    public sealed class LoginHandler : IRequestHandler<LoginRequest, bool>
    {
        private readonly IUserRepository _userRepository;
        private readonly IMapper _mapper;
        private readonly IPasswordHelper _passwordHelper;
        private readonly string _papper = "v81IKJ3ZBFgwc2AdnYeOLhUn9muUtIQ0AJKgfewu*!(24uyjfebweuy";
        private readonly int _iteration = 5;
        public LoginHandler(IUserRepository userRepository, IMapper mapper, IPasswordHelper passwordHelper)
        {
            _userRepository = userRepository;
            _mapper = mapper;
            _passwordHelper = passwordHelper;
        }

        public async Task<bool> Handle(LoginRequest request, CancellationToken cancellationToken)
        {
            var user = await _userRepository.GetByUsername(request.Username);
            if(user == null)
            {
                throw new NotFoundException($"User with username {request.Username} Not Found");
            }

            var passwordHash = _passwordHelper.ComputeHash(request.Password, user.password_salt, _papper, _iteration);
            if (passwordHash != user.password_hash)
            {
                throw new NotFoundException("Incorrect password");
            }

            return true;
        }
    }
}