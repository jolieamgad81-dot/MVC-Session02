namespace GYM_project.Entity
{
    public class MemberShip:BaseEntity
    {
        public DateTime StartDate { get; set; }
        public DateTime EndDate { get; set; }
        public int MemberId { get; set; }
        public Member Member { get; set; } = default!;
        public int PlanId { get; set; }
        public Plan Plan  { get; set; } = default!;
        public String Status => StartDate > DateTime.Now ? "upComing" : EndDate> DateTime.Now ? "Active" : "Expired";


    }
}
