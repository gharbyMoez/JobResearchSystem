using JobResearchSystem.Application.Bases;
using MediatR;
using Microsoft.AspNetCore.Http;

namespace JobResearchSystem.Application.Feature.JobSeekers.Commands.Models
{
    public class AddJobSeekerCommand : IRequest<Response<string>>
    {
        public string? CVFilePath { get; set; }
        public string? ImageFilePath { get; set; }
        public string UserId { get; set; }

        public IFormFile? ImageForm { get; set; } = null!;
        public IFormFile? CvForm { get; set; } = null!;
    }
}
