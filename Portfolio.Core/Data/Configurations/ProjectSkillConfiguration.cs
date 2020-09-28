using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using Portfolio.Common.Core.Entities;
using System;
using System.Collections.Generic;
using System.Text;

namespace Portfolio.Core.Data.Configurations
{
    public class ProjectSkillConfiguration : IEntityTypeConfiguration<ProjectSkill>
    {
        public void Configure(EntityTypeBuilder<ProjectSkill> builder)
        {
            throw new NotImplementedException();
        }
    }
}
