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
    public partial class Registration : Form
    {
        public Registration()
        {
            InitializeComponent();
        }

        private void btnSubmit_Click(object sender, EventArgs e)
        {
            using var db = new AppDbContext();
            var auth = new AuthService(db);
            var member = auth.RegisterAsync(textReferenceId.Text, textCardId.Text,
                textEmail.Text, textFullName.Text, textPhone.Text, textPassword.Text,
                textPhoneAlt.Text, textReferenceId.Text, textUsername.Text, textQuest1.Text,
                textQuest2.Text);
            if (member != null)
            {
                this.Hide();
                LoginForm loginForm = new LoginForm();
                loginForm.setSuccessAlert("Registration successful. Please log in.");
                loginForm.ShowDialog();
            }
            else
            {
                labelError.Text = "Registration failed. Please try again.";
                labelError.Visible = true;
            }

        }

        private void btnBack_Click(object sender, EventArgs e)
        {
            this.Hide();
            LoginForm loginForm = new LoginForm();
            loginForm.ShowDialog();
        }

        private void btnSubmit_Click_1(object sender, EventArgs e)
        {
.
        }
    }
