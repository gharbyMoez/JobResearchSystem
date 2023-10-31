using AutoMapper;
using JobResearchSystem.Application.Feature.Qualifications.Commands.Models;
using JobResearchSystem.Application.Feature.Qualifications.Queries.Response;
using JobResearchSystem.Domain.Entities;

namespace JobResearchSystem.Application.Mapping.Qualifications
{
    public class QualificationsMappingProfile : Profile
    {
        public QualificationsMappingProfile()
        {
            CreateMap<Qualification, GetQualificationResponse>();
            CreateMap<UpdateQualificationCommand, GetQualificationResponse>();

            CreateMap<AddQualificationCommand, Qualification>();

            CreateMap<UpdateQualificationCommand, Qualification>();

        }
    }
}
