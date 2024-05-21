using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RegistrationForm.ApplicationCore.Features.Users.Commands.Results
{
    public class GetUserRegResponse
    {
        public string firstName { get; set; }
        public string? middelName { get; set; }
        public string lastName { get; set; }
        public DateTime brithDate { get; set; }
        public String mobileNumber { get; set; }
        public String email { get; set; }
    }
}
