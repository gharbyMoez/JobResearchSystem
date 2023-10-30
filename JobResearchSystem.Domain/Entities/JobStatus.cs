using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace JobResearchSystem.Domain.Entities
{
    public class JobStatus : BaseEntity
    {
        
        public string JobStatusName { get; set; }

        /*----- Relations -----*/

        public ICollection<Job> Jobs { get; set; } = new List<Job>();
    }
}
