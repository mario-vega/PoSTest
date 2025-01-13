using CashMastersPOS.Utilities;
using System.Text;

namespace CashMastersPOS.Test;

[TestClass]
public class CalculateChangeUnitTest
{
    [TestMethod]
    public void Valid_ReturnChangeMx()
    {
        double payment = 100;
        double total = 51.5;
        string country = "mx";

        var result = CalculateChange.ReturnChange(country, payment, total);
        StringBuilder expected = new StringBuilder();
        expected.AppendLine("Bills: 20, 20");
        expected.AppendLine("Coins: 5, 2, 1, 0.5");

        Assert.AreEqual(expected.ToString(), result);
    }

    [TestMethod]
	public void Valid_ReturnChangeUs()
	{
		double payment = 70;
		double total = 59.98;
		string country = "us";

		var result = CalculateChange.ReturnChange(country, payment, total);
		StringBuilder expected = new StringBuilder();
		expected.AppendLine("Bills: 10");
		expected.AppendLine("Coins: 0.01, 0.01");

		Assert.AreEqual(expected.ToString(), result);
	}

	[TestMethod]
	public void Valid_RoundDecimals()
	{
		double amount = 59.98;
		double expected = 60;

		var result = CalculateChange.RoundDecimals(amount);

		Assert.AreEqual(expected, result);
	}
}