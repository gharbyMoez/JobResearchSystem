

using JobResearchSystem.Domain.Entities;
using JobResearchSystem.Domain.Entities.Extend;
using Microsoft.AspNetCore.Identity.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore;
using System.Reflection;

namespace JobResearchSystem.Infrastructure.Database
{
    public class ApplicationContext : IdentityDbContext<ApplicationUser>
    {

        #region DbSets

        public DbSet<Applicant> Applicants { get; set; } = null!;
        public DbSet<ApplicantStatus> ApplicantStatuses { get; set; } = null!;
        public DbSet<Category> Categories { get; set; } = null!;
        public DbSet<Company> Companies { get; set; } = null!;
        public DbSet<Experience> Experiences { get; set; } = null!;
        public DbSet<Job> Jobs { get; set; } = null!;
        public DbSet<JobSeeker> JobSeekers { get; set; } = null!;
        public DbSet<JobStatus> JobStatuses { get; set; } = null!;
        public DbSet<Qualification> Qualifications { get; set; } = null!;
        public DbSet<Skill> Skills { get; set; } = null!;
        public DbSet<UserType> UserTypes { get; set; } = null!;

        #endregion

        public ApplicationContext() { }
        public ApplicationContext(DbContextOptions options) : base(options) { }

        override protected void OnModelCreating(ModelBuilder builder)
        {
            base.OnModelCreating(builder);
            //builder.Entity<Skill>().HasQueryFilter(s => !s.IsDeleted);

            builder.ApplyConfigurationsFromAssembly(Assembly.GetExecutingAssembly());

            #region commented
            //#region Data Seeding

            ////JobStatus
            //builder.Entity<JobStatus>(builder =>
            //{
            //    builder.HasData(new JobStatus { Id = 1, JobStatusName = "Pending" });
            //    builder.HasData(new JobStatus { Id = 2, JobStatusName = "Published" });
            //    builder.HasData(new JobStatus { Id = 3, JobStatusName = "Rejected" });
            //});

            ////ApplicantStatus
            //builder.Entity<ApplicantStatus>(builder =>
            //{
            //    builder.HasData(new ApplicantStatus { Id = 1, ApplicantStatusName = "Open" });
            //    builder.HasData(new ApplicantStatus { Id = 2, ApplicantStatusName = "Accepted" });
            //    builder.HasData(new ApplicantStatus { Id = 3, ApplicantStatusName = "Rejected" });
            //});

            ////UserType
            //builder.Entity<UserType>(builder =>
            //{
            //    builder.HasData(new UserType { Id = 1, UserTypeName = "JobSeeker" });
            //    builder.HasData(new UserType { Id = 2, UserTypeName = "Company" });
            //    builder.HasData(new UserType { Id = 3, UserTypeName = "SystemAdministrators" });
            //});

            //#endregion

            //#region Applicant Table 
            //builder.Entity<Applicant>(builder =>
            //{
            //    builder
            //    .HasKey(r => new { r.JobSeekerId, r.JobId });

            //    builder
            //   .HasIndex(r => new { r.JobSeekerId, r.JobId })
            //   .IsUnique();

            //    builder
            //    .HasOne(r => r.JobSeeker)
            //    .WithMany(u => u.Applicants)
            //    .HasForeignKey(r => r.JobSeekerId);

            //    builder
            //    .HasOne(r => r.Job)
            //    .WithMany(u => u.Applicants)
            //    .HasForeignKey(r => r.JobId)
            //    .OnDelete(DeleteBehavior.NoAction);

            //    builder
            //    .HasOne(r => r.ApplicantStatus)
            //    .WithMany(u => u.Applicants)
            //    .HasForeignKey(r => r.ApplicantStatusId);
            //});
            //#endregion

            //#region ApplicationUser Table 
            //builder.Entity<ApplicationUser>(builder =>
            //{

            //    builder
            //    .HasOne(r => r.UserType)
            //    .WithMany(u => u.Users)
            //    .HasForeignKey(r => r.UserTypeId).OnDelete(DeleteBehavior.NoAction);
            //});
            //#endregion
            #endregion



        }

    }
}
