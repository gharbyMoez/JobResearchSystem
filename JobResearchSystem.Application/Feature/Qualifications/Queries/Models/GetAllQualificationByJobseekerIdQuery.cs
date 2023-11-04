using JobResearchSystem.Application.Bases;
using JobResearchSystem.Application.Feature.Qualifications.Queries.Response;
using MediatR;

namespace JobResearchSystem.Application.Feature.Qualifications.Queries.Models
{
    public class GetAllQualificationByJobseekerIdQuery : IRequest<Response<IEnumerable<GetQualificationResponse>>>
    {
        public int JobseekerId { get; set; }
    }
}
