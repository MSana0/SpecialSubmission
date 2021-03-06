﻿using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using ProductSpecialSubmission.Models;
//using ProductSpecialSubmission.Views;

namespace ProductSpecialSubmission.Controllers
{
    public class ProductController
    {
        static Database db = new Database();
        public static bool AddProduct(dynamic p)
        {
            Product product = new Product();
            product.Product_Name = p.Product_Name;
            product.Product_Type = p.Product_Type;
            //product.Product_Price = p.Product_Price;
            //product.Product_Quantity = p.Product_Quantity;
            return db.Products.AddProduct(product);
        }
        public static Product GetProduct(string product_Name)
        {
            return db.Products.GetProduct(product_Name);
        }
        public static bool ModifyProduct(dynamic p)
        {
            Product product = new Product();
            product.Product_Name = p.Product_Name;
            product.Product_Type = p.Product_Type;
            return db.Products.ModifyProduct(product);
        }
        public static bool RemoveProduct(string product_Name)
        {
            return db.Products.RemoveProduct(product_Name);
        }
        public static ArrayList GetAllProducts()
        {
            return db.Products.GetAllProducts();
        }
    }
}
