using JobResearchSystem.Application.Bases;
using MediatR;

namespace JobResearchSystem.Application.Feature.Qualifications.Commands.Models
{
    public class DeleteQualificationCommand : IRequest<Response<string>>
    {
        public int QualificationId { get; set; }
    }
}
