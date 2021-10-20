using System.Collections.Generic;
using System.Threading.Tasks;
using Backend.DAL.Collections;
using MongoDB.Bson;
using MongoDB.Driver;

namespace Backend.DAL.Repositories
{
    public class MongoRepository : IMongoRepository
    {
        private readonly IMongoCollection<Registration> _collection;

        public MongoRepository(IMongoDbSettings settings)
        {
            var client = new MongoClient(settings.ConnectionString);
            var database = client.GetDatabase(settings.DatabaseName);

            _collection = database.GetCollection<Registration>(settings.CollectionName);
        }

        public async Task<List<Registration>> GetAsync()
        {
            return await _collection.Find(x => true).ToListAsync();
        }

        public async Task<Registration> GetByIdAsync(string id)
        {
            return await _collection.Find<Registration>(item => item.Id == id).FirstOrDefaultAsync();
        }

        public void Update(string id, Registration itemIn)
        {
            _collection.ReplaceOne(item => item.Id == id, itemIn);
        }
    }
}
