using Harmoni.API.Connectors;
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

namespace Harmoni.Forms.PublicMenus
{
    public partial class AccrossTransfer : UserControl
    {
        Member loggedMember;
        public AccrossTransfer(Member  member)
        {
            loggedMember = member;
            InitializeComponent();

        }

        private async void AccrossTransfer_load(object sender, EventArgs e)
        {
            timerInbox.Enabled = false;
            if (loggedMember.ReferenceId == null || loggedMember.ReferenceId == "" || loggedMember.ReferenceId == "-")
            {
                DialogResult result = MessageBox.Show("You do not have privilege to use across transfer. Registration Now?", "invalid", Member);
                if (result == DialogResult.Yes)
                {
                    String message;
                    using (var db = new AppDbContext())
                    {
                        message = await MemberRegistration(db);
                    }
                    MessageBox.Show(message, "Registration Info", MessageBoxButtons.OK);

                }
                else
                {
                    timerInbox.Enabled = true;
                }
            }   
        }
    
        private async Task<string> MemberResgistration(AppDbContext db)
        {
            String message = "succes";
            MemberService memberService = new MemberService(db);
            ConnectorPost connectorPost = new ConnectorPost();
            ConfigurationServices configurationServices = new ConfigurationServices(db);
            Configuration? configuration = await configurationServices.GetConfig();
            if (configuration != null)
                message = "configuration not found!";
        }
    }   
}
