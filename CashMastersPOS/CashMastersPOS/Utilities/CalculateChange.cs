using System.Text;

namespace CashMastersPOS.Utilities
{
	public static class CalculateChange
	{
		public static string ReturnChange(string country, double payment, double total)
		{
			var denominations = MoneyDenominations.GetDenomination(country);
			List<double> result = new List<double>();
            double change = Math.Round(payment - total,2);

            if (change.Equals(0))
            {
				result.Add(change);
				return "0";
            }

            double changeCondition = 0;
			while (changeCondition < change)
			{
				double remaining = change - changeCondition;
				double closest = 0;
				closest = denominations.Where(m => m <= remaining).OrderDescending().First();
				result.Add(closest);
				changeCondition += closest;
			}

			return DistributeMoney(result, country);
		}

		public static double RoundDecimals(double amount)
		{
			return Math.Round(amount / 0.05) * 0.05;
		}

		private static string DistributeMoney(List<double> denominations, string country)
		{
			IMonetarySystem ms = MonetarySystemFactory.CreateMonetarySystem(country);
			var bills = ms.GetBills(denominations);
			var coins = ms.GetCoins(denominations);

			StringBuilder change = new StringBuilder();
			change.Append($"Bills: {string.Join(", ", bills)}");
			change.AppendLine($"Coins: {string.Join(", ", coins)}");

			return change.ToString();
		}
	}
}
