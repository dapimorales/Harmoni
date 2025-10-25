using Harmoni.Data;
using Harmoni.Forms.PublicMenus;
using Harmoni.Models;
using Harmoni.Services;

using Microsoft.VisualBasic.ApplicationServices;
using System;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;
 namespace Harmoni.Forms { 
public partial class HomeForm : Form
{
    Member loggedMember;
    string title;
    public HomeForm(Member member)
    {
        loggedMember = member;
        InitializeComponent();
        this.Text = this.Text + "User:" +loggedMember.FullName + " (" + loggedMember.MemberId + ")";
        title = this.Text;
        route(new DashboardPage(member));
    }
    public void route(System.Windows.Forms.Control control)
    {
        this.panelDisplay.Controls.Clear();
        this.panelDisplay.Dock = DockStyle.Fill;
        this.panelDisplay.Controls.Add(control);
    }
    public void autoDisableMenu() { 
        loanToolStripMenuItem.Enabled = false;
        savingToolStripMenuItem.Enabled = false;
        transferToolStripMenuItem.Enabled = false;
        exchangeToolStripMenuItem.Enabled = false;
        inhouseToolStripMenuItem.Enabled = false;
        acrossToolStripMenuItem.Enabled = false;
        loanToolStripMenuItem.ToolTipText = "Disabled";
        savingToolStripMenuItem.ToolTipText = "Disabled";
        transferToolStripMenuItem.ToolTipText = "Disabled";
        exchangeToolStripMenuItem.ToolTipText = "Disabled";
        inhouseToolStripMenuItem.ToolTipText = "Disabled";
        acrossToolStripMenuItem.ToolTipText = "Disabled";
    }

    public void grantAllMenu() {
        loanToolStripMenuItem.Enabled = true;
        savingToolStripMenuItem.Enabled = true;
        transferToolStripMenuItem.Enabled = true;
        exchangeToolStripMenuItem.Enabled = true;
        inhouseToolStripMenuItem.Enabled = true;
        acrossToolStripMenuItem.Enabled = true;
    }

        public void grantAccess()
        {
            AppDbContext db = new AppDbContext();
            AccessService accessService = new AccessService(db);
            Access? access = accessService.findByMember(loggedMember.Id);
            if (access != null)
            {
                var listaccess = access.AccessList.Split(",");

                for (int i = 0; i < listaccess.Length; i++)
                {
                    var accesName = listaccess[i];
                    var accesSegement = accesName.Trim();

                    if (accesSegement == "GrantAll")
                    {
                        grantAllMenu();
                        break;
                    }

                    if (accesSegement.Contains(","))
                    {
                        var parts = accesSegement.Split(",");
                        if (parts.Length > 1)
                            accesSegement = parts[1].Trim();
                    }

                    foreach (ToolStripMenuItem menu in menuStrip1.Items)
                    {
                        if (menu.Text != null && menu.Text.Contains(accesSegement))
                        {
                            menu.Enabled = true;
                            menu.ToolTipText = "";
                        }

                        else
                        {
                            foreach (ToolStripMenuItem submenu in menu.DropDownItems)
                            {
                                if (submenu.Text != null && submenu.Text.Contains(accesSegement))
                                {
                                    submenu.Enabled = true;
                                    submenu.ToolTipText = "";
                                }
                            }
                        }
                    }
                }
            }

        }

        private void definitionsToolStripMenuItem_Click(object sender, EventArgs e)
        {
       /// route(new TerminologiPage(loggedMember)); // member
        }
        private void  ToolStripMenuItem_Click(object sender, EventArgs e)
        {
        }
        private void fileToolStripMenuItem_Click(object sender, EventArgs e)
        {
        }
        private void HomeForm_Load(object sender, EventArgs e)
        {
        autoDisableMenu();
        grantAccess();
        }
       private void logoutToolStripMenuItem_Click(object sender, EventArgs e)
        {
        loggedMember = null;
        this.Hide();
        LoginForm loginForm = new LoginForm();
        loginForm.ShowDialog();
        }

        private void dashboardToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.Text = title;
            route(new DashboardPage(loggedMember));
        }
        private void profileToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.Text = title + " << Profile Page >>";
           //// route(new ProfilePage(loggedMember)); // member
        }
        private void loanToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.Text = title + " << Loan Page >>";
           //// route(new LoanPage(loggedMember));
        }
    }


}