using AutoMapper;
using JobResearchSystem.Application.Bases;
using JobResearchSystem.Application.Feature.Companies.Queries.Models;
using JobResearchSystem.Application.Feature.Companies.Queries.Responses;
using JobResearchSystem.Application.IService;
using MediatR;

namespace JobResearchSystem.Application.Feature.Companies.Queries.Handlers
{
    public class CompanyQueryHandler : ResponseHandler,
                                     IRequestHandler<GetAllCompaniesQuery, Response<IEnumerable<GetCompanyResponse>>>,
                                     IRequestHandler<GetCompanyByIdQuery, Response<GetCompanyResponse>>
    {
        #region CTOR
        private readonly ICompanyService _companyService;
        private IMapper _mapper;

        public CompanyQueryHandler(ICompanyService companyService, IMapper mapper)
        {
            this._companyService = companyService;
            _mapper = mapper;
        }
        #endregion

        
        public async Task<Response<IEnumerable<GetCompanyResponse>>> Handle(GetAllCompaniesQuery request, CancellationToken cancellationToken)
        {
            var entitiesList = await _companyService.GetAllAsync();
            if (entitiesList == null)
            {
                return NotFound<IEnumerable<GetCompanyResponse>>();
            }
            else
            {
                var ListMapped = _mapper.Map<IEnumerable<GetCompanyResponse>>(entitiesList);
                var result = Success(ListMapped);
                result.Meta = new { count = ListMapped.Count() };
                return result;
            }
        }

        public async Task<Response<GetCompanyResponse>> Handle(GetCompanyByIdQuery request, CancellationToken cancellationToken)
        {
            var entity = await _companyService.GetCompanyByUserIdAsync(request.UserId);

            if (entity == null)
            {
                return NotFound<GetCompanyResponse>("Sorry, There is no data to display!");
            }
            else
            {
                var entityMapped = _mapper.Map<GetCompanyResponse>(entity);

                return Success(entityMapped);
            }
        }
    }
}
