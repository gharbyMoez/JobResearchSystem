using AutoMapper;
using JobResearchSystem.Application.Bases;
using JobResearchSystem.Application.Feature.Jobs.Commands.Models;
using JobResearchSystem.Application.Feature.Jobs.Queries.Response;
using JobResearchSystem.Application.IService;
using JobResearchSystem.Domain.Entities;
using MediatR;

namespace JobResearchSystem.Application.Feature.Jobs.Commands.Handlers
{
    public class JobCommandHandler : ResponseHandler,
                                       IRequestHandler<AddJobCommand, Response<string>>,
                                       IRequestHandler<DeleteJobCommand, Response<string>>,
                                       IRequestHandler<UpdateJobCommand, Response<GetJobResponse>>
    {
        #region CTOR
        private IJobService _jobService;
        private IMapper _mapper;

        public JobCommandHandler(IJobService jobService, IMapper mapper)
        {
            _jobService = jobService;
            _mapper = mapper;
        }
        #endregion

        public async Task<Response<string>> Handle(AddJobCommand request, CancellationToken cancellationToken)
        {
            var job = _mapper.Map<Job>(request);
            var result = await _jobService.AddJobAsync(job);
            if (result != "success")
            { return BadRequest<string>("Something Went Wrong"); }
            else { return Created(" Job Added Successfully"); }
        }

        public async Task<Response<GetJobResponse>> Handle(UpdateJobCommand request, CancellationToken cancellationToken)
        {
            var job = _mapper.Map<Job>(request);
            var result = await _jobService.UpdateJobAsync(job);
            var resultDto = _mapper.Map<GetJobResponse>(request);
            if (resultDto == null) { return BadRequest<GetJobResponse>(""); }
            else { return Success(resultDto); }
        }

        public async Task<Response<string>> Handle(DeleteJobCommand request, CancellationToken cancellationToken)
        {
            var result = await _jobService.DeleteJobAsync(request.Id);

            if (result != "success")
            {
                return BadRequest<string>("");
            }
            else { return Deleted<string>(result); }
        }

    }
}
