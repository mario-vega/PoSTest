namespace CashMastersPOS
{
	partial class Main
	{
		/// <summary>
		///  Required designer variable.
		/// </summary>
		private System.ComponentModel.IContainer components = null;

		/// <summary>
		///  Clean up any resources being used.
		/// </summary>
		/// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
		protected override void Dispose(bool disposing)
		{
			if (disposing && (components != null))
			{
				components.Dispose();
			}
			base.Dispose(disposing);
		}

		#region Windows Form Designer generated code

		/// <summary>
		///  Required method for Designer support - do not modify
		///  the contents of this method with the code editor.
		/// </summary>
		private void InitializeComponent()
		{
			txtCode = new TextBox();
			dgvSellingItems = new DataGridView();
			clmId = new DataGridViewTextBoxColumn();
			clmName = new DataGridViewTextBoxColumn();
			clmPrice = new DataGridViewTextBoxColumn();
			label1 = new Label();
			btnPay = new Button();
			btnCancel = new Button();
			txtTotal = new TextBox();
			txtPayment = new TextBox();
			label2 = new Label();
			lblConf = new Label();
			((System.ComponentModel.ISupportInitialize)dgvSellingItems).BeginInit();
			SuspendLayout();
			// 
			// txtCode
			// 
			txtCode.Location = new Point(13, 416);
			txtCode.Name = "txtCode";
			txtCode.PlaceholderText = "Item code";
			txtCode.Size = new Size(293, 23);
			txtCode.TabIndex = 0;
			txtCode.KeyPress += txtCode_KeyPress;
			// 
			// dgvSellingItems
			// 
			dgvSellingItems.AllowUserToAddRows = false;
			dgvSellingItems.AllowUserToDeleteRows = false;
			dgvSellingItems.AllowUserToResizeRows = false;
			dgvSellingItems.Anchor = AnchorStyles.Top | AnchorStyles.Left | AnchorStyles.Right;
			dgvSellingItems.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
			dgvSellingItems.Columns.AddRange(new DataGridViewColumn[] { clmId, clmName, clmPrice });
			dgvSellingItems.Location = new Point(12, 12);
			dgvSellingItems.MultiSelect = false;
			dgvSellingItems.Name = "dgvSellingItems";
			dgvSellingItems.ReadOnly = true;
			dgvSellingItems.ShowCellErrors = false;
			dgvSellingItems.ShowCellToolTips = false;
			dgvSellingItems.ShowEditingIcon = false;
			dgvSellingItems.ShowRowErrors = false;
			dgvSellingItems.Size = new Size(605, 387);
			dgvSellingItems.TabIndex = 5;
			// 
			// clmId
			// 
			clmId.DataPropertyName = "Id";
			clmId.HeaderText = "Code";
			clmId.Name = "clmId";
			clmId.ReadOnly = true;
			clmId.Width = 50;
			// 
			// clmName
			// 
			clmName.DataPropertyName = "Name";
			clmName.HeaderText = "Product";
			clmName.Name = "clmName";
			clmName.ReadOnly = true;
			clmName.Width = 200;
			// 
			// clmPrice
			// 
			clmPrice.DataPropertyName = "Price";
			clmPrice.HeaderText = "Price";
			clmPrice.Name = "clmPrice";
			clmPrice.ReadOnly = true;
			// 
			// label1
			// 
			label1.AutoSize = true;
			label1.Font = new Font("Segoe UI", 9F, FontStyle.Bold);
			label1.Location = new Point(311, 418);
			label1.Name = "label1";
			label1.Size = new Size(37, 15);
			label1.TabIndex = 3;
			label1.Text = "Total:";
			// 
			// btnPay
			// 
			btnPay.Location = new Point(542, 444);
			btnPay.Name = "btnPay";
			btnPay.Size = new Size(75, 23);
			btnPay.TabIndex = 2;
			btnPay.Text = "Pay";
			btnPay.UseVisualStyleBackColor = true;
			btnPay.Click += btnPay_Click;
			// 
			// btnCancel
			// 
			btnCancel.Location = new Point(461, 444);
			btnCancel.Name = "btnCancel";
			btnCancel.Size = new Size(75, 23);
			btnCancel.TabIndex = 3;
			btnCancel.Text = "Cancel";
			btnCancel.UseVisualStyleBackColor = true;
			btnCancel.Click += btnCancel_Click;
			// 
			// txtTotal
			// 
			txtTotal.Font = new Font("Segoe UI", 9F, FontStyle.Bold);
			txtTotal.Location = new Point(354, 415);
			txtTotal.Name = "txtTotal";
			txtTotal.ReadOnly = true;
			txtTotal.Size = new Size(92, 23);
			txtTotal.TabIndex = 4;
			txtTotal.Text = "0.00";
			txtTotal.TextAlign = HorizontalAlignment.Right;
			// 
			// txtPayment
			// 
			txtPayment.Font = new Font("Segoe UI", 9F, FontStyle.Bold);
			txtPayment.Location = new Point(517, 415);
			txtPayment.Name = "txtPayment";
			txtPayment.Size = new Size(100, 23);
			txtPayment.TabIndex = 1;
			txtPayment.TextAlign = HorizontalAlignment.Right;
			// 
			// label2
			// 
			label2.AutoSize = true;
			label2.Font = new Font("Segoe UI", 9F, FontStyle.Bold);
			label2.Location = new Point(452, 418);
			label2.Name = "label2";
			label2.Size = new Size(59, 15);
			label2.TabIndex = 7;
			label2.Text = "Payment:";
			// 
			// lblConf
			// 
			lblConf.AutoSize = true;
			lblConf.Location = new Point(12, 448);
			lblConf.Name = "lblConf";
			lblConf.Size = new Size(100, 15);
			lblConf.TabIndex = 8;
			lblConf.Text = "Configuration: - -";
			// 
			// Main
			// 
			AutoScaleDimensions = new SizeF(7F, 15F);
			AutoScaleMode = AutoScaleMode.Font;
			ClientSize = new Size(627, 476);
			Controls.Add(lblConf);
			Controls.Add(txtPayment);
			Controls.Add(label2);
			Controls.Add(txtTotal);
			Controls.Add(btnCancel);
			Controls.Add(btnPay);
			Controls.Add(label1);
			Controls.Add(dgvSellingItems);
			Controls.Add(txtCode);
			Name = "Main";
			Text = "Main.cs";
			((System.ComponentModel.ISupportInitialize)dgvSellingItems).EndInit();
			ResumeLayout(false);
			PerformLayout();
		}

		#endregion

		private TextBox txtCode;
		private DataGridView dgvSellingItems;
		private Label label1;
		private Button btnPay;
		private Button btnCancel;
		private DataGridViewTextBoxColumn clmId;
		private DataGridViewTextBoxColumn clmName;
		private DataGridViewTextBoxColumn clmPrice;
		private TextBox txtTotal;
		private TextBox txtPayment;
		private Label label2;
		private Label lblConf;
	}
}
