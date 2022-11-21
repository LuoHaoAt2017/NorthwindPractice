namespace NorthwindClient
{
	partial class NorthwindClient
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
			this.customerView = new System.Windows.Forms.DataGridView();
			this.tabControl1 = new System.Windows.Forms.TabControl();
			this.tabPage1 = new System.Windows.Forms.TabPage();
			this.tabPage2 = new System.Windows.Forms.TabPage();
			this.productView = new System.Windows.Forms.DataGridView();
			((System.ComponentModel.ISupportInitialize)(this.customerView)).BeginInit();
			this.tabControl1.SuspendLayout();
			this.tabPage1.SuspendLayout();
			this.tabPage2.SuspendLayout();
			((System.ComponentModel.ISupportInitialize)(this.productView)).BeginInit();
			this.SuspendLayout();
			// 
			// customerView
			// 
			this.customerView.AllowUserToAddRows = false;
			this.customerView.AllowUserToDeleteRows = false;
			this.customerView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
			this.customerView.Dock = System.Windows.Forms.DockStyle.Fill;
			this.customerView.Location = new System.Drawing.Point(3, 3);
			this.customerView.Margin = new System.Windows.Forms.Padding(20);
			this.customerView.MultiSelect = false;
			this.customerView.Name = "customerView";
			this.customerView.RowHeadersWidth = 50;
			this.customerView.RowTemplate.Height = 48;
			this.customerView.Size = new System.Drawing.Size(1266, 921);
			this.customerView.TabIndex = 0;
			// 
			// tabControl1
			// 
			this.tabControl1.Controls.Add(this.tabPage1);
			this.tabControl1.Controls.Add(this.tabPage2);
			this.tabControl1.Dock = System.Windows.Forms.DockStyle.Fill;
			this.tabControl1.Location = new System.Drawing.Point(0, 0);
			this.tabControl1.Name = "tabControl1";
			this.tabControl1.SelectedIndex = 0;
			this.tabControl1.Size = new System.Drawing.Size(1280, 960);
			this.tabControl1.TabIndex = 1;
			this.tabControl1.SelectedIndexChanged += new System.EventHandler(this.TabControlIndexChanged);
			// 
			// tabPage1
			// 
			this.tabPage1.BackColor = System.Drawing.Color.Transparent;
			this.tabPage1.Controls.Add(this.customerView);
			this.tabPage1.Dock = System.Windows.Forms.DockStyle.Fill;
			this.tabPage1.Location = new System.Drawing.Point(4, 29);
			this.tabPage1.Name = "tabPage1";
			this.tabPage1.Padding = new System.Windows.Forms.Padding(3);
			this.tabPage1.Size = new System.Drawing.Size(1272, 927);
			this.tabPage1.TabIndex = 0;
			this.tabPage1.Text = "tabPage1";
			// 
			// tabPage2
			// 
			this.tabPage2.BackColor = System.Drawing.Color.Transparent;
			this.tabPage2.Controls.Add(this.productView);
			this.tabPage2.Dock = System.Windows.Forms.DockStyle.Fill;
			this.tabPage2.Location = new System.Drawing.Point(4, 29);
			this.tabPage2.Name = "tabPage2";
			this.tabPage2.Padding = new System.Windows.Forms.Padding(3);
			this.tabPage2.Size = new System.Drawing.Size(672, 767);
			this.tabPage2.TabIndex = 1;
			this.tabPage2.Text = "tabPage2";
			// 
			// productView
			// 
			this.productView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
			this.productView.Dock = System.Windows.Forms.DockStyle.Fill;
			this.productView.Location = new System.Drawing.Point(3, 3);
			this.productView.Margin = new System.Windows.Forms.Padding(20);
			this.productView.MultiSelect = false;
			this.productView.Name = "productView";
			this.productView.RowHeadersWidth = 50;
			this.productView.RowTemplate.Height = 48;
			this.productView.Size = new System.Drawing.Size(666, 761);
			this.productView.TabIndex = 0;
			// 
			// NorthwindClient
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.ClientSize = new System.Drawing.Size(1280, 960);
			this.Controls.Add(this.tabControl1);
			this.Margin = new System.Windows.Forms.Padding(4);
			this.Name = "NorthwindClient";
			this.Text = "NorthwindClient";
			this.Load += new System.EventHandler(this.NorthwindClientLoad);
			((System.ComponentModel.ISupportInitialize)(this.customerView)).EndInit();
			this.tabControl1.ResumeLayout(false);
			this.tabPage1.ResumeLayout(false);
			this.tabPage2.ResumeLayout(false);
			((System.ComponentModel.ISupportInitialize)(this.productView)).EndInit();
			this.ResumeLayout(false);

		}

		#endregion

		private DataGridView customerView;
		private TabControl tabControl1;
		private TabPage tabPage1;
		private TabPage tabPage2;
		private DataGridView productView;
	}
}