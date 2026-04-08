using System.Collections.Generic;
using System.Threading.Tasks;
using WorshipSet.Domain;

namespace WorshipSet.Application
{
    public interface IRepository<T> where T : BaseEntity
    {
        Task<T> GetById(int id);
        Task<List<T>> GetAll();
        Task Add(T entity);
        Task Update(T entity);
        Task Delete(int id);
    }
}