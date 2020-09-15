using Portfolio.Core.Entities.Base;
using System;
using System.ComponentModel.DataAnnotations;
using System.Linq;

namespace Portfolio.Core.Entities
{
    public class Employer : BaseEntity
    {
        [Required]
        public string Name { get; set; }

        [Required]
        public DateTime StartDate { get; set; }

        public DateTime EndDate { get; set; }

        public virtual IQueryable<Project> Projects { get; set; }
    }
}
