using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RegistrationForm.ApplicationCore.Features.Users.Queries.Results
{
    public class GetCitiesListByGovIdResponse
    {
        public int cityId { get; set; }
        public string cityName { get; set; }
        public string governmentName { get; set; }
    }
}
