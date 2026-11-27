namespace GYM_project.Entity
{
    public class Plan:BaseEntity
    {
        public String Name { get; set; } = default!;
        public String Description { get; set; } = default!;
        public int DurationDays { get; set; } = default!;
        public Decimal Price { get; set; }
        public bool IsActive { get; set; }
        public ICollection<MemberShip> memberShips { get; set; } = new HashSet<MemberShip>();
    }
}
