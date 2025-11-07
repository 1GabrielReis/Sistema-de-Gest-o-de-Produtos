using back_end.Model.Entities;
using MongoDB.Driver;
using back_end.Model.DataBase;
using System.Data.Common;

namespace back_end.Model.Dao.implantacion
{
    public class CategoriaMGDB : INCategoriaDao
    {
        private readonly IMongoDatabase? database;

        public CategoriaMGDB(IMongoDatabase db)
        {
            database = db;
        }

        public void Insert(CategoriaEntity categoria)
        {
            try
            {

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
            
            return null; 
        }

        public List<CategoriaEntity> FindAll()
        {
            
            return new List<CategoriaEntity>(); 
        }

        public List<CategoriaEntity> FindByname(string name)
        {
            
            return new List<CategoriaEntity>(); 
        }
    }
}

