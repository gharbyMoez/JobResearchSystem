using AutoMapper;
using JobResearchSystem.Application.Bases;
using JobResearchSystem.Application.Feature.Applicants.Queries.Models;
using JobResearchSystem.Application.Feature.Applicants.Queries.Response;
using JobResearchSystem.Application.IService;
using MediatR;

namespace JobResearchSystem.Application.Feature.Applicants.Queries.Handlers
{
    public class ApplicantQueryHandler : ResponseHandler,
                                     IRequestHandler<GetAllApplicantsQuery, Response<IEnumerable<GetApplicantResponse>>>,
                                     IRequestHandler<GetApplicantByIdQuery, Response<GetApplicantResponse>>
    {
        #region CTOR
        private IApplicantService _applicantService;
        private IMapper _mapper;

        public ApplicantQueryHandler(IApplicantService applicantService, IMapper mapper)
        {
            _applicantService = applicantService;
            _mapper = mapper;
        }
        #endregion

        public async Task<Response<IEnumerable<GetApplicantResponse>>> Handle(GetAllApplicantsQuery request, CancellationToken cancellationToken)
        {
            var entitiesList = await _applicantService.GetAllAsync();
            if (entitiesList == null)
            {
                return NotFound<IEnumerable<GetApplicantResponse>>();
            }
            else
            {
                var ListMapped = _mapper.Map<IEnumerable<GetApplicantResponse>>(entitiesList);
                var result = Success(ListMapped);
                result.Meta = new { count = ListMapped.Count() };
                return result;
            }

        }

        public async Task<Response<GetApplicantResponse>> Handle(GetApplicantByIdQuery request, CancellationToken cancellationToken)
        {
            var entity = await _applicantService.GetByIdAsync(request.ApplicantId);

            if (entity == null)
            {
                return NotFound<GetApplicantResponse>("Sorry, There is no data to display!");
            }
            else
            {
                var entityMapped = _mapper.Map<GetApplicantResponse>(entity);


                return Success(entityMapped);
            }
        }


    }
}
