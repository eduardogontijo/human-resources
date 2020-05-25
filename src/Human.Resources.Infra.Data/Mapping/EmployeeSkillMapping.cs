using Human.Resources.Domain.Entities;
using Human.Resources.Infra.Data.Extensions;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace Human.Resources.Infra.Data.Mapping
{
    public class EmployeeSkillMapping : EntityTypeConfiguration<EmployeeSkill>
    {
        public override void Map(EntityTypeBuilder<EmployeeSkill> builder)
        {
            builder.ToTable("EmployeeSkills");

            builder.HasKey(t => new { t.EmployeeId, t.SkillId });

            builder.HasOne(pt => pt.Employee)
                .WithMany(p => p.EmployeeSkills)
                .HasForeignKey(pt => pt.EmployeeId);

            builder.HasOne(pt => pt.Skill)
                .WithMany(t => t.EmployeeSkills)
                .HasForeignKey(pt => pt.SkillId);
        }
    }
}
