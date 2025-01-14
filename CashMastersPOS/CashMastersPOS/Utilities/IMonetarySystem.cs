using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CashMastersPOS.Utilities
{
	public interface IMonetarySystem
	{
		/// <summary>
		/// Get the bills depending of the instance created.
		/// </summary>
		/// <param name="values">List of denominations ready to be splitted.</param>
		/// <returns>List of the bills.</returns>
		public List<double> GetBills(List<double> values);
		/// <summary>
		/// Get the coins depending of the instance created.
		/// </summary>
		/// <param name="values">List of denominations ready to be splitted.</param>
		/// <returns>List of the coins.</returns>
		public List<double> GetCoins(List<double> values);
	}
}
