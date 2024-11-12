using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;
using System.Data.SqlClient;
using EntityF.Model;
using Microsoft.Data.SqlClient;

namespace EntityF
{
	public class AdoNetDemo
	{

		public const string connectionString = "Server=.;Database=Northwind;Trusted_Connection=True;";

		public void SelectProducts()
		{
			SqlConnection conn = new SqlConnection(connectionString);
			if (conn.State != ConnectionState.Open)
			{
				conn.Open();
			}
			
			SqlCommand cmd = new SqlCommand("SELECT * FROM Products", conn);
			var dt = new DataTable();
			using (var da = new SqlDataAdapter(cmd))
			{
				da.Fill(dt);
			}

			foreach (DataRow row in dt.Rows)
			{
				int productId = Convert.ToInt32(row[0]);
				string productName = row[1].ToString();
				double unitPrice = Convert.ToDouble(row[5]);


				Console.WriteLine($"{productId} {productName} {unitPrice}");
			}

			conn.Close();
			Console.ReadKey();
		}

		public void SelectProductsDataReader()
		{
			SqlConnection conn = new SqlConnection(connectionString);
			if (conn.State != ConnectionState.Open)
			{
				conn.Open();
			}

			SqlCommand cmd = new SqlCommand("SELECT * FROM Products", conn);

			SqlDataReader dr = cmd.ExecuteReader();
			while (dr.Read())
			{
				int productId = Convert.ToInt32(dr[0]);
				string productName = dr[1].ToString();
				double unitPrice = Convert.ToDouble(dr[5]);
				Console.WriteLine($"{productId} {productName} {unitPrice}");
			}
			conn.Close();
			Console.ReadKey();

		}

		public void UpdateProduct(int productId, string newUpdate)
		{
			SqlConnection conn = new SqlConnection(connectionString);
			if (conn.State != ConnectionState.Open)
			{
				conn.Open();
			}

			SqlCommand cmd = new SqlCommand($"UPDATE Products SET ProductName = '{newUpdate}' WHERE ProductId = {productId}", conn);
			cmd.ExecuteNonQuery();
			Console.WriteLine($"Row updated with {newUpdate}");

			conn.Close();
			Console.ReadKey();
		}
		public void InsertProduct(Product product)
		{
			SqlConnection conn = new SqlConnection(connectionString);
			if (conn.State != ConnectionState.Open)
			{
				conn.Open();
			}
			
			string InsertQuery = $"INSERT INTO Products (ProductId, ProductName,SupplierID, QuantityPerUnit," +
			                     $"UnitPrice, UnitsInStock, ReorderLevel, Discontinued) VALUES {product.ProductID}," +
			                     $" '{product.ProductName}', .......";
			SqlCommand cmd = new SqlCommand( InsertQuery, conn);
			cmd.ExecuteNonQuery();
			

			conn.Close();
			Console.ReadKey();
		}

		public void DeleteProduct(int ProductID)
		{
			SqlConnection conn = new SqlConnection(connectionString);
			if (conn.State != ConnectionState.Open)
			{
				conn.Open();
			}

			string DeleteQuery = $"Delete from Products where ProductId = {ProductID}";
			SqlCommand cmd = new SqlCommand(DeleteQuery, conn);
			cmd.ExecuteNonQuery();


			conn.Close();
			Console.ReadKey();
		}
	}
}
