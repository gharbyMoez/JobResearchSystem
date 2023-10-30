using JobResearchSystem.Domain.Entities.Extend;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace JobResearchSystem.Infrastructure.Database.Config
{
    internal class ApplicationUserConfiguration : IEntityTypeConfiguration<ApplicationUser>
    {
        public void Configure(EntityTypeBuilder<ApplicationUser> builder)
        {
            builder.HasOne(x => x.UserType)
                .WithMany(x => x.Users)
                .HasForeignKey(x => x.UserTypeId)
                .OnDelete(DeleteBehavior.NoAction);
        }
    }
}
