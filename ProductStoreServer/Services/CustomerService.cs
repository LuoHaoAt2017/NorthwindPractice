using System.Data;
using NorthwindServer.Common;
using NorthwindServer.Models;

namespace NorthwindServer.Services
{
	public class CustomerService
	{
		public List<Customer> GetCustomerList()
		{
			string conStr = "server=192.168.0.193;database=northwind;uid=tomcat;pwd=LuoHao123";
			string sqlStr = "select * from Customers";
			DataTable dt = DBHelper.ExecuteSql(DefaultDB.SQLServer, sqlStr, conStr);

			List<Customer> list = new List<Customer>();

			if (dt != null && dt.Rows.Count > 0)
			{
				foreach (DataRow row in dt.Rows)
				{
					Customer customer = new Customer();
					customer.CustomerId = GetFieldValue(row, "CustomerId");
					customer.CustomerName = GetFieldValue(row, "CustomerName");
					// customer.CompanyName = GetFieldValue(row, "CompanyName");
					customer.ContactName = GetFieldValue(row, "ContactName");
					//customer.ContactTitle = GetFieldValue(row, "ContactTitle");
					customer.Address = GetFieldValue(row, "Address");
					customer.City = GetFieldValue(row, "City");
					//customer.Region = GetFieldValue(row, "Region");
					customer.PostalCode = GetFieldValue(row, "PostalCode");
					// customer.Phone = GetFieldValue(row, "Phone");
					customer.Country = GetFieldValue(row, "Country");
					//customer.Fax = GetFieldValue(row, "Fax");
					list.Add(customer);
				}
			}

			return list;
		}

		private string GetFieldValue(DataRow row, string field)
		{
			if (row == null || string.IsNullOrEmpty(field))
			{
				return "";
			}
			if (row[field] == null)
			{
				return "";
			}
			return row[field].ToString();
		}
	}
}
