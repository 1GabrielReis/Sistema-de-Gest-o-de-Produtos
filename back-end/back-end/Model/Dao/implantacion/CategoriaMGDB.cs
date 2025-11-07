using back_end.Model.Entities;
using MongoDB.Driver;
using back_end.Model.DataBase;
using System.Data.Common;

namespace back_end.Model.Dao.implantacion
{
    public class CategoriaMGDB : INCategoriaDao
    {
        private readonly IMongoDatabase database;
        private readonly IMongoCollection<CategoriaEntity> categories;

        public CategoriaMGDB(IMongoDatabase db)
        {
            if (db == null)
            {
                throw new ArgumentNullException(nameof(db), "O banco de dados não pode ser nulo.");
            }
            database = db;
            categories = database.GetCollection<CategoriaEntity>("categories");
        }

        public void Insert(CategoriaEntity categoria)
        {
            var list= new List<CategoriaEntity>();
            try
            {
                // Implementação do método Insert
            }
            catch (MongoException ex)
            {
                throw new CustomDbException(ex.Message);
            }
            finally { }
        }

        public void Update(CategoriaEntity categoria)
        {
            // Implementação do método Update
        }

        public void DeleById(int id)
        {
            // Implementação do método DeleById
        }

        public CategoriaEntity FindById(int id)
        {
            try
            {
                CategoriaEntity categoria = categories.Find(p => p.Id == id.ToString()).FirstOrDefault();
                return categoria;
            }
            catch (MongoException ex)
            {
                throw new CustomDbException(ex.Message);
            }
        }

        public List<CategoriaEntity> FindAll()
        {
            try
            {
                return categories.Find(_ => true).ToList();
            }
            catch (MongoException ex)
            {
                throw new CustomDbException(ex.Message);
            } 
        }

        public List<CategoriaEntity> FindByname(string name)
        {
            
            return new List<CategoriaEntity>(); 
        }

    }
}

