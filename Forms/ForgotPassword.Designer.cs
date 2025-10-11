namespace Harmoni.Forms
{
    partial class ForgotPassword
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
            label1 = new Label();
            label2 = new Label();
            label3 = new Label();
            label4 = new Label();
            usernametext = new TextBox();
            colortext = new TextBox();
            singertext = new TextBox();
            passwordtext = new TextBox();
            buttonsubmit = new Button();
            buttonback = new Button();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(79, 65);
            label1.Name = "label1";
            label1.Size = new Size(75, 20);
            label1.TabIndex = 0;
            label1.Text = "Username";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(79, 170);
            label2.Name = "label2";
            label2.Size = new Size(163, 20);
            label2.TabIndex = 1;
            label2.Text = "What Is Your Fav Color?";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(468, 170);
            label3.Name = "label3";
            label3.Size = new Size(210, 20);
            label3.TabIndex = 2;
            label3.Text = "What Is Your Fav Artist/Singer?";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(79, 364);
            label4.Name = "label4";
            label4.Size = new Size(70, 20);
            label4.TabIndex = 3;
            label4.Text = "Password";
            // 
            // usernametext
            // 
            usernametext.Location = new Point(79, 88);
            usernametext.Name = "usernametext";
            usernametext.Size = new Size(247, 27);
            usernametext.TabIndex = 4;
            // 
            // colortext
            // 
            colortext.Location = new Point(79, 193);
            colortext.Name = "colortext";
            colortext.Size = new Size(247, 27);
            colortext.TabIndex = 5;
            // 
            // singertext
            // 
            singertext.Location = new Point(468, 193);
            singertext.Name = "singertext";
            singertext.Size = new Size(247, 27);
            singertext.TabIndex = 6;
            // 
            // passwordtext
            // 
            passwordtext.Location = new Point(79, 387);
            passwordtext.Name = "passwordtext";
            passwordtext.Size = new Size(247, 27);
            passwordtext.TabIndex = 7;
            // 
            // buttonsubmit
            // 
            buttonsubmit.Location = new Point(89, 252);
            buttonsubmit.Name = "buttonsubmit";
            buttonsubmit.Size = new Size(94, 29);
            buttonsubmit.TabIndex = 8;
            buttonsubmit.Text = "Submit";
            buttonsubmit.UseVisualStyleBackColor = true;
            // 
            // buttonback
            // 
            buttonback.Location = new Point(232, 252);
            buttonback.Name = "buttonback";
            buttonback.Size = new Size(94, 29);
            buttonback.TabIndex = 9;
            buttonback.Text = "Back";
            buttonback.UseVisualStyleBackColor = true;
            // 
            // ForgotPassword
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(880, 501);
            Controls.Add(buttonback);
            Controls.Add(buttonsubmit);
            Controls.Add(passwordtext);
            Controls.Add(singertext);
            Controls.Add(colortext);
            Controls.Add(usernametext);
            Controls.Add(label4);
            Controls.Add(label3);
            Controls.Add(label2);
            Controls.Add(label1);
            Name = "ForgotPassword";
            Text = "ForgotPassword";
            Load += ForgotPassword_Load;
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label1;
        private Label label2;
        private Label label3;
        private Label label4;
        private TextBox usernametext;
        private TextBox colortext;
        private TextBox singertext;
        private TextBox passwordtext;
        private Button buttonsubmit;
        private Button buttonback;
    }
}