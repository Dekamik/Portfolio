using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;

namespace Portfolio.Core.Entities
{
    public class Project
    {
        [Key]
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public int ProjectId { get; set; }

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
