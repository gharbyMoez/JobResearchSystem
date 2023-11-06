using AutoMapper;
using JobResearchSystem.Application.Bases;
using JobResearchSystem.Application.Feature.JobSeekers.Queries.Models;
using JobResearchSystem.Application.Feature.JobSeekers.Queries.Response;
using JobResearchSystem.Application.IService;
using MediatR;

namespace JobResearchSystem.Application.Feature.JobSeekers.Queries.Handlers
{
    public class JobSeekerQueryHandler : ResponseHandler,
                                         IRequestHandler<GetAllJobSeekersQuery, Response<IEnumerable<GetJobSeekerResponse>>>,
                                         IRequestHandler<GetJobSeekerByIdQuery, Response<GetJobSeekerDetailsResponse>>
    {
        #region CTOR
        private IJobSeekerService _jobSeekerService;
        private IMapper _mapper;

        public JobSeekerQueryHandler(IJobSeekerService jobSeekerService, IMapper mapper)
        {
            _jobSeekerService = jobSeekerService;
            _mapper = mapper;
        }
        #endregion

        public async Task<Response<IEnumerable<GetJobSeekerResponse>>> Handle(GetAllJobSeekersQuery request, CancellationToken cancellationToken)
        {
            var entitiesList = await _jobSeekerService.GetAllAsync();
            if (entitiesList == null)
            {
                return NotFound<IEnumerable<GetJobSeekerResponse>>();
            }
            else
            {
                var ListMapped = _mapper.Map<IEnumerable<GetJobSeekerResponse>>(entitiesList);
                var result = Success(ListMapped);
                result.Meta = new { count = ListMapped.Count() };
                return result;
            }

        }

        public async Task<Response<GetJobSeekerDetailsResponse>> Handle(GetJobSeekerByIdQuery request, CancellationToken cancellationToken)
        {
            var entity = await _jobSeekerService.GetJobSeekerByUserIdAsync(request.UserId);

            if (entity == null)
            {
                return NotFound<GetJobSeekerDetailsResponse>("Sorry, There is no data to display!");
            }
            else
            {
                var entityMapped = _mapper.Map<GetJobSeekerDetailsResponse>(entity);


                return Success(entityMapped);
            }
        }


    }
}
