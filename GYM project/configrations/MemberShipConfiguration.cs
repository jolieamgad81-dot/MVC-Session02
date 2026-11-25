using GYM_project.Entity;
using Microsoft.EntityFrameworkCore;

namespace GYM_project.configrations
{
    public class MemberShipConfiguration : IEntityTypeConfiguration<MemberShip>
    {
        public void Configure(Microsoft.EntityFrameworkCore.Metadata.Builders.EntityTypeBuilder<MemberShip> builder)
        {
            builder.HasKey(n => n.Id);
            builder.Property(x => x.CreateAt).HasDefaultValueSql("getDate()");
            builder.HasOne(n=>n.Plan).WithMany(p=>p.memberShips).HasForeignKey(n=>n.PlanId).OnDelete(DeleteBehavior.Restrict);
        }
    }
}
