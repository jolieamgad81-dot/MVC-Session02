using GYM_project.Entity;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace GYM_project.configrations
{
    public class TrainerConfiguration:GymUserConfigrations<Trainer>,IEntityTypeConfiguration<Trainer>

    {
        
            public void Configure(EntityTypeBuilder<Trainer> builder)
            {
                builder.Property(x => x.CreateAt).HasColumnName("joinDate").HasDefaultValueSql("getDate()");
                base.Configure(builder);
            }
        }
    }

