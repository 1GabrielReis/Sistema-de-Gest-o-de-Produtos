using back_end.Model.DataBase;
using Microsoft.Extensions.Configuration;
using MongoDB.Bson;
using MongoDB.Driver;

namespace back_end.Model.DB
{
    public class Db
    {
        private static IMongoDatabase? database = null;
        private static MongoClient? client = null;

        private static readonly IConfiguration configuration = new ConfigurationBuilder() 
            .SetBasePath(AppContext.BaseDirectory)
            .AddJsonFile("appsettings.json", optional: false, reloadOnChange: true)
            .Build();

        public static IMongoDatabase GetDatabase()
        {
            if (database == null)
            {
                string connectionString = configuration.GetSection("MongoDB:ConnectionString")?.Value
                    ?? throw new CustomDbException("Connection string not found in configuration.");
                string databaseName = configuration.GetSection("MongoDB:DatabaseName")?.Value
                    ?? throw new CustomDbException("Database name not found in configuration.");
                client = new MongoClient(connectionString);
                database = client.GetDatabase(databaseName);
            }
            return database;
        }

        public static IMongoCollection<T> GetCollection<T>(string collectionName)
        {
            try { 
                if (string.IsNullOrWhiteSpace(collectionName))
                {
                    throw new ArgumentException("Collection name cannot be null or empty.", nameof(collectionName));
                }
                var db = GetDatabase();
                return db.GetCollection<T>(collectionName);
            }
            catch (ArgumentException ex)
            {
                throw new CustomDbException("Error retrieving collection: " + ex.Message);
            }
        }

        public static void ResetConnection()
        {
            client = null;
            database = null;
        }

    }
}
