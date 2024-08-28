using Microsoft.AspNetCore.Http.HttpResults;
using Microsoft.Extensions.Options;
using MongoDB.Driver;
using WebApi_Respository_Pattren.Models;

namespace WebApi_Respository_Pattren.Repository
{
    public class Fitness_Repository : IFitness
    {
        private readonly IMongoCollection<MFitness> _booksCollection;
        public Fitness_Repository(
        IOptions<FitnessDBSettings> FitnessDBSettings)
        {
            var mongoClient = new MongoClient(
                FitnessDBSettings.Value.ConnectionString);

            var mongoDatabase = mongoClient.GetDatabase(
                FitnessDBSettings.Value.DatabaseName);

            _booksCollection = mongoDatabase.GetCollection<MFitness>(
                FitnessDBSettings.Value.BooksCollectionName);
        }
        public async Task<List<MFitness>> GetAsync() =>
       await _booksCollection.Find(_ => true).Limit(200).ToListAsync();

        public async Task<MFitness?> GetAsync(string id) =>
            await _booksCollection.Find(x => x.Id == id).FirstOrDefaultAsync();

        public async Task CreateAsync(MFitness newBook) =>
            await _booksCollection.InsertOneAsync(newBook);

        public async Task UpdateAsync(string id, MFitness updatedBook) =>
            await _booksCollection.ReplaceOneAsync(x => x.Id == id, updatedBook);

        public async Task RemoveAsync(string id) =>
            await _booksCollection.DeleteOneAsync(x => x.Id == id);
  
    }
}
