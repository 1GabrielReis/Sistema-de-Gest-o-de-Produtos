using back_end.Model.Entities;
using MongoDB.Driver;

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
            // Implementação do método Insert
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
