﻿namespace JobResearchSystem.Application.Feature.Experiences.Queries.Response
{
    public class GetExperienceResponse
    {
        public int Id { get; set; }
        public string ExperienceCompanyName { get; set; }

        public string ExperienceTitle { get; set; }

        public DateTime? ExperienceStartDate { get; set; }
        public DateTime? ExperienceEndDate { get; set; }

        public string? PositionDescription { get; set; }
    }
}
