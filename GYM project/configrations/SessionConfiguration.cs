using GYM_project.Entity;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace GYM_project.configrations
{
    public class SessionConfiguration : IEntityTypeConfiguration<Session>
    {
        public void Configure(EntityTypeBuilder<Session> builder)
        {
            builder.Property(x => x.CreateAt).HasDefaultValueSql("getDate()");
            builder.HasOne(X=>X.Trainer).WithMany(t=>t.sessions).OnDelete(DeleteBehavior.Restrict);

            builder.ToTable(t =>
            {
                t.HasCheckConstraint("sessioncapacityconstrain", "Capacity BETWEEN 1 AND 25");
                t.HasCheckConstraint("sessionEndDateAfterStartDate", "EndDate>StartDate");

            });

        }
    }
}
