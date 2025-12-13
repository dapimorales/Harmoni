namespace Harmoni.Forms.PublicMenus
{
    partial class ExchangePage
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

        #region Component Designer generated code

        /// <summary> 
        /// Required method for Designer support - do not modify 
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            label1 = new Label();
            txtAmount = new TextBox();
            btnSubmit = new Button();
            label2 = new Label();
            label3 = new Label();
            label4 = new Label();
            label5 = new Label();
            label6 = new Label();
            txtSubTotal = new TextBox();
            txtRate = new TextBox();
            txtFee = new TextBox();
            txtTotal = new TextBox();
            btnClear = new Button();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI Black", 14F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label1.Location = new Point(206, 53);
            label1.Name = "label1";
            label1.Size = new Size(214, 38);
            label1.TabIndex = 0;
            label1.Text = "Exchange USD";
            // 
            // txtAmount
            // 
            txtAmount.Location = new Point(246, 172);
            txtAmount.Name = "txtAmount";
            txtAmount.Size = new Size(150, 31);
            txtAmount.TabIndex = 1;
            txtAmount.TextChanged += txtAmount_TextChanged;
            // 
            // btnSubmit
            // 
            btnSubmit.Location = new Point(183, 442);
            btnSubmit.Name = "btnSubmit";
            btnSubmit.Size = new Size(112, 34);
            btnSubmit.TabIndex = 2;
            btnSubmit.Text = "Submit";
            btnSubmit.UseVisualStyleBackColor = true;
            btnSubmit.Click += btnSubmit_Click;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(97, 172);
            label2.Name = "label2";
            label2.Size = new Size(77, 25);
            label2.TabIndex = 3;
            label2.Text = "Amount";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(97, 276);
            label3.Name = "label3";
            label3.Size = new Size(85, 25);
            label3.TabIndex = 4;
            label3.Text = "Sub Total";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(97, 223);
            label4.Name = "label4";
            label4.Size = new Size(47, 25);
            label4.TabIndex = 5;
            label4.Text = "Rate";
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Location = new Point(97, 373);
            label5.Name = "label5";
            label5.Size = new Size(49, 25);
            label5.TabIndex = 6;
            label5.Text = "Total";
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Location = new Point(97, 328);
            label6.Name = "label6";
            label6.Size = new Size(39, 25);
            label6.TabIndex = 7;
            label6.Text = "Fee";
            // 
            // txtSubTotal
            // 
            txtSubTotal.Location = new Point(246, 273);
            txtSubTotal.Name = "txtSubTotal";
            txtSubTotal.Size = new Size(150, 31);
            txtSubTotal.TabIndex = 8;
            // 
            // txtRate
            // 
            txtRate.Location = new Point(247, 220);
            txtRate.Name = "txtRate";
            txtRate.Size = new Size(150, 31);
            txtRate.TabIndex = 9;
            // 
            // txtFee
            // 
            txtFee.Location = new Point(246, 325);
            txtFee.Name = "txtFee";
            txtFee.Size = new Size(150, 31);
            txtFee.TabIndex = 10;
            // 
            // txtTotal
            // 
            txtTotal.Location = new Point(246, 370);
            txtTotal.Name = "txtTotal";
            txtTotal.Size = new Size(150, 31);
            txtTotal.TabIndex = 11;
            // 
            // btnClear
            // 
            btnClear.Location = new Point(340, 442);
            btnClear.Name = "btnClear";
            btnClear.Size = new Size(112, 34);
            btnClear.TabIndex = 12;
            btnClear.Text = "Clear";
            btnClear.UseVisualStyleBackColor = true;
            btnClear.Click += btnClear_Click;
            // 
            // ExchangePage
            // 
            AutoScaleDimensions = new SizeF(10F, 25F);
            AutoScaleMode = AutoScaleMode.Font;
            Controls.Add(btnClear);
            Controls.Add(txtTotal);
            Controls.Add(txtFee);
            Controls.Add(txtRate);
            Controls.Add(txtSubTotal);
            Controls.Add(label6);
            Controls.Add(label5);
            Controls.Add(label4);
            Controls.Add(label3);
            Controls.Add(label2);
            Controls.Add(btnSubmit);
            Controls.Add(txtAmount);
            Controls.Add(label1);
            Name = "ExchangePage";
            Size = new Size(648, 612);
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label1;
        private TextBox txtAmount;
        private Button btnSubmit;
        private Label label2;
        private Label label3;
        private Label label4;
        private Label label5;
        private Label label6;
        private TextBox txtSubTotal;
        private TextBox txtRate;
        private TextBox txtFee;
        private TextBox txtTotal;
        private Button btnClear;
    }
}
