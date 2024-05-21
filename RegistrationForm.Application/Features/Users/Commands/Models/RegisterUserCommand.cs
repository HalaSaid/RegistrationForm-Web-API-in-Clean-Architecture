using MediatR;
using RegistrationForm.ApplicationCore.Bases;
using RegistrationForm.ApplicationCore.Features.Users.Commands.Results;
using RegistrationForm.ApplicationCore.Models;
using RegistrationForm.Domain.Entities;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RegistrationForm.ApplicationCore.Features.Users.Commands.Models
{
    public class RegisterUserCommand : IRequest<Response<GetUserRegResponse>>
    {
        //public string firstName { get; set; }
        //public string? middelName { get; set; }
        //public string lastName { get; set; }
        //public DateTime brithDate { get; set; }
        //public String mobileNumber { get; set; }
        //public String email { get; set; }

        public string fristName { get; set; }
        public string? middelName { get; set; }
        public string lastName { get; set; }
        public DateTime brithDate { get; set; }
        public String mobileNumber { get; set; }
        public String email { get; set; }
        public AddressReg? Addresses { get; set; }
    }
    public class AddressReg
    {
        public int AddressId { get; set; }
        public int CityId { get; set; }
        public int GovernmentId { get; set; }
        public string street { get; set; }
        public string buildingNumber { get; set; }
        public int flatNumber { get; set; }
        public int UserId { get; set; }
        public virtual User User { get; set; }
        public virtual City City { get; set; }
        public virtual Government Government { get; set; }
    }
}
