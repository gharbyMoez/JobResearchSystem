using JobResearchSystem.Application.Feature.Companies.Commands.Models;
using JobResearchSystem.Application.Feature.Companies.Queries.Models;
using MediatR;
using Microsoft.AspNetCore.Mvc;

// For more information on enabling Web API for empty projects, visit https://go.microsoft.com/fwlink/?LinkID=397860

namespace JobResearchSystem.API.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class CompanyController : ApiBaseController
    {
        

        // GET: api/<CompanyController>
        [HttpGet]
        public async Task<IActionResult> Get()
        {
            var result = await Mediator.Send(new GetAllCompaniesQuery());

            return NewResult(result);
        }

        // GET api/<CompanyController>/5
        [HttpGet("{userId}")]
        public async Task<IActionResult> Get(string userId)
        {
            var result = await Mediator.Send(new GetCompanyByIdQuery() { UserId = userId});

            return NewResult(result);
        }

        // POST api/<CompanyController>
        [HttpPost]
        public async Task<IActionResult> Post([FromBody] AddCompanyCommand addCompanyCommand )
        {
            var result = await Mediator.Send(addCompanyCommand);

            return NewResult(result);
        }

        // PUT api/<CompanyController>/5
        [HttpPut]
        public async Task<IActionResult> Put([FromBody] UpdateCompanyCommand updateCompanyCommand)
        {
            var result = await Mediator.Send(updateCompanyCommand);
            
            return NewResult(result);
        }

        // DELETE api/<CompanyController>/5
        [HttpDelete("{id}")]
        public async Task<IActionResult> Delete(int id)
        {
            var result = await Mediator.Send(new DeleteCompanyCommand() { Id = id });
            
            return NewResult(result);
        }
    }
}
