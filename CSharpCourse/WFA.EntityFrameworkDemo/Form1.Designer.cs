namespace WFA.EntityFrameworkDemo
{
    partial class Form1
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
            this.lblSearch = new System.Windows.Forms.Label();
            this.tbxUptStock = new System.Windows.Forms.TextBox();
            this.btnUpdate = new System.Windows.Forms.Button();
            this.lblUptStock = new System.Windows.Forms.Label();
            this.tbxSearch = new System.Windows.Forms.TextBox();
            this.lblUptUnitPrice = new System.Windows.Forms.Label();
            this.groupUpdate = new System.Windows.Forms.GroupBox();
            this.btnDelete = new System.Windows.Forms.Button();
            this.tbxUptUPrice = new System.Windows.Forms.TextBox();
            this.groupAddProduct = new System.Windows.Forms.GroupBox();
            this.lblName = new System.Windows.Forms.Label();
            this.tbxStock = new System.Windows.Forms.TextBox();
            this.btnAdd = new System.Windows.Forms.Button();
            this.lblStockAmount = new System.Windows.Forms.Label();
            this.tbxName = new System.Windows.Forms.TextBox();
            this.tbxUnitPrice = new System.Windows.Forms.TextBox();
            this.lblUnitPrice = new System.Windows.Forms.Label();
            this.dgwProducts = new System.Windows.Forms.DataGridView();
            this.groupUpdate.SuspendLayout();
            this.groupAddProduct.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgwProducts)).BeginInit();
            this.SuspendLayout();
            // 
            // lblSearch
            // 
            this.lblSearch.AutoSize = true;
            this.lblSearch.Location = new System.Drawing.Point(262, 280);
            this.lblSearch.Name = "lblSearch";
            this.lblSearch.Size = new System.Drawing.Size(53, 17);
            this.lblSearch.TabIndex = 2;
            this.lblSearch.Text = "Search";
            // 
            // tbxUptStock
            // 
            this.tbxUptStock.Location = new System.Drawing.Point(129, 128);
            this.tbxUptStock.Name = "tbxUptStock";
            this.tbxUptStock.Size = new System.Drawing.Size(100, 27);
            this.tbxUptStock.TabIndex = 7;
            // 
            // btnUpdate
            // 
            this.btnUpdate.Location = new System.Drawing.Point(129, 161);
            this.btnUpdate.Name = "btnUpdate";
            this.btnUpdate.Size = new System.Drawing.Size(100, 66);
            this.btnUpdate.TabIndex = 1;
            this.btnUpdate.Text = "Update";
            this.btnUpdate.UseVisualStyleBackColor = true;
            this.btnUpdate.Click += new System.EventHandler(this.btnUpdate_Click);
            // 
            // lblUptStock
            // 
            this.lblUptStock.AutoSize = true;
            this.lblUptStock.Location = new System.Drawing.Point(6, 131);
            this.lblUptStock.Name = "lblUptStock";
            this.lblUptStock.Size = new System.Drawing.Size(105, 19);
            this.lblUptStock.TabIndex = 6;
            this.lblUptStock.Text = "Stock Amount";
            // 
            // tbxSearch
            // 
            this.tbxSearch.Location = new System.Drawing.Point(265, 300);
            this.tbxSearch.Name = "tbxSearch";
            this.tbxSearch.Size = new System.Drawing.Size(77, 22);
            this.tbxSearch.TabIndex = 3;
            this.tbxSearch.TextChanged += new System.EventHandler(this.tbxSearch_TextChanged);
            // 
            // lblUptUnitPrice
            // 
            this.lblUptUnitPrice.AutoSize = true;
            this.lblUptUnitPrice.Location = new System.Drawing.Point(6, 83);
            this.lblUptUnitPrice.Name = "lblUptUnitPrice";
            this.lblUptUnitPrice.Size = new System.Drawing.Size(80, 19);
            this.lblUptUnitPrice.TabIndex = 4;
            this.lblUptUnitPrice.Text = "Unit Price";
            // 
            // groupUpdate
            // 
            this.groupUpdate.AutoSize = true;
            this.groupUpdate.BackColor = System.Drawing.SystemColors.InactiveCaption;
            this.groupUpdate.Controls.Add(this.tbxUptStock);
            this.groupUpdate.Controls.Add(this.btnDelete);
            this.groupUpdate.Controls.Add(this.btnUpdate);
            this.groupUpdate.Controls.Add(this.lblUptStock);
            this.groupUpdate.Controls.Add(this.tbxUptUPrice);
            this.groupUpdate.Controls.Add(this.lblUptUnitPrice);
            this.groupUpdate.Font = new System.Drawing.Font("Times New Roman", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.groupUpdate.Location = new System.Drawing.Point(396, 280);
            this.groupUpdate.Name = "groupUpdate";
            this.groupUpdate.Size = new System.Drawing.Size(244, 262);
            this.groupUpdate.TabIndex = 11;
            this.groupUpdate.TabStop = false;
            this.groupUpdate.Text = "Update a Product";
            // 
            // btnDelete
            // 
            this.btnDelete.Location = new System.Drawing.Point(6, 162);
            this.btnDelete.Name = "btnDelete";
            this.btnDelete.Size = new System.Drawing.Size(100, 66);
            this.btnDelete.TabIndex = 1;
            this.btnDelete.Text = "Remove";
            this.btnDelete.UseVisualStyleBackColor = true;
            this.btnDelete.Click += new System.EventHandler(this.btnDelete_Click);
            // 
            // tbxUptUPrice
            // 
            this.tbxUptUPrice.Location = new System.Drawing.Point(129, 80);
            this.tbxUptUPrice.Name = "tbxUptUPrice";
            this.tbxUptUPrice.Size = new System.Drawing.Size(100, 27);
            this.tbxUptUPrice.TabIndex = 5;
            // 
            // groupAddProduct
            // 
            this.groupAddProduct.AutoSize = true;
            this.groupAddProduct.BackColor = System.Drawing.SystemColors.Info;
            this.groupAddProduct.Controls.Add(this.lblName);
            this.groupAddProduct.Controls.Add(this.tbxStock);
            this.groupAddProduct.Controls.Add(this.btnAdd);
            this.groupAddProduct.Controls.Add(this.lblStockAmount);
            this.groupAddProduct.Controls.Add(this.tbxName);
            this.groupAddProduct.Controls.Add(this.tbxUnitPrice);
            this.groupAddProduct.Controls.Add(this.lblUnitPrice);
            this.groupAddProduct.Font = new System.Drawing.Font("Times New Roman", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.groupAddProduct.Location = new System.Drawing.Point(12, 280);
            this.groupAddProduct.Name = "groupAddProduct";
            this.groupAddProduct.Size = new System.Drawing.Size(244, 273);
            this.groupAddProduct.TabIndex = 10;
            this.groupAddProduct.TabStop = false;
            this.groupAddProduct.Text = "Add a Product";
            // 
            // lblName
            // 
            this.lblName.AutoSize = true;
            this.lblName.Location = new System.Drawing.Point(6, 40);
            this.lblName.Name = "lblName";
            this.lblName.Size = new System.Drawing.Size(49, 19);
            this.lblName.TabIndex = 2;
            this.lblName.Text = "Name";
            // 
            // tbxStock
            // 
            this.tbxStock.Location = new System.Drawing.Point(129, 128);
            this.tbxStock.Name = "tbxStock";
            this.tbxStock.Size = new System.Drawing.Size(100, 27);
            this.tbxStock.TabIndex = 7;
            // 
            // btnAdd
            // 
            this.btnAdd.Location = new System.Drawing.Point(129, 181);
            this.btnAdd.Name = "btnAdd";
            this.btnAdd.Size = new System.Drawing.Size(100, 66);
            this.btnAdd.TabIndex = 1;
            this.btnAdd.Text = "Add";
            this.btnAdd.UseVisualStyleBackColor = true;
            this.btnAdd.Click += new System.EventHandler(this.btnAdd_Click);
            // 
            // lblStockAmount
            // 
            this.lblStockAmount.AutoSize = true;
            this.lblStockAmount.Location = new System.Drawing.Point(6, 131);
            this.lblStockAmount.Name = "lblStockAmount";
            this.lblStockAmount.Size = new System.Drawing.Size(105, 19);
            this.lblStockAmount.TabIndex = 6;
            this.lblStockAmount.Text = "Stock Amount";
            // 
            // tbxName
            // 
            this.tbxName.Location = new System.Drawing.Point(129, 37);
            this.tbxName.Name = "tbxName";
            this.tbxName.Size = new System.Drawing.Size(100, 27);
            this.tbxName.TabIndex = 3;
            // 
            // tbxUnitPrice
            // 
            this.tbxUnitPrice.Location = new System.Drawing.Point(129, 80);
            this.tbxUnitPrice.Name = "tbxUnitPrice";
            this.tbxUnitPrice.Size = new System.Drawing.Size(100, 27);
            this.tbxUnitPrice.TabIndex = 5;
            // 
            // lblUnitPrice
            // 
            this.lblUnitPrice.AutoSize = true;
            this.lblUnitPrice.Location = new System.Drawing.Point(6, 83);
            this.lblUnitPrice.Name = "lblUnitPrice";
            this.lblUnitPrice.Size = new System.Drawing.Size(80, 19);
            this.lblUnitPrice.TabIndex = 4;
            this.lblUnitPrice.Text = "Unit Price";
            // 
            // dgwProducts
            // 
            this.dgwProducts.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgwProducts.Location = new System.Drawing.Point(12, 12);
            this.dgwProducts.Name = "dgwProducts";
            this.dgwProducts.RowHeadersWidth = 51;
            this.dgwProducts.RowTemplate.Height = 24;
            this.dgwProducts.Size = new System.Drawing.Size(628, 262);
            this.dgwProducts.TabIndex = 9;
            this.dgwProducts.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgwProducts_CellClick);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(659, 565);
            this.Controls.Add(this.lblSearch);
            this.Controls.Add(this.groupUpdate);
            this.Controls.Add(this.groupAddProduct);
            this.Controls.Add(this.dgwProducts);
            this.Controls.Add(this.tbxSearch);
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.groupUpdate.ResumeLayout(false);
            this.groupUpdate.PerformLayout();
            this.groupAddProduct.ResumeLayout(false);
            this.groupAddProduct.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgwProducts)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblSearch;
        private System.Windows.Forms.TextBox tbxUptStock;
        private System.Windows.Forms.Button btnUpdate;
        private System.Windows.Forms.Label lblUptStock;
        private System.Windows.Forms.TextBox tbxSearch;
        private System.Windows.Forms.Label lblUptUnitPrice;
        private System.Windows.Forms.GroupBox groupUpdate;
        private System.Windows.Forms.Button btnDelete;
        private System.Windows.Forms.TextBox tbxUptUPrice;
        private System.Windows.Forms.GroupBox groupAddProduct;
        private System.Windows.Forms.Label lblName;
        private System.Windows.Forms.TextBox tbxStock;
        private System.Windows.Forms.Label lblStockAmount;
        private System.Windows.Forms.TextBox tbxName;
        private System.Windows.Forms.TextBox tbxUnitPrice;
        private System.Windows.Forms.Label lblUnitPrice;
        private System.Windows.Forms.DataGridView dgwProducts;
        private System.Windows.Forms.Button btnAdd;
    }
}

