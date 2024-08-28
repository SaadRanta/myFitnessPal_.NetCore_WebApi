using Microsoft.Extensions.Options;
using MongoDB.Driver;

namespace WebApi_Respository_Pattren.Models
{
    public class FitnessDBSettings
    {



  public string ConnectionString { get; set; } = null!;

    public string DatabaseName { get; set; } = null!;

    public string BooksCollectionName { get; set; } = null!;

    }
}
