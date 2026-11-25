namespace GYM_project.Entity
{
    public class Session :BaseEntity
    {
        public String Description { get; set; }
        public int Capacity { get; set; }
        public DateTime StartDate { get; set; }
        public DateTime EndDate { get; set; }
        public int TrainerId { get; set; }
        public Trainer Trainer { get; set; } = default!;
    }
}
