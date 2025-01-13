using CashMastersPOS.CustomExceptions;
using CashMastersPOS.Model;
using CashMastersPOS.Repository;
using CashMastersPOS.Utilities;
using System.Configuration;
using System.Text;

namespace CashMastersPOS
{
	public partial class Main : Form
	{
		private readonly ProductsRepository _repository;
		private List<Product> _dgvSource;
		private readonly string _country;
		private List<double> _denominations;

		public Main()
		{
			InitializeComponent();
			_repository = new ProductsRepository();
			_dgvSource = new List<Product>();
			_country = ConfigurationManager.AppSettings["country"] ?? "";
			dgvSellingItems.AutoGenerateColumns = false;
			lblConf.Text = $"Configuration: {_country}";
		}

		private void txtCode_KeyPress(object sender, KeyPressEventArgs e)
		{
			if (e.KeyChar == (char)Keys.Enter)
			{
				// Check product existence
				int productId = int.Parse(txtCode.Text.Trim());
				var product = _repository.GetById(productId);

				// Send warning message if product does not exist
				if (product == null)
				{
					MessageBox.Show("Product not found.", "", MessageBoxButtons.OK, MessageBoxIcon.Warning);
					return;
				}

				// Add product
				_dgvSource.Add(product);

				// Update gridview
				dgvSellingItems.DataSource = null;
				dgvSellingItems.DataSource = _dgvSource;
				txtCode.Text = string.Empty;
				UpdateTotal();
			}
		}

		private void btnCancel_Click(object sender, EventArgs e)
		{
			ClearControls();
		}

		private void btnPay_Click(object sender, EventArgs e)
		{
			try
			{
				double total = double.Parse(txtTotal.Text);
				if (_country == MoneyDenominations.mx)
					total = Math.Round(CalculateChange.RoundDecimals(total), 2);
				if (!ValidatePayment(total)) return;

				double payment = Math.Round(double.Parse(txtPayment.Text), 2);
				var result = CalculateChange.ReturnChance(_country, payment, total);
				StringBuilder change = new StringBuilder();
				foreach (var item in result)
				{
					change.AppendLine(item.ToString());
				}
				MessageBox.Show(change.ToString(), "Result", MessageBoxButtons.OK, MessageBoxIcon.Information);
			}
			catch (NoCountryConfiguredException ex)
			{
				MessageBox.Show(ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
			}
			catch (MoneyDenominationDoesNotExist ex)
			{
				MessageBox.Show(ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
			}
			finally
			{
				ClearControls();
			}
		}

		private void UpdateTotal()
		{
			double totalRaw = _dgvSource.Sum(e => e.Price);
			double total = Math.Round(totalRaw, 2);
			txtTotal.Text = $"{total.ToString()}";
		}

		private void ClearControls()
		{
			_dgvSource = new List<Product>();
			dgvSellingItems.DataSource = null;
			dgvSellingItems.DataSource = _dgvSource;
			txtCode.Text = string.Empty;
			txtTotal.Text = "0.00";
			txtPayment.Text = string.Empty;
		}

		private bool ValidatePayment(double total)
		{
			if (string.IsNullOrEmpty(txtPayment.Text))
			{
				MessageBox.Show("Payment field is empty.", "", MessageBoxButtons.OK, MessageBoxIcon.Warning);
				return false;
			}

			if (total > Math.Round(double.Parse(txtPayment.Text), 2))
            {
				MessageBox.Show("Payment is not enough.", "", MessageBoxButtons.OK, MessageBoxIcon.Warning);
				return false;
			}

			return true;
		}
	}
}
