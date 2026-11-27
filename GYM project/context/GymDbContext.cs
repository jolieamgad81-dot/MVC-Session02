using GYM_project.Entity;
using Microsoft.EntityFrameworkCore;
using System.Reflection;

namespace GYM_project.context
{
    public class GymDbContext:DbContext
    {
        public GymDbContext(DbContextOptions options):base(options) 
        {

        }
        //protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        //{
        //    optionsBuilder.UseSqlServer("Server=.;Database=gymdbg01;Trusted_Connection=true;TrustServerCertificate=true");
        //}
        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.ApplyConfigurationsFromAssembly(Assembly.GetExecutingAssembly());
        }
       
        public DbSet<Trainer> Trainers { get; set; }
        public DbSet<Member> Members { get; set; }
        public DbSet<MemberShip> Memberships { get; set; }
        public DbSet<Plan> Plans { get; set; }
        public DbSet<Session> Sessions { get; set; }
       
    }
}
