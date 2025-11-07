using MongoDB.Bson;
using MongoDB.Bson.Serialization.Attributes;

namespace back_end.Model.Entities
{
    public class CategoriaEntity
    {
        [BsonId]
        [BsonRepresentation(BsonType.ObjectId)]
        public string Id { get; set; } = string.Empty;
        public string Nome { get; set; } = string.Empty;

        public CategoriaEntity() { }
        public CategoriaEntity(string id, string nome)
        {
            Id = id;
            Nome = nome;
        }

    }
}
