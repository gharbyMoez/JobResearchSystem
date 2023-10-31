using JobResearchSystem.Application.Bases;
using JobResearchSystem.Application.Feature.Qualifications.Queries.Response;
using MediatR;

namespace JobResearchSystem.Application.Feature.Qualifications.Queries.Models
{
    public class GetQualificationByIdQuery : IRequest<Response<GetQualificationResponse>>
    {
        public int QualificationId { get; set; }
    }
}
