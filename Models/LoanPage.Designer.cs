namespace Harmoni.Models
{
    partial class LoanPage
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
            lblLoanID = new Label();
            txtLoanID = new TextBox();
            label2 = new Label();
            label3 = new Label();
            txtAdminFee = new TextBox();
            label4 = new Label();
            label5 = new Label();
            lblAmount = new Label();
            label7 = new Label();
            label8 = new Label();
            label9 = new Label();
            label10 = new Label();
            label11 = new Label();
            label12 = new Label();
            btnBrowseKTP = new Button();
            btnShowKTP = new Button();
            btnBrowseSlipGaji = new Button();
            btnBrowseDocumentKK = new Button();
            btnShowSlipGaji = new Button();
            btnShowDocumentKK = new Button();
            btnApplyLoan = new Button();
            btnNewLoan = new Button();
            dgvLoan = new DataGridView();
            label13 = new Label();
            btnReload = new Button();
            cmbLoanType = new ComboBox();
            txtMinAmount = new TextBox();
            txtDueDate = new TextBox();
            txtDocumentKK = new TextBox();
            txtAmount = new TextBox();
            txtInterest = new TextBox();
            txtTenor = new TextBox();
            txtMaxAmount = new TextBox();
            txtDocumentKTP = new TextBox();
            txtDocumentSlipGaji = new TextBox();
            label14 = new Label();
            txtInterestFine = new TextBox();
            ((System.ComponentModel.ISupportInitialize)dgvLoan).BeginInit();
            SuspendLayout();
            // 
            // lblLoanID
            // 
            lblLoanID.AutoSize = true;
            lblLoanID.Location = new Point(40, 36);
            lblLoanID.Name = "lblLoanID";
            lblLoanID.Size = new Size(47, 15);
            lblLoanID.TabIndex = 0;
            lblLoanID.Text = "Loan ID";
            // 
            // txtLoanID
            // 
            txtLoanID.Location = new Point(40, 54);
            txtLoanID.Name = "txtLoanID";
            txtLoanID.Size = new Size(193, 23);
            txtLoanID.TabIndex = 1;
            txtLoanID.TextChanged += txtLoanID_TextChanged;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(40, 91);
            label2.Name = "label2";
            label2.Size = new Size(61, 15);
            label2.TabIndex = 2;
            label2.Text = "Loan Type";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(40, 143);
            label3.Name = "label3";
            label3.Size = new Size(64, 15);
            label3.TabIndex = 4;
            label3.Text = "Admin Fee";
            // 
            // txtAdminFee
            // 
            txtAdminFee.Location = new Point(40, 161);
            txtAdminFee.Name = "txtAdminFee";
            txtAdminFee.Size = new Size(193, 23);
            txtAdminFee.TabIndex = 7;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(40, 197);
            label4.Name = "label4";
            label4.Size = new Size(75, 15);
            label4.TabIndex = 8;
            label4.Text = "Min Amount";
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Location = new Point(279, 197);
            label5.Name = "label5";
            label5.Size = new Size(76, 15);
            label5.TabIndex = 9;
            label5.Text = "Max Amount";
            // 
            // lblAmount
            // 
            lblAmount.AutoSize = true;
            lblAmount.Location = new Point(279, 36);
            lblAmount.Name = "lblAmount";
            lblAmount.Size = new Size(51, 15);
            lblAmount.TabIndex = 10;
            lblAmount.Text = "Amount";
            // 
            // label7
            // 
            label7.AutoSize = true;
            label7.Location = new Point(279, 91);
            label7.Name = "label7";
            label7.Size = new Size(46, 15);
            label7.TabIndex = 11;
            label7.Text = "Interest";
            // 
            // label8
            // 
            label8.AutoSize = true;
            label8.Location = new Point(279, 143);
            label8.Name = "label8";
            label8.Size = new Size(37, 15);
            label8.TabIndex = 12;
            label8.Text = "Tenor";
            // 
            // label9
            // 
            label9.AutoSize = true;
            label9.Location = new Point(279, 252);
            label9.Name = "label9";
            label9.Size = new Size(87, 15);
            label9.TabIndex = 13;
            label9.Text = "Document KTP";
            label9.Click += label9_Click;
            // 
            // label10
            // 
            label10.AutoSize = true;
            label10.Location = new Point(40, 296);
            label10.Name = "label10";
            label10.Size = new Size(55, 15);
            label10.TabIndex = 17;
            label10.Text = "Due Date";
            // 
            // label11
            // 
            label11.AutoSize = true;
            label11.Location = new Point(40, 347);
            label11.Name = "label11";
            label11.Size = new Size(80, 15);
            label11.TabIndex = 19;
            label11.Text = "Document KK";
            // 
            // label12
            // 
            label12.AutoSize = true;
            label12.Location = new Point(279, 347);
            label12.Name = "label12";
            label12.Size = new Size(108, 15);
            label12.TabIndex = 20;
            label12.Text = "Document Slip Gaji";
            // 
            // btnBrowseKTP
            // 
            btnBrowseKTP.Location = new Point(279, 314);
            btnBrowseKTP.Name = "btnBrowseKTP";
            btnBrowseKTP.Size = new Size(75, 23);
            btnBrowseKTP.TabIndex = 21;
            btnBrowseKTP.Text = "Browse";
            btnBrowseKTP.UseVisualStyleBackColor = true;
            // 
            // btnShowKTP
            // 
            btnShowKTP.Location = new Point(392, 314);
            btnShowKTP.Name = "btnShowKTP";
            btnShowKTP.Size = new Size(75, 23);
            btnShowKTP.TabIndex = 22;
            btnShowKTP.Text = "Show";
            btnShowKTP.UseVisualStyleBackColor = true;
            btnShowKTP.Click += button2_Click;
            // 
            // btnBrowseSlipGaji
            // 
            btnBrowseSlipGaji.Location = new Point(274, 427);
            btnBrowseSlipGaji.Name = "btnBrowseSlipGaji";
            btnBrowseSlipGaji.Size = new Size(75, 23);
            btnBrowseSlipGaji.TabIndex = 24;
            btnBrowseSlipGaji.Text = "Browse";
            btnBrowseSlipGaji.UseVisualStyleBackColor = true;
            // 
            // btnBrowseDocumentKK
            // 
            btnBrowseDocumentKK.Location = new Point(40, 427);
            btnBrowseDocumentKK.Name = "btnBrowseDocumentKK";
            btnBrowseDocumentKK.Size = new Size(75, 23);
            btnBrowseDocumentKK.TabIndex = 25;
            btnBrowseDocumentKK.Text = "Browse";
            btnBrowseDocumentKK.UseVisualStyleBackColor = true;
            // 
            // btnShowSlipGaji
            // 
            btnShowSlipGaji.Location = new Point(375, 427);
            btnShowSlipGaji.Name = "btnShowSlipGaji";
            btnShowSlipGaji.Size = new Size(75, 23);
            btnShowSlipGaji.TabIndex = 26;
            btnShowSlipGaji.Text = "Show";
            btnShowSlipGaji.UseVisualStyleBackColor = true;
            btnShowSlipGaji.Click += button5_Click;
            // 
            // btnShowDocumentKK
            // 
            btnShowDocumentKK.Location = new Point(144, 427);
            btnShowDocumentKK.Name = "btnShowDocumentKK";
            btnShowDocumentKK.Size = new Size(75, 23);
            btnShowDocumentKK.TabIndex = 27;
            btnShowDocumentKK.Text = "Show";
            btnShowDocumentKK.UseVisualStyleBackColor = true;
            // 
            // btnApplyLoan
            // 
            btnApplyLoan.Location = new Point(115, 490);
            btnApplyLoan.Name = "btnApplyLoan";
            btnApplyLoan.Size = new Size(132, 23);
            btnApplyLoan.TabIndex = 29;
            btnApplyLoan.Text = "Apply Loan";
            btnApplyLoan.UseVisualStyleBackColor = true;
            // 
            // btnNewLoan
            // 
            btnNewLoan.Location = new Point(253, 490);
            btnNewLoan.Name = "btnNewLoan";
            btnNewLoan.Size = new Size(132, 23);
            btnNewLoan.TabIndex = 30;
            btnNewLoan.Text = "New Loan";
            btnNewLoan.UseVisualStyleBackColor = true;
            // 
            // dgvLoan
            // 
            dgvLoan.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgvLoan.Location = new Point(519, 54);
            dgvLoan.Name = "dgvLoan";
            dgvLoan.Size = new Size(580, 459);
            dgvLoan.TabIndex = 31;
            // 
            // label13
            // 
            label13.AutoSize = true;
            label13.Location = new Point(519, 36);
            label13.Name = "label13";
            label13.Size = new Size(36, 15);
            label13.TabIndex = 32;
            label13.Text = "Loan ";
            // 
            // btnReload
            // 
            btnReload.Location = new Point(777, 519);
            btnReload.Name = "btnReload";
            btnReload.Size = new Size(132, 23);
            btnReload.TabIndex = 33;
            btnReload.Text = "Reload";
            btnReload.UseVisualStyleBackColor = true;
            // 
            // cmbLoanType
            // 
            cmbLoanType.FormattingEnabled = true;
            cmbLoanType.Location = new Point(40, 109);
            cmbLoanType.Name = "cmbLoanType";
            cmbLoanType.Size = new Size(193, 23);
            cmbLoanType.TabIndex = 34;
            // 
            // txtMinAmount
            // 
            txtMinAmount.Location = new Point(40, 215);
            txtMinAmount.Name = "txtMinAmount";
            txtMinAmount.Size = new Size(193, 23);
            txtMinAmount.TabIndex = 35;
            // 
            // txtDueDate
            // 
            txtDueDate.Location = new Point(40, 314);
            txtDueDate.Name = "txtDueDate";
            txtDueDate.Size = new Size(193, 23);
            txtDueDate.TabIndex = 36;
            txtDueDate.TextChanged += textBox4_TextChanged;
            // 
            // txtDocumentKK
            // 
            txtDocumentKK.Location = new Point(40, 365);
            txtDocumentKK.Name = "txtDocumentKK";
            txtDocumentKK.Size = new Size(193, 23);
            txtDocumentKK.TabIndex = 37;
            // 
            // txtAmount
            // 
            txtAmount.Location = new Point(274, 54);
            txtAmount.Name = "txtAmount";
            txtAmount.Size = new Size(193, 23);
            txtAmount.TabIndex = 38;
            // 
            // txtInterest
            // 
            txtInterest.Location = new Point(279, 109);
            txtInterest.Name = "txtInterest";
            txtInterest.Size = new Size(193, 23);
            txtInterest.TabIndex = 39;
            // 
            // txtTenor
            // 
            txtTenor.Location = new Point(279, 161);
            txtTenor.Name = "txtTenor";
            txtTenor.Size = new Size(193, 23);
            txtTenor.TabIndex = 40;
            // 
            // txtMaxAmount
            // 
            txtMaxAmount.Location = new Point(279, 215);
            txtMaxAmount.Name = "txtMaxAmount";
            txtMaxAmount.Size = new Size(193, 23);
            txtMaxAmount.TabIndex = 41;
            // 
            // txtDocumentKTP
            // 
            txtDocumentKTP.Location = new Point(279, 270);
            txtDocumentKTP.Name = "txtDocumentKTP";
            txtDocumentKTP.Size = new Size(193, 23);
            txtDocumentKTP.TabIndex = 42;
            // 
            // txtDocumentSlipGaji
            // 
            txtDocumentSlipGaji.Location = new Point(279, 365);
            txtDocumentSlipGaji.Name = "txtDocumentSlipGaji";
            txtDocumentSlipGaji.Size = new Size(193, 23);
            txtDocumentSlipGaji.TabIndex = 43;
            // 
            // label14
            // 
            label14.AutoSize = true;
            label14.Location = new Point(40, 252);
            label14.Name = "label14";
            label14.Size = new Size(71, 15);
            label14.TabIndex = 44;
            label14.Text = "Interest Fine";
            // 
            // txtInterestFine
            // 
            txtInterestFine.Location = new Point(40, 270);
            txtInterestFine.Name = "txtInterestFine";
            txtInterestFine.Size = new Size(193, 23);
            txtInterestFine.TabIndex = 45;
            // 
            // LoanPage
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            Controls.Add(txtInterestFine);
            Controls.Add(label14);
            Controls.Add(txtDocumentSlipGaji);
            Controls.Add(txtDocumentKTP);
            Controls.Add(txtMaxAmount);
            Controls.Add(txtTenor);
            Controls.Add(txtInterest);
            Controls.Add(txtAmount);
            Controls.Add(txtDocumentKK);
            Controls.Add(txtDueDate);
            Controls.Add(txtMinAmount);
            Controls.Add(cmbLoanType);
            Controls.Add(btnReload);
            Controls.Add(label13);
            Controls.Add(dgvLoan);
            Controls.Add(btnNewLoan);
            Controls.Add(btnApplyLoan);
            Controls.Add(btnShowDocumentKK);
            Controls.Add(btnShowSlipGaji);
            Controls.Add(btnBrowseDocumentKK);
            Controls.Add(btnBrowseSlipGaji);
            Controls.Add(btnShowKTP);
            Controls.Add(btnBrowseKTP);
            Controls.Add(label12);
            Controls.Add(label11);
            Controls.Add(label10);
            Controls.Add(label9);
            Controls.Add(label8);
            Controls.Add(label7);
            Controls.Add(lblAmount);
            Controls.Add(label5);
            Controls.Add(label4);
            Controls.Add(txtAdminFee);
            Controls.Add(label3);
            Controls.Add(label2);
            Controls.Add(txtLoanID);
            Controls.Add(lblLoanID);
            Name = "LoanPage";
            Size = new Size(1116, 555);
            ((System.ComponentModel.ISupportInitialize)dgvLoan).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label lblLoanID;
        private TextBox txtLoanID;
        private Label label2;
        private Label label3;
        private TextBox txtAdminFee;
        private Label label4;
        private Label label5;
        private Label lblAmount;
        private Label label7;
        private Label label8;
        private Label label9;
        private Label label10;
        private Label label11;
        private Label label12;
        private Button btnBrowseKTP;
        private Button btnShowKTP;
        private Button btnBrowseSlipGaji;
        private Button btnBrowseDocumentKK;
        private Button btnShowSlipGaji;
        private Button btnShowDocumentKK;
        private Button btnApplyLoan;
        private Button btnNewLoan;
        private DataGridView dgvLoan;
        private Label label13;
        private Button btnReload;
        private ComboBox cmbLoanType;
        private TextBox txtMinAmount;
        private TextBox txtDueDate;
        private TextBox txtDocumentKK;
        private TextBox txtAmount;
        private TextBox txtInterest;
        private TextBox txtTenor;
        private TextBox txtMaxAmount;
        private TextBox txtDocumentKTP;
        private TextBox txtDocumentSlipGaji;
        private Label label14;
        private TextBox txtInterestFine;
    }
}
