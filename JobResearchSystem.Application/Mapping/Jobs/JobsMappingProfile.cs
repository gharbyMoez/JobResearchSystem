using AutoMapper;
using JobResearchSystem.Application.Feature.Jobs.Commands.Models;
using JobResearchSystem.Application.Feature.Jobs.Queries.Response;
using JobResearchSystem.Domain.Entities;

namespace JobResearchSystem.Application.Mapping.Experiences
{
    public class JobsMappingProfile : Profile
    {
        public JobsMappingProfile()
        {
            CreateMap<Job, GetJobResponse>()
                             .ForMember(dest => dest.CategoryName, opt => opt.MapFrom(src => src.Category.CategoryName))
                             .ForMember(dest => dest.CompanyName, opt => opt.MapFrom(src => src.Company.CompanyName))
                             .ForMember(dest => dest.NumberOfApplicants, opt => opt.MapFrom(src => src.Applicants.Count()));

            CreateMap<UpdateJobCommand, GetJobResponse>();

            CreateMap<AddJobCommand, Job>();

            CreateMap<UpdateJobCommand, Job>();

            CreateMap<Applicant, GetApplicantsByJobIdResponse>()
                .ForMember(x => x.ApplicantStatus, opt => opt.MapFrom(src => src.ApplicantStatus.ApplicantStatusName))
                .ForMember(x => x.CVFilePath, opt => opt.MapFrom(src => src.JobSeeker.CVFilePath))
                .ForMember(x => x.ImageFilePath, opt => opt.MapFrom(src => src.JobSeeker.ImageFilePath));

        }
    }
}
