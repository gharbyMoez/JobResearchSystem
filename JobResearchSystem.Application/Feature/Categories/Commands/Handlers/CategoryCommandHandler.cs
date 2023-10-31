using AutoMapper;
using JobResearchSystem.Application.Bases;
using JobResearchSystem.Application.Feature.Categories.Commands.Models;
using JobResearchSystem.Application.Feature.Categories.Queries.Response;
using JobResearchSystem.Application.IService;
using JobResearchSystem.Domain.Entities;
using MediatR;

namespace JobResearchSystem.Application.Feature.Categories.Commands.Handlers
{
    public class CategoryCommandHandler : ResponseHandler,
                                       IRequestHandler<AddCategoryCommand, Response<string>>,
                                       IRequestHandler<DeleteCategoryCommand, Response<string>>,
                                       IRequestHandler<UpdateCategoryCommand, Response<GetCategoryResponse>>
    {
        #region CTOR
        private ICategoryService _CategoryService;
        private IMapper _mapper;

        public CategoryCommandHandler(ICategoryService CategorySerice, IMapper mapper)
        {
            _CategoryService = CategorySerice;
            _mapper = mapper;
        }
        #endregion

        public async Task<Response<string>> Handle(AddCategoryCommand request, CancellationToken cancellationToken)
        {
            var experiene = _mapper.Map<Category>(request);
            var result = await _CategoryService.CreateAsync(experiene);

            if (result is null)
                return BadRequest<string>("Something Went Wrong");

            return Created(" Category Added Successfully");
        }

        public async Task<Response<GetCategoryResponse>> Handle(UpdateCategoryCommand request, CancellationToken cancellationToken)
        {
            var experiene = _mapper.Map<Category>(request);

            var result = await _CategoryService.UpdateAsync(experiene);

            var resultDto = _mapper.Map<GetCategoryResponse>(request);

            if (resultDto == null) { return BadRequest<GetCategoryResponse>(""); }
            else { return Success<GetCategoryResponse>(resultDto); }
        }




        public async Task<Response<string>> Handle(DeleteCategoryCommand request, CancellationToken cancellationToken)
        {
            var result = await _CategoryService.DeleteAsync(request.CategoryId);

            if (!result)
                return BadRequest<string>("");

            return Deleted<string>("");
        }

    }
}
