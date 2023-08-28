using Kassensystem.Entity;

namespace Kassensystem.DAL
{
    public interface IProductDAL 
    {
        List<Product> SelectAllProducts();
    }
}
