using back_end.Model.Entities;

namespace back_end.Model.Dao
{
    public interface INCategoriaDao
    {
        Task Insert(CategoriaEntity categoria);
        Task Update(CategoriaEntity categoria);
        void DeleById(int id);
        CategoriaEntity FindById(int id);
        List<CategoriaEntity> FindAll();
        List<CategoriaEntity> FindByname(string name);
    }
}
