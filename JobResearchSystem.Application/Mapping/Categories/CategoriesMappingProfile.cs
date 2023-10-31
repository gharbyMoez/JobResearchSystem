using AutoMapper;
using JobResearchSystem.Application.Feature.Categories.Commands.Models;
using JobResearchSystem.Application.Feature.Categories.Queries.Response;
using JobResearchSystem.Domain.Entities;

namespace JobResearchSystem.Application.Mapping.Experiences
{
    public class CategoriesMappingProfile : Profile
    {
        public CategoriesMappingProfile()
        {
            CreateMap<Category, GetCategoryResponse>();
            CreateMap<UpdateCategoryCommand, GetCategoryResponse>();

            CreateMap<AddCategoryCommand, Category>();

            CreateMap<UpdateCategoryCommand, Category>();

        }
    }
}
