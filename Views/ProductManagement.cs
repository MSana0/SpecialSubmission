using System;
using System.Collections;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using ProductSpecialSubmission.Controllers;
//using ProductSpecialSubmission.Models;

namespace ProductSpecialSubmission.Views
{
    public partial class ProductManagement : Form
    {
        public ProductManagement()
        {
            InitializeComponent();
            gridProducts.DataSource = ProductController.GetAllProducts();
        }
        /*
        private void Add_Click(object sender, EventArgs e)
        {
            var product = new
            {
                Product_Name = tBAdd.Text;
                Product_Type = tBMod.Text;
            }
        */
        private void Add_Click_1(object sender, EventArgs e)
        {
            var product = new
            {
            Product_Name = tBName.Text,
            Product_Type = tBType.Text,
            //Product_Price = tBPrice.Text,
            //Product_Quantity = tBQuantity.Text
        };
            var r = ProductController.AddProduct(product);
            if(r)
            {
                MessageBox.Show("Product added");
            }
            else
            {
                MessageBox.Show("Product not added");
            }
        }

        private void Search_Click(object sender, EventArgs e)
        {
            dynamic product = ProductController.GetProduct(Search.Text);
            if(product!=null)
            {
                tBName.Text = product.Product_Name;
                tBType.Text = product.Product_Type;
                //tBPrice.Text = product.Product_Price;
                //tBQuantity.Text = product.Product_Quantity;

            }
            else
            {
                tBName.Text = "";
                tBType.Text = "";
                MessageBox.Show("can't find the product");
            }

        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void Up_Click(object sender, EventArgs e)
        {
            var product = new { 
                Product_Name = tBName.Text,
                Product_Type = tBType.Text

            };
            var r = ProductController.ModifyProduct(product);
            if (r)
            {
                MessageBox.Show("Successfully modified product.");
            }
            else
            {
                MessageBox.Show("Couldn't modify product");
            }
        }

        private void Remove_Click(object sender, EventArgs e)
        {
            var r = ProductController.RemoveProduct(tBName.Text);
            if (r)
            {
                tBName.Text = "";
                tBType.Text = "";
                MessageBox.Show("Successfully removed product.");

            }
            else
            {
                tBName.Text = "";
                tBType.Text = "";
                MessageBox.Show("can't remove the product");
            }
        }
    }
}
