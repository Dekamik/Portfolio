using Portfolio.Common.Api.BaseEntities;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;

namespace Portfolio.Core.Entities
{
    public class Skill : BaseEntity
    {
        [Required]
        public string Name { get; set; }

        public virtual List<ProjectSkill> ProjectTechnologies { get; set; }

        public override void Copy(BaseEntity other)
        {
            Skill otherSkill = other as Skill;
            Name = otherSkill.Name;
        }
    }
}
