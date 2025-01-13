namespace CashMastersPOS.Utilities
{
	public class USMonetarySystem : IMonetarySystem
	{
		public List<double> GetBills(List<double> values)
		{
			return values.Where(x => x >= 1).ToList();
		}

		public List<double> GetCoins(List<double> values)
		{
			return values.Where(x => x < 1).ToList();
		}
	}
}
