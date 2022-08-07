namespace ATMService
{
    partial class WithDrawFrom
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
            this.label1 = new System.Windows.Forms.Label();
            this.txtCardNumber = new System.Windows.Forms.TextBox();
            this.btnWithDrawAmount = new System.Windows.Forms.Button();
            this.label2 = new System.Windows.Forms.Label();
            this.txtWithDraw = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(270, 65);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(66, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "CardNumber";
            // 
            // txtCardNumber
            // 
            this.txtCardNumber.Location = new System.Drawing.Point(354, 62);
            this.txtCardNumber.Name = "txtCardNumber";
            this.txtCardNumber.Size = new System.Drawing.Size(100, 20);
            this.txtCardNumber.TabIndex = 1;
            // 
            // btnWithDrawAmount
            // 
            this.btnWithDrawAmount.Location = new System.Drawing.Point(337, 177);
            this.btnWithDrawAmount.Name = "btnWithDrawAmount";
            this.btnWithDrawAmount.Size = new System.Drawing.Size(75, 23);
            this.btnWithDrawAmount.TabIndex = 2;
            this.btnWithDrawAmount.Text = "WithDraw";
            this.btnWithDrawAmount.UseVisualStyleBackColor = true;
            this.btnWithDrawAmount.Click += new System.EventHandler(this.btnWithDrawAmount_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(283, 128);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(43, 13);
            this.label2.TabIndex = 3;
            this.label2.Text = "Amount";
            // 
            // txtWithDraw
            // 
            this.txtWithDraw.Location = new System.Drawing.Point(354, 121);
            this.txtWithDraw.Name = "txtWithDraw";
            this.txtWithDraw.Size = new System.Drawing.Size(100, 20);
            this.txtWithDraw.TabIndex = 4;
            // 
            // WithDrawFrom
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.txtWithDraw);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.btnWithDrawAmount);
            this.Controls.Add(this.txtCardNumber);
            this.Controls.Add(this.label1);
            this.Name = "WithDrawFrom";
            this.Text = "WithDrawFrom";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txtCardNumber;
        private System.Windows.Forms.Button btnWithDrawAmount;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox txtWithDraw;
    }
}