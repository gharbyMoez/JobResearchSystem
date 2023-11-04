using AutoMapper;
using JobResearchSystem.Application.Bases;
using JobResearchSystem.Application.Feature.Experiences.Queries.Models;
using JobResearchSystem.Application.Feature.Qualifications.Queries.Models;
using JobResearchSystem.Application.Feature.Qualifications.Queries.Response;
using JobResearchSystem.Application.Feature.Skills.Queries.Response;
using JobResearchSystem.Application.IService;
using JobResearchSystem.Application.Services;
using MediatR;

namespace JobResearchSystem.Application.Feature.Qualifications.Queries.Handlers
{
    public class QualificationQueryHandler : ResponseHandler,
                                     IRequestHandler<GetAllQualificationsQuery, Response<IEnumerable<GetQualificationResponse>>>,
                                     IRequestHandler<GetAllQualificationByJobseekerIdQuery, Response<IEnumerable<GetQualificationResponse>>>,
                                     IRequestHandler<GetQualificationByIdQuery, Response<GetQualificationResponse>>
    {
        #region CTOR
        private IMapper _mapper;
        private readonly IQualificationService _qualificationService;

        public QualificationQueryHandler(IQualificationService qualificationService, IMapper mapper)
        {
            this._qualificationService = qualificationService;
            _mapper = mapper;
        }
        #endregion

        public async Task<Response<IEnumerable<GetQualificationResponse>>> Handle(GetAllQualificationsQuery request, CancellationToken cancellationToken)
        {
            var entitiesList = await _qualificationService.GetAllAsync();
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
            var entity = await _qualificationService.GetByIdAsync(request.QualificationId);

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

        public async Task<Response<IEnumerable<GetQualificationResponse>>> Handle(GetAllQualificationByJobseekerIdQuery request, CancellationToken cancellationToken)
        {
            var entityList = await _qualificationService.GetAllQualificationByJobseekerIdAsync(request.JobseekerId);

            if (entityList == null)
                return NotFound<IEnumerable<GetQualificationResponse>>("Sorry, There is no data to display!");

            var entityListMapped = _mapper.Map<IEnumerable<GetQualificationResponse>>(entityList);

            return Success(entityListMapped);
        }
    }
}
