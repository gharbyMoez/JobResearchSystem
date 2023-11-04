using JobResearchSystem.Domain.Entities;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace JobResearchSystem.Infrastructure.Database.Config
{
    internal class QualificationConfiguration : IEntityTypeConfiguration<Qualification>
    {
        public void Configure(EntityTypeBuilder<Qualification> builder)
        {
            builder.ToTable("Qualifications");

            builder.Property(x => x.SchoolName)
                .IsRequired()
                .HasMaxLength(100);
            
            builder.Property(x =>x.Degree)
                .IsRequired(false);
            
            builder.Property(x =>x.FieldOfStudy)
                .IsRequired(false);
            
            builder.Property(x =>x.Duration)
                .IsRequired(false)
                .HasColumnType("decimal(18,2)");

            builder.Property(x =>x.Grade)
                .IsRequired(false)
                .HasColumnType("decimal(18,2)");

            builder.Property(x => x.QualificationDescription)
                .IsRequired();

            builder.HasOne(x => x.JobSeeker)
                .WithMany(x => x.Qualifications)
                .HasForeignKey(x => x.JobSeekerId)
                .OnDelete(DeleteBehavior.Cascade);

            builder.HasQueryFilter(x => x.IsDeleted == false);

        }
    }


}
