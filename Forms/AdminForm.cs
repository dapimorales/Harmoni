using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Harmoni.Models;

namespace Harmoni.Forms
{
    public partial class AdminForm : Form
    {
        Member? loggedMember = null;
        public AdminForm(Member member)
        {
            loggedMember = member;
            InitializeComponent();
            this.Text = "Brave Hero Cooperation (Administrator: " +
            LoggedMember.MemberId + " " + logged Member.FullName + ")";
        }
        public void route(System.Windows.Forms.Control control)
        {
            this.panelDisplay.Controls.Clear();
            this.panelDisplay.Dock DockStyle.Fill;
            this.panelDisplay.Controls.Add(control);
        }

        private void AdminForm_Load(object sender, EventArgs e)
        { route(new DashboardAdminPage(loggedMember)); }

        private void accessToolStripMenuItem_Click(object sender, EventArgs e)
        {
            route(new AccessPage(loggedMember));
        }

        private void configurationToolStripMenuItem_Click(object sender, EventArgs e)
        {
            route(new ConfigPage());
        }

        private void logoutToolStripMenuItem_Click(object sender, EventArgs e)
        {
            loggedMember = null;
            this.Hide();
            LoginForm loginForm = new LoginForm();
            loginForm.ShowDialog();
        }

        private void memberToolStripMenuItem_Click(object sender, EventArgs e)
        { route(new MemberPage()); }

        private void productToolStripMenuItem_Click(object sender, EventArgs e)
        { route(new ProductPage()); }

        private void acrossCooperationToolStripMenuItem_Click(object sender, EventArgs e)
        {
            route(new AcrossPage());
        }
        private void approval ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            route(new Approval Page(loggedMember));
        }

    }
}
