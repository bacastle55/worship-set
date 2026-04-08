using WorshipSet.Domain.Songs;

namespace WorshipSet.Application.Features.Songs
{
    public interface ISongRepository
    {
        Task<Song> GetById(int id);
        Task<List<Song>> GetAll();
        Task Add(Song song);
        Task Update(Song song);
        Task Delete(int id);
    }
}
