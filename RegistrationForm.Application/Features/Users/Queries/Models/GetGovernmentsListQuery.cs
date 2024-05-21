using MediatR;
using RegistrationForm.ApplicationCore.Bases;
using RegistrationForm.ApplicationCore.Features.Users.Queries.Results;
using RegistrationForm.Domain.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RegistrationForm.ApplicationCore.Features.Users.Queries.Models
{
    public class GetGovernmentsListQuery : IRequest<Response<List<GetGovernmentsListResponse>>>
    {
    }
}
