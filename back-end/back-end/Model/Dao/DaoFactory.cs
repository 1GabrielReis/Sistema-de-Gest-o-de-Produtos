using back_end.Model.Dao.implantacion;
using back_end.Model.DB;

namespace back_end.Model.Dao
{
    public class DaoFactory
    {
        public static INCategoriaDao CreaterCategoriaDao()
        {
            return new CategoriaMGDB(Db.GetDatabase());
        }

        public static INProdutoDao CreaterProdutoDao()
        {
            return new ProdutoMGDB(Db.GetDatabase());
        }
    }
}
