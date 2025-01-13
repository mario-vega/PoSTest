using CashMastersPOS.Model;

namespace CashMastersPOS.Database
{
	public class DatabaseSingleton
	{
		private static DatabaseSingleton _instance;

		private DatabaseSingleton() { }
		public static DatabaseSingleton Instance
		{
			get
			{
				if (_instance == null)
					_instance = new DatabaseSingleton();
				return _instance;
			}
		}


		public List<Product> Products = new List<Product>
		{ 
			new Product{ Id = 1, Name = "Soap", Price = 10.2 },
			new Product{ Id = 2, Name = "Chocolate", Price = 22.55 },
			new Product{ Id = 3, Name = "Cup", Price = 29.99 },
			new Product{ Id = 4, Name = "Bubblegum", Price = 1.5  },
			new Product{ Id = 5, Name = "Sugar", Price = 12.39 },
			new Product{ Id = 6, Name = "Beer", Price = 49.99 },
			new Product{ Id = 7, Name = "Speakers", Price = 50 }
		};
	}
}
