namespace WorshipSet.Domain
{
    public class BaseEntity : IBaseEntity
    {
        public int Id { get; set; }
        public DateTimeOffset CreatedOn { get; set; }
    }
}
