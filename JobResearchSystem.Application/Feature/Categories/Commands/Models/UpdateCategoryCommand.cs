using JobResearchSystem.Application.Bases;
using JobResearchSystem.Application.Feature.Categories.Queries.Response;
using MediatR;

namespace JobResearchSystem.Application.Feature.Categories.Commands.Models
{
    public class UpdateCategoryCommand : IRequest<Response<GetCategoryResponse>>
    {
        public int Id { get; set; }
        public string CategoryName { get; set; }
        //public int CategoryParentId { get; set; }
        public string? Description { get; set; }

    }
}
