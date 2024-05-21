using Microsoft.Extensions.DependencyInjection;
using RegistrationForm.ApplicationCore.Abstracts;
using RegistrationForm.Infrastructure.Repositories;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RegistrationForm.Persistence
{
    public static class ModulePresistenceDependancies
    {
        public static IServiceCollection AddModulePresistenceDependancies(this IServiceCollection services)
        {
            services.AddTransient<IUserRepository, UserRepository>();
            return services;


        }
    }
}
