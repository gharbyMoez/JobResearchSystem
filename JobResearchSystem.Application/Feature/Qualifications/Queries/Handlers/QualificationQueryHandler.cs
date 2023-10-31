using AutoMapper;
using JobResearchSystem.Application.Bases;
using JobResearchSystem.Application.Feature.Experiences.Queries.Models;
using JobResearchSystem.Application.Feature.Qualifications.Queries.Models;
using JobResearchSystem.Application.Feature.Qualifications.Queries.Response;
using JobResearchSystem.Application.IService;
using MediatR;

namespace JobResearchSystem.Application.Feature.Qualifications.Queries.Handlers
{
    public class QualificationQueryHandler : ResponseHandler,
                                     IRequestHandler<GetAllQualificationsQuery, Response<IEnumerable<GetQualificationResponse>>>,
                                     IRequestHandler<GetQualificationByIdQuery, Response<GetQualificationResponse>>
    {
        #region CTOR
        private IQualificationService _experienceService;
        private IMapper _mapper;

        public QualificationQueryHandler(IQualificationService experienceService, IMapper mapper)
        {
            _experienceService = experienceService;
            _mapper = mapper;
        }
        #endregion

        public async Task<Response<IEnumerable<GetQualificationResponse>>> Handle(GetAllQualificationsQuery request, CancellationToken cancellationToken)
        {
            var entitiesList = await _experienceService.GetAllAsync();
            if (entitiesList == null)
            {
                return NotFound<IEnumerable<GetQualificationResponse>>();
            }
            else
            {
                var ListMapped = _mapper.Map<IEnumerable<GetQualificationResponse>>(entitiesList);
                var result = Success(ListMapped);
                result.Meta = new { count = ListMapped.Count() };
                return result;
            }

        }

        public async Task<Response<GetQualificationResponse>> Handle(GetQualificationByIdQuery request, CancellationToken cancellationToken)
        {
            var entity = await _experienceService.GetByIdAsync(request.QualificationId);

            if (entity == null)
            {
                return NotFound<GetQualificationResponse>("Sorry, There is no data to display!");
            }
            else
            {
                var entityMapped = _mapper.Map<GetQualificationResponse>(entity);


                return Success(entityMapped);
            }
        }


    }
}
