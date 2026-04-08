using System.Collections.Generic;
using System.Threading.Tasks;
using WorshipSet.Domain;
using WorshipSet.Domain.Readings;

namespace WorshipSet.Application.Features.Readings
{
    public interface IReadingRepository
    {
        Task<Reading> GetById(int id);
        Task<List<Reading>> GetAll();
        Task Add(Reading reading);
        Task Update(Reading reading);
        Task Delete(int id);
    }
}
