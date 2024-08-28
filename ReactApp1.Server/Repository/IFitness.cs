using WebApi_Respository_Pattren.Models;

namespace WebApi_Respository_Pattren.Repository
{
    public interface IFitness
    {
        public  Task<List<MFitness>> GetAsync();



        public  Task<MFitness?> GetAsync(string id);



        public  Task CreateAsync(MFitness newBook);


        public  Task UpdateAsync(string id, MFitness updatedBook);


        public  Task RemoveAsync(string id);
           
    }
}
