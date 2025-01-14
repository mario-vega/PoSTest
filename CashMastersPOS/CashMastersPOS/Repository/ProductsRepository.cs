using CashMastersPOS.Database;
using CashMastersPOS.Model;

namespace CashMastersPOS.Repository
{
	public class ProductsRepository
	{
        public ProductsRepository() { }

        /// <summary>
        /// Get a product that matches the id.
        /// </summary>
        /// <param name="id">Unique identifier of the product.</param>
        /// <returns>A product object or null if no exists.</returns>
        public Product? GetById(int id)
        {
            var item = DatabaseSingleton.Instance.Products.FirstOrDefault(x => x.Id == id);
            return item;
        }
    }
}
