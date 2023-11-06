using JobResearchSystem.Application.Bases;
using JobResearchSystem.Application.Feature.Jobs.Queries.Response;
using MediatR;

namespace JobResearchSystem.Application.Feature.Jobs.Queries.Models
{
    public class GetAllApplicantByJobIdQuery : IRequest<Response<IEnumerable<GetApplicantsByJobIdResponse>>>
    {
        public int JobId { get; set; }

    }
}
