using JobResearchSystem.Application.Bases;
using JobResearchSystem.Application.Feature.Categories.Queries.Response;
using MediatR;

namespace JobResearchSystem.Application.Feature.Categories.Queries.Models
{
    public class GetAllCategoriesQuery : IRequest<Response<IEnumerable<GetCategoryResponse>>>
    {
    }
}
