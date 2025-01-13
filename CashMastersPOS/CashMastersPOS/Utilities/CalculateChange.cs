namespace CashMastersPOS.Utilities
{
	public static class CalculateChange
	{
		public static List<double> ReturnChance(string country, double payment, double total)
		{
			var denominations = MoneyDenominations.GetDenomination(country);
			List<double> result = new List<double>();
            double change = Math.Round(payment - total,2);

            if (change.Equals(0))
            {
				result.Add(change);
				return result;
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

			return result;
		}

		public static double RoundDecimals(double amount)
		{
			return Math.Round(amount / 0.05) * 0.05;
		}
	}
}
