using System;
using System.Collections.Generic;
using System.Text;

namespace Portfolio.Core.Entities
{
    public class ProjectTechnology
    {
        public int ProjectId { get; set; }

        public Project Project { get; set; }

        public int TechnologyId { get; set; }

        public Technology Technology { get; set; }
    }
}
