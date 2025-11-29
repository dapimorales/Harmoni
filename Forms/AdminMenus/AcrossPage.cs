using Harmoni.API.Connectors;
using Harmoni.API.Models;
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

namespace Harmoni.Forms.AdminMenus
{
    public partial class AcrossPage : UserControl
    {
        public AcrossPage()
        {
            InitializeComponent();
        }

        private void labelMemberAcrossPage_Click(object sender, EventArgs e)
        {

        }

        private async void AcrossPage_Load(object sender, EventArgs e)
        {
            String message = "";
            AppDbContext db = new AppDbContext();
            ConnectorPost connectorPost = new ConnectorPost();
            ConfigurationServices configurationService = new ConfigurationServices(db);
            Configuration? configuration = await configurationService.GetConfig();
            if (configuration == null)
                message = "Configuration not found!";

            if (configuration != null) {
                if (configuration.terminologi3 == null || configuration.terminologi3 == "-")
                {
                    DialogResult result = MessageBox.Show("Not registered yet. Register Now!",
                    "Regist Accross", MessageBoxButtons.OK);

                    if (result == DialogResult.OK)
                    {
                        CoopApiResponse? coopApiResponse = await connectorPost.CoopRegistrationAsync(
                            new CoopPayload
                            {
                                name = "Harmoni",
                                address = "Siberia",
                                code = ""
                            });
                        if (coopApiResponse != null && coopApiResponse.CoopCode != null)
                        {
                            configuration.terminologi3 = coopApiResponse.CoopCode;
                            configurationService.Update(configuration);

                            LoadData();
                        }
                        else
                        {
                            message = "Failed to register coop to across system: " + coopApiResponse?.ResponseMessage;
                        }
                    }
                }
                else
                {
                    LoadData();
                }
            }
        }
    


        private async void buttonRefresh_Click(object sender, EventArgs e)
        {
            await LoadData();
        }

        private async Task LoadData()
        {
            AppDbContext appDbContext = new AppDbContext();
            ConfigurationServices configurationService = new ConfigurationServices(appDbContext);
            Configuration configuration = await configurationService.GetConfig();

            string message = "";

            // ======================
            // GET COOP LIST
            // ======================
            ConnectorGet connectorGet = new ConnectorGet();
            CoopApiResponse? coopApiResponse = await connectorGet.GetCoopAsync();

            if (coopApiResponse != null && coopApiResponse.ResponseCode == "00")
            {
                dgvCoop.Rows.Clear();
                foreach (var coop in coopApiResponse.CoopList)
                {
                    dgvCoop.Rows.Add(coop.Code, coop.Name, coop.Address);
                }
            }
            else
            {
                message = coopApiResponse != null
                    ? coopApiResponse.ResponseCode + " - " + coopApiResponse.ResponseMessage
                    : "Did not get Coop data";
            }

            // ======================
            // GET BALANCE LIST
            // ======================
            BalanceApiResponse? balanceApiResponse =
                await connectorGet.GetBalancesByCoopAsync(configuration.terminologi3);

            if (balanceApiResponse != null && balanceApiResponse.ResponseCode == "00")
            {
                dgvBalance.Rows.Clear();
                foreach (var bal in balanceApiResponse.balanceList)
                {
                    dgvBalance.Rows.Add(bal.Member.Code, bal.Member.Name, bal.Amount);
                }
            }
            else
            {
                message = balanceApiResponse != null
                    ? balanceApiResponse.ResponseCode + " - " + balanceApiResponse.ResponseMessage
                    : "Did not get Balance data";
            }

            // ======================
            // GET TRANSFER LIST
            // ======================
            TransferApiResponse? transferApiResponse =
                await connectorGet.GetTransfersByCoopAsync(configuration.terminologi3);

            if (transferApiResponse != null && transferApiResponse.ResponseCode == "00")
            {
                dgvTransfer.Rows.Clear();
                foreach (var transfer in transferApiResponse.TransferList)
                {
                    dgvTransfer.Rows.Add(
                        transfer.Code,
                        transfer.CoopCode,
                        transfer.CodeOrigin,
                        transfer.CodeBenef,
                        transfer.Amount,
                        transfer.Remaks
                    );
                }
            }
            else
            {
                message = transferApiResponse != null
                    ? transferApiResponse.ResponseCode + " - " + transferApiResponse.ResponseMessage
                    : "Did not get Transfer data";
            }

            // ======================
            // SHOW ERROR IF ANY
            // ======================
            if (message != "")
            {
                MessageBox.Show("Failed to load data from API.\nError: " + message);
            }
        }
    }
}