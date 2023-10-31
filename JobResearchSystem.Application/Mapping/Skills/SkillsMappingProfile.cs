using AutoMapper;
using JobResearchSystem.Application.Feature.Skills.Commands.Models;
using JobResearchSystem.Application.Feature.Skills.Queries.Response;
using JobResearchSystem.Domain.Entities;

namespace JobResearchSystem.Application.Mapping.Skills
{
    public class SkillsMappingProfile : Profile
    {
        public SkillsMappingProfile()
        {
            CreateMap<Skill, GetSkillResponse>();
            CreateMap<UpdateSkillCommand, GetSkillResponse>();

            CreateMap<AddSkillCommand, Skill>();

            CreateMap<UpdateSkillCommand, Skill>();

        }
    }
}
