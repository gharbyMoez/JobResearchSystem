using JobResearchSystem.Application.Feature.Experiences.Queries.Response;
using JobResearchSystem.Application.Feature.Qualifications.Queries.Response;
using JobResearchSystem.Application.Feature.Skills.Queries.Response;
using JobResearchSystem.Domain.Entities;

namespace JobResearchSystem.Application.Feature.JobSeekers.Queries.Response
{
    public class GetJobSeekerDetailsResponse
    {
        public string? CVFilePath { get; set; }
        public string? ImageFilePath { get; set; }
        public string UserId { get; set; }

        //////////
        
        public IEnumerable<GetExperienceResponse>? Experiences { get; set; }
        public IEnumerable<GetQualificationResponse>? Qualifications { get; set; }
        public IEnumerable<GetSkillResponse>? Skills { get; set; }


    }
}
