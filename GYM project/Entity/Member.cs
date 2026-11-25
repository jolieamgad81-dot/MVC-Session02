namespace GYM_project.Entity
{
    public class Member:GymUser
    {
        public string? photo {  get; set; }
        public ICollection<MemberShip> memberShips { get; set; } = new HashSet<MemberShip>();
    }
}
