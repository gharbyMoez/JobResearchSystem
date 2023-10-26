using AutoMapper;
using JobResearchSystem.Application.Bases;
using JobResearchSystem.Application.Feature.Jobs.Queries.Models;
using JobResearchSystem.Application.Feature.Jobs.Queries.Response;
using JobResearchSystem.Application.IService;
using MediatR;

namespace JobResearchSystem.Application.Feature.Jobs.Queries.Handlers
{
    public class JobQueryHandler : ResponseHandler,
                                     IRequestHandler<GetAllJobsQuery, Response<IEnumerable<GetJobResponse>>>,
                                     IRequestHandler<GetJobByIdQuery, Response<GetJobResponse>>
    {
        #region CTOR
        private IJobService _jobService;
        private IMapper _mapper;

        public JobQueryHandler(IJobService jobService, IMapper mapper)
        {
            _jobService = jobService;
            _mapper = mapper;
        }
        #endregion

        public async Task<Response<IEnumerable<GetJobResponse>>> Handle(GetAllJobsQuery request, CancellationToken cancellationToken)
        {
            var entitiesList = await _jobService.GetAllJobsAsync();
            if (entitiesList == null)
            {
                return NotFound<IEnumerable<GetJobResponse>>();
            }
            else
            {
                var ListMapped = _mapper.Map<IEnumerable<GetJobResponse>>(entitiesList);
                var result = Success(ListMapped);
                result.Meta = new { count = ListMapped.Count() };
                return result;
            }

        }

        public async Task<Response<GetJobResponse>> Handle(GetJobByIdQuery request, CancellationToken cancellationToken)
        {
            var entity = await _jobService.GetJobByIdAsync(request.Id);

            if (entity == null)
            {
                return NotFound<GetJobResponse>("Sorry, There is no data to display!");
            }
            else
            {
                var entityMapped = _mapper.Map<GetJobResponse>(entity);


                return Success(entityMapped);
            }
        }


    }
}
