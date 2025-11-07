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
            database = db ?? throw new ArgumentNullException(nameof(db), "O banco de dados não pode ser nulo.");
            categories = database.GetCollection<CategoriaEntity>("categories");
        }

        public async Task Insert(CategoriaEntity categoria)
        {
            try
            {
                await categories.InsertOneAsync(categoria);
            }
            catch (MongoException ex)
            {
                throw new CustomDbException(ex.Message);
            }
        }

        public async Task Update(CategoriaEntity categoria)
        {
            try
            {
                var filter = Builders<CategoriaEntity>.Filter.Eq(c => c.Id, categoria.Id);
                var result = await categories.ReplaceOneAsync(filter, categoria);

                if (result.ModifiedCount == 0)
                {
                    throw new Exception("Categoria não encontrada ou nenhum dado alterado.");
                }
            }
            catch (MongoException ex)
            {
                throw new CustomDbException(ex.Message);
            }
        }

        public void DeleById(int id)
        {
            try
            {
                var categoria = categories.DeleteOne(c => c.Id == id.ToString());
                if (categoria.DeletedCount == 0)
                {
                    throw new CustomDbException("Categoria não encontrada para exclusão.");
                }
            }
            catch (MongoException ex)
            {
                throw new CustomDbException(ex.Message);
            }
        }

        public CategoriaEntity FindById(int id)
        {
            try
            {
                CategoriaEntity categoria = categories.Find(c => c.Id == id.ToString()).FirstOrDefault();
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
            try
            {
                var categorias = categories.Find(c => c.Nome.ToLower().Contains(name.ToLower())).ToList();
                return categorias;
            }
            catch (MongoException ex)
            {
                throw new CustomDbException(ex.Message);
            }

        }

    }
}

