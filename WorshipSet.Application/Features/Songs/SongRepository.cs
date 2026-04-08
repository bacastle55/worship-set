using WorshipSet.Domain.Songs;

namespace WorshipSet.Application.Features.Songs
{
    public class SongRepository : BaseRepository<Song>, ISongRepository
    {
        public SongRepository(WorshipSetContext context)
            : base(context) { }
    }
}
