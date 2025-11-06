using MongoDB.Driver;
using MongoDB.Bson;
using Microsoft.Extensions.Configuration;

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
                    ?? throw new Exception("Connection string not found in configuration.");
                string databaseName = configuration.GetSection("MongoDB:DatabaseName")?.Value
                    ?? throw new Exception("Database name not found in configuration.");
                client = new MongoClient(connectionString);
                database = client.GetDatabase(databaseName);
            }
            return database;
        }

        public static void ResetConnection()
        {
            client = null;
            database = null;
        }
    }
}
