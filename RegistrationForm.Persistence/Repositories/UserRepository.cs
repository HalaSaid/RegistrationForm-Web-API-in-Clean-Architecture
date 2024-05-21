using Azure;
using Microsoft.EntityFrameworkCore;
using RegistrationForm.ApplicationCore.Abstracts;
using RegistrationForm.ApplicationCore.Features.Users.Commands.Models;
using RegistrationForm.ApplicationCore.Features.Users.Commands.Results;
using RegistrationForm.ApplicationCore.Models;
using RegistrationForm.Domain.Entities;
using RegistrationForm.Persistence.Data.Context;
//using RegistrationForm.Persistence.Data.Context;

namespace RegistrationForm.Infrastructure.Repositories
{
    public class UserRepository : IUserRepository
    {
        #region fields
        private readonly ApplicationDbContext _dbContext;
        #endregion
        public UserRepository(ApplicationDbContext dbContext)
        {
            _dbContext = dbContext;
        }


        #region Handle Function 
       

        public async Task<List<City>> GetCitiesByGovIdAsync(int id)
        {
            var res = await _dbContext.Cities.Include(g => g.Government).Where(x=>x.governmentId==id).ToListAsync();
            return res;
        }
        public  async Task<List<Government>> GetGovernmentsAsync()
        {
            return await _dbContext.Governments.ToListAsync();
        }
        public async Task<GetUserRegResponse> RegisterUsersAsync(User user)
        {
            try
            {
                var res = _dbContext.Users.AddAsync(user);
                await _dbContext.SaveChangesAsync();
                return new GetUserRegResponse()
                {
                    firstName = user.fristName
                };
            }
            catch (Exception)
            {
                return null;
            }

        }
        #endregion
    }
}
