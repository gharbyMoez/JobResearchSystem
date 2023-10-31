using AutoMapper;
using JobResearchSystem.Application.Bases;
using JobResearchSystem.Application.Feature.JobStatus.Queries.Models;
using JobResearchSystem.Application.Feature.JobStatus.Queries.Response;
using JobResearchSystem.Application.IService;
using MediatR;

namespace JobResearchSystem.Application.Feature.JobStatus.Queries.Handlers
{
    public class JobStatusQueryHandler : ResponseHandler,
                                     IRequestHandler<GetAllJobStatusesQuery, Response<IEnumerable<GetJobStatusResponse>>>,
                                     IRequestHandler<GetJobStatusByIdQuery, Response<GetJobStatusResponse>>
    {
        #region CTOR
        private IJobStatusService _JobStatusService;
        private IMapper _mapper;

        public JobStatusQueryHandler(IJobStatusService JobStatusService, IMapper mapper)
        {
            _JobStatusService = JobStatusService;
            _mapper = mapper;
        }
        #endregion

        public async Task<Response<IEnumerable<GetJobStatusResponse>>> Handle(GetAllJobStatusesQuery request, CancellationToken cancellationToken)
        {
            var entitiesList = await _JobStatusService.GetAllAsync();
            if (entitiesList == null)
            {
                return NotFound<IEnumerable<GetJobStatusResponse>>();
            }
            else
            {
                var ListMapped = _mapper.Map<IEnumerable<GetJobStatusResponse>>(entitiesList);
                var result = Success(ListMapped);
                result.Meta = new { count = ListMapped.Count() };
                return result;
            }

        }

        public async Task<Response<GetJobStatusResponse>> Handle(GetJobStatusByIdQuery request, CancellationToken cancellationToken)
        {
            var entity = await _JobStatusService.GetByIdAsync(request.SkillId);

            if (entity == null)
            {
                return NotFound<GetJobStatusResponse>("Sorry, There is no data to display!");
            }
            else
            {
                var entityMapped = _mapper.Map<GetJobStatusResponse>(entity);


                return Success(entityMapped);
            }
        }


    }
}
