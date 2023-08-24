namespace Kassensystem.DAL
{
    public class ProductBL
    {
        public IProductDAL productDAL;
        public ProductBL(IProductDAL productDAL) 
        { 
            this.productDAL = productDAL;
        }
        public List<Product> GetAllProducts() 
        {
            return productDAL.SelectAllProducts();
        }
    }
}
