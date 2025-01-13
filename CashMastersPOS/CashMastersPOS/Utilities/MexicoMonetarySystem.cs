namespace CashMastersPOS.Utilities
{
	public class MexicoMonetarySystem : IMonetarySystem
	{
		public List<double> GetBills(List<double> values)
		{
			return values.Where(b => b >= 20).ToList();
		}

		public List<double> GetCoins(List<double> values)
		{
			return values.Where(b => b < 20).ToList();
		}
	}
}
