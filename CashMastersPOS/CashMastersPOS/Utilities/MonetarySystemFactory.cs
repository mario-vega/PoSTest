using CashMastersPOS.CustomExceptions;

namespace CashMastersPOS.Utilities
{
	public static class MonetarySystemFactory
	{
		public static IMonetarySystem CreateMonetarySystem(string country)
		{
			return country switch
			{
				MoneyDenominations.mx => new MexicoMonetarySystem(),
				MoneyDenominations.us => new USMonetarySystem(),
				_ => throw new NoCountryConfiguredException()
			};
		}
	}
}
