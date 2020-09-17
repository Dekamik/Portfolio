using Portfolio.Common.Api.BaseEntities;
using Portfolio.Common.Enums;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;

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
        public ProjectCategory Category { get; set; }

        [Required]
        public DateTime StartDate { get; set; }

        public DateTime? EndDate { get; set; }

        [Required]
        public bool IsHighlighted { get; set; } = false;

        [Required]
        public bool Show { get; set; } = true;

        public string Customer { get; set; }

        public int? EmployerId { get; set; }

        public Employer Employer { get; set; }

        public virtual List<ProjectSkill> ProjectSkills { get; set; }
    }
}
