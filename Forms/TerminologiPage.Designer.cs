namespace Harmoni.Forms
{
    partial class TerminologiPage
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
            AccrossTerminologi = new Label();
            InhouseTerminologi = new Label();
            ExchangeTerminologi = new Label();
            SuspendLayout();
            // 
            // AccrossTerminologi
            // 
            AccrossTerminologi.AutoSize = true;
            AccrossTerminologi.Location = new Point(874, 417);
            AccrossTerminologi.Name = "AccrossTerminologi";
            AccrossTerminologi.Size = new Size(82, 20);
            AccrossTerminologi.TabIndex = 5;
            AccrossTerminologi.Text = "Across Fee:";
            // 
            // InhouseTerminologi
            // 
            InhouseTerminologi.AutoSize = true;
            InhouseTerminologi.Location = new Point(490, 417);
            InhouseTerminologi.Name = "InhouseTerminologi";
            InhouseTerminologi.Size = new Size(90, 20);
            InhouseTerminologi.TabIndex = 4;
            InhouseTerminologi.Text = "Inhouse Fee:";
            // 
            // ExchangeTerminologi
            // 
            ExchangeTerminologi.AutoSize = true;
            ExchangeTerminologi.Location = new Point(90, 417);
            ExchangeTerminologi.Name = "ExchangeTerminologi";
            ExchangeTerminologi.Size = new Size(109, 20);
            ExchangeTerminologi.TabIndex = 3;
            ExchangeTerminologi.Text = "Exchange Rate:";
            // 
            // TerminologiPage
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            Controls.Add(AccrossTerminologi);
            Controls.Add(InhouseTerminologi);
            Controls.Add(ExchangeTerminologi);
            Name = "TerminologiPage";
            Size = new Size(1130, 565);
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label AccrossTerminologi;
        private Label InhouseTerminologi;
        private Label ExchangeTerminologi;
    }
}
