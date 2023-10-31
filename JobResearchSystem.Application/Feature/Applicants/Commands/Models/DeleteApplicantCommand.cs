using JobResearchSystem.Application.Bases;
using MediatR;

namespace JobResearchSystem.Application.Feature.Applicants.Commands.Models
{
    public class DeleteApplicantCommand : IRequest<Response<string>>
    {
        public int ApplicantId { get; set; }
    }
}
