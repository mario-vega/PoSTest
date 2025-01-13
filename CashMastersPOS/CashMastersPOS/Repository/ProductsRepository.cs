using CashMastersPOS.Database;
using CashMastersPOS.Model;

namespace CashMastersPOS.Repository
{
	public class ProductsRepository
	{
        public ProductsRepository() { }

        public Product? GetById(int id)
        {
            var item = DatabaseSingleton.Instance.Products.FirstOrDefault(x => x.Id == id);
            return item;
        }
    }
}
