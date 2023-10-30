using JobResearchSystem.Domain.Entities;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace JobResearchSystem.Infrastructure.Database.Config
{
    internal class JobConfiguration : IEntityTypeConfiguration<Job>
    {
        public void Configure(EntityTypeBuilder<Job> builder)
        {
            builder.ToTable("Jobs");

            builder.Property(x => x.Title)
                .IsRequired()
                .HasMaxLength(100);

            builder.Property(x => x.Description)
                .IsRequired();

            builder.Property(x => x.Location)
                .IsRequired();

            builder.Property(x => x.RangeSalaryMin)
                .IsRequired(false)
                .HasColumnType("decimal(18,2)");

            builder.Property(x => x.RangeSalaryMax)
                .IsRequired(false)
                .HasColumnType("decimal(18,2)");

            builder.HasOne(x => x.Company)
                .WithMany(x => x.Jobs)
                .HasForeignKey(x => x.CompanyId)
                .OnDelete(DeleteBehavior.NoAction);

            builder.HasOne(x => x.Category)
                .WithMany(x => x.Jobs)
                .HasForeignKey(x => x.CategoryId)
                .OnDelete(DeleteBehavior.NoAction);

            builder.HasOne(x => x.JobStatus)
                .WithMany(x => x.Jobs)
                .HasForeignKey(x => x.JobStatusId)
                .OnDelete(DeleteBehavior.NoAction);
        }
    }


}
