using AutoMapper;
using JobResearchSystem.Application.Bases;
using JobResearchSystem.Application.Feature.UserTypes.Queries.Models;
using JobResearchSystem.Application.Feature.UserTypes.Queries.Response;
using JobResearchSystem.Application.IService;
using MediatR;

namespace JobResearchSystem.Application.Feature.UserTypes.Queries.Handlers
{
    public class UserTypeQueryHandler : ResponseHandler,
                                     IRequestHandler<GetAllUserTypesQuery, Response<IEnumerable<GetUserTypeResponse>>>,
                                     IRequestHandler<GetUserTypeByIdQuery, Response<GetUserTypeResponse>>
    {
        #region CTOR
        private IUserTypeService _UserTypeService;
        private IMapper _mapper;

        public UserTypeQueryHandler(IUserTypeService UserTypeService, IMapper mapper)
        {
            _UserTypeService = UserTypeService;
            _mapper = mapper;
        }
        #endregion

        public async Task<Response<IEnumerable<GetUserTypeResponse>>> Handle(GetAllUserTypesQuery request, CancellationToken cancellationToken)
        {
            var entitiesList = await _UserTypeService.GetAllAsync();
            if (entitiesList == null)
            {
                return NotFound<IEnumerable<GetUserTypeResponse>>();
            }
            else
            {
                var ListMapped = _mapper.Map<IEnumerable<GetUserTypeResponse>>(entitiesList);
                var result = Success(ListMapped);
                result.Meta = new { count = ListMapped.Count() };
                return result;
            }

        }

        public async Task<Response<GetUserTypeResponse>> Handle(GetUserTypeByIdQuery request, CancellationToken cancellationToken)
        {
            var entity = await _UserTypeService.GetByIdAsync(request.UserTypeId);

            if (entity == null)
            {
                return NotFound<GetUserTypeResponse>("Sorry, There is no data to display!");
            }
            else
            {
                var entityMapped = _mapper.Map<GetUserTypeResponse>(entity);


                return Success(entityMapped);
            }
        }


    }
}
