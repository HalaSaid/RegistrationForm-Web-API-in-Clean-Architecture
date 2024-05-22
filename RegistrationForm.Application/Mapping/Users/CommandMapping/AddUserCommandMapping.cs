using AutoMapper;
using RegistrationForm.ApplicationCore.Features.Users.Commands.Models;
using RegistrationForm.ApplicationCore.Features.Users.Commands.Results;
using RegistrationForm.ApplicationCore.Features.Users.Queries.Results;
using RegistrationForm.Domain.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RegistrationForm.ApplicationCore.Mapping.Users
{
    public partial class UserProfile
    {
        public void AddUserCommandMapping()
        {
            CreateMap<RegisterUserCommand, User>();
            CreateMap<AddressReg, Address>();
        }
        
    }
}
