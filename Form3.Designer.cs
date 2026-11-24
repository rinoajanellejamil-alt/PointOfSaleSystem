namespace MYBIGASAN
{
    partial class Form3
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            lblPostTitle = new Label();
            lblProductSearch = new Label();
            txtProductSearch = new TextBox();
            lblSelectProduct = new Label();
            cmbProduct = new ComboBox();
            this.lblQuantity = new Label();
            this.txtQuantity = new TextBox();
            btnAddToCart = new Button();
            dataGridView1 = new DataGridView();
            ProductID = new DataGridViewTextBoxColumn();
            RiceVariety = new DataGridViewTextBoxColumn();
            SellingUnit = new DataGridViewTextBoxColumn();
            Quantity = new DataGridViewTextBoxColumn();
            UnitPrice = new DataGridViewTextBoxColumn();
            Subtotal = new DataGridViewTextBoxColumn();
            btnRemoveItem = new Button();
            btnClearCart = new Button();
            lblSubtotal = new Label();
            lblDiscount = new Label();
            lblTotal = new Label();
            lblCashTendered = new Label();
            lblChange = new Label();
            lblChangeAmount = new Label();
            txtCashTendered = new TextBox();
            btnComputeTotal = new Button();
            btnCompleteSale = new Button();
            btnNewTransaction = new Button();
            ((System.ComponentModel.ISupportInitialize)dataGridView1).BeginInit();
            SuspendLayout();
            // 
            // lblPostTitle
            // 
            lblPostTitle.Font = new Font("Segoe UI", 18F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lblPostTitle.Location = new Point(54, 24);
            lblPostTitle.Name = "lblPostTitle";
            lblPostTitle.Size = new Size(445, 43);
            lblPostTitle.TabIndex = 0;
            lblPostTitle.Text = "MYBIGASAN - POINT OF SALE";
            // 
            // lblProductSearch
            // 
            lblProductSearch.AutoSize = true;
            lblProductSearch.Location = new Point(102, 88);
            lblProductSearch.Name = "lblProductSearch";
            lblProductSearch.Size = new Size(87, 15);
            lblProductSearch.TabIndex = 1;
            lblProductSearch.Text = "Search Product";
            // 
            // txtProductSearch
            // 
            txtProductSearch.Location = new Point(102, 106);
            txtProductSearch.Name = "txtProductSearch";
            txtProductSearch.Size = new Size(100, 23);
            txtProductSearch.TabIndex = 2;
            // 
            // lblSelectProduct
            // 
            lblSelectProduct.AutoSize = true;
            lblSelectProduct.Location = new Point(295, 88);
            lblSelectProduct.Name = "lblSelectProduct";
            lblSelectProduct.Size = new Size(63, 15);
            lblSelectProduct.TabIndex = 3;
            lblSelectProduct.Text = "Select Rice";
            lblSelectProduct.Click += lblSelectProduct_Click;
            // 
            // cmbProduct
            // 
            cmbProduct.FormattingEnabled = true;
            cmbProduct.Location = new Point(295, 106);
            cmbProduct.Name = "cmbProduct";
            cmbProduct.Size = new Size(121, 23);
            cmbProduct.TabIndex = 4;
            // 
            // lblQuantity
            // 
            this.lblQuantity.AutoSize = true;
            this.lblQuantity.Location = new Point(531, 88);
            this.lblQuantity.Name = "lblQuantity";
            this.lblQuantity.Size = new Size(53, 15);
            this.lblQuantity.TabIndex = 5;
            this.lblQuantity.Text = "Quantity";
            this.lblQuantity.Click += this.lblQuantity_Click;
            // 
            // txtQuantity
            // 
            this.txtQuantity.Location = new Point(531, 106);
            this.txtQuantity.Name = "txtQuantity";
            this.txtQuantity.Size = new Size(100, 23);
            this.txtQuantity.TabIndex = 6;
            // 
            // btnAddToCart
            // 
            btnAddToCart.Location = new Point(753, 106);
            btnAddToCart.Name = "btnAddToCart";
            btnAddToCart.Size = new Size(102, 23);
            btnAddToCart.TabIndex = 7;
            btnAddToCart.Text = "Add to Cart";
            btnAddToCart.UseVisualStyleBackColor = true;
            btnAddToCart.Click += button1_Click;
            // 
            // dataGridView1
            // 
            dataGridView1.AccessibleName = "dgvCart";
            dataGridView1.AllowUserToAddRows = false;
            dataGridView1.AllowUserToDeleteRows = false;
            dataGridView1.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            dataGridView1.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridView1.Columns.AddRange(new DataGridViewColumn[] { ProductID, RiceVariety, SellingUnit, Quantity, UnitPrice, Subtotal });
            dataGridView1.Location = new Point(194, 155);
            dataGridView1.MultiSelect = false;
            dataGridView1.Name = "dataGridView1";
            dataGridView1.ReadOnly = true;
            dataGridView1.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            dataGridView1.Size = new Size(557, 314);
            dataGridView1.TabIndex = 8;
            // 
            // ProductID
            // 
            ProductID.HeaderText = "Product ID";
            ProductID.Name = "ProductID";
            ProductID.ReadOnly = true;
            // 
            // RiceVariety
            // 
            RiceVariety.HeaderText = "Rice Variety";
            RiceVariety.Name = "RiceVariety";
            RiceVariety.ReadOnly = true;
            // 
            // SellingUnit
            // 
            SellingUnit.HeaderText = "Selling Unit";
            SellingUnit.Name = "SellingUnit";
            SellingUnit.ReadOnly = true;
            // 
            // Quantity
            // 
            Quantity.HeaderText = "Quantity";
            Quantity.Name = "Quantity";
            Quantity.ReadOnly = true;
            // 
            // UnitPrice
            // 
            UnitPrice.HeaderText = "Unit Price";
            UnitPrice.Name = "UnitPrice";
            UnitPrice.ReadOnly = true;
            // 
            // Subtotal
            // 
            Subtotal.HeaderText = "Subtotal";
            Subtotal.Name = "Subtotal";
            Subtotal.ReadOnly = true;
            // 
            // btnRemoveItem
            // 
            btnRemoveItem.Location = new Point(194, 484);
            btnRemoveItem.Name = "btnRemoveItem";
            btnRemoveItem.Size = new Size(111, 23);
            btnRemoveItem.TabIndex = 9;
            btnRemoveItem.Text = "Remove Item";
            btnRemoveItem.UseVisualStyleBackColor = true;
            // 
            // btnClearCart
            // 
            btnClearCart.Location = new Point(642, 484);
            btnClearCart.Name = "btnClearCart";
            btnClearCart.Size = new Size(109, 23);
            btnClearCart.TabIndex = 10;
            btnClearCart.Text = "Clear Cart";
            btnClearCart.UseVisualStyleBackColor = true;
            btnClearCart.Click += button2_Click;
            // 
            // lblSubtotal
            // 
            lblSubtotal.AutoSize = true;
            lblSubtotal.Location = new Point(102, 522);
            lblSubtotal.Name = "lblSubtotal";
            lblSubtotal.Size = new Size(54, 15);
            lblSubtotal.TabIndex = 11;
            lblSubtotal.Text = "Subtotal:";
            // 
            // lblDiscount
            // 
            lblDiscount.AutoSize = true;
            lblDiscount.Location = new Point(102, 557);
            lblDiscount.Name = "lblDiscount";
            lblDiscount.Size = new Size(57, 15);
            lblDiscount.TabIndex = 12;
            lblDiscount.Text = "Discount:";
            // 
            // lblTotal
            // 
            lblTotal.AutoSize = true;
            lblTotal.Location = new Point(102, 591);
            lblTotal.Name = "lblTotal";
            lblTotal.Size = new Size(36, 15);
            lblTotal.TabIndex = 13;
            lblTotal.Text = "Total:";
            // 
            // lblCashTendered
            // 
            lblCashTendered.AutoSize = true;
            lblCashTendered.Location = new Point(102, 623);
            lblCashTendered.Name = "lblCashTendered";
            lblCashTendered.Size = new Size(88, 15);
            lblCashTendered.TabIndex = 14;
            lblCashTendered.Text = "Cash Tendered:";
            lblCashTendered.Click += lblCashTendered_Click;
            // 
            // lblChange
            // 
            lblChange.AutoSize = true;
            lblChange.Location = new Point(102, 652);
            lblChange.Name = "lblChange";
            lblChange.Size = new Size(51, 15);
            lblChange.TabIndex = 15;
            lblChange.Text = "Change:";
            // 
            // lblChangeAmount
            // 
            lblChangeAmount.AutoSize = true;
            lblChangeAmount.Location = new Point(152, 652);
            lblChangeAmount.Name = "lblChangeAmount";
            lblChangeAmount.Size = new Size(38, 15);
            lblChangeAmount.TabIndex = 16;
            lblChangeAmount.Text = " ₱0.00";
            // 
            // txtCashTendered
            // 
            txtCashTendered.Location = new Point(196, 615);
            txtCashTendered.Name = "txtCashTendered";
            txtCashTendered.Size = new Size(100, 23);
            txtCashTendered.TabIndex = 17;
            // 
            // btnComputeTotal
            // 
            btnComputeTotal.Location = new Point(194, 694);
            btnComputeTotal.Name = "btnComputeTotal";
            btnComputeTotal.Size = new Size(117, 23);
            btnComputeTotal.TabIndex = 18;
            btnComputeTotal.Text = "Compute Total";
            btnComputeTotal.UseVisualStyleBackColor = true;
            // 
            // btnCompleteSale
            // 
            btnCompleteSale.Location = new Point(407, 694);
            btnCompleteSale.Name = "btnCompleteSale";
            btnCompleteSale.Size = new Size(126, 23);
            btnCompleteSale.TabIndex = 19;
            btnCompleteSale.Text = "Complete Sale";
            btnCompleteSale.UseVisualStyleBackColor = true;
            // 
            // btnNewTransaction
            // 
            btnNewTransaction.Location = new Point(620, 694);
            btnNewTransaction.Name = "btnNewTransaction";
            btnNewTransaction.Size = new Size(131, 23);
            btnNewTransaction.TabIndex = 20;
            btnNewTransaction.Text = "New Transaction";
            btnNewTransaction.UseVisualStyleBackColor = true;
            btnNewTransaction.Click += btnNewTransaction_Click;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1084, 749);
            Controls.Add(btnNewTransaction);
            Controls.Add(btnCompleteSale);
            Controls.Add(btnComputeTotal);
            Controls.Add(txtCashTendered);
            Controls.Add(lblChangeAmount);
            Controls.Add(lblChange);
            Controls.Add(lblCashTendered);
            Controls.Add(lblTotal);
            Controls.Add(lblDiscount);
            Controls.Add(lblSubtotal);
            Controls.Add(btnClearCart);
            Controls.Add(btnRemoveItem);
            Controls.Add(dataGridView1);
            Controls.Add(btnAddToCart);
            Controls.Add(this.txtQuantity);
            Controls.Add(this.lblQuantity);
            Controls.Add(cmbProduct);
            Controls.Add(lblSelectProduct);
            Controls.Add(txtProductSearch);
            Controls.Add(lblProductSearch);
            Controls.Add(lblPostTitle);
            Name = "Form1";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "MYBIGASAN - POINT OF SALE";
            ((System.ComponentModel.ISupportInitialize)dataGridView1).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label lblPostTitle;
        private Label lblProductSearch;
        private TextBox txtProductSearch;
        private Label lblSelectProduct;
        private ComboBox cmbProduct;
        private Label lblQuantity;
        private TextBox txtQuantity;
        private Button btnAddToCart;
        private DataGridView dataGridView1;
        private DataGridViewTextBoxColumn ProductID;
        private DataGridViewTextBoxColumn RiceVariety;
        private DataGridViewTextBoxColumn SellingUnit;
        private DataGridViewTextBoxColumn Quantity;
        private DataGridViewTextBoxColumn UnitPrice;
        private DataGridViewTextBoxColumn Subtotal;
        private Button btnRemoveItem;
        private Button btnClearCart;
        private Label lblSubtotal;
        private Label lblDiscount;
        private Label lblTotal;
        private Label lblCashTendered;
        private Label lblChange;
        private Label lblChangeAmount;
        private TextBox txtCashTendered;
        private Button btnComputeTotal;
        private Button btnCompleteSale;
        private Button btnNewTransaction;
    }
}
