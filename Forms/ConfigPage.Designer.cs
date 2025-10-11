namespace Harmoni.Forms
{
    partial class ConfigPage
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
            textBoxTermin1 = new TextBox();
            textBoxTermin2 = new TextBox();
            textBoxTermin3 = new TextBox();
            label1 = new Label();
            label2 = new Label();
            label3 = new Label();
            textBoxExchangeRate = new TextBox();
            textBoxInHouseFee = new TextBox();
            textBoxAcrossFee = new TextBox();
            label4 = new Label();
            label5 = new Label();
            label6 = new Label();
            btnUpdate = new Button();
            SuspendLayout();
            // 
            // textBoxTermin1
            // 
            textBoxTermin1.Location = new Point(33, 41);
            textBoxTermin1.Multiline = true;
            textBoxTermin1.Name = "textBoxTermin1";
            textBoxTermin1.Size = new Size(312, 339);
            textBoxTermin1.TabIndex = 0;
            // 
            // textBoxTermin2
            // 
            textBoxTermin2.Location = new Point(377, 39);
            textBoxTermin2.Multiline = true;
            textBoxTermin2.Name = "textBoxTermin2";
            textBoxTermin2.Size = new Size(312, 339);
            textBoxTermin2.TabIndex = 1;
            // 
            // textBoxTermin3
            // 
            textBoxTermin3.Location = new Point(721, 38);
            textBoxTermin3.Multiline = true;
            textBoxTermin3.Name = "textBoxTermin3";
            textBoxTermin3.Size = new Size(312, 339);
            textBoxTermin3.TabIndex = 2;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(33, 13);
            label1.Name = "label1";
            label1.Size = new Size(120, 25);
            label1.TabIndex = 3;
            label1.Text = "Terminologi 1";
            label1.Click += label1_Click;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(377, 13);
            label2.Name = "label2";
            label2.Size = new Size(120, 25);
            label2.TabIndex = 4;
            label2.Text = "Terminologi 2";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(721, 13);
            label3.Name = "label3";
            label3.Size = new Size(120, 25);
            label3.TabIndex = 5;
            label3.Text = "Terminologi 3";
            // 
            // textBoxExchangeRate
            // 
            textBoxExchangeRate.Location = new Point(33, 422);
            textBoxExchangeRate.Name = "textBoxExchangeRate";
            textBoxExchangeRate.Size = new Size(312, 31);
            textBoxExchangeRate.TabIndex = 6;
            // 
            // textBoxInHouseFee
            // 
            textBoxInHouseFee.Location = new Point(377, 422);
            textBoxInHouseFee.Name = "textBoxInHouseFee";
            textBoxInHouseFee.Size = new Size(312, 31);
            textBoxInHouseFee.TabIndex = 7;
            // 
            // textBoxAcrossFee
            // 
            textBoxAcrossFee.Location = new Point(721, 422);
            textBoxAcrossFee.Name = "textBoxAcrossFee";
            textBoxAcrossFee.Size = new Size(312, 31);
            textBoxAcrossFee.TabIndex = 8;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(33, 394);
            label4.Name = "label4";
            label4.Size = new Size(126, 25);
            label4.TabIndex = 9;
            label4.Text = "Exchange Rate";
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Location = new Point(377, 394);
            label5.Name = "label5";
            label5.Size = new Size(110, 25);
            label5.TabIndex = 10;
            label5.Text = "InHouse Fee";
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Location = new Point(721, 394);
            label6.Name = "label6";
            label6.Size = new Size(97, 25);
            label6.TabIndex = 11;
            label6.Text = "Across Fee";
            // 
            // btnUpdate
            // 
            btnUpdate.Location = new Point(479, 472);
            btnUpdate.Name = "btnUpdate";
            btnUpdate.Size = new Size(112, 37);
            btnUpdate.TabIndex = 12;
            btnUpdate.Text = "Update";
            btnUpdate.UseVisualStyleBackColor = true;
            // 
            // ConfigPage
            // 
            AutoScaleDimensions = new SizeF(10F, 25F);
            AutoScaleMode = AutoScaleMode.Font;
            Controls.Add(btnUpdate);
            Controls.Add(label6);
            Controls.Add(label5);
            Controls.Add(label4);
            Controls.Add(textBoxAcrossFee);
            Controls.Add(textBoxInHouseFee);
            Controls.Add(textBoxExchangeRate);
            Controls.Add(label3);
            Controls.Add(label2);
            Controls.Add(label1);
            Controls.Add(textBoxTermin3);
            Controls.Add(textBoxTermin2);
            Controls.Add(textBoxTermin1);
            Name = "ConfigPage";
            Size = new Size(1070, 549);
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private TextBox textBoxTermin1;
        private TextBox textBoxTermin2;
        private TextBox textBoxTermin3;
        private Label label1;
        private Label label2;
        private Label label3;
        private TextBox textBoxExchangeRate;
        private TextBox textBoxInHouseFee;
        private TextBox textBoxAcrossFee;
        private Label label4;
        private Label label5;
        private Label label6;
        private Button btnUpdate;
    }
}
