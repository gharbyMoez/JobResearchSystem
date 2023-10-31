using JobResearchSystem.Application.Bases;
using MediatR;

namespace JobResearchSystem.Application.Feature.Categories.Commands.Models
{
    public class AddCategoryCommand : IRequest<Response<string>>
    {
        public string CategoryName { get; set; }
        //public int CategoryParentId { get; set; }
        public string? Description { get; set; }

    }
}
