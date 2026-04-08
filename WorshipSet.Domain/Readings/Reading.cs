namespace WorshipSet.Domain.Readings
{
    public class Reading : BaseEntity
    {
        public required string Title { get; set; }
        public string? Content { get; set; }
    }
}
