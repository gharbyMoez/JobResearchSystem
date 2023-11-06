using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Text.Json.Serialization;

namespace JobResearchSystem.Domain.Entities
{
    public class Category : BaseEntity
    {
        public string CategoryName { get; set; }
        //public int CategoryParentId { get; set; }
        public string? Description { get; set; }

        /*----- Relations -----*/

        //public ICollection<Category>? SubCategories { get; set; }//Self Relation

        //[JsonIgnore]
        public virtual ICollection<Job>? Jobs { get; set; } = new List<Job>();
    }
}
