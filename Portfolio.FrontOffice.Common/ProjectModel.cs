﻿using System;

namespace Portfolio.Web.Common
{
    public class ProjectModel
    {
        public string Name { get; set; }

        public string Role { get; set; }

        public string Description { get; set; }

        public DateTime StartDate { get; set; }

        public DateTime EndDate { get; set; }

        public bool IsHighlighted { get; set; }

        public bool Show { get; set; }

        public string Customer { get; set; }

        public int EmployerId { get; set; }

        public string[] Technologies { get; set; }
    }
}
