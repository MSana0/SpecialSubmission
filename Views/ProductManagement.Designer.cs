namespace ProductSpecialSubmission.Views
{
    partial class ProductManagement
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
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
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.Name = new System.Windows.Forms.Button();
            this.Type = new System.Windows.Forms.Button();
            this.Price = new System.Windows.Forms.Button();
            this.Quantity = new System.Windows.Forms.Button();
            this.tBName = new System.Windows.Forms.TextBox();
            this.tBType = new System.Windows.Forms.TextBox();
            this.tBPrice = new System.Windows.Forms.TextBox();
            this.tBQuantity = new System.Windows.Forms.TextBox();
            this.Up = new System.Windows.Forms.Button();
            this.Remove = new System.Windows.Forms.Button();
            this.Add = new System.Windows.Forms.Button();
            this.Show = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.SuspendLayout();
            // 
            // dataGridView1
            // 
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Location = new System.Drawing.Point(70, 266);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.RowHeadersWidth = 51;
            this.dataGridView1.RowTemplate.Height = 24;
            this.dataGridView1.Size = new System.Drawing.Size(657, 150);
            this.dataGridView1.TabIndex = 0;
            // 
            // Name
            // 
            this.Name.Location = new System.Drawing.Point(70, 41);
            this.Name.Name = "Name";
            this.Name.Size = new System.Drawing.Size(127, 23);
            this.Name.TabIndex = 1;
            this.Name.Text = "Product Name";
            this.Name.UseVisualStyleBackColor = true;
            this.Name.Click += new System.EventHandler(this.Add_Click_1);
            // 
            // Type
            // 
            this.Type.Location = new System.Drawing.Point(70, 87);
            this.Type.Name = "Type";
            this.Type.Size = new System.Drawing.Size(127, 23);
            this.Type.TabIndex = 2;
            this.Type.Text = "Product Type";
            this.Type.UseVisualStyleBackColor = true;
            // 
            // Price
            // 
            this.Price.Location = new System.Drawing.Point(70, 131);
            this.Price.Name = "Price";
            this.Price.Size = new System.Drawing.Size(127, 23);
            this.Price.TabIndex = 3;
            this.Price.Text = "Product Price";
            this.Price.UseVisualStyleBackColor = true;
            // 
            // Quantity
            // 
            this.Quantity.Location = new System.Drawing.Point(70, 180);
            this.Quantity.Name = "Quantity";
            this.Quantity.Size = new System.Drawing.Size(127, 23);
            this.Quantity.TabIndex = 4;
            this.Quantity.Text = "Product Quantity";
            this.Quantity.UseVisualStyleBackColor = true;
            // 
            // tBName
            // 
            this.tBName.Location = new System.Drawing.Point(226, 42);
            this.tBName.Name = "tBName";
            this.tBName.Size = new System.Drawing.Size(497, 22);
            this.tBName.TabIndex = 5;
            // 
            // tBType
            // 
            this.tBType.Location = new System.Drawing.Point(226, 87);
            this.tBType.Name = "tBType";
            this.tBType.Size = new System.Drawing.Size(497, 22);
            this.tBType.TabIndex = 6;
            // 
            // tBPrice
            // 
            this.tBPrice.Location = new System.Drawing.Point(226, 132);
            this.tBPrice.Name = "tBPrice";
            this.tBPrice.Size = new System.Drawing.Size(497, 22);
            this.tBPrice.TabIndex = 7;
            // 
            // tBQuantity
            // 
            this.tBQuantity.Location = new System.Drawing.Point(226, 180);
            this.tBQuantity.Name = "tBQuantity";
            this.tBQuantity.Size = new System.Drawing.Size(497, 22);
            this.tBQuantity.TabIndex = 8;
            // 
            // Up
            // 
            this.Up.Location = new System.Drawing.Point(460, 227);
            this.Up.Name = "Up";
            this.Up.Size = new System.Drawing.Size(127, 23);
            this.Up.TabIndex = 9;
            this.Up.Text = "Modify Product";
            this.Up.UseVisualStyleBackColor = true;
            // 
            // Remove
            // 
            this.Remove.Location = new System.Drawing.Point(327, 227);
            this.Remove.Name = "Remove";
            this.Remove.Size = new System.Drawing.Size(127, 23);
            this.Remove.TabIndex = 10;
            this.Remove.Text = "Remove Product";
            this.Remove.UseVisualStyleBackColor = true;
            // 
            // Add
            // 
            this.Add.Location = new System.Drawing.Point(194, 227);
            this.Add.Name = "Add";
            this.Add.Size = new System.Drawing.Size(127, 23);
            this.Add.TabIndex = 11;
            this.Add.Text = "Add Product";
            this.Add.UseVisualStyleBackColor = true;
            this.Add.Click += new System.EventHandler(this.Add_Click_1);
            // 
            // Show
            // 
            this.Show.Location = new System.Drawing.Point(291, 435);
            this.Show.Name = "Show";
            this.Show.Size = new System.Drawing.Size(163, 23);
            this.Show.TabIndex = 12;
            this.Show.Text = "Show All Products";
            this.Show.UseVisualStyleBackColor = true;
            // 
            // ProductManagement
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 491);
            this.Controls.Add(this.Show);
            this.Controls.Add(this.Add);
            this.Controls.Add(this.Remove);
            this.Controls.Add(this.Up);
            this.Controls.Add(this.tBQuantity);
            this.Controls.Add(this.tBPrice);
            this.Controls.Add(this.tBType);
            this.Controls.Add(this.tBName);
            this.Controls.Add(this.Quantity);
            this.Controls.Add(this.Price);
            this.Controls.Add(this.Type);
            this.Controls.Add(this.Name);
            this.Controls.Add(this.dataGridView1);
            this.Name = "ProductManagement";
            this.Text = "ProductManagement";
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.Button Name;
        private System.Windows.Forms.Button Type;
        private System.Windows.Forms.Button Price;
        private System.Windows.Forms.Button Quantity;
        private System.Windows.Forms.TextBox tBName;
        private System.Windows.Forms.TextBox tBType;
        private System.Windows.Forms.TextBox tBPrice;
        private System.Windows.Forms.TextBox tBQuantity;
        private System.Windows.Forms.Button Up;
        private System.Windows.Forms.Button Remove;
        private System.Windows.Forms.Button Add;
        private System.Windows.Forms.Button Show;
    }
}