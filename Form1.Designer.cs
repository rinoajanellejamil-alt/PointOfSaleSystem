namespace PointOfSaleSystem
{
    partial class Form1
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
            lblTitle = new Label();
            lblCustomerName = new Label();
            lblCustomerAddress = new Label();
            txtCustomerAddress = new TextBox();
            btnContinueToPOS = new Button();
            btnExit = new Button();
            txtCustomerName = new TextBox();
            flowLayoutPanel1 = new FlowLayoutPanel();
            btnSalesHistory = new Button();
            btnProductManagement = new Button();
            flowLayoutPanel1.SuspendLayout();
            SuspendLayout();
            // 
            // lblTitle
            // 
            lblTitle.AutoSize = true;
            lblTitle.Font = new Font("Javanese Text", 36F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lblTitle.ForeColor = Color.FromArgb(255, 224, 192);
            lblTitle.Location = new Point(3, 0);
            lblTitle.Name = "lblTitle";
            lblTitle.Size = new Size(288, 109);
            lblTitle.TabIndex = 0;
            lblTitle.Text = "MyBigasan";
            // 
            // lblCustomerName
            // 
            lblCustomerName.AutoSize = true;
            lblCustomerName.Font = new Font("Javanese Text", 14.25F);
            lblCustomerName.ForeColor = Color.FromArgb(128, 64, 0);
            lblCustomerName.Location = new Point(127, 163);
            lblCustomerName.Name = "lblCustomerName";
            lblCustomerName.Size = new Size(152, 43);
            lblCustomerName.TabIndex = 0;
            lblCustomerName.Text = "Customer Name";
            // 
            // lblCustomerAddress
            // 
            lblCustomerAddress.AutoSize = true;
            lblCustomerAddress.Font = new Font("Javanese Text", 14.25F);
            lblCustomerAddress.ForeColor = Color.FromArgb(128, 64, 0);
            lblCustomerAddress.Location = new Point(127, 201);
            lblCustomerAddress.Name = "lblCustomerAddress";
            lblCustomerAddress.Size = new Size(86, 43);
            lblCustomerAddress.TabIndex = 0;
            lblCustomerAddress.Text = "Address";
            // 
            // txtCustomerAddress
            // 
            txtCustomerAddress.Location = new Point(307, 210);
            txtCustomerAddress.Name = "txtCustomerAddress";
            txtCustomerAddress.Size = new Size(415, 23);
            txtCustomerAddress.TabIndex = 1;
            // 
            // btnContinueToPOS
            // 
            btnContinueToPOS.BackColor = Color.FromArgb(82, 152, 82);
            btnContinueToPOS.Font = new Font("Segoe UI", 12F, FontStyle.Bold);
            btnContinueToPOS.ForeColor = SystemColors.ButtonHighlight;
            btnContinueToPOS.Location = new Point(294, 325);
            btnContinueToPOS.Name = "btnContinueToPOS";
            btnContinueToPOS.Size = new Size(383, 33);
            btnContinueToPOS.TabIndex = 2;
            btnContinueToPOS.Text = "CONTINUE";
            btnContinueToPOS.UseVisualStyleBackColor = false;
            // 
            // btnExit
            // 
            btnExit.FlatStyle = FlatStyle.Flat;
            btnExit.Font = new Font("Segoe UI", 12F, FontStyle.Bold);
            btnExit.Location = new Point(294, 445);
            btnExit.Name = "btnExit";
            btnExit.Size = new Size(383, 33);
            btnExit.TabIndex = 2;
            btnExit.Text = "EXIT";
            btnExit.UseVisualStyleBackColor = true;
            // 
            // txtCustomerName
            // 
            txtCustomerName.Location = new Point(307, 172);
            txtCustomerName.Name = "txtCustomerName";
            txtCustomerName.Size = new Size(415, 23);
            txtCustomerName.TabIndex = 1;
            // 
            // flowLayoutPanel1
            // 
            flowLayoutPanel1.BackColor = Color.DarkGreen;
            flowLayoutPanel1.Controls.Add(lblTitle);
            flowLayoutPanel1.Location = new Point(1, 2);
            flowLayoutPanel1.Name = "flowLayoutPanel1";
            flowLayoutPanel1.Size = new Size(949, 103);
            flowLayoutPanel1.TabIndex = 3;
            // 
            // btnSalesHistory
            // 
            btnSalesHistory.BackColor = Color.FromArgb(221, 200, 77);
            btnSalesHistory.Font = new Font("Segoe UI", 12F, FontStyle.Bold);
            btnSalesHistory.ForeColor = SystemColors.ActiveCaptionText;
            btnSalesHistory.Location = new Point(294, 364);
            btnSalesHistory.Name = "btnSalesHistory";
            btnSalesHistory.Size = new Size(383, 33);
            btnSalesHistory.TabIndex = 2;
            btnSalesHistory.Text = "SALES HISTORY";
            btnSalesHistory.UseVisualStyleBackColor = false;
            // 
            // btnProductManagement
            // 
            btnProductManagement.BackColor = Color.FromArgb(213, 204, 164);
            btnProductManagement.Font = new Font("Segoe UI", 12F, FontStyle.Bold);
            btnProductManagement.Location = new Point(294, 403);
            btnProductManagement.Name = "btnProductManagement";
            btnProductManagement.Size = new Size(383, 33);
            btnProductManagement.TabIndex = 2;
            btnProductManagement.Text = "PRODUCT MANAGEMENT";
            btnProductManagement.UseVisualStyleBackColor = false;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = SystemColors.Info;
            ClientSize = new Size(947, 578);
            Controls.Add(flowLayoutPanel1);
            Controls.Add(btnProductManagement);
            Controls.Add(btnSalesHistory);
            Controls.Add(btnExit);
            Controls.Add(btnContinueToPOS);
            Controls.Add(txtCustomerName);
            Controls.Add(txtCustomerAddress);
            Controls.Add(lblCustomerAddress);
            Controls.Add(lblCustomerName);
            Name = "Form1";
            Text = "Form1";
            flowLayoutPanel1.ResumeLayout(false);
            flowLayoutPanel1.PerformLayout();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label lblTitle;
        private Label lblCustomerName;
        private Label lblCustomerAddress;
        private TextBox textBox1;
        private TextBox txtCustomerAddress;
        private Button btnContinueToPOS;
        private Button btnExit;
        private TextBox txtCustomerName;
        private FlowLayoutPanel flowLayoutPanel1;
        private Button btnSalesHistory;
        private Button btnProductManagement;
    }
}
