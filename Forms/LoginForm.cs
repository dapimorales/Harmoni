using BraveHeroCooperation.Forms;
using Harmoni.Data;
using Harmoni.Models;
using Harmoni.Services;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Harmoni.Forms
{
    public partial class LoginForm : Form
    {

        public Member? LoggedInUser { get; private set; }
        public LoginForm()
        {
            InitializeComponent();
        }

        public void setSuccessAlert(String message)
        {
            lblvalidasi.Text = message;
            lblvalidasi.Visible = true;
        }

        private void linkLabel1_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            this.Hide();
            ForgotPasswordForm form = new ForgotPasswordForm();
            form.ShowDialog();
        }

        private void txtUsername_TextChanged(object sender, EventArgs e)
        {

        }

        private void txtPassword_TextChanged(object sender, EventArgs e)
        {

        }

        private void txtUsername_TextChanged_1(object sender, EventArgs e)
        {

        }

        private void btnRegis_Click(object sender, EventArgs e)
        {
            this.Hide();
            Registration form = new Registration();
            form.ShowDialog();
        }

        private async Task btnSubmit_Click(object sender, EventArgs e)
        {
            lblvalidasi.Visible = false;
            using var db = new AppDbContext();
            var auth = new AuthService(db);
            var user = await auth.LoginAsync(txtUsername.Text, txtPassword.Text);
            if (user != null)
            {
                LoggedInUser = user;
                if (LoggedInUser.level == "admin")
                {
                    this.Hide();
                    AdminForm form = new AdminForm(LoggedInUser);
                    form.ShowDialog();
                }
                else
                {
                    AccessService accessService = new AccessService(db);
                    Access access = await accessService.GetAccess(user.Id);
                    if (access == null)
                    {
                        lblvalidasi.Text = "Access Is Not Granted By Admin!";
                        lblvalidasi.ForeColor = Color.Red;
                        lblvalidasi.Visible = true;
                    }
                    else
                    {
                        this.Hide();
                        HomeForm form = new HomeForm(LoggedInUser);
                        form.ShowDialog();
                    }
                }
            }
            else
            {
                lblvalidasi.Text = "Invalid Credentials";
                lblvalidasi.ForeColor = Color.Red;
                lblvalidasi.Visible = true;
            }
        }

        private void txtUsername_TextChanged_2(object sender, EventArgs e)
        {

        }

        private void LoginForm_Load(object sender, EventArgs e)
        {

        }
    }
}
