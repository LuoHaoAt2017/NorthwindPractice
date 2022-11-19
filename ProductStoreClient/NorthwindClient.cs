using NorthwindClient.Models;
using System.Net.Http.Json;
using System.Windows.Forms;

namespace NorthwindClient
{
	public partial class NorthwindClient : Form
	{
		private readonly HttpClient client = new HttpClient()
		{
			BaseAddress = new Uri("https://localhost:7053"),
		};

		private readonly string[] columns = new string[7]
		{
			"CustomerId",
			"CustomerName",
			"ContactName",
			"Address",
			"City",
			"PostalCode",
			"Country",
		};

		public NorthwindClient()
		{
			InitializeComponent();
			this.SetupLayout();
		}

		private void NorthwindClientLoad(object sender, EventArgs e)
		{
			SetupDataGridView();
			FetchCustomerList();
		}

		private async void FetchCustomerList()
		{
			var customers = await client.GetFromJsonAsync<List<Customer>>("/api/Customer");
			if (customers == null)
			{
				return;
			}
			this.RefreshCustomersList(customers);
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
				dataGridView.Rows.Add(row);
			}
		}

		private void SetupDataGridView()
		{
			dataGridView.ColumnCount = columns.Length;
			// dataGridView.AutoSizeRowsMode = DataGridViewAutoSizeRowsMode.DisplayedCellsExceptHeaders;
			for (int i = 0; i < columns.Length; i++)
			{
				dataGridView.Columns[i].Name = columns[i];
				dataGridView.Columns[i].DisplayIndex = i;
				dataGridView.Columns[i].Width = 240;
			}
		}

		private void SetupLayout()
		{

		}
	}
}