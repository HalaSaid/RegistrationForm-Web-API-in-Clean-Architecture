using FluentValidation;
using RegistrationForm.ApplicationCore.Features.Users.Commands.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RegistrationForm.ApplicationCore.Features.Users.Commands.Validations
{
    public class AddUserValidation :AbstractValidator<RegisterUserCommand>
    {
        public AddUserValidation()
        {
            applyValidationRule();
        }
         private int GetAge(DateTime bornDate)
        {
            DateTime today = DateTime.Today;
            int age = today.Year - bornDate.Year;
            if (bornDate > today.AddYears(-age))
                age--;

            return age;
        }
        public void applyValidationRule() {

            RuleFor(x => x.fristName).NotEmpty().WithMessage("fristName must not be empty")
                                    .MaximumLength(20)
                                    .Matches("^[\u0621-\u064A\u0660-\u0669 ]+$");

            RuleFor(x => x.middelName).NotEmpty().WithMessage("middelName must not be empty")
                                   .MaximumLength(20)
                                   .Matches("^[\u0621-\u064A\u0660-\u0669 ]+$");

            RuleFor(x => x.lastName).NotEmpty().WithMessage("LastName must not be empty")
                                  .MaximumLength(20)
                                  .Matches("^[\u0621-\u064A\u0660-\u0669 ]+$");

            //RuleFor(x => x.brithDate).Must(v => v.brithDate >= GetAge(x.brithDate));
                //WithMessage("brithDate must not be empty");

        }
    }
}
