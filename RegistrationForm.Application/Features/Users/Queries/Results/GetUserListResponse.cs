using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RegistrationForm.ApplicationCore.Features.Users.Queries.Results
{
    public class GetUserListResponse
    {

        public int userId { get; set; }
        public string fristName { get; set; }
        public string? middelName { get; set; }
        public string lastName { get; set; }
        public DateTime brithDate { get; set; }
        public String mobileNumber { get; set; }
        public String email { get; set; }
    }
}
