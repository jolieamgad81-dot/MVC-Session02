namespace GYM_project.Entity
{
    public abstract class BaseEntity
    {
        public int Id { get; set; }
        public  DateTime CreateAt { get; set; }
        public DateTime UpdateAt { get; set; }
        public String CreatedBy { get; set; }
    }
}
