using GYM_project.Entity;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace GYM_project.configrations
{
    public class GymUserConfigrations<T> : IEntityTypeConfiguration<T> where T : GymUser
    {
        public void Configure(EntityTypeBuilder<T> builder)
        {
            builder.Property(X=>X.Name).HasColumnType("varchar").HasMaxLength(50);
            builder.Property(X => X.Phone).HasColumnType("varchar").HasMaxLength(11);
            builder.ComplexProperty(X => X.Address);

            builder.HasIndex(X => X.Email).IsUnique();

            builder.HasIndex(X => X.Phone).IsUnique();

            builder.ToTable(t =>
            {
                t.HasCheckConstraint("GymUser_EmailChek", "Email Like '_%@_%._%");
                t.HasCheckConstraint("GymUser_PhoneChek", "Phone LIKE '01[0125][0-9][0-9][0-9][0-9][0-9][0-9][0-9][0-9]'");
            });

        }
    }
}
