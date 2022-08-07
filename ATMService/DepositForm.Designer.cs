namespace ATMService
{
    partial class DepositForm
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
            this.lblAmount = new System.Windows.Forms.Label();
            this.txtAmount = new System.Windows.Forms.TextBox();
            this.btnDepositAmount = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.txtCardNumber = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // lblAmount
            // 
            this.lblAmount.AutoSize = true;
            this.lblAmount.Location = new System.Drawing.Point(236, 125);
            this.lblAmount.Name = "lblAmount";
            this.lblAmount.Size = new System.Drawing.Size(94, 13);
            this.lblAmount.TabIndex = 0;
            this.lblAmount.Text = "ENTER AMOUNT";
            this.lblAmount.Click += new System.EventHandler(this.lblAmount_Click);
            // 
            // txtAmount
            // 
            this.txtAmount.Location = new System.Drawing.Point(336, 122);
            this.txtAmount.Name = "txtAmount";
            this.txtAmount.Size = new System.Drawing.Size(128, 20);
            this.txtAmount.TabIndex = 1;
            // 
            // btnDepositAmount
            // 
            this.btnDepositAmount.Location = new System.Drawing.Point(298, 182);
            this.btnDepositAmount.Name = "btnDepositAmount";
            this.btnDepositAmount.Size = new System.Drawing.Size(107, 31);
            this.btnDepositAmount.TabIndex = 2;
            this.btnDepositAmount.Text = "Deposit";
            this.btnDepositAmount.UseVisualStyleBackColor = true;
            this.btnDepositAmount.Click += new System.EventHandler(this.btnDepositAmount_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(236, 80);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(66, 13);
            this.label1.TabIndex = 3;
            this.label1.Text = "CardNumber";
            // 
            // txtCardNumber
            // 
            this.txtCardNumber.Location = new System.Drawing.Point(336, 73);
            this.txtCardNumber.Name = "txtCardNumber";
            this.txtCardNumber.Size = new System.Drawing.Size(128, 20);
            this.txtCardNumber.TabIndex = 4;
            // 
            // DepositForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.txtCardNumber);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.btnDepositAmount);
            this.Controls.Add(this.txtAmount);
            this.Controls.Add(this.lblAmount);
            this.Name = "DepositForm";
            this.Text = "DepositForm";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblAmount;
        private System.Windows.Forms.TextBox txtAmount;
        private System.Windows.Forms.Button btnDepositAmount;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txtCardNumber;
    }
}