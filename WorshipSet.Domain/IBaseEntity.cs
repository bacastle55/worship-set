namespace WorshipSet.Domain
{
    public interface IBaseEntity
    {
        public int Id { get; set; }
        public DateTimeOffset CreatedOn { get; set; }
    }
}
