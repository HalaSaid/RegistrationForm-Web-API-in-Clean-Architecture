using Microsoft.Extensions.DependencyInjection;
using RegistrationForm.ApplicationCore.Abstracts;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection;
using System.Text;
using System.Threading.Tasks;

namespace RegistrationForm.ApplicationCore
{
    public static class ModuleApplicationDependancies
    {
        public static IServiceCollection AddModuleApplicationDependancies(this IServiceCollection services)
        {
            //configuration of medaitor
            services.AddMediatR(M=>M.RegisterServicesFromAssemblies(Assembly.GetExecutingAssembly()));

            //configuration of auto mapper
            services.AddAutoMapper(Assembly.GetExecutingAssembly());
            return services;
        }
    }
}
