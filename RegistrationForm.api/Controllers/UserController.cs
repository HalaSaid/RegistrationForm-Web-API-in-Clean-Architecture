using MediatR;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using RegistrationForm.ApplicationCore.Features.Users.Commands.Models;
using RegistrationForm.ApplicationCore.Features.Users.Queries.Models;
using RegistrationForm.Domain.Entities;
//using System.Web.Http;

namespace RegistrationForm.Presentation.Controllers
{
    [Route("api/[controller]")]
    //[Route("")]
    [ApiController]
    public class UserController : ControllerBase
    {
        private readonly IMediator mediator;

        public UserController(IMediator mediator)
        {
            this.mediator = mediator;
        }
        [HttpPost("/User/Registeration")]
        public async Task<IActionResult> RegisterUser([FromBody] RegisterUserCommand user)
        {
            var ret = await this.mediator.Send(user);//new RegisterUserCommand(
            return Ok(ret);
        }
        [HttpGet("/User/GetGovernments")]
        public async Task<IActionResult> GetGovernments()
        {
            var ret = await this.mediator.Send(new GetGovernmentsListQuery());
            return Ok(ret);
        }
        [HttpGet("/User/GetCitiesByGovId/{GovId}")]
        public async Task<IActionResult> GetCitiesByGovId([FromRoute] int GovId)
        {
            var ret = await this.mediator.Send(new GetCitiesByGovIdListQuery(GovId));
            return Ok(ret);
        }
    }
}
