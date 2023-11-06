using AutoMapper;
using JobResearchSystem.Application.Bases;
using JobResearchSystem.Application.Feature.ApplicantStatus.Queries.Models;
using JobResearchSystem.Application.Feature.ApplicantStatus.Queries.Response;
using JobResearchSystem.Application.IService;
using MediatR;

namespace JobResearchSystem.Application.Feature.ApplicantStatus.Queries.Handlers
{
    public class ApplicantStatusQueryHandler : ResponseHandler,
                                     IRequestHandler<GetAllApplicantStatusesQuery, Response<IEnumerable<GetApplicantStatusResponse>>>,
                                     IRequestHandler<GetApplicantStatusByIdQuery, Response<GetApplicantStatusResponse>>
    {
        #region CTOR
        private IApplicantStatusService _ApplicantStatusService;
        private IMapper _mapper;

        public ApplicantStatusQueryHandler(IApplicantStatusService ApplicantStatusService, IMapper mapper)
        {
            _ApplicantStatusService = ApplicantStatusService;
            _mapper = mapper;
        }
        #endregion

        public async Task<Response<IEnumerable<GetApplicantStatusResponse>>> Handle(GetAllApplicantStatusesQuery request, CancellationToken cancellationToken)
        {
            var entitiesList = await _ApplicantStatusService.GetAllAsync();
            if (entitiesList == null)
            {
                return NotFound<IEnumerable<GetApplicantStatusResponse>>();
            }
            else
            {
                var ListMapped = _mapper.Map<IEnumerable<GetApplicantStatusResponse>>(entitiesList);
                var result = Success(ListMapped);
                result.Meta = new { count = ListMapped.Count() };
                return result;
            }

        }

        public async Task<Response<GetApplicantStatusResponse>> Handle(GetApplicantStatusByIdQuery request, CancellationToken cancellationToken)
        {
            var entity = await _ApplicantStatusService.GetByIdAsync(request.SkillId);

            if (entity == null)
            {
                return NotFound<GetApplicantStatusResponse>("Sorry, There is no data to display!");
            }
            else
            {
                var entityMapped = _mapper.Map<GetApplicantStatusResponse>(entity);


                return Success(entityMapped);
            }
        }


    }
}
