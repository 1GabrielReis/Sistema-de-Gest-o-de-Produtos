using back_end.Model.DataBase;
using back_end.Model.Entities;
using MongoDB.Driver;

namespace back_end.Model.Dao.implantacion
{
    public class ProdutoMGDB : INProdutoDao
    {
        private readonly IMongoDatabase? database = null;
        private readonly IMongoCollection<ProdutoEntity> products;

        public ProdutoMGDB(IMongoDatabase db)
        {
            database = db ?? throw new ArgumentNullException(nameof(db), "O banco de dados não pode ser nulo.");
            products = database.GetCollection<ProdutoEntity>("products");
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
            try
            {
                return products.Find(_ => true).ToList();
            }
            catch (MongoException ex)
            {
                throw new CustomDbException(ex.Message);
            } 
        }

        
        public List<ProdutoEntity> FindBySelect(string select)
        {
            return new List<ProdutoEntity>(); 
        }
    }
}
