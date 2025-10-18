namespace Harmoni.Models
{
    partial class ProductPage
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
            label2 = new Label();
            label4 = new Label();
            label5 = new Label();
            label6 = new Label();
            label7 = new Label();
            label8 = new Label();
            label3 = new Label();
            label9 = new Label();
            txtInterest = new TextBox();
            cmbMode = new ComboBox();
            txtInterestFine = new TextBox();
            txtName = new TextBox();
            txtTenor = new TextBox();
            txtAdminFee = new TextBox();
            txtMinAmount = new TextBox();
            txtMaxAmount = new TextBox();
            btnSubmit = new Button();
            btnNew = new Button();
            dgvLoan = new DataGridView();
            label10 = new Label();
            dgvSaving = new DataGridView();
            label11 = new Label();
            ((System.ComponentModel.ISupportInitialize)dgvLoan).BeginInit();
            ((System.ComponentModel.ISupportInitialize)dgvSaving).BeginInit();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(59, 21);
            label1.Name = "label1";
            label1.Size = new Size(59, 25);
            label1.TabIndex = 0;
            label1.Text = "Name";
            label1.Click += label1_Click;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(387, 21);
            label2.Name = "label2";
            label2.Size = new Size(59, 25);
            label2.TabIndex = 1;
            label2.Text = "Mode";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(1049, 31);
            label4.Name = "label4";
            label4.Size = new Size(108, 25);
            label4.TabIndex = 3;
            label4.Text = "Interest Fine";
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Location = new Point(63, 118);
            label5.Name = "label5";
            label5.Size = new Size(55, 25);
            label5.TabIndex = 4;
            label5.Text = "Tenor";
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Location = new Point(387, 118);
            label6.Name = "label6";
            label6.Size = new Size(97, 25);
            label6.TabIndex = 5;
            label6.Text = "Admin Fee";
            // 
            // label7
            // 
            label7.AutoSize = true;
            label7.Location = new Point(717, 118);
            label7.Name = "label7";
            label7.Size = new Size(158, 25);
            label7.TabIndex = 6;
            label7.Text = "Minimum Amount";
            label7.Click += label7_Click;
            // 
            // label8
            // 
            label8.AutoSize = true;
            label8.Location = new Point(604, 191);
            label8.Name = "label8";
            label8.Size = new Size(0, 25);
            label8.TabIndex = 7;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(717, 21);
            label3.Name = "label3";
            label3.Size = new Size(71, 25);
            label3.TabIndex = 8;
            label3.Text = "Interest";
            // 
            // label9
            // 
            label9.AutoSize = true;
            label9.Location = new Point(1049, 118);
            label9.Name = "label9";
            label9.Size = new Size(161, 25);
            label9.TabIndex = 9;
            label9.Text = "Maximum Amount";
            // 
            // txtInterest
            // 
            txtInterest.Location = new Point(717, 69);
            txtInterest.Name = "txtInterest";
            txtInterest.Size = new Size(290, 31);
            txtInterest.TabIndex = 10;
            // 
            // cmbMode
            // 
            cmbMode.FormattingEnabled = true;
            cmbMode.Location = new Point(387, 69);
            cmbMode.Name = "cmbMode";
            cmbMode.Size = new Size(290, 33);
            cmbMode.TabIndex = 11;
            // 
            // txtInterestFine
            // 
            txtInterestFine.Location = new Point(1049, 69);
            txtInterestFine.Name = "txtInterestFine";
            txtInterestFine.Size = new Size(290, 31);
            txtInterestFine.TabIndex = 12;
            // 
            // txtName
            // 
            txtName.Location = new Point(59, 69);
            txtName.Name = "txtName";
            txtName.Size = new Size(290, 31);
            txtName.TabIndex = 14;
            // 
            // txtTenor
            // 
            txtTenor.Location = new Point(59, 157);
            txtTenor.Name = "txtTenor";
            txtTenor.Size = new Size(290, 31);
            txtTenor.TabIndex = 15;
            // 
            // txtAdminFee
            // 
            txtAdminFee.Location = new Point(387, 157);
            txtAdminFee.Name = "txtAdminFee";
            txtAdminFee.Size = new Size(283, 31);
            txtAdminFee.TabIndex = 16;
            // 
            // txtMinAmount
            // 
            txtMinAmount.Location = new Point(717, 157);
            txtMinAmount.Name = "txtMinAmount";
            txtMinAmount.Size = new Size(290, 31);
            txtMinAmount.TabIndex = 17;
            // 
            // txtMaxAmount
            // 
            txtMaxAmount.Location = new Point(1049, 157);
            txtMaxAmount.Name = "txtMaxAmount";
            txtMaxAmount.Size = new Size(290, 31);
            txtMaxAmount.TabIndex = 18;
            // 
            // btnSubmit
            // 
            btnSubmit.Location = new Point(59, 209);
            btnSubmit.Name = "btnSubmit";
            btnSubmit.Size = new Size(112, 34);
            btnSubmit.TabIndex = 19;
            btnSubmit.Text = "Submit";
            btnSubmit.UseVisualStyleBackColor = true;
            // 
            // btnNew
            // 
            btnNew.Location = new Point(206, 209);
            btnNew.Name = "btnNew";
            btnNew.Size = new Size(112, 34);
            btnNew.TabIndex = 20;
            btnNew.Text = "New";
            btnNew.UseVisualStyleBackColor = true;
            // 
            // dgvLoan
            // 
            dgvLoan.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgvLoan.Location = new Point(59, 281);
            dgvLoan.Name = "dgvLoan";
            dgvLoan.RowHeadersWidth = 62;
            dgvLoan.Size = new Size(611, 320);
            dgvLoan.TabIndex = 21;
            // 
            // label10
            // 
            label10.AutoSize = true;
            label10.Location = new Point(63, 253);
            label10.Name = "label10";
            label10.Size = new Size(109, 25);
            label10.TabIndex = 22;
            label10.Text = "Master Loan";
            // 
            // dgvSaving
            // 
            dgvSaving.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgvSaving.Location = new Point(717, 281);
            dgvSaving.Name = "dgvSaving";
            dgvSaving.RowHeadersWidth = 62;
            dgvSaving.Size = new Size(622, 320);
            dgvSaving.TabIndex = 23;
            // 
            // label11
            // 
            label11.AutoSize = true;
            label11.Location = new Point(717, 253);
            label11.Name = "label11";
            label11.Size = new Size(124, 25);
            label11.TabIndex = 24;
            label11.Text = "Master Saving";
            // 
            // ProductPage
            // 
            AutoScaleDimensions = new SizeF(10F, 25F);
            AutoScaleMode = AutoScaleMode.Font;
            Controls.Add(label11);
            Controls.Add(dgvSaving);
            Controls.Add(label10);
            Controls.Add(dgvLoan);
            Controls.Add(btnNew);
            Controls.Add(btnSubmit);
            Controls.Add(txtMaxAmount);
            Controls.Add(txtMinAmount);
            Controls.Add(txtAdminFee);
            Controls.Add(txtTenor);
            Controls.Add(txtName);
            Controls.Add(txtInterestFine);
            Controls.Add(cmbMode);
            Controls.Add(txtInterest);
            Controls.Add(label9);
            Controls.Add(label3);
            Controls.Add(label8);
            Controls.Add(label7);
            Controls.Add(label6);
            Controls.Add(label5);
            Controls.Add(label4);
            Controls.Add(label2);
            Controls.Add(label1);
            Name = "ProductPage";
            Size = new Size(1371, 617);
            ((System.ComponentModel.ISupportInitialize)dgvLoan).EndInit();
            ((System.ComponentModel.ISupportInitialize)dgvSaving).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label1;
        private Label label2;
        private Label label4;
        private Label label5;
        private Label label6;
        private Label label7;
        private Label label8;
        private Label label3;
        private Label label9;
        private TextBox txtInterest;
        private ComboBox cmbMode;
        private TextBox txtInterestFine;
        private TextBox txtName;
        private TextBox txtTenor;
        private TextBox txtAdminFee;
        private TextBox txtMinAmount;
        private TextBox txtMaxAmount;
        private Button btnSubmit;
        private Button btnNew;
        private DataGridView dgvLoan;
        private Label label10;
        private DataGridView dgvSaving;
        private Label label11;
    }
}
