using Portfolio.Common.Api.BaseEntities;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;

namespace Portfolio.Core.Entities
{
    public class Employer : BaseEntity
    {
        [Required]
        public string Name { get; set; }

        [Required]
        public DateTime StartDate { get; set; }

        public DateTime? EndDate { get; set; }

        [Required]
        public string EmployerDescription { get; set; }

        [Required]
        public string RoleDescription { get; set; }

        public virtual List<Project> Projects { get; set; }

        public override void Copy(BaseEntity other)
        {
            var otherEmployer = other as Employer;
            Name = otherEmployer.Name;
            StartDate = otherEmployer.StartDate;
            EndDate = otherEmployer.EndDate;
            EmployerDescription = otherEmployer.EmployerDescription;
            RoleDescription = otherEmployer.EmployerDescription;
        }
    }
}
