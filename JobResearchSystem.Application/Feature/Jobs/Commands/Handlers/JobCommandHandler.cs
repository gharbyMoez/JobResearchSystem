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
        private IJobService _JobService;
        private IMapper _mapper;

        public JobCommandHandler(IJobService JobSerice, IMapper mapper)
        {
            _JobService = JobSerice;
            _mapper = mapper;
        }
        #endregion

        public async Task<Response<string>> Handle(AddJobCommand request, CancellationToken cancellationToken)
        {
            var experiene = _mapper.Map<Job>(request);
            var result = await _JobService.CreateAsync(experiene);

            if (result is null)
                return BadRequest<string>("Something Went Wrong");

            return Created(" Job Added Successfully");
        }

        public async Task<Response<GetJobResponse>> Handle(UpdateJobCommand request, CancellationToken cancellationToken)
        {
            var experiene = _mapper.Map<Job>(request);

            var result = await _JobService.UpdateAsync(experiene);

            var resultDto = _mapper.Map<GetJobResponse>(request);

            if (resultDto == null) { return BadRequest<GetJobResponse>(""); }
            else { return Success<GetJobResponse>(resultDto); }
        }




        public async Task<Response<string>> Handle(DeleteJobCommand request, CancellationToken cancellationToken)
        {
            var result = await _JobService.DeleteAsync(request.JobId);

            if (!result)
                return BadRequest<string>("");

            return Deleted<string>("");
        }

    }
}
