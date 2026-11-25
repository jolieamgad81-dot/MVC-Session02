using GYM_project.Entity.Enumis;

namespace GYM_project.Entity
{
    public class Trainer:GymUser
    {
        public DateTime HireDate { get; set; }
        public Specialties Specialties { get; set; }
        public ICollection<Session> sessions { get; set; } =new HashSet<Session>();
    }
}
