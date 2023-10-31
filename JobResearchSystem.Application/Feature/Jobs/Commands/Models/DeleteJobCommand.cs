using JobResearchSystem.Application.Bases;
using MediatR;

namespace JobResearchSystem.Application.Feature.Jobs.Commands.Models
{
    public class DeleteJobCommand : IRequest<Response<string>>
    {
        public int JobId { get; set; }
    }
}
