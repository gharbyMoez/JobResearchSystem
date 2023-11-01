using JobResearchSystem.Domain.Entities;

namespace JobResearchSystem.Application.Feature.Jobs.Queries.Response
{
    public class GetApplicantsByJobIdResponse
    {
        public string? CVFilePath { get; set; }
        public string? ImageFilePath { get; set; }

        public string ApplicantStatus { get; set; }

    }
}
