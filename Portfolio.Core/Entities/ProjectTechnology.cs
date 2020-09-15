using Portfolio.Core.Entities.Base;

namespace Portfolio.Core.Entities
{
    public class ProjectTechnology : BaseEntity
    {
        public int ProjectId { get; set; }

        public Project Project { get; set; }

        public int TechnologyId { get; set; }

        public Technology Technology { get; set; }
    }
}
