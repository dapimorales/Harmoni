using Harmoni.Data;
using Harmoni.Services;
using System;
using System.Windows.Forms;

namespace Harmoni.Forms
{
    public partial class Registration : Form
    {
        public Registration()
        {
            InitializeComponent();
        }

        private async void btnSubmit_Click(object sender, EventArgs e)
        {
            using var db = new AppDbContext();
            var auth = new AuthService(db);

            await auth.RegisterAsync(
                textRefId.Text,        // address
                textCardId.Text,       // cardId
                textEmail.Text,        // email
                textFullName.Text,     // fullName
                textPassword.Text,     // password
                textPhone.Text,        // phone
                textPhoneAlt.Text,     // phoneAlt
                textReferenceId.Text,  // referenceId
                textUsername.Text,     // username
                textQuest1.Text,       // quest1
                textQuest2.Text        // quest2
            );

            this.Hide();
            LoginForm loginForm = new LoginForm();
            loginForm.setSuccessAlert("Registration successful. Please log in.");
            loginForm.ShowDialog();
        }

        private void btnBack_Click(object sender, EventArgs e)
        {
            this.Hide();
            new LoginForm().ShowDialog();
        }
    }
}
