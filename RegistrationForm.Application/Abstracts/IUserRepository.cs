using RegistrationForm.ApplicationCore.Bases;
using RegistrationForm.ApplicationCore.Features.Users.Commands.Models;
using RegistrationForm.ApplicationCore.Features.Users.Commands.Results;
using RegistrationForm.ApplicationCore.Models;
using RegistrationForm.Domain.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RegistrationForm.ApplicationCore.Abstracts
{
    public interface IUserRepository
    {
        public Task<GetUserRegResponse> RegisterUsersAsync(User user);//RegisterUserCommand
        public Task<List<Government>> GetGovernmentsAsync();
        public Task<List<City>> GetCitiesByGovIdAsync(int id);
    }
}
