using CashMastersPOS.CustomExceptions;

namespace CashMastersPOS.Utilities
{
	public static class MoneyDenominations
	{
		private static List<double> _mxDenominations = new List<double> { 0.05, 0.10, 0.20, 0.50, 1, 2, 5, 10, 20, 50, 100 };
		private static List<double> _usDenominations = new List<double> { 0.01, 0.05, 0.10, 0.25, 0.50, 1, 2, 5, 10, 20, 50, 100 };
		public const string mx = "mx";
		public const string us = "us";

		/// <summary>
		/// Get the whole list of denominations used on the country specified.
		/// </summary>
		/// <param name="country">Data configured in App.config file.</param>
		/// <returns>A list of values with all the denominations.</returns>
		/// <exception cref="NoCountryConfiguredException"></exception>
		/// <exception cref="MoneyDenominationDoesNotExist"></exception>
		public static List<double> GetDenomination(string country)
		{
			if (string.IsNullOrEmpty(country))
				throw new NoCountryConfiguredException();

            if (country == us) return _usDenominations;
			if (country == mx) return _mxDenominations;
			
			throw new MoneyDenominationDoesNotExist(country);
		}
	}
}
