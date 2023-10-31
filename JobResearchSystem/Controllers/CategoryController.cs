using JobResearchSystem.Application.Feature.Categories.Commands.Models;
using JobResearchSystem.Application.Feature.Categories.Queries.Models;
using Microsoft.AspNetCore.Mvc;

namespace JobResearchSystem.API.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class CategoryController : ApiBaseController
    {


        [HttpGet("GetAllCategories")]
        public async Task<IActionResult> GetAllCategories()
        {
            var result = await Mediator.Send(new GetAllCategoriesQuery());
            return NewResult(result);
        }

        [HttpGet("GetCategoryById")]
        public async Task<IActionResult> GetCategoryById([FromQuery] GetCategoryByIdQuery query)
        {
            var result = await Mediator.Send(query);

            return NewResult(result);
        }

        [HttpPost("AddCategory")]
        public async Task<IActionResult> AddCategory(AddCategoryCommand command)
        {
            var result = await Mediator.Send(command);
            return NewResult(result);
        }

        [HttpPut("UpdateCategory")]
        public async Task<IActionResult> UpdateCategory(UpdateCategoryCommand command)
        {
            var result = await Mediator.Send(command);
            return NewResult(result);
        }

        [HttpDelete("RemoveCategory")]
        public async Task<IActionResult> RemoveCategory(DeleteCategoryCommand command)
        {
            var result = await Mediator.Send(command);
            return NewResult(result);
        }

    }
}
