namespace back_end.Model.Entities
{
    public class CategoriaEntity
    {
        public int Id { get; set; }
        public string Nome { get; set; } = string.Empty;

        public CategoriaEntity() { }
        public CategoriaEntity(int id, string nome)
        {
            Id = id;
            Nome = nome;
        }

    }
}
