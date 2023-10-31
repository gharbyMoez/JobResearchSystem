using AutoMapper;
using JobResearchSystem.Application.Feature.UserTypes.Commands.Models;
using JobResearchSystem.Application.Feature.UserTypes.Queries.Response;
using JobResearchSystem.Domain.Entities;

namespace JobResearchSystem.Application.Mapping.Experiences
{
    public class UserTypesMappingProfile : Profile
    {
        public UserTypesMappingProfile()
        {
            CreateMap<UserType, GetUserTypeResponse>();
            CreateMap<UpdateUserTypeCommand, GetUserTypeResponse>();

            CreateMap<AddUserTypeCommand, UserType>();

            CreateMap<UpdateUserTypeCommand, UserType>();

        }
    }
}
