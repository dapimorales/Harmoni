namespace Harmoni.Forms
{
    partial class ApprovalPage
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
            cmbProduct = new ComboBox();
            dataGridViewApproval = new DataGridView();
            ((System.ComponentModel.ISupportInitialize)dataGridViewApproval).BeginInit();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(26, 31);
            label1.Name = "label1";
            label1.Size = new Size(49, 15);
            label1.TabIndex = 0;
            label1.Text = "Product";
            // 
            // cmbProduct
            // 
            cmbProduct.FormattingEnabled = true;
            cmbProduct.Location = new Point(26, 49);
            cmbProduct.Name = "cmbProduct";
            cmbProduct.Size = new Size(198, 23);
            cmbProduct.TabIndex = 1;
            // 
            // dataGridViewApproval
            // 
            dataGridViewApproval.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridViewApproval.Location = new Point(26, 78);
            dataGridViewApproval.Name = "dataGridViewApproval";
            dataGridViewApproval.Size = new Size(918, 165);
            dataGridViewApproval.TabIndex = 2;
            // 
            // ApprovalPage
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            Controls.Add(dataGridViewApproval);
            Controls.Add(cmbProduct);
            Controls.Add(label1);
            Name = "ApprovalPage";
            Size = new Size(969, 269);
            ((System.ComponentModel.ISupportInitialize)dataGridViewApproval).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label1;
        private ComboBox cmbProduct;
        private DataGridView dataGridViewApproval;
    }
}
