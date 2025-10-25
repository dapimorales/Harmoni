﻿namespace Harmoni.Forms
{
    partial class HomeForm
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
            menuStrip1 = new MenuStrip();
            fileToolStripMenuItem = new ToolStripMenuItem();
            dashboardToolStripMenuItem = new ToolStripMenuItem();
            terminologiToolStripMenuItem = new ToolStripMenuItem();
            logoutToolStripMenuItem = new ToolStripMenuItem();
            profileToolStripMenuItem = new ToolStripMenuItem();
            loanToolStripMenuItem = new ToolStripMenuItem();
            savingToolStripMenuItem = new ToolStripMenuItem();
            transferToolStripMenuItem = new ToolStripMenuItem();
            inhouseToolStripMenuItem = new ToolStripMenuItem();
            acrossToolStripMenuItem = new ToolStripMenuItem();
            exchangeToolStripMenuItem = new ToolStripMenuItem();
            historyToolStripMenuItem = new ToolStripMenuItem();
            panelDisplay = new Panel();
            menuStrip1.SuspendLayout();
            SuspendLayout();
            // 
            // menuStrip1
            // 
            menuStrip1.ImageScalingSize = new Size(20, 20);
            menuStrip1.Items.AddRange(new ToolStripItem[] { fileToolStripMenuItem, profileToolStripMenuItem, loanToolStripMenuItem, savingToolStripMenuItem, transferToolStripMenuItem, exchangeToolStripMenuItem, historyToolStripMenuItem });
            menuStrip1.Location = new Point(0, 0);
            menuStrip1.Name = "menuStrip1";
            menuStrip1.Size = new Size(1039, 28);
            menuStrip1.TabIndex = 0;
            menuStrip1.Text = "menuStrip1";
            // 
            // fileToolStripMenuItem
            // 
            fileToolStripMenuItem.DropDownItems.AddRange(new ToolStripItem[] { dashboardToolStripMenuItem, terminologiToolStripMenuItem, logoutToolStripMenuItem });
            fileToolStripMenuItem.Name = "fileToolStripMenuItem";
            fileToolStripMenuItem.Size = new Size(46, 24);
            fileToolStripMenuItem.Text = "File";
            // 
            // dashboardToolStripMenuItem
            // 
            dashboardToolStripMenuItem.Name = "dashboardToolStripMenuItem";
            dashboardToolStripMenuItem.Size = new Size(172, 26);
            dashboardToolStripMenuItem.Text = "Dashboard";
            // 
            // terminologiToolStripMenuItem
            // 
            terminologiToolStripMenuItem.Name = "terminologiToolStripMenuItem";
            terminologiToolStripMenuItem.Size = new Size(172, 26);
            terminologiToolStripMenuItem.Text = "Terminologi";
            // 
            // logoutToolStripMenuItem
            // 
            logoutToolStripMenuItem.Name = "logoutToolStripMenuItem";
            logoutToolStripMenuItem.Size = new Size(172, 26);
            logoutToolStripMenuItem.Text = "Logout";
            // 
            // profileToolStripMenuItem
            // 
            profileToolStripMenuItem.Name = "profileToolStripMenuItem";
            profileToolStripMenuItem.Size = new Size(66, 24);
            profileToolStripMenuItem.Text = "Profile";
            // 
            // loanToolStripMenuItem
            // 
            loanToolStripMenuItem.Name = "loanToolStripMenuItem";
            loanToolStripMenuItem.Size = new Size(55, 24);
            loanToolStripMenuItem.Text = "Loan";
            // 
            // savingToolStripMenuItem
            // 
            savingToolStripMenuItem.Name = "savingToolStripMenuItem";
            savingToolStripMenuItem.Size = new Size(67, 24);
            savingToolStripMenuItem.Text = "Saving";
            // 
            // transferToolStripMenuItem
            // 
            transferToolStripMenuItem.DropDownItems.AddRange(new ToolStripItem[] { inhouseToolStripMenuItem, acrossToolStripMenuItem });
            transferToolStripMenuItem.Name = "transferToolStripMenuItem";
            transferToolStripMenuItem.Size = new Size(69, 24);
            transferToolStripMenuItem.Text = "Tranfer";
            // 
            // inhouseToolStripMenuItem
            // 
            inhouseToolStripMenuItem.Name = "inhouseToolStripMenuItem";
            inhouseToolStripMenuItem.Size = new Size(224, 26);
            inhouseToolStripMenuItem.Text = "Inhouse";
            // 
            // acrossToolStripMenuItem
            // 
            acrossToolStripMenuItem.Name = "acrossToolStripMenuItem";
            acrossToolStripMenuItem.Size = new Size(224, 26);
            acrossToolStripMenuItem.Text = "Across";
            // 
            // exchangeToolStripMenuItem
            // 
            exchangeToolStripMenuItem.Name = "exchangeToolStripMenuItem";
            exchangeToolStripMenuItem.Size = new Size(86, 24);
            exchangeToolStripMenuItem.Text = "Exchange";
            // 
            // historyToolStripMenuItem
            // 
            historyToolStripMenuItem.Name = "historyToolStripMenuItem";
            historyToolStripMenuItem.Size = new Size(70, 24);
            historyToolStripMenuItem.Text = "History";
            // 
            // panelDisplay
            // 
            panelDisplay.Location = new Point(498, 127);
            panelDisplay.Name = "panelDisplay";
            panelDisplay.Size = new Size(250, 125);
            panelDisplay.TabIndex = 1;
            // 
            // HomeForm
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1039, 534);
            Controls.Add(panelDisplay);
            Controls.Add(menuStrip1);
            MainMenuStrip = menuStrip1;
            Name = "HomeForm";
            Text = "HomeForm";
            Load += HomeForm_Load;
            menuStrip1.ResumeLayout(false);
            menuStrip1.PerformLayout();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private MenuStrip menuStrip1;
        private ToolStripMenuItem fileToolStripMenuItem;
        private ToolStripMenuItem profileToolStripMenuItem;
        private ToolStripMenuItem dashboardToolStripMenuItem;
        private ToolStripMenuItem terminologiToolStripMenuItem;
        private ToolStripMenuItem logoutToolStripMenuItem;
        private ToolStripMenuItem loanToolStripMenuItem;
        private ToolStripMenuItem savingToolStripMenuItem;
        private ToolStripMenuItem transferToolStripMenuItem;
        private ToolStripMenuItem exchangeToolStripMenuItem;
        private ToolStripMenuItem historyToolStripMenuItem;
        private Panel panelDisplay;
        private ToolStripMenuItem inhouseToolStripMenuItem;
        private ToolStripMenuItem acrossToolStripMenuItem;
    }
}