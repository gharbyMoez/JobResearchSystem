using JobResearchSystem.Application.Bases;
using JobResearchSystem.Application.Feature.Experiences.Queries.Response;
using MediatR;

namespace JobResearchSystem.Application.Feature.Experiences.Queries.Models
{
    public class GetAllExperiencesQuery : IRequest<Response<IEnumerable<GetExperienceResponse>>>
    {
    }
}
