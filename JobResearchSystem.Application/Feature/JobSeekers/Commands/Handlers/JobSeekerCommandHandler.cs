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
            var jobSeeker = _mapper.Map<JobSeeker>(request);

            //upload image calling  
            if (request.ImageForm != null)
            {

                var myTuple = await Helper.HandelFiles.UploadFile(request.ImageForm);  // Add the New Image

                if (myTuple.Item1)
                {
                    jobSeeker.ImageFilePath = myTuple.Item2;
                }
                else
                    return BadRequest<string>(myTuple.Item2);
            }

            //upload Cv calling  
            if (request.CvForm != null)
            {

                var myTuple = await Helper.HandelFiles.UploadFile(request.CvForm);  // Add the New Cv

                if (myTuple.Item1)
                {
                    jobSeeker.CVFilePath = myTuple.Item2;
                }
                else
                    return BadRequest<string>(myTuple.Item2);
            }

            var result = await _jobSeekerService.CreateAsync(jobSeeker);

            if (result is null)
                return BadRequest<string>("Something Went Wrong");

            return Created(" JobSeeker Has Been Added Successfully");
        }

        public async Task<Response<GetJobSeekerResponse>> Handle(UpdateJobSeekerCommand request, CancellationToken cancellationToken)
        {

            if (request.Id <= 0)
            {
                return NotFound<GetJobSeekerResponse>("ID must be a positive integer.");
            }

            var existingJobSeeker = await _jobSeekerService.GetByIdAsync(request.Id);

            if (existingJobSeeker == null)
            {
                return NotFound<GetJobSeekerResponse>("This Id Doesn't Exist in DB");
            }

            var jobSeeker = _mapper.Map<JobSeeker>(request);

            if (request.ImageForm != null)//Update Image
            {
                if (existingJobSeeker.ImageFilePath != null)
                {
                    await Helper.HandelFiles.RemoveFile(existingJobSeeker.ImageFilePath, "image"); // remove old Image
                }

                var myTuple = await Helper.HandelFiles.UploadFile(request.ImageForm); // Add the New Image

                if (myTuple.Item1)
                {
                    jobSeeker.ImageFilePath = myTuple.Item2;
                }
                else
                    return BadRequest<GetJobSeekerResponse>(myTuple.Item2);
            }

            if (request.CvForm != null)//Update Cv
            {
                if (existingJobSeeker.CVFilePath != null)
                {
                    await Helper.HandelFiles.RemoveFile(existingJobSeeker.CVFilePath, "cv"); // remove old Image
                }

                var myTuple = await Helper.HandelFiles.UploadFile(request.CvForm); // Add the New Image

                if (myTuple.Item1)
                {
                    jobSeeker.CVFilePath = myTuple.Item2;
                }
                else
                    return BadRequest<GetJobSeekerResponse>(myTuple.Item2);
            }

            var result = await _jobSeekerService.UpdateAsync(jobSeeker);

            var resultDto = _mapper.Map<GetJobSeekerResponse>(request);

            if (resultDto == null) { return BadRequest<GetJobSeekerResponse>(""); }
            else { return Success<GetJobSeekerResponse>(resultDto); }
        }

        public async Task<Response<string>> Handle(DeleteJobSeekerCommand request, CancellationToken cancellationToken)
        {

            if (request.JobSeekerId <= 0)
            {
                return BadRequest<string>("ID must be a positive integer.");
            }

            var existingJobSeeker = await _jobSeekerService.GetByIdAsync(request.JobSeekerId);

            if (existingJobSeeker == null)
            {
                return NotFound<string>("This Id Doesn't Exist in DB");
            }

            if (existingJobSeeker.ImageFilePath != null)
            {
                await Helper.HandelFiles.RemoveFile(existingJobSeeker.ImageFilePath, "image"); // remove Image
            }

            if (existingJobSeeker.CVFilePath != null)
            {
                await Helper.HandelFiles.RemoveFile(existingJobSeeker.CVFilePath, "cv"); // remove Cv
            }

            var result = await _jobSeekerService.DeleteAsync(request.JobSeekerId);

            if (!result)
                return BadRequest<string>("");

            return Deleted<string>("");
        }

    }

}




