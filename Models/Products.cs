using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SqlClient;
using System.Collections;
using ProductSpecialSubmission.Views;
//using ProductSpecialSubmission.Controllers;

namespace ProductSpecialSubmission.Models
{
    public class Products
    {
        SqlConnection conn;
        public Products(SqlConnection conn)
        {
            this.conn = conn;
        }
        public bool AddProduct(Product product)
        {
            conn.Open();
            string query = string.Format("INSERT INTO Products VALUES ('{0}','{1}')", product.Product_Name, product.Product_Type);
            SqlCommand cmd = new SqlCommand(query, conn);
            int r = cmd.ExecuteNonQuery();
            conn.Close();
            if (r > 0)
                return true;
            return false;
            //conn.Close();
        }
        public ArrayList GetAllProducts()
        {
            ArrayList products = new ArrayList();
            conn.Open();
            string query = "SELECT * FROM Products";
            SqlCommand cmd = new SqlCommand(query, conn);
            SqlDataReader reader = cmd.ExecuteReader();
            while(reader.Read())
            {
                Product product = new Product();
                product = new Product();
                //product.PId = reader.GetInt32(reader.GetOrdinal("PId"));
                product.Product_Name = reader.GetString(reader.GetOrdinal("Product_Name"));
                product.Product_Type = reader.GetString(reader.GetOrdinal("Product_Type"));
                //product.Product_Price = reader.GetString(reader.GetOrdinal("Product_Price"));
                //product.Product_Quantity = reader.GetString(reader.GetOrdinal("Produc_Quantity"));
                products.Add(product);
            }
            conn.Close();
            return products;
        }
        public Product GetProduct(string product_Name)
        {
            conn.Open();
            string query = String.Format("SELECT * FROM Products WHERE Product_Name = '{0}'",product_Name);
            SqlCommand cmd = new SqlCommand(query, conn);
            SqlDataReader reader = cmd.ExecuteReader();
            Product product = null;
            while (reader.Read())
            {
                product = new Product();
                //product.PId = reader.GetInt32(reader.GetOrdinal("PId"));
                product.Product_Name = reader.GetString(reader.GetOrdinal("Product_Name"));
                product.Product_Type = reader.GetString(reader.GetOrdinal("Product_Type"));
                //product.Product_Price = reader.GetString(reader.GetOrdinal("Product_Price"));
                //product.Product_Quantity = reader.GetString(reader.GetOrdinal("Produc_Quantity"));
            }
            conn.Close();
            return product;
        }
        public bool ModifyProduct(Product product)
        {
            conn.Open();
            string query = String.Format("UPDATE Products SET Product_Type='{0}' WHERE product_Name='{1}'", product.Product_Type, product.Product_Name);
            SqlCommand cmd = new SqlCommand(query, conn);
            int r = cmd.ExecuteNonQuery();
            conn.Close();
            if (r > 0) return true;
            return false;
        }
        public bool RemoveProduct(string product_Name)
        {
            conn.Open();
            string query = String.Format("DELETE FROM Products WHERE product_Name='{1}'", product_Name);
            SqlCommand cmd = new SqlCommand(query, conn);
            int r = cmd.ExecuteNonQuery();
            conn.Close();
            if (r > 0) return true;
            return false;
        }

    }
}
