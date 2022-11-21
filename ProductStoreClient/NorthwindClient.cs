using NorthwindClient.Common;
using NorthwindClient.Models;
using System.Data;
using System.Net.Http.Json;

namespace NorthwindClient
{
	public partial class NorthwindClient : Form
	{
		private readonly HttpClient client = new HttpClient()
		{
			BaseAddress = new Uri("https://localhost:7053"),
		};

		public NorthwindClient()
		{
			InitializeComponent();
			this.SetupLayout();
		}

		private void NorthwindClientLoad(object sender, EventArgs e)
		{
			this.tabControl1.SelectedIndex = 1;
			SetupProductView();
			FetchProductList();
		}

		private string GetFieldValue(DataRow row, string field)
		{
			if (row == null || string.IsNullOrEmpty(field))
			{
				return null;
			}
			if (row[field] == null)
			{
				return null;
			}
			return row[field].ToString();
		}

		private void SetupCustomerView()
		{
			string[] columns = new string[7]
			{
						"CustomerId",
						"CustomerName",
						"ContactName",
						"Address",
						"City",
						"PostalCode",
						"Country",
			};
			customerView.ColumnCount = columns.Length;
			// dataGridView.AutoSizeRowsMode = DataGridViewAutoSizeRowsMode.DisplayedCellsExceptHeaders;
			for (int i = 0; i < columns.Length; i++)
			{
				customerView.Columns[i].Name = columns[i];
				customerView.Columns[i].DisplayIndex = i;
				customerView.Columns[i].Width = 240;
			}
		}

		private async void FetchCustomerList()
		{
			try
			{
				var customers = await client.GetFromJsonAsync<List<Customer>>("/api/Customer");
				if (customers == null)
				{
					return;
				}
				this.RefreshCustomersList(customers);
			}
			catch(Exception ex)
			{
				LogHelper.Error(ex.Message);
			}
		}

		private void RefreshCustomersList(List<Customer> customers)
		{
			foreach (var customer in customers)
			{
				string[] row = new string[7]
				{
					customer.CustomerId,
					customer.CustomerName,
					customer.ContactName,
					customer.Address,
					customer.City,
					customer.PostalCode,
					customer.Country
				};
				customerView.Rows.Add(row);
			}
		}

		private void FetchProductList()
		{
			string conStr = "server=192.168.0.193;database=northwind;uid=tomcat;pwd=LuoHao123";
			string sqlStr = "select * from Products";
			DataTable dt = DBHelper.ExecuteSql(DefaultDB.SQLServer, sqlStr, conStr);

			List<Product> list = new List<Product>();

			if (dt != null && dt.Rows.Count > 0)
			{
				foreach (DataRow row in dt.Rows)
				{
					Product product = new Product();
					product.ProductId = GetFieldValue(row, "ProductId");
					product.ProductName = GetFieldValue(row, "ProductName");
					product.SupplierId = GetFieldValue(row, "SupplierId");
					product.CategoryId = GetFieldValue(row, "CategoryId");
					product.Unit = GetFieldValue(row, "Unit");
					product.Price = GetFieldValue(row, "Price");
					list.Add(product);
				}
			}

			this.RefreshProductList(list);
		}

		private void SetupProductView()
		{
			string[] columns = new string[6]
			{
				"ProductId",
				"ProductName",
				"SupplierId",
				"CategoryId",
				"Unit",
				"Price",
			};
			productView.ColumnCount = columns.Length;
			// dataGridView.AutoSizeRowsMode = DataGridViewAutoSizeRowsMode.DisplayedCellsExceptHeaders;
			for (int i = 0; i < columns.Length; i++)
			{
				productView.Columns[i].Name = columns[i];
				productView.Columns[i].DisplayIndex = i;
				productView.Columns[i].Width = 240;
			}
		}

		private void RefreshProductList(List<Product> products)
		{
			foreach (var product in products)
			{
				string[] row = new string[6]
				{
					product.ProductId,
					product.ProductName,
					product.SupplierId,
					product.CategoryId,
					product.Unit,
					product.Price,
				};
				productView.Rows.Add(row);
			}
		}

		private void SetupLayout()
		{

		}

		private void TabControlIndexChanged(object sender, EventArgs e)
		{
			LogHelper.Log(this.tabControl1.SelectedIndex.ToString());
			if (this.tabControl1.SelectedIndex == 0)
			{
				SetupCustomerView();
				FetchCustomerList();
			}
			else if (this.tabControl1.SelectedIndex == 1)
			{
				SetupProductView();
				FetchProductList();
			}
			else
			{

			}
		}
	}
}