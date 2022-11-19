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
			this.dataGridView = new System.Windows.Forms.DataGridView();
			((System.ComponentModel.ISupportInitialize)(this.dataGridView)).BeginInit();
			this.SuspendLayout();
			// 
			// dataGridView
			// 
			this.dataGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
			this.dataGridView.Dock = System.Windows.Forms.DockStyle.Fill;
			this.dataGridView.Location = new System.Drawing.Point(0, 0);
			this.dataGridView.Margin = new System.Windows.Forms.Padding(4);
			this.dataGridView.Name = "dataGridView";
			this.dataGridView.RowHeadersWidth = 50;
			this.dataGridView.RowTemplate.Height = 48;
			this.dataGridView.MultiSelect = false;
			this.dataGridView.AllowUserToAddRows = false;
			this.dataGridView.AllowUserToDeleteRows = false;
			this.dataGridView.AllowUserToOrderColumns = false;
			// this.dataGridView.Dock = DockStyle.Fill;
			this.dataGridView.Padding = new Padding(20, 20, 20, 20);
			this.dataGridView.Margin = new Padding(20, 20, 20, 20);
			this.dataGridView.ColumnHeadersDefaultCellStyle.Font = new Font("微软雅黑", 16);
			this.dataGridView.RowsDefaultCellStyle.Font = new Font("微软雅黑", 16);
			this.dataGridView.ColumnHeadersHeight = 54;
			this.dataGridView.AutoSize = true;
			//this.dataGridView.Size = new System.Drawing.Size(1280, 640);
			this.dataGridView.TabIndex = 0;
			// 
			// NorthwindClient
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.ClientSize = new System.Drawing.Size(1680, 800);
			this.Controls.Add(this.dataGridView);
			this.Margin = new System.Windows.Forms.Padding(4);
			this.Name = "NorthwindClient";
			this.Text = "NorthwindClient";
			this.Load += new System.EventHandler(this.NorthwindClientLoad);
			((System.ComponentModel.ISupportInitialize)(this.dataGridView)).EndInit();
			this.ResumeLayout(false);

		}

		#endregion

		private DataGridView dataGridView;
	}
}