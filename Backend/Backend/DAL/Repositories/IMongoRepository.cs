using System.Collections.Generic;
using System.Threading.Tasks;
using Backend.DAL.Collections;

namespace Backend.DAL.Repositories
{
    public interface IMongoRepository
    {
        Task<List<Registration>> GetAsync();
        Task<Registration> GetByIdAsync(string id);
        void Update(string id, Registration document);
    }
}
