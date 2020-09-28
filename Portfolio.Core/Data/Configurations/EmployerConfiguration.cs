using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using Portfolio.Common.Core.Entities;
using Portfolio.Core.Data.Baseline;
using System;

namespace Portfolio.Core.Data.Configurations
{
    public class EmployerConfiguration : IEntityTypeConfiguration<Employer>
    {
        public void Configure(EntityTypeBuilder<Employer> builder)
        {
            builder.HasData(
                EmployerData.Adssets,
                EmployerData.CybercomGroup,
                EmployerData.SvrviveStudios,
                EmployerData.SopraSteria
            );
        }
    }
}
