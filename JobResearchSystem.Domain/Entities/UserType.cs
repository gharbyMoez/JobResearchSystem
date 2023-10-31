using JobResearchSystem.Domain.Entities.Extend;

namespace JobResearchSystem.Domain.Entities
{
    public class UserType : BaseEntity
    {

        public string UserTypeName { get; set; }

        /*----- Relations -----*/

        public ICollection<ApplicationUser> Users { get; set; }
    }
}
