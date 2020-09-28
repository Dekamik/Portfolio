using Portfolio.Common.Enums;
using System;

namespace Portfolio.BusinessLogic.Projects
{
    public class ProjectModel
    {
        public string Name { get; set; }

        public string Role { get; set; }

        public string Description { get; set; }

        public ProjectCategory Category { get; set; }

        public DateTime StartDate { get; set; }

        public DateTime? EndDate { get; set; }

        public bool IsHighlighted { get; set; }

        public bool Show { get; set; }

        public string Customer { get; set; }

        public string Employer { get; set; }

        public string[] Skills { get; set; }
    }
}
