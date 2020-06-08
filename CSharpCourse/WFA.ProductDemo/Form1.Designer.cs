namespace WFA.ProductDemo
{
    partial class frmMain
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
            this.dgwProducts = new System.Windows.Forms.DataGridView();
            this.btnDelete = new System.Windows.Forms.Button();
            this.lblName = new System.Windows.Forms.Label();
            this.tbxName = new System.Windows.Forms.TextBox();
            this.tbxUnitPrice = new System.Windows.Forms.TextBox();
            this.lblUnitPrice = new System.Windows.Forms.Label();
            this.tbxStock = new System.Windows.Forms.TextBox();
            this.lblStockAmount = new System.Windows.Forms.Label();
            this.groupAddProduct = new System.Windows.Forms.GroupBox();
            this.groupUpdate = new System.Windows.Forms.GroupBox();
            this.lblUptName = new System.Windows.Forms.Label();
            this.tbxUptStock = new System.Windows.Forms.TextBox();
            this.btnUpdate = new System.Windows.Forms.Button();
            this.lblUptStock = new System.Windows.Forms.Label();
            this.tbxUptName = new System.Windows.Forms.TextBox();
            this.tbxUptUPrice = new System.Windows.Forms.TextBox();
            this.lblUptUnitPrice = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.dgwProducts)).BeginInit();
            this.groupAddProduct.SuspendLayout();
            this.groupUpdate.SuspendLayout();
            this.SuspendLayout();
            // 
            // dgwProducts
            // 
            this.dgwProducts.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgwProducts.Location = new System.Drawing.Point(12, 12);
            this.dgwProducts.Name = "dgwProducts";
            this.dgwProducts.RowHeadersWidth = 51;
            this.dgwProducts.RowTemplate.Height = 24;
            this.dgwProducts.Size = new System.Drawing.Size(628, 262);
            this.dgwProducts.TabIndex = 0;
            this.dgwProducts.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgwProducts_CellClick);
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
            // lblName
            // 
            this.lblName.AutoSize = true;
            this.lblName.Location = new System.Drawing.Point(6, 40);
            this.lblName.Name = "lblName";
            this.lblName.Size = new System.Drawing.Size(49, 19);
            this.lblName.TabIndex = 2;
            this.lblName.Text = "Name";
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
            // tbxStock
            // 
            this.tbxStock.Location = new System.Drawing.Point(129, 128);
            this.tbxStock.Name = "tbxStock";
            this.tbxStock.Size = new System.Drawing.Size(100, 27);
            this.tbxStock.TabIndex = 7;
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
            // groupAddProduct
            // 
            this.groupAddProduct.AutoSize = true;
            this.groupAddProduct.BackColor = System.Drawing.SystemColors.Info;
            this.groupAddProduct.Controls.Add(this.lblName);
            this.groupAddProduct.Controls.Add(this.tbxStock);
            this.groupAddProduct.Controls.Add(this.lblStockAmount);
            this.groupAddProduct.Controls.Add(this.tbxName);
            this.groupAddProduct.Controls.Add(this.tbxUnitPrice);
            this.groupAddProduct.Controls.Add(this.lblUnitPrice);
            this.groupAddProduct.Font = new System.Drawing.Font("Times New Roman", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.groupAddProduct.Location = new System.Drawing.Point(12, 280);
            this.groupAddProduct.Name = "groupAddProduct";
            this.groupAddProduct.Size = new System.Drawing.Size(244, 262);
            this.groupAddProduct.TabIndex = 8;
            this.groupAddProduct.TabStop = false;
            this.groupAddProduct.Text = "Add a Product";
            // 
            // groupUpdate
            // 
            this.groupUpdate.AutoSize = true;
            this.groupUpdate.BackColor = System.Drawing.SystemColors.InactiveCaption;
            this.groupUpdate.Controls.Add(this.lblUptName);
            this.groupUpdate.Controls.Add(this.tbxUptStock);
            this.groupUpdate.Controls.Add(this.btnDelete);
            this.groupUpdate.Controls.Add(this.btnUpdate);
            this.groupUpdate.Controls.Add(this.lblUptStock);
            this.groupUpdate.Controls.Add(this.tbxUptName);
            this.groupUpdate.Controls.Add(this.tbxUptUPrice);
            this.groupUpdate.Controls.Add(this.lblUptUnitPrice);
            this.groupUpdate.Font = new System.Drawing.Font("Times New Roman", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.groupUpdate.Location = new System.Drawing.Point(396, 280);
            this.groupUpdate.Name = "groupUpdate";
            this.groupUpdate.Size = new System.Drawing.Size(244, 262);
            this.groupUpdate.TabIndex = 8;
            this.groupUpdate.TabStop = false;
            this.groupUpdate.Text = "Update a Product";
            // 
            // lblUptName
            // 
            this.lblUptName.AutoSize = true;
            this.lblUptName.Location = new System.Drawing.Point(6, 40);
            this.lblUptName.Name = "lblUptName";
            this.lblUptName.Size = new System.Drawing.Size(49, 19);
            this.lblUptName.TabIndex = 2;
            this.lblUptName.Text = "Name";
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
            // tbxUptName
            // 
            this.tbxUptName.Location = new System.Drawing.Point(129, 37);
            this.tbxUptName.Name = "tbxUptName";
            this.tbxUptName.Size = new System.Drawing.Size(100, 27);
            this.tbxUptName.TabIndex = 3;
            // 
            // tbxUptUPrice
            // 
            this.tbxUptUPrice.Location = new System.Drawing.Point(129, 80);
            this.tbxUptUPrice.Name = "tbxUptUPrice";
            this.tbxUptUPrice.Size = new System.Drawing.Size(100, 27);
            this.tbxUptUPrice.TabIndex = 5;
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
            // frmMain
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoSize = true;
            this.ClientSize = new System.Drawing.Size(658, 581);
            this.Controls.Add(this.groupUpdate);
            this.Controls.Add(this.groupAddProduct);
            this.Controls.Add(this.dgwProducts);
            this.Name = "frmMain";
            this.Text = "Ana Form";
            this.Load += new System.EventHandler(this.frmMain_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgwProducts)).EndInit();
            this.groupAddProduct.ResumeLayout(false);
            this.groupAddProduct.PerformLayout();
            this.groupUpdate.ResumeLayout(false);
            this.groupUpdate.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView dgwProducts;
        private System.Windows.Forms.Button btnDelete;
        private System.Windows.Forms.Label lblName;
        private System.Windows.Forms.TextBox tbxName;
        private System.Windows.Forms.TextBox tbxUnitPrice;
        private System.Windows.Forms.Label lblUnitPrice;
        private System.Windows.Forms.TextBox tbxStock;
        private System.Windows.Forms.Label lblStockAmount;
        private System.Windows.Forms.GroupBox groupAddProduct;
        private System.Windows.Forms.GroupBox groupUpdate;
        private System.Windows.Forms.Label lblUptName;
        private System.Windows.Forms.TextBox tbxUptStock;
        private System.Windows.Forms.Button btnUpdate;
        private System.Windows.Forms.Label lblUptStock;
        private System.Windows.Forms.TextBox tbxUptName;
        private System.Windows.Forms.TextBox tbxUptUPrice;
        private System.Windows.Forms.Label lblUptUnitPrice;
    }
}

