using AutoMapper;
using JobResearchSystem.Application.Feature.Skills.Commands.Models;
using JobResearchSystem.Application.Feature.Skills.Queries.Response;
using JobResearchSystem.Domain.Entities;

namespace JobResearchSystem.Application.Mapping.Skills
{
    public class JobsMappingProfile : Profile
    {
        public JobsMappingProfile()
        {
            CreateMap<Skill, GetJobResponse>();
            CreateMap<UpdateSkillCommand, GetJobResponse>();

            CreateMap<AddSkillCommand, Skill>();

            CreateMap<UpdateSkillCommand, Skill>();

        }
    }
}
