using AutoMapper;
using MediatR;
using RegistrationForm.ApplicationCore.Abstracts;
using RegistrationForm.ApplicationCore.Bases;
using RegistrationForm.ApplicationCore.Features.Users.Commands.Models;
using RegistrationForm.ApplicationCore.Features.Users.Commands.Results;
using RegistrationForm.ApplicationCore.Features.Users.Queries.Results;
using RegistrationForm.ApplicationCore.Models;
using RegistrationForm.Domain.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RegistrationForm.ApplicationCore.Features.Users.Commands.Handlers
{
    public class UserCommandsHandler : ResponseHandler, IRequestHandler<RegisterUserCommand, Response<GetUserRegResponse>>
    {
        private readonly IUserRepository userRepository;
        private readonly IMapper mapper;

        public UserCommandsHandler(IUserRepository userRepository, IMapper mapper)
        {
            this.userRepository = userRepository;
            this.mapper = mapper;
        }
        public async Task<Response<GetUserRegResponse>> Handle(RegisterUserCommand request, CancellationToken cancellationToken)
        {
            var userMapper = this.mapper.Map<User>(request);

            var result =await userRepository.RegisterUsersAsync(userMapper);
            //var distObj = this.mapper.Map<GetUserRegResponse>(result);
            return Success(result);
        }

    }
}
