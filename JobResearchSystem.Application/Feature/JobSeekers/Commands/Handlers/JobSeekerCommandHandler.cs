using AutoMapper;
using JobResearchSystem.Application.Bases;
using JobResearchSystem.Application.Feature.JobSeekers.Commands.Models;
using JobResearchSystem.Application.Feature.JobSeekers.Queries.Response;
using JobResearchSystem.Application.IService;
using JobResearchSystem.Domain.Entities;
using MediatR;

namespace JobResearchSystem.Application.Feature.JobSeekers.Commands.Handlers
{
    public class JobSeekerCommandHandler : ResponseHandler,
                                           IRequestHandler<AddJobSeekerCommand, Response<string>>,
                                           IRequestHandler<DeleteJobSeekerCommand, Response<string>>,
                                           IRequestHandler<UpdateJobSeekerCommand, Response<GetJobSeekerResponse>>
    {
        #region CTOR
        private IJobSeekerService _jobSeekerService;
        private IMapper _mapper;

        public JobSeekerCommandHandler(IJobSeekerService jobSeekerService, IMapper mapper)
        {
            _jobSeekerService = jobSeekerService;
            _mapper = mapper;
        }
        #endregion

        public async Task<Response<string>> Handle(AddJobSeekerCommand request, CancellationToken cancellationToken)
        {
            var movie = _mapper.Map<JobSeeker>(request);
            var result = await _jobSeekerService.CreateAsync(movie);

            if (result is null)
                return BadRequest<string>("Something Went Wrong");

            return Created(" JobSeeker Has Been Added Successfully");
        }

        public async Task<Response<GetJobSeekerResponse>> Handle(UpdateJobSeekerCommand request, CancellationToken cancellationToken)
        {
            var jobSeeker = _mapper.Map<JobSeeker>(request);

            var result = await _jobSeekerService.UpdateAsync(jobSeeker);

            var resultDto = _mapper.Map<GetJobSeekerResponse>(request);

            if (resultDto == null) { return BadRequest<GetJobSeekerResponse>(""); }
            else { return Success<GetJobSeekerResponse>(resultDto); }
        }

        public async Task<Response<string>> Handle(DeleteJobSeekerCommand request, CancellationToken cancellationToken)
        {
            var result = await _jobSeekerService.DeleteAsync(request.JobSeekerId);

            if (!result)
                return BadRequest<string>("");

            return Deleted<string>("");
        }

    }

}




