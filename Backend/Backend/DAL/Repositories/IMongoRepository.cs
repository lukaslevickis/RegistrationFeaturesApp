using System.Collections.Generic;
using System.Threading.Tasks;

namespace Backend.DAL.Repositories
{
    public interface IMongoRepository<TDocument> where TDocument : IDocument
    {
        Task<List<TDocument>> GetAsync();
    }
}
