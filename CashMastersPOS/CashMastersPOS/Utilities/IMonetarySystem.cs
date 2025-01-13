using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CashMastersPOS.Utilities
{
	public interface IMonetarySystem
	{
		public List<double> GetBills(List<double> values);
		public List<double> GetCoins(List<double> values);
	}
}
