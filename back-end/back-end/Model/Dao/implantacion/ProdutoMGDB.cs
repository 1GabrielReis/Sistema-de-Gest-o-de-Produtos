using back_end.Model.Entities;
using MongoDB.Driver;

namespace back_end.Model.Dao.implantacion
{
    public class ProdutoMGDB : INProdutoDao
    {
        private readonly IMongoDatabase? database = null;

        public ProdutoMGDB(IMongoDatabase db)
        {
            database = db;
        }
        public void Insert(ProdutoEntity produto)
        {
            // Implementação do método Insert
        }

        public void Update(ProdutoEntity produto)
        {
            // Implementação do método Update
        }

        public void DeleById(int id)
        {
            // Implementação do método DeleById
        }

        public ProdutoEntity FindById(int id)
        {
            return null; 
        }

        public List<ProdutoEntity> FindAll()
        {
            return new List<ProdutoEntity>(); 
        }

        public List<ProdutoEntity> FindBySelect(string select)
        {
            return new List<ProdutoEntity>(); 
        }
    }
}
