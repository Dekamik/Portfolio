﻿using Portfolio.Common.Api.BaseEntities;
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

        public virtual List<Project> Projects { get; set; }
    }
}
