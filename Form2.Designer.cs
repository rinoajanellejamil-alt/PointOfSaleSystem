namespace PointOfSaleSystem
{
    partial class dgvCart
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
            lblTitleHeader = new Label();
            panel1 = new Panel();
            lblSubHead = new Label();
            lblSelectProduct = new Label();
            label2 = new Label();
            lblSearchPorduct = new Label();
            txtProductSearch = new TextBox();
            cmbProductSearch = new ComboBox();
            lblQuantity = new Label();
            txtQuantity = new TextBox();
            btnAddToCart = new Button();
            label1 = new Label();
            pnl1 = new Panel();
            dataGridView1 = new DataGridView();
            colProductID = new DataGridViewTextBoxColumn();
            colRiceVariety = new DataGridViewTextBoxColumn();
            colSellingUnit = new DataGridViewTextBoxColumn();
            colQuantity = new DataGridViewTextBoxColumn();
            colUnitPrice = new DataGridViewTextBoxColumn();
            colSubtotal = new DataGridViewTextBoxColumn();
            btnRemoveItem = new Button();
            btnClearCart = new Button();
            panel2 = new Panel();
            btnComputeTotal = new Button();
            lblChangeAmount = new Label();
            lblSubtotal = new Label();
            lblDiscount = new Label();
            lblTotalDue = new Label();
            lblCashTendered = new Label();
            lblDis = new Label();
            lblChan = new Label();
            txtCashTendered = new TextBox();
            lblSub = new Label();
            lblPaymentDetails = new Label();
            lblTotalAmount = new Label();
            btnCompleteSale = new Button();
            btnNewTransaction = new Button();
            panel1.SuspendLayout();
            pnl1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)dataGridView1).BeginInit();
            panel2.SuspendLayout();
            SuspendLayout();
            // 
            // lblTitleHeader
            // 
            lblTitleHeader.AutoSize = true;
            lblTitleHeader.Font = new Font("Sitka Display", 21.75F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lblTitleHeader.ForeColor = Color.White;
            lblTitleHeader.Location = new Point(313, 9);
            lblTitleHeader.Name = "lblTitleHeader";
            lblTitleHeader.Size = new Size(152, 42);
            lblTitleHeader.TabIndex = 0;
            lblTitleHeader.Text = "MyBigasan";
            // 
            // panel1
            // 
            panel1.BackColor = Color.FromArgb(30, 74, 30);
            panel1.Controls.Add(lblSubHead);
            panel1.Controls.Add(lblTitleHeader);
            panel1.Location = new Point(0, 0);
            panel1.Name = "panel1";
            panel1.Size = new Size(800, 100);
            panel1.TabIndex = 5;
            // 
            // lblSubHead
            // 
            lblSubHead.AutoSize = true;
            lblSubHead.Font = new Font("Segoe MDL2 Assets", 18F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lblSubHead.ForeColor = Color.FromArgb(214, 183, 37);
            lblSubHead.Location = new Point(287, 51);
            lblSubHead.Name = "lblSubHead";
            lblSubHead.Size = new Size(202, 24);
            lblSubHead.TabIndex = 0;
            lblSubHead.Text = "Point of Sale System";
            // 
            // lblSelectProduct
            // 
            lblSelectProduct.AutoSize = true;
            lblSelectProduct.Location = new Point(80, 119);
            lblSelectProduct.Name = "lblSelectProduct";
            lblSelectProduct.Size = new Size(83, 15);
            lblSelectProduct.TabIndex = 7;
            lblSelectProduct.Text = "Select Product";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(47, 147);
            label2.Name = "label2";
            label2.Size = new Size(0, 15);
            label2.TabIndex = 8;
            // 
            // lblSearchPorduct
            // 
            lblSearchPorduct.AutoSize = true;
            lblSearchPorduct.Location = new Point(80, 51);
            lblSearchPorduct.Name = "lblSearchPorduct";
            lblSearchPorduct.Size = new Size(87, 15);
            lblSearchPorduct.TabIndex = 7;
            lblSearchPorduct.Text = "Search Product";
            // 
            // txtProductSearch
            // 
            txtProductSearch.Location = new Point(80, 69);
            txtProductSearch.Name = "txtProductSearch";
            txtProductSearch.Size = new Size(205, 23);
            txtProductSearch.TabIndex = 9;
            txtProductSearch.Text = "Search rice products";
            // 
            // cmbProductSearch
            // 
            cmbProductSearch.FormattingEnabled = true;
            cmbProductSearch.Items.AddRange(new object[] { "Regular-Milled Rice\t₱45.00", "", "Well-Milled Rice\t₱50.00", "", "Sinandomeng\t₱55.00", "", "Dinorado\t₱65.00", "", "Jasmine Rice\t₱70.00", "", "Angelica Rice\t₱60.00", "", "Long Grain Rice\t₱55.00", "", "Brown Rice\t₱75.00", "", "Red Rice\t₱80.00", "", "Glutinous Rice (Malagkit)\t₱90.00" });
            cmbProductSearch.Location = new Point(80, 137);
            cmbProductSearch.Name = "cmbProductSearch";
            cmbProductSearch.Size = new Size(205, 23);
            cmbProductSearch.TabIndex = 10;
            // 
            // lblQuantity
            // 
            lblQuantity.AutoSize = true;
            lblQuantity.Location = new Point(80, 179);
            lblQuantity.Name = "lblQuantity";
            lblQuantity.Size = new Size(53, 15);
            lblQuantity.TabIndex = 7;
            lblQuantity.Text = "Quantity";
            // 
            // txtQuantity
            // 
            txtQuantity.Location = new Point(80, 197);
            txtQuantity.Name = "txtQuantity";
            txtQuantity.Size = new Size(205, 23);
            txtQuantity.TabIndex = 9;
            // 
            // btnAddToCart
            // 
            btnAddToCart.BackColor = Color.FromArgb(46, 118, 39);
            btnAddToCart.Font = new Font("Microsoft Sans Serif", 9.75F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btnAddToCart.ForeColor = Color.White;
            btnAddToCart.Location = new Point(121, 304);
            btnAddToCart.Name = "btnAddToCart";
            btnAddToCart.Size = new Size(128, 47);
            btnAddToCart.TabIndex = 11;
            btnAddToCart.Text = "Add to Cart";
            btnAddToCart.UseVisualStyleBackColor = false;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe MDL2 Assets", 18F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label1.ForeColor = Color.FromArgb(128, 64, 0);
            label1.Location = new Point(18, 13);
            label1.Name = "label1";
            label1.Size = new Size(170, 24);
            label1.TabIndex = 0;
            label1.Text = "Product Selection";
            // 
            // pnl1
            // 
            pnl1.BackColor = Color.Transparent;
            pnl1.Controls.Add(btnAddToCart);
            pnl1.Controls.Add(label1);
            pnl1.Controls.Add(lblSelectProduct);
            pnl1.Controls.Add(lblQuantity);
            pnl1.Controls.Add(cmbProductSearch);
            pnl1.Controls.Add(lblSearchPorduct);
            pnl1.Controls.Add(txtQuantity);
            pnl1.Controls.Add(txtProductSearch);
            pnl1.Location = new Point(9, 113);
            pnl1.Name = "pnl1";
            pnl1.Size = new Size(370, 375);
            pnl1.TabIndex = 12;
            // 
            // dataGridView1
            // 
            dataGridView1.AllowUserToAddRows = false;
            dataGridView1.AllowUserToDeleteRows = false;
            dataGridView1.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            dataGridView1.BackgroundColor = Color.FromArgb(221, 219, 193);
            dataGridView1.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridView1.Columns.AddRange(new DataGridViewColumn[] { colProductID, colRiceVariety, colSellingUnit, colQuantity, colUnitPrice, colSubtotal });
            dataGridView1.Location = new Point(385, 113);
            dataGridView1.MultiSelect = false;
            dataGridView1.Name = "dataGridView1";
            dataGridView1.ReadOnly = true;
            dataGridView1.RowHeadersVisible = false;
            dataGridView1.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            dataGridView1.Size = new Size(400, 290);
            dataGridView1.TabIndex = 13;
            // 
            // colProductID
            // 
            colProductID.HeaderText = "Product ID";
            colProductID.Name = "colProductID";
            colProductID.ReadOnly = true;
            // 
            // colRiceVariety
            // 
            colRiceVariety.HeaderText = "Rice Variety";
            colRiceVariety.Name = "colRiceVariety";
            colRiceVariety.ReadOnly = true;
            // 
            // colSellingUnit
            // 
            colSellingUnit.HeaderText = "Selling Unit";
            colSellingUnit.Name = "colSellingUnit";
            colSellingUnit.ReadOnly = true;
            // 
            // colQuantity
            // 
            colQuantity.HeaderText = "Quantity";
            colQuantity.Name = "colQuantity";
            colQuantity.ReadOnly = true;
            // 
            // colUnitPrice
            // 
            colUnitPrice.HeaderText = "Unit Price";
            colUnitPrice.Name = "colUnitPrice";
            colUnitPrice.ReadOnly = true;
            // 
            // colSubtotal
            // 
            colSubtotal.HeaderText = "Subtotal";
            colSubtotal.Name = "colSubtotal";
            colSubtotal.ReadOnly = true;
            // 
            // btnRemoveItem
            // 
            btnRemoveItem.BackColor = Color.FromArgb(184, 62, 52);
            btnRemoveItem.Font = new Font("Microsoft New Tai Lue", 9.75F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btnRemoveItem.ForeColor = Color.White;
            btnRemoveItem.Location = new Point(492, 409);
            btnRemoveItem.Name = "btnRemoveItem";
            btnRemoveItem.Size = new Size(186, 30);
            btnRemoveItem.TabIndex = 14;
            btnRemoveItem.Text = "Remove Item";
            btnRemoveItem.UseVisualStyleBackColor = false;
            // 
            // btnClearCart
            // 
            btnClearCart.BackColor = Color.FromArgb(213, 172, 64);
            btnClearCart.Font = new Font("Microsoft New Tai Lue", 9.75F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btnClearCart.ForeColor = Color.FromArgb(114, 68, 22);
            btnClearCart.Location = new Point(492, 445);
            btnClearCart.Name = "btnClearCart";
            btnClearCart.Size = new Size(186, 30);
            btnClearCart.TabIndex = 14;
            btnClearCart.Text = "Clear Cart";
            btnClearCart.UseVisualStyleBackColor = false;
            // 
            // panel2
            // 
            panel2.Controls.Add(btnNewTransaction);
            panel2.Controls.Add(btnCompleteSale);
            panel2.Controls.Add(btnComputeTotal);
            panel2.Controls.Add(lblChangeAmount);
            panel2.Controls.Add(lblSubtotal);
            panel2.Controls.Add(lblTotalAmount);
            panel2.Controls.Add(lblDiscount);
            panel2.Controls.Add(lblTotalDue);
            panel2.Controls.Add(lblCashTendered);
            panel2.Controls.Add(lblDis);
            panel2.Controls.Add(lblChan);
            panel2.Controls.Add(txtCashTendered);
            panel2.Controls.Add(lblSub);
            panel2.Controls.Add(lblPaymentDetails);
            panel2.Location = new Point(10, 492);
            panel2.Name = "panel2";
            panel2.Size = new Size(784, 366);
            panel2.TabIndex = 15;
            // 
            // btnComputeTotal
            // 
            btnComputeTotal.BackColor = Color.FromArgb(46, 118, 39);
            btnComputeTotal.Font = new Font("Microsoft Sans Serif", 9.75F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btnComputeTotal.ForeColor = Color.White;
            btnComputeTotal.Location = new Point(61, 236);
            btnComputeTotal.Name = "btnComputeTotal";
            btnComputeTotal.Size = new Size(607, 32);
            btnComputeTotal.TabIndex = 11;
            btnComputeTotal.Text = "Compute Total";
            btnComputeTotal.UseVisualStyleBackColor = false;
            // 
            // lblChangeAmount
            // 
            lblChangeAmount.AutoSize = true;
            lblChangeAmount.Font = new Font("Segoe UI Symbol", 12F);
            lblChangeAmount.Location = new Point(594, 212);
            lblChangeAmount.Name = "lblChangeAmount";
            lblChangeAmount.Size = new Size(51, 21);
            lblChangeAmount.TabIndex = 1;
            lblChangeAmount.Text = "₱0.00";
            // 
            // lblSubtotal
            // 
            lblSubtotal.AutoSize = true;
            lblSubtotal.Font = new Font("Segoe UI Symbol", 12F);
            lblSubtotal.Location = new Point(589, 45);
            lblSubtotal.Name = "lblSubtotal";
            lblSubtotal.Size = new Size(51, 21);
            lblSubtotal.TabIndex = 1;
            lblSubtotal.Text = "₱0.00";
            // 
            // lblDiscount
            // 
            lblDiscount.AutoSize = true;
            lblDiscount.Font = new Font("Segoe UI Symbol", 12F);
            lblDiscount.Location = new Point(589, 82);
            lblDiscount.Name = "lblDiscount";
            lblDiscount.Size = new Size(51, 21);
            lblDiscount.TabIndex = 1;
            lblDiscount.Text = "₱0.00";
            // 
            // lblTotalDue
            // 
            lblTotalDue.AutoSize = true;
            lblTotalDue.Font = new Font("Segoe UI Symbol", 14.25F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lblTotalDue.Location = new Point(56, 123);
            lblTotalDue.Name = "lblTotalDue";
            lblTotalDue.Size = new Size(117, 25);
            lblTotalDue.TabIndex = 1;
            lblTotalDue.Text = "TOTAL DUE";
            // 
            // lblCashTendered
            // 
            lblCashTendered.AutoSize = true;
            lblCashTendered.Font = new Font("Segoe UI Symbol", 12F);
            lblCashTendered.Location = new Point(61, 162);
            lblCashTendered.Name = "lblCashTendered";
            lblCashTendered.Size = new Size(113, 21);
            lblCashTendered.TabIndex = 1;
            lblCashTendered.Text = "Cash Tendered";
            // 
            // lblDis
            // 
            lblDis.AutoSize = true;
            lblDis.Font = new Font("Segoe UI Symbol", 12F);
            lblDis.Location = new Point(56, 82);
            lblDis.Name = "lblDis";
            lblDis.Size = new Size(71, 21);
            lblDis.TabIndex = 1;
            lblDis.Text = "Discount";
            // 
            // lblChan
            // 
            lblChan.AutoSize = true;
            lblChan.Font = new Font("Segoe UI Symbol", 12F);
            lblChan.Location = new Point(61, 212);
            lblChan.Name = "lblChan";
            lblChan.Size = new Size(63, 21);
            lblChan.TabIndex = 1;
            lblChan.Text = "Change";
            // 
            // txtCashTendered
            // 
            txtCashTendered.Location = new Point(61, 186);
            txtCashTendered.Name = "txtCashTendered";
            txtCashTendered.Size = new Size(607, 23);
            txtCashTendered.TabIndex = 9;
            // 
            // lblSub
            // 
            lblSub.AutoSize = true;
            lblSub.Font = new Font("Segoe UI Symbol", 12F);
            lblSub.Location = new Point(56, 45);
            lblSub.Name = "lblSub";
            lblSub.Size = new Size(68, 21);
            lblSub.TabIndex = 1;
            lblSub.Text = "Subtotal";
            // 
            // lblPaymentDetails
            // 
            lblPaymentDetails.AutoSize = true;
            lblPaymentDetails.Font = new Font("Segoe UI Emoji", 18F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lblPaymentDetails.ForeColor = Color.FromArgb(128, 64, 64);
            lblPaymentDetails.Location = new Point(17, 11);
            lblPaymentDetails.Name = "lblPaymentDetails";
            lblPaymentDetails.Size = new Size(229, 32);
            lblPaymentDetails.TabIndex = 0;
            lblPaymentDetails.Text = "PAYMENT DETAILS";
            // 
            // lblTotalAmount
            // 
            lblTotalAmount.AutoSize = true;
            lblTotalAmount.Font = new Font("Segoe UI Symbol", 14.25F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lblTotalAmount.Location = new Point(589, 123);
            lblTotalAmount.Name = "lblTotalAmount";
            lblTotalAmount.Size = new Size(64, 25);
            lblTotalAmount.TabIndex = 1;
            lblTotalAmount.Text = "₱0.00";
            // 
            // btnCompleteSale
            // 
            btnCompleteSale.BackColor = Color.FromArgb(0, 192, 0);
            btnCompleteSale.Font = new Font("Microsoft Sans Serif", 9.75F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btnCompleteSale.ForeColor = Color.White;
            btnCompleteSale.Location = new Point(61, 274);
            btnCompleteSale.Name = "btnCompleteSale";
            btnCompleteSale.Size = new Size(607, 32);
            btnCompleteSale.TabIndex = 11;
            btnCompleteSale.Text = "Complete Sale";
            btnCompleteSale.UseVisualStyleBackColor = false;
            // 
            // btnNewTransaction
            // 
            btnNewTransaction.BackColor = Color.FromArgb(223, 211, 181);
            btnNewTransaction.Font = new Font("Microsoft Sans Serif", 9.75F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btnNewTransaction.ForeColor = Color.Black;
            btnNewTransaction.Location = new Point(61, 312);
            btnNewTransaction.Name = "btnNewTransaction";
            btnNewTransaction.Size = new Size(607, 32);
            btnNewTransaction.TabIndex = 11;
            btnNewTransaction.Text = "New Transaction";
            btnNewTransaction.UseVisualStyleBackColor = false;
            // 
            // dgvCart
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = SystemColors.Info;
            ClientSize = new Size(800, 861);
            Controls.Add(panel2);
            Controls.Add(btnClearCart);
            Controls.Add(btnRemoveItem);
            Controls.Add(dataGridView1);
            Controls.Add(pnl1);
            Controls.Add(label2);
            Controls.Add(panel1);
            Name = "dgvCart";
            Text = "Checkout Controls";
            panel1.ResumeLayout(false);
            panel1.PerformLayout();
            pnl1.ResumeLayout(false);
            pnl1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)dataGridView1).EndInit();
            panel2.ResumeLayout(false);
            panel2.PerformLayout();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label lblTitleHeader;
        private TextBox cmbProduct;
       
        private Button btnAddToCart;
        private Panel panel1;
        private Label lblSubHead;
        private Button button2;
        private Label lblSelectProduct;
        private Label label2;
        private Label lblSearchPorduct;
        private Button btnSalesHistory;
        private Button btnPOS;
        private Button button3;
        private TextBox txtProductSearch;
        private ComboBox cmbProductSearch;
        private Label lblQuantity;
        private TextBox txtQuantity;
        private Label label1;
        private Panel pnl1;
        private DataGridView dataGridView1;
        private DataGridViewTextBoxColumn colProductID;
        private DataGridViewTextBoxColumn colRiceVariety;
        private DataGridViewTextBoxColumn colSellingUnit;
        private DataGridViewTextBoxColumn colQuantity;
        private DataGridViewTextBoxColumn colUnitPrice;
        private DataGridViewTextBoxColumn colSubtotal;
        private Button btnRemoveItem;
        private Button btnClearCart;
        private Panel panel2;
        private Label lblSub;
        private Label lblPaymentDetails;
        private Label lblSubtotal;
        private Label label5;
        private Label lblDiscount;
        private Label lblTotalDue;
        private Label lblDis;
        private Label lblCashTendered;
        private TextBox txtCashTendered;
        private Label lblChangeAmount;
        private Label lblChan;
        private Button btnComputeTotal;
        private Button btnCompleteSale;
        private Label lblTotalAmount;
        private Button btnNewTransaction;
    }
}