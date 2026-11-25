using GYM_project.Entity;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.ChangeTracking;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace GYM_project.configrations
{
    public class MemberConfigration:GymUserConfigrations<Member>,IEntityTypeConfiguration<Member>
    {
        public void Configure(EntityTypeBuilder<Member> builder)
        {
            builder.Property(x => x.CreateAt).HasColumnName("joinDate").HasDefaultValueSql("getDate()");
            base.Configure(builder);
        }
    }
}
