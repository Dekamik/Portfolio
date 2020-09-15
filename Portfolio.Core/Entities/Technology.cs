using Portfolio.Core.Base;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;

namespace Portfolio.Core.Entities
{
    public class Technology : BaseEntity
    {
        [Required]
        public string Name { get; set; }

        public virtual IQueryable<ProjectTechnology> ProjectTechnologies { get; set; }
    }
}
