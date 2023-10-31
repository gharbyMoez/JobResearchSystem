﻿using JobResearchSystem.Application.Bases;
using JobResearchSystem.Application.Feature.JobSeekers.Queries.Response;
using MediatR;

namespace JobResearchSystem.Application.Feature.JobSeekers.Queries.Models
{
    public class GetAllJobSeekersQuery : IRequest<Response<IEnumerable<GetJobSeekerResponse>>>
    {
    }
}
