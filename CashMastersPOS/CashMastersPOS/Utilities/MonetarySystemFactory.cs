using CashMastersPOS.CustomExceptions;

namespace CashMastersPOS.Utilities
{
	public static class MonetarySystemFactory
	{
		/// <summary>
		/// Creates an instance depending on the country specified.
		/// </summary>
		/// <param name="country">Data configured in App.config file.</param>
		/// <returns>An instance inherited from IMonetarySystem.</returns>
		/// <exception cref="NoCountryConfiguredException"></exception>
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
