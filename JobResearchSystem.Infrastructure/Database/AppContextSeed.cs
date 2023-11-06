using JobResearchSystem.Domain.Entities;
using JobResearchSystem.Domain.Entities.Extend;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.Json;
using System.Threading.Tasks;

namespace JobResearchSystem.Infrastructure.Database
{
    public class AppContextSeed
    {
        public static async Task SeedAsync(ApplicationContext dbContext)
        {

            #region Seeding Data
            if (!dbContext.UserTypes.Any())
            {
                var stringData = File.ReadAllText("../JobResearchSystem.Infrastructure/Database/DataSeed/UserType.json");
                var data = JsonSerializer.Deserialize<IEnumerable<UserType>>(stringData);

                if (data?.Count() > 0)
                {
                    foreach (var item in data)
                    {
                        await dbContext.UserTypes.AddAsync(item);
                    }
                    await dbContext.SaveChangesAsync();
                }
            }
           
            if (!dbContext.Users.Any())
            {
                var users = new List<ApplicationUser>()
                {
                    new ApplicationUser() {Id = "user1", Email="foo.example.com", UserTypeId = 1},
                    new ApplicationUser() {Id = "user2", Email="foo.example.com", UserTypeId = 2},
                    new ApplicationUser() {Id = "user3", Email="foo.example.com", UserTypeId = 3},
                    new ApplicationUser() {Id = "user4", Email="foo.example.com", UserTypeId = 1},
                    new ApplicationUser() {Id = "user5", Email="foo.example.com", UserTypeId = 2},
                    new ApplicationUser() {Id = "user6", Email="foo.example.com", UserTypeId = 2},
                    new ApplicationUser() {Id = "user7", Email="foo.example.com", UserTypeId = 2},
                    new ApplicationUser() {Id = "user8", Email="foo.example.com", UserTypeId = 2},
                    new ApplicationUser() {Id = "user9", Email="foo.example.com", UserTypeId = 2},
                };


                foreach (var user in users)
                {
                    await dbContext.Users.AddAsync(user);
                }
                await dbContext.SaveChangesAsync();
            }

            if (!dbContext.JobStatuses.Any())
            {
                var stringData = File.ReadAllText("../JobResearchSystem.Infrastructure/Database/DataSeed/JobStatus.json");
                var data = JsonSerializer.Deserialize<IEnumerable<JobStatus>>(stringData);

                if (data?.Count() > 0)
                {
                    foreach (var item in data)
                    {
                        await dbContext.JobStatuses.AddAsync(item);
                    }
                    await dbContext.SaveChangesAsync();
                }
            }

            if (!dbContext.Categories.Any())
            {
                var stringData = File.ReadAllText("../JobResearchSystem.Infrastructure/Database/DataSeed/Category.json");
                var data = JsonSerializer.Deserialize<IEnumerable<Category>>(stringData);

                if (data?.Count() > 0)
                {
                    foreach (var item in data)
                    {
                        await dbContext.Categories.AddAsync(item);
                    }
                    await dbContext.SaveChangesAsync();
                }
            }

            if (!dbContext.ApplicantStatuses.Any())
            {
                var stringData = File.ReadAllText("../JobResearchSystem.Infrastructure/Database/DataSeed/ApplicantStatus.json");
                var data = JsonSerializer.Deserialize<IEnumerable<ApplicantStatus>>(stringData);

                if (data?.Count() > 0)
                {
                    foreach (var item in data)
                    {
                        await dbContext.ApplicantStatuses.AddAsync(item);
                    }
                    await dbContext.SaveChangesAsync();
                }
            }

            if (!dbContext.Skills.Any())
            {
                var stringData = File.ReadAllText("../JobResearchSystem.Infrastructure/Database/DataSeed/Skill.json");
                var data = JsonSerializer.Deserialize<IEnumerable<Skill>>(stringData);

                if (data?.Count() > 0)
                {
                    foreach (var item in data)
                    {
                        await dbContext.Skills.AddAsync(item);
                    }
                    await dbContext.SaveChangesAsync();
                }
            }

            if (!dbContext.JobSeekers.Any())
            {
                var stringData = File.ReadAllText("../JobResearchSystem.Infrastructure/Database/DataSeed/JobSeeker.json");
                var data = JsonSerializer.Deserialize<IEnumerable<JobSeeker>>(stringData);

                if (data?.Count() > 0)
                {
                    foreach (var item in data)
                    {
                        await dbContext.JobSeekers.AddAsync(item);
                    }
                    await dbContext.SaveChangesAsync();
                }
            }

            if (!dbContext.Qualifications.Any())
            {
                var stringData = File.ReadAllText("../JobResearchSystem.Infrastructure/Database/DataSeed/Qualification.json");
                var data = JsonSerializer.Deserialize<IEnumerable<Qualification>>(stringData);

                if (data?.Count() > 0)
                {
                    foreach (var item in data)
                    {
                        await dbContext.Qualifications.AddAsync(item);
                    }
                    await dbContext.SaveChangesAsync();
                }
            }

            if (!dbContext.Companies.Any())
            {
                var stringData = File.ReadAllText("../JobResearchSystem.Infrastructure/Database/DataSeed/Company.json");
                var data = JsonSerializer.Deserialize<IEnumerable<Company>>(stringData);

                if (data?.Count() > 0)
                {
                    foreach (var item in data)
                    {
                        await dbContext.Companies.AddAsync(item);
                    }
                    await dbContext.SaveChangesAsync();
                }
            }

            if (!dbContext.Jobs.Any())
            {
                var stringData = File.ReadAllText("../JobResearchSystem.Infrastructure/Database/DataSeed/Job.json");
                var data = JsonSerializer.Deserialize<IEnumerable<Job>>(stringData);

                if (data?.Count() > 0)
                {
                    foreach (var item in data)
                    {
                        await dbContext.Jobs.AddAsync(item);
                    }
                    await dbContext.SaveChangesAsync();
                }
            }

            if (!dbContext.Experiences.Any())
            {
                var stringData = File.ReadAllText("../JobResearchSystem.Infrastructure/Database/DataSeed/Experience.json");
                var data = JsonSerializer.Deserialize<IEnumerable<Experience>>(stringData);

                if (data?.Count() > 0)
                {
                    foreach (var item in data)
                    {
                        await dbContext.Experiences.AddAsync(item);
                    }
                    await dbContext.SaveChangesAsync();
                }
            }

 
           
            if (!dbContext.Applicants.Any())
            {
                var stringData = File.ReadAllText("../JobResearchSystem.Infrastructure/Database/DataSeed/Applicant.json");
                var data = JsonSerializer.Deserialize<IEnumerable<Applicant>>(stringData);

                if (data?.Count() > 0)
                {
                    foreach (var item in data)
                    {
                        await dbContext.Applicants.AddAsync(item);
                    }
                    await dbContext.SaveChangesAsync();
                }
            }
            #endregion


        }

    }
}

