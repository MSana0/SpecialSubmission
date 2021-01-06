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
            this.gridProducts = new System.Windows.Forms.DataGridView();
            this.tBName = new System.Windows.Forms.TextBox();
            this.tBType = new System.Windows.Forms.TextBox();
            this.Up = new System.Windows.Forms.Button();
            this.Remove = new System.Windows.Forms.Button();
            this.Add = new System.Windows.Forms.Button();
            this.Show = new System.Windows.Forms.Button();
            this.Search = new System.Windows.Forms.Button();
            this.label = new System.Windows.Forms.Label();
            this.Type = new System.Windows.Forms.Label();
            this.Name = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.gridProducts)).BeginInit();
            this.SuspendLayout();
            // 
            // gridProducts
            // 
            this.gridProducts.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.gridProducts.Location = new System.Drawing.Point(70, 202);
            this.gridProducts.Name = "gridProducts";
            this.gridProducts.RowHeadersWidth = 51;
            this.gridProducts.RowTemplate.Height = 24;
            this.gridProducts.Size = new System.Drawing.Size(657, 201);
            this.gridProducts.TabIndex = 0;
            this.gridProducts.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView1_CellContentClick);
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
            // Up
            // 
            this.Up.Location = new System.Drawing.Point(411, 146);
            this.Up.Name = "Up";
            this.Up.Size = new System.Drawing.Size(127, 23);
            this.Up.TabIndex = 9;
            this.Up.Text = "Modify Product";
            this.Up.UseVisualStyleBackColor = true;
            this.Up.Click += new System.EventHandler(this.Up_Click);
            // 
            // Remove
            // 
            this.Remove.Location = new System.Drawing.Point(278, 146);
            this.Remove.Name = "Remove";
            this.Remove.Size = new System.Drawing.Size(127, 23);
            this.Remove.TabIndex = 10;
            this.Remove.Text = "Remove Product";
            this.Remove.UseVisualStyleBackColor = true;
            this.Remove.Click += new System.EventHandler(this.Remove_Click);
            // 
            // Add
            // 
            this.Add.Location = new System.Drawing.Point(145, 146);
            this.Add.Name = "Add";
            this.Add.Size = new System.Drawing.Size(127, 23);
            this.Add.TabIndex = 11;
            this.Add.Text = "Add Product";
            this.Add.UseVisualStyleBackColor = true;
            this.Add.Click += new System.EventHandler(this.Add_Click_1);
            // 
            // Show
            // 
            this.Show.Location = new System.Drawing.Point(292, 424);
            this.Show.Name = "Show";
            this.Show.Size = new System.Drawing.Size(163, 23);
            this.Show.TabIndex = 12;
            this.Show.Text = "Show All Products";
            this.Show.UseVisualStyleBackColor = true;
            // 
            // Search
            // 
            this.Search.Location = new System.Drawing.Point(544, 146);
            this.Search.Name = "Search";
            this.Search.Size = new System.Drawing.Size(127, 23);
            this.Search.TabIndex = 13;
            this.Search.Text = "Search Product";
            this.Search.UseVisualStyleBackColor = true;
            this.Search.Click += new System.EventHandler(this.Search_Click);
            // 
            // label
            // 
            this.label.AutoSize = true;
            this.label.Location = new System.Drawing.Point(336, 9);
            this.label.Name = "label";
            this.label.Size = new System.Drawing.Size(139, 17);
            this.label.TabIndex = 14;
            this.label.Text = "ProductManagement";
            // 
            // Type
            // 
            this.Type.AutoSize = true;
            this.Type.Location = new System.Drawing.Point(86, 87);
            this.Type.Name = "Type";
            this.Type.Size = new System.Drawing.Size(93, 17);
            this.Type.TabIndex = 15;
            this.Type.Text = "Product Type";
            // 
            // Name
            // 
            this.Name.AutoSize = true;
            this.Name.Location = new System.Drawing.Point(86, 42);
            this.Name.Name = "Name";
            this.Name.Size = new System.Drawing.Size(98, 17);
            this.Name.TabIndex = 16;
            this.Name.Text = "Product Name";
            // 
            // ProductManagement
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 491);
            this.Controls.Add(this.Name);
            this.Controls.Add(this.Type);
            this.Controls.Add(this.label);
            this.Controls.Add(this.Search);
            this.Controls.Add(this.Show);
            this.Controls.Add(this.Add);
            this.Controls.Add(this.Remove);
            this.Controls.Add(this.Up);
            this.Controls.Add(this.tBType);
            this.Controls.Add(this.tBName);
            this.Controls.Add(this.gridProducts);
            //this.Name.Text = "Product Name";
            ((System.ComponentModel.ISupportInitialize)(this.gridProducts)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView gridProducts;
        private System.Windows.Forms.TextBox tBName;
        private System.Windows.Forms.TextBox tBType;
        private System.Windows.Forms.Button Up;
        private System.Windows.Forms.Button Remove;
        private System.Windows.Forms.Button Add;
        private System.Windows.Forms.Button Show;
        private System.Windows.Forms.Button Search;
        private System.Windows.Forms.Label label;
        private System.Windows.Forms.Label Type;
        private System.Windows.Forms.Label Name;
    }
}