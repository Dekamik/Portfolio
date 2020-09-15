using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;

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
