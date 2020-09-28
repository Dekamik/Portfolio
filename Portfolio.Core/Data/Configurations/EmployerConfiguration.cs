using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using Portfolio.Core.Data.Baseline;
using Portfolio.Core.Entities;

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
