using JobResearchSystem.Application.Bases;
using JobResearchSystem.Application.Feature.ApplicantStatus.Queries.Response;
using MediatR;

namespace JobResearchSystem.Application.Feature.ApplicantStatus.Queries.Models
{
    public class GetApplicantStatusByIdQuery : IRequest<Response<GetApplicantStatusResponse>>
    {
        public int SkillId { get; set; }
    }
}
