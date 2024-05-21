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
        public void GetCitiesListByIdMapping()
        {
            CreateMap<City, GetCitiesListByGovIdResponse>().
                ForMember(x => x.governmentName, opt => opt.MapFrom(src => src.Government.governmentName));
        }
    }
}
