using Portfolio.Core.Entities.Base;
using System;
using System.ComponentModel.DataAnnotations;
using System.Linq;

namespace Portfolio.Core.Entities
{
    public class Project : BaseEntity
    {
        [Required]
        public string Name { get; set; }

        [Required]
        public string Role { get; set; }

        [Required]
        public string Description { get; set; }

        [Required]
        public DateTime StartDate { get; set; }

        [Required]
        public DateTime EndDate { get; set; }

        [Required]
        public bool IsHighlighted { get; set; } = false;

        [Required]
        public bool Show { get; set; } = true;

        public string Customer { get; set; }

        public int EmployerId { get; set; }

        public Employer Employer { get; set; }

        public virtual IQueryable<ProjectTechnology> ProjectTechnologies { get; set; }
    }
}
