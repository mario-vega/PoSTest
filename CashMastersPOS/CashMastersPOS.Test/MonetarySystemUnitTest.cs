using CashMastersPOS.Utilities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CashMastersPOS.Test
{
	[TestClass]
	public class MonetarySystemUnitTest
	{
		[TestMethod]
		public void Valid_ReturnBillsMx()
		{
			string country = "mx";
			List<double> money = new List<double> { 100, 100, 50, 20, 10, 10, 5, 10 };
			List<double> expected = new List<double> { 100, 100, 50, 20 };
			IMonetarySystem ms = MonetarySystemFactory.CreateMonetarySystem(country);

			List<double> result = ms.GetBills(money);
			Assert.IsNotNull(result);
			Assert.IsTrue(expected.SequenceEqual(result));
			CollectionAssert.AreEqual(expected, result);
		}

		[TestMethod]
		public void Valid_ReturnCoinsMx()
		{
			string country = "mx";
			List<double> money = new List<double> { 100, 100, 50, 20, 10, 10, 5, 10 };
			List<double> expected = new List<double> { 10, 10, 5, 10 };
			IMonetarySystem ms = MonetarySystemFactory.CreateMonetarySystem(country);

			List<double> result = ms.GetCoins(money);
			Assert.IsNotNull(result);
			Assert.IsTrue(expected.SequenceEqual(result));
			CollectionAssert.AreEqual(expected, result);
		}

		[TestMethod]
		public void Valid_ReturnBillsUs()
		{
			string country = "us";
			List<double> money = new List<double> { 20, 10, 10, 5, 10, 1, 2, 0.5, 0.01, 0.1 };
			List<double> expected = new List<double> { 20, 10, 10, 5, 10, 1, 2 };
			IMonetarySystem ms = MonetarySystemFactory.CreateMonetarySystem(country);

			List<double> result = ms.GetBills(money);
			Assert.IsNotNull(result);
			Assert.IsTrue(expected.SequenceEqual(result));
			CollectionAssert.AreEqual(expected, result);
		}

		[TestMethod]
		public void Valid_ReturnCoinsUs()
		{
			string country = "us";
			List<double> money = new List<double> { 20, 50, 5, 0.5, 0.25, 0.25, 100 };
			List<double> expected = new List<double> { 0.5, 0.25, 0.25 };
			IMonetarySystem ms = MonetarySystemFactory.CreateMonetarySystem(country);

			List<double> result = ms.GetCoins(money);
			Assert.IsNotNull(result);
			Assert.IsTrue(expected.SequenceEqual(result));
			CollectionAssert.AreEqual(expected, result);
		}
	}
}
