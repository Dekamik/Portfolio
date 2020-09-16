using Portfolio.Common.Api.BaseEntities;
using System.ComponentModel.DataAnnotations;
using System.Linq;

namespace Portfolio.Core.Entities
{
    public class Technology : BaseEntity
    {
        [Required]
        public string Name { get; set; }

        public virtual IQueryable<ProjectTechnology> ProjectTechnologies { get; set; }
    }
}
