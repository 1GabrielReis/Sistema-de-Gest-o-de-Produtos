using back_end.Model.Entities;

namespace back_end.Model.Dao
{
    public interface INProdutoDao
    {
        void Insert(ProdutoEntity produto);
        void Update(ProdutoEntity produto);
        void DeleById(int id);
        ProdutoEntity FindById(int id);
        List<ProdutoEntity> FindAll();
        List<ProdutoEntity> FindBySelect(string select);
    }
}
