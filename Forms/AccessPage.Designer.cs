namespace Harmoni.Forms
{
    partial class AccessPage
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
            groupBoxAccess = new GroupBox();
            label8 = new Label();
            label7 = new Label();
            label6 = new Label();
            label5 = new Label();
            label4 = new Label();
            label3 = new Label();
            dataGridAccess = new DataGridView();
            buttonAccess = new Button();
            checkedListBoxAccess = new CheckedListBox();
            comboBoxAccess = new ComboBox();
            labelAccess = new Label();
            MemberAccess = new Label();
            groupBoxAccess.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)dataGridAccess).BeginInit();
            SuspendLayout();
            // 
            // groupBoxAccess
            // 
            groupBoxAccess.Controls.Add(label8);
            groupBoxAccess.Controls.Add(label7);
            groupBoxAccess.Controls.Add(label6);
            groupBoxAccess.Controls.Add(label5);
            groupBoxAccess.Controls.Add(label4);
            groupBoxAccess.Controls.Add(label3);
            groupBoxAccess.Location = new Point(15, 279);
            groupBoxAccess.Name = "groupBoxAccess";
            groupBoxAccess.Size = new Size(299, 241);
            groupBoxAccess.TabIndex = 13;
            groupBoxAccess.TabStop = false;
            groupBoxAccess.Text = "Details";
            // 
            // label8
            // 
            label8.AutoSize = true;
            label8.Location = new Point(10, 203);
            label8.Name = "label8";
            label8.Size = new Size(62, 20);
            label8.TabIndex = 5;
            label8.Text = "Address";
            // 
            // label7
            // 
            label7.AutoSize = true;
            label7.Location = new Point(10, 168);
            label7.Name = "label7";
            label7.Size = new Size(73, 20);
            label7.TabIndex = 4;
            label7.Text = "Phone Alt";
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Location = new Point(10, 135);
            label6.Name = "label6";
            label6.Size = new Size(50, 20);
            label6.TabIndex = 3;
            label6.Text = "Phone";
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Location = new Point(10, 101);
            label5.Name = "label5";
            label5.Size = new Size(46, 20);
            label5.TabIndex = 2;
            label5.Text = "Email";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(10, 66);
            label4.Name = "label4";
            label4.Size = new Size(71, 20);
            label4.TabIndex = 1;
            label4.Text = "Join Date";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(10, 32);
            label3.Name = "label3";
            label3.Size = new Size(76, 20);
            label3.TabIndex = 0;
            label3.Text = "Full Name";
            // 
            // dataGridAccess
            // 
            dataGridAccess.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridAccess.Location = new Point(435, 62);
            dataGridAccess.Name = "dataGridAccess";
            dataGridAccess.RowHeadersWidth = 51;
            dataGridAccess.Size = new Size(624, 499);
            dataGridAccess.TabIndex = 12;
            dataGridAccess.CellContentClick += dataGridView1_CellContentClick;
            // 
            // buttonAccess
            // 
            buttonAccess.Location = new Point(279, 62);
            buttonAccess.Name = "buttonAccess";
            buttonAccess.Size = new Size(98, 35);
            buttonAccess.TabIndex = 11;
            buttonAccess.Text = "Submit";
            buttonAccess.UseVisualStyleBackColor = true;
            // 
            // checkedListBoxAccess
            // 
            checkedListBoxAccess.FormattingEnabled = true;
            checkedListBoxAccess.Items.AddRange(new object[] { "Grant All", "Loan", "Saving", "Tranfer - InHouse", "Tranfer - Accros", "Exchange" });
            checkedListBoxAccess.Location = new Point(15, 122);
            checkedListBoxAccess.Name = "checkedListBoxAccess";
            checkedListBoxAccess.Size = new Size(299, 136);
            checkedListBoxAccess.TabIndex = 10;
            // 
            // comboBoxAccess
            // 
            comboBoxAccess.FormattingEnabled = true;
            comboBoxAccess.Location = new Point(15, 66);
            comboBoxAccess.Name = "comboBoxAccess";
            comboBoxAccess.Size = new Size(234, 28);
            comboBoxAccess.TabIndex = 9;
            // 
            // labelAccess
            // 
            labelAccess.AutoSize = true;
            labelAccess.Location = new Point(435, 31);
            labelAccess.Name = "labelAccess";
            labelAccess.Size = new Size(53, 20);
            labelAccess.TabIndex = 8;
            labelAccess.Text = "Access";
            // 
            // MemberAccess
            // 
            MemberAccess.AutoSize = true;
            MemberAccess.Location = new Point(10, 31);
            MemberAccess.Name = "MemberAccess";
            MemberAccess.Size = new Size(65, 20);
            MemberAccess.TabIndex = 7;
            MemberAccess.Text = "Member";
            // 
            // AccessPage
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            Controls.Add(groupBoxAccess);
            Controls.Add(dataGridAccess);
            Controls.Add(buttonAccess);
            Controls.Add(checkedListBoxAccess);
            Controls.Add(comboBoxAccess);
            Controls.Add(labelAccess);
            Controls.Add(MemberAccess);
            Name = "AccessPage";
            Size = new Size(1053, 561);
            groupBoxAccess.ResumeLayout(false);
            groupBoxAccess.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)dataGridAccess).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private GroupBox groupBoxAccess;
        private Label label8;
        private Label label7;
        private Label label6;
        private Label label5;
        private Label label4;
        private Label label3;
        private DataGridView dataGridAccess;
        private Button buttonAccess;
        private CheckedListBox checkedListBoxAccess;
        private ComboBox comboBoxAccess;
        private Label labelAccess;
        private Label MemberAccess;
    }
}
