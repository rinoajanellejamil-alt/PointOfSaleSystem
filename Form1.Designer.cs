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
            SuspendLayout();
            // 
            // lblTitle
            // 
            lblTitle.AutoSize = true;
            lblTitle.Font = new Font("Javanese Text", 36F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lblTitle.ForeColor = Color.FromArgb(128, 64, 0);
            lblTitle.Location = new Point(310, 9);
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
            lblCustomerName.Location = new Point(136, 194);
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
            lblCustomerAddress.Location = new Point(136, 319);
            lblCustomerAddress.Name = "lblCustomerAddress";
            lblCustomerAddress.Size = new Size(86, 43);
            lblCustomerAddress.TabIndex = 0;
            lblCustomerAddress.Text = "Address";
            // 
            // txtCustomerAddress
            // 
            txtCustomerAddress.Location = new Point(316, 328);
            txtCustomerAddress.Name = "txtCustomerAddress";
            txtCustomerAddress.Size = new Size(415, 23);
            txtCustomerAddress.TabIndex = 1;
            // 
            // btnContinueToPOS
            // 
            btnContinueToPOS.FlatStyle = FlatStyle.System;
            btnContinueToPOS.Location = new Point(316, 428);
            btnContinueToPOS.Name = "btnContinueToPOS";
            btnContinueToPOS.Size = new Size(75, 23);
            btnContinueToPOS.TabIndex = 2;
            btnContinueToPOS.Text = "Continue";
            btnContinueToPOS.UseVisualStyleBackColor = true;
            // 
            // btnExit
            // 
            btnExit.FlatStyle = FlatStyle.Flat;
            btnExit.Location = new Point(461, 428);
            btnExit.Name = "btnExit";
            btnExit.Size = new Size(75, 23);
            btnExit.TabIndex = 2;
            btnExit.Text = "Exit";
            btnExit.UseVisualStyleBackColor = true;
            // 
            // txtCustomerName
            // 
            txtCustomerName.Location = new Point(316, 203);
            txtCustomerName.Name = "txtCustomerName";
            txtCustomerName.Size = new Size(415, 23);
            txtCustomerName.TabIndex = 1;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = SystemColors.Info;
            ClientSize = new Size(947, 578);
            Controls.Add(btnExit);
            Controls.Add(btnContinueToPOS);
            Controls.Add(txtCustomerName);
            Controls.Add(txtCustomerAddress);
            Controls.Add(lblCustomerAddress);
            Controls.Add(lblCustomerName);
            Controls.Add(lblTitle);
            Name = "Form1";
            Text = "Form1";
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
    }
}
