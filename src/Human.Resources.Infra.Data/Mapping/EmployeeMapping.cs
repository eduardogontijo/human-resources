using Human.Resources.Domain.Entities;
using Human.Resources.Infra.Data.Extensions;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace Human.Resources.Infra.Data.Mapping
{
    public class EmployeeMapping : EntityTypeConfiguration<Employee>
    {
        public override void Map(EntityTypeBuilder<Employee> builder)
        {
            builder.ToTable("Employees");

            builder.HasKey(c => c.Id);

            builder.Property(c => c.Name)
                .IsRequired()
                .HasColumnName("Name");

            builder.Property(c => c.LastName)
                .IsRequired()
                .HasColumnName("LastName");

            builder.Property(c => c.Email)
                .IsRequired()
                .HasColumnName("Email");

            builder.Property(c => c.BirthDate)
                .IsRequired()
                .HasColumnName("BirthDate");

            builder.HasOne(c => c.Gender)
                .WithOne(s => s.Employee)
                .HasForeignKey<Employee>(ad => ad.GenderId);

            builder.Ignore(e => e.ValidationResult);

            builder.Ignore(e => e.CascadeMode);
        }
    }
}
