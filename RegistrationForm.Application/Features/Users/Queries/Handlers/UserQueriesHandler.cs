using AutoMapper;
using MediatR;
using RegistrationForm.ApplicationCore.Abstracts;
using RegistrationForm.ApplicationCore.Bases;
using RegistrationForm.ApplicationCore.Features.Users.Queries.Models;
using RegistrationForm.ApplicationCore.Features.Users.Queries.Results;
using RegistrationForm.Domain.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RegistrationForm.ApplicationCore.Features.Users.Queries.Handlers
{
    public class UserQueriesHandler : ResponseHandler ,IRequestHandler<GetGovernmentsListQuery, Response<List<GetGovernmentsListResponse>>>
                                                      ,IRequestHandler<GetCitiesByGovIdListQuery, Response<List<GetCitiesListByGovIdResponse>>>
    {
        private readonly IUserRepository userRepository;
        private readonly IMapper mapper;

        public UserQueriesHandler(IUserRepository userRepository, IMapper mapper)
        {
            this.userRepository = userRepository;
            this.mapper = mapper;
        }
        public async Task<Response<List<GetGovernmentsListResponse>>> Handle(GetGovernmentsListQuery request, CancellationToken cancellationToken)
        {
            var sourceListObj = await this.userRepository.GetGovernmentsAsync();
            var distListObj = this.mapper.Map<List<GetGovernmentsListResponse>>(sourceListObj);
            return Success(distListObj);
        }

        public async Task<Response<List<GetCitiesListByGovIdResponse>>> Handle(GetCitiesByGovIdListQuery request, CancellationToken cancellationToken)
        {
            var sourceListObj = await this.userRepository.GetCitiesByGovIdAsync(request.GovId);
            //if (sourceListObj==null)
            //{
            //    return BadRequest("Object Not Found");
            //}
            var distListObj = this.mapper.Map<List<GetCitiesListByGovIdResponse>>(sourceListObj);
            return Success(distListObj);
        }
    }
}
