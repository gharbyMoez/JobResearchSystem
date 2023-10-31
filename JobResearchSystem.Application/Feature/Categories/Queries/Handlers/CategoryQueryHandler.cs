using AutoMapper;
using JobResearchSystem.Application.Bases;
using JobResearchSystem.Application.Feature.Categories.Queries.Models;
using JobResearchSystem.Application.Feature.Categories.Queries.Response;
using JobResearchSystem.Application.IService;
using MediatR;

namespace JobResearchSystem.Application.Feature.Categories.Queries.Handlers
{
    public class CategoryQueryHandler : ResponseHandler,
                                     IRequestHandler<GetAllCategoriesQuery, Response<IEnumerable<GetCategoryResponse>>>,
                                     IRequestHandler<GetCategoryByIdQuery, Response<GetCategoryResponse>>
    {
        #region CTOR
        private ICategoryService _CategoryService;
        private IMapper _mapper;

        public CategoryQueryHandler(ICategoryService CategoryService, IMapper mapper)
        {
            _CategoryService = CategoryService;
            _mapper = mapper;
        }
        #endregion

        public async Task<Response<IEnumerable<GetCategoryResponse>>> Handle(GetAllCategoriesQuery request, CancellationToken cancellationToken)
        {
            var entitiesList = await _CategoryService.GetAllAsync();
            if (entitiesList == null)
            {
                return NotFound<IEnumerable<GetCategoryResponse>>();
            }
            else
            {
                var ListMapped = _mapper.Map<IEnumerable<GetCategoryResponse>>(entitiesList);
                var result = Success(ListMapped);
                result.Meta = new { count = ListMapped.Count() };
                return result;
            }

        }

        public async Task<Response<GetCategoryResponse>> Handle(GetCategoryByIdQuery request, CancellationToken cancellationToken)
        {
            var entity = await _CategoryService.GetByIdAsync(request.CategoryId);

            if (entity == null)
            {
                return NotFound<GetCategoryResponse>("Sorry, There is no data to display!");
            }
            else
            {
                var entityMapped = _mapper.Map<GetCategoryResponse>(entity);


                return Success(entityMapped);
            }
        }


    }
}
