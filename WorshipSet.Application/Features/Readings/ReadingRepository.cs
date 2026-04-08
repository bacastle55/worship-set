using WorshipSet.Domain.Readings;

namespace WorshipSet.Application.Features.Readings
{
    public class ReadingRepository : BaseRepository<Reading>, IReadingRepository
    {
        public ReadingRepository(WorshipSetContext context)
            : base(context) { }
    }
}
