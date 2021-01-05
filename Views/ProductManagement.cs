using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ProductSpecialSubmission.Views
{
    public partial class ProductManagement : Form
    {
        public ProductManagement()
        {
            InitializeComponent();
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
            Product_Price = tBPrice.Text,
            Product_Quantity = tBQuantity.Text
        };
            bool r = ProductController.AddProduct(product);
            if(r)
            {
                MessageBox.Show("Product added");
            }
            else
            {
                MessageBox.Show("Product not added");
            }
        }
    }
    }
