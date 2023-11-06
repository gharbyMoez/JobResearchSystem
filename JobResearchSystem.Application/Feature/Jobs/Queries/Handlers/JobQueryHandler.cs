using AutoMapper;
using JobResearchSystem.Application.Bases;
using JobResearchSystem.Application.Feature.Jobs.Queries.Models;
using JobResearchSystem.Application.Feature.Jobs.Queries.Response;
using JobResearchSystem.Application.IService;
using JobResearchSystem.Application.Wrappers;
using JobResearchSystem.Domain.Entities;
using MediatR;
using System.Linq.Expressions;

namespace JobResearchSystem.Application.Feature.Jobs.Queries.Handlers
{
    public class JobQueryHandler : ResponseHandler,
                                     IRequestHandler<GetAllJobsQuery, Response<IEnumerable<GetJobResponse>>>,
                                     IRequestHandler<GetJobPaginatedListQuery, PaginatedResult<GetPaginatedJobResponse>>,
                                     IRequestHandler<GetJobByIdQuery, Response<GetJobResponse>>,
                                     IRequestHandler<GetAllApplicantByJobIdQuery, Response<IEnumerable<GetApplicantsByJobIdResponse>>>

    {
        #region CTOR
        private IJobService _JobService;
        private IMapper _mapper;

        public JobQueryHandler(IJobService JobService, IMapper mapper)
        {
            _JobService = JobService;
            _mapper = mapper;
        }
        #endregion

        public async Task<Response<IEnumerable<GetJobResponse>>> Handle(GetAllJobsQuery request, CancellationToken cancellationToken)
        {
            var entitiesList = await _JobService.GetAllAsync(x => x.Company, x => x.Category);
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
            var entity = await _JobService.GetByIdAsync(request.JobId, x => x.Category, x => x.Company, x => x.Applicants);

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

        public async Task<Response<IEnumerable<GetApplicantsByJobIdResponse>>> Handle(GetAllApplicantByJobIdQuery request, CancellationToken cancellationToken)
        {
            var entitiesList = await _JobService.GetByIdWithJobApplicantAndJobSeekerAsync(request.JobId);

            if (entitiesList == null)
            {
                return NotFound<IEnumerable<GetApplicantsByJobIdResponse>>();
            }
            else
            {
                var ListMapped = _mapper.Map<IEnumerable<GetApplicantsByJobIdResponse>>(entitiesList);
                var result = Success(ListMapped);
                result.Meta = new { count = ListMapped.Count() };
                return result;
            }
        }

        public async Task<PaginatedResult<GetPaginatedJobResponse>> Handle(GetJobPaginatedListQuery request, CancellationToken cancellationToken)
        {

            Expression<Func<Job, GetPaginatedJobResponse>> expression = e => new GetPaginatedJobResponse()
            {
                Id = e.Id,
                Location = e.Location,
                Title = e.Title,
                Description = e.Description,
                ApplicantsNumber = e.ApplicantsNumber,
                PublishDateTime = e.PublishDateTime,
            };

            var queryableList = _JobService.GetAllPaginatedAsync();

            //var paginatedList = await queryableList.Select(expression).ToPaginatedListAsync(request.PageNumber, request.PageSize);

            var FilterQuery = _JobService.FilterJobPaginatedQueryable(request.Search);

            var paginatedList = await _mapper.ProjectTo<GetPaginatedJobResponse>(FilterQuery).ToPaginatedListAsync(request.PageNumber, request.PageSize);

            paginatedList.Meta = new { Count = paginatedList.Data.Count };

            return paginatedList;
        }
    }
}
