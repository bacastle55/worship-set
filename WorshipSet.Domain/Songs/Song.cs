namespace WorshipSet.Domain.Songs
{
    public class Song : BaseEntity
    {
        public Song() { }

        public required string Title { get; set; }
        public string? Composer { get; set; }
        public List<string> ImagePaths { get; set; } = [];
    }
}
