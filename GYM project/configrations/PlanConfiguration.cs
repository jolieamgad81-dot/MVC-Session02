using GYM_project.Entity;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace GYM_project.configrations
{
    public class PlanConfiguration : IEntityTypeConfiguration<Plan>
    {
        public void Configure(EntityTypeBuilder<Plan> builder)
        {
            builder.Property(x => x.CreateAt).HasDefaultValueSql("getDate()");
            builder.ToTable(t =>
            {
                t.HasCheckConstraint("planDurationChek", "DurationInDays BETWEEN 1 AND 365");
            });
        }
    }
}
