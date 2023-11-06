using JobResearchSystem.Application.Bases;
using JobResearchSystem.Application.Feature.Jobs.Queries.Response;
using MediatR;

namespace JobResearchSystem.Application.Feature.Jobs.Queries.Models
{
    public class GetAllJobsQuery : IRequest<Response<IEnumerable<GetJobResponse>>>
    {
    }
}
