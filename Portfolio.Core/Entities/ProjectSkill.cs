using Portfolio.Common.Api.BaseEntities;

namespace Portfolio.Core.Entities
{
    public class ProjectSkill : BaseEntity
    {
        public int ProjectId { get; set; }

        public Project Project { get; set; }

        public int SkillId { get; set; }

        public Skill Skill { get; set; }

        public override void Copy(BaseEntity other)
        {
            throw new System.NotImplementedException();
        }
    }
}
