using MongoDB.Bson;
using MongoDB.Bson.Serialization.Attributes;

namespace back_end.Model.Entities

{
    public class ProdutoEntity
    {
        [BsonId]
        [BsonRepresentation(BsonType.ObjectId)]
        public string Id { get; set; } = string.Empty;
        public string Nome { get; set; } = string.Empty;
        public string Descricao { get; set; } = string.Empty;
        public decimal Preco { get; set; }
        public CategoriaEntity Categoria { get; set; } = new CategoriaEntity();
        public int Estoque { get; set; }

        public ProdutoEntity() { }

        public ProdutoEntity(string id, string nome, string descricao, decimal preco, CategoriaEntity categoria, int estoque)
        {
            Id = id;
            Nome = nome;
            Descricao = descricao;
            Preco = preco;
            Categoria = categoria;
            Estoque = estoque;
        }
    }
}
