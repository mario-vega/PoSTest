using System.Text;

namespace CashMastersPOS.Utilities
{
	public static class CalculateChange
	{
		/// <summary>
		/// Returns the change distibuted in the country denomination specified.
		/// </summary>
		/// <param name="country">Data configured in App.config file.</param>
		/// <param name="payment">Amount given to calculate the return change.</param>
		/// <param name="total">Sum of all the products price, used to calculate the return change.</param>
		/// <returns></returns>
		public static string ReturnChange(string country, double payment, double total)
		{
			var denominations = MoneyDenominations.GetDenomination(country);
			List<double> result = new List<double>();
            double change = Math.Round(payment - total, 2);

            if (change.Equals(0))
				return "0";

            double changeCondition = 0;
			while (changeCondition < change)
			{
				double remaining = Math.Round(change - changeCondition, 2);
				double closest = 0;
				closest = denominations.Where(m => m <= remaining).OrderDescending().First();
				result.Add(closest);
				changeCondition += closest;
			}

			return DistributeMoney(result, country);
		}

		/// <summary>
		/// Rounds up the given amount, used particularly for Mexico due the lowest cent denomination is '0.05'.
		/// </summary>
		/// <param name="amount"></param>
		/// <returns></returns>
		public static double RoundDecimals(double amount)
		{
			return Math.Ceiling(amount / 0.05) * 0.05;
		}

		/// <summary>
		/// Distributes the money into bills and coins.
		/// </summary>
		/// <param name="money">List of denominations.</param>
		/// <param name="country">Used to create an object depending on the value.</param>
		/// <returns>Returns an appended string with the denominations.</returns>
		private static string DistributeMoney(List<double> money, string country)
		{
			IMonetarySystem ms = MonetarySystemFactory.CreateMonetarySystem(country);
			var bills = ms.GetBills(money);
			var coins = ms.GetCoins(money);

			StringBuilder change = new StringBuilder();
			change.AppendLine($"Bills: {string.Join(", ", bills)}");
			change.AppendLine($"Coins: {string.Join(", ", coins)}");

			return change.ToString();
		}
	}
}
