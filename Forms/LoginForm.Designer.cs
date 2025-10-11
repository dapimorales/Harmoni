namespace Harmoni.Forms
{
    partial class LoginForm
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
            txtUsername = new TextBox();
            txtPassword = new TextBox();
            btnSubmit = new Button();
            btnRegis = new Button();
            linkForgot = new LinkLabel();
            label1 = new Label();
            lblvalidasi = new Label();
            label3 = new Label();
            label4 = new Label();
            pictureBox1 = new PictureBox();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            SuspendLayout();
            // 
            // txtUsername
            // 
            txtUsername.Location = new Point(439, 136);
            txtUsername.Multiline = true;
            txtUsername.Name = "txtUsername";
            txtUsername.Size = new Size(353, 27);
            txtUsername.TabIndex = 0;
            // 
            // txtPassword
            // 
            txtPassword.Location = new Point(439, 193);
            txtPassword.Multiline = true;
            txtPassword.Name = "txtPassword";
            txtPassword.Size = new Size(353, 27);
            txtPassword.TabIndex = 1;
            txtPassword.TextChanged += txtPassword_TextChanged;
            // 
            // btnSubmit
            // 
            btnSubmit.Location = new Point(439, 226);
            btnSubmit.Name = "btnSubmit";
            btnSubmit.Size = new Size(86, 29);
            btnSubmit.TabIndex = 2;
            btnSubmit.Text = "Submit";
            btnSubmit.UseVisualStyleBackColor = true;
            btnSubmit.Click += this.btnSubmit_Click;
            // 
            // btnRegis
            // 
            btnRegis.Location = new Point(439, 298);
            btnRegis.Name = "btnRegis";
            btnRegis.Size = new Size(119, 29);
            btnRegis.TabIndex = 3;
            btnRegis.Text = "Registration";
            btnRegis.UseVisualStyleBackColor = true;
            btnRegis.Click += btnRegis_Click;
            // 
            // linkForgot
            // 
            linkForgot.AutoSize = true;
            linkForgot.Location = new Point(697, 233);
            linkForgot.Name = "linkForgot";
            linkForgot.Size = new Size(95, 15);
            linkForgot.TabIndex = 4;
            linkForgot.TabStop = true;
            linkForgot.Text = "Forgot Password";
            linkForgot.LinkClicked += linkLabel1_LinkClicked;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.BackColor = SystemColors.ButtonFace;
            label1.Font = new Font("Trobus Expanded", 24F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label1.Location = new Point(523, 61);
            label1.Name = "label1";
            label1.Size = new Size(183, 31);
            label1.TabIndex = 5;
            label1.Text = "LOGIN";
            // 
            // lblvalidasi
            // 
            lblvalidasi.AutoSize = true;
            lblvalidasi.Location = new Point(439, 29);
            lblvalidasi.Name = "lblvalidasi";
            lblvalidasi.Size = new Size(16, 15);
            lblvalidasi.TabIndex = 6;
            lblvalidasi.Text = "...";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(439, 118);
            label3.Name = "label3";
            label3.Size = new Size(60, 15);
            label3.TabIndex = 7;
            label3.Text = "Username";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(439, 175);
            label4.Name = "label4";
            label4.Size = new Size(57, 15);
            label4.TabIndex = 8;
            label4.Text = "Password";
            // 
            // pictureBox1
            // 
            pictureBox1.Location = new Point(1, 0);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(403, 371);
            pictureBox1.TabIndex = 9;
            pictureBox1.TabStop = false;
            // 
            // LoginForm
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            AutoSize = true;
            ClientSize = new Size(834, 367);
            Controls.Add(pictureBox1);
            Controls.Add(label4);
            Controls.Add(label3);
            Controls.Add(lblvalidasi);
            Controls.Add(label1);
            Controls.Add(linkForgot);
            Controls.Add(btnRegis);
            Controls.Add(btnSubmit);
            Controls.Add(txtPassword);
            Controls.Add(txtUsername);
            Name = "LoginForm";
            Text = "LoginForm";
            Load += LoginForm_Load;
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private TextBox txtUsername;
        private TextBox txtPassword;
        private Button btnSubmit;
        private Button btnRegis;
        private LinkLabel linkForgot;
        private Label label1;
        private Label lblvalidasi;
        private Label label3;
        private Label label4;
        private PictureBox pictureBox1;
    }
}