using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Reflection.Emit;
using System.Security.Cryptography;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using BraveHeroCooperation.Utils;
using Harmoni.Data;
using Harmoni.Models;
using Harmoni.Services;

namespace Harmoni.Forms.PublicMenus
{
    public partial class SavingPage : UserControl
    {
        Member loggedMember;

        public SavingPage(Member member)
        {
            loggedMember = member;
            InitializeComponent();
        }

        private void buttonApply_Click(object sender, EventArgs e)
        {

        }

        private void buttonFileKK_Click(object sender, EventArgs e)
        {
            txtDocumentKK.Text = FileHelper.UploadDocument("KK");
        }

        private void SavingPage_Load(object sender, EventArgs e)
        {
            AppDbContext db = new AppDbContext();

            SetSavingDropDown(db);
            SetDefaultField();
            ResetField();

            LoadSavingGrid(db);
        }

        private void SetSavingDropDown(AppDbContext db)
        {
            ProductService productService = new ProductService(db);
            loanMasterBindingSource.DataSource = productService.SetDropDownSaving();
            comboSavingMaster.DisplayMember = "DisplayName";
            comboSavingMaster.ValueMember = "Id";
        }

        private void SetDefaultField()
        {
            comboSavingMaster.SelectedIndex = 0;
            btnShowKTP.Visible = false;
            btnShowKK.Visible = false;
            btnShowSlip.Visible = false;
            btnBrowseKTP.Visible = true;
            btnBrowseKK.Visible = true;
            btnBrowseSlip.Visible = true;
        }

        private void SetChosenField()
        {
            btnShowKK.Visible = true;
            btnShowKK.Visible = true;
            btnShowSlip.Visible = true;
            btnBrowseKTP.Visible = false;
            btnBrowseKK.Visible = false;
            btnBrowseSlip.Visible = false;
        }

        private void ResetField()
        {
            txtDocumentKK.Text = "";
            txtDocumentKTP.Text = "";
            txtDocumentSlip.Text = "";
            txtDueDate.Text = "";
            txtAmount.Text = "";
            ResetDropDown();
            textLoanId.Text = RandomNumberGenerator.GetString("1234567890", 6);
            labelId.Text = "";
        }

        private void ResetDropDown()
        {
            txtInterest.Text = "";
            txtInterestFIne.Text = "";
            txtTenor.Text = "";
            txtAdminFee.Text = "";
            txtMinAmount.Text = "";
            txtMaxAmount.Text = "";
        }

        private async void LoadSavingGrid(AppDbContext db)
        {
            SavingService savingService = new SavingService(db);
            loanBindingSource.DataSource = await savingService.LoadSavingGrid(loggedMe);
            dataGridViewSaving.Columns[0].DataPropertyName = "Id";
            dataGridViewSaving.Columns[1].DataPropertyName = "SavingId";
            dataGridViewSaving.Columns[2].DataPropertyName = "Amount";
            dataGridViewSaving.Columns[3].DataPropertyName = "Tenor";

            dataGridViewSaving.Columns[0].Visible = false;
            dataGridViewSaving.Columns[1].HeaderText = "Saving ID";
            dataGridViewSaving.Columns[2].HeaderText = "Amount";
            dataGridViewSaving.Columns[3].HeaderText = "Tenor";
        }

        private async void comboLoanMaster_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (comboSavingMaster.SelectedIndex == 0)
                ResetDropDown();

            if (comboSavingMaster.SelectedIndex > 0)
            {
                int idLoanMaster = int.Parse(comboSavingMaster.SelectedValue.ToString());
                AppDbContext db = new AppDbContext();
                ProductService productService = new ProductService(db);
                LoanMaster? loanMaster = await productService.findLoanById(idLoanMaster);

                if (loanMaster != null)
                {
                    txtInterest.Text = loanMaster.Interest.ToString();
                    txtInterestFIne.Text = loanMaster.Fine.ToString();
                    txtTenor.Text = loanMaster.Tenor.ToString();
                    txtAdminFee.Text = loanMaster.AdminFee.ToString();
                    txtMinAmount.Text = loanMaster.MinAmount.ToString();
                    txtMaxAmount.Text = loanMaster.MaxAmount.ToString();
                }
                else
                {
                    ResetDropDown();
                }
            }
        }

        private async void cmbLoanMaster_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (comboSavingMaster.SelectedIndex == 0)
                ResetDropDown();

            if (comboSavingMaster.SelectedIndex > 0)
            {
                int idLoanMaster = int.Parse(comboSavingMaster.SelectedValue.ToString());
                AppDbContext db = new AppDbContext();
                ProductService productService = new ProductService(db);
                LoanMaster? loanMaster = await productService.findLoanById(idLoanMaster);

                if (loanMaster != null)
                {
                    txtInterest.Text = loanMaster.Interest.ToString();
                    txtInterestFIne.Text = loanMaster.Fine.ToString();
                    txtTenor.Text = loanMaster.Tenor.ToString();
                    txtAdminFee.Text = loanMaster.AdminFee.ToString();
                    txtMinAmount.Text = loanMaster.MinAmount.ToString();
                    txtMaxAmount.Text = loanMaster.MaxAmount.ToString();
                }
                else
                {
                    ResetDropDown();
                }
            }
        }

        private void buttonNewSaving_Click(object sender, EventArgs e)
        {
            SetDefaultField();
            ResetField();
            btnApplySaving.Enabled = true;
            comboSavingMaster.SelectedIndex = 0;
            comboSavingMaster.Enabled = true;
        }

        private void buttonReload_Click_1(object sender, EventArgs e)
        {
            AppDbContext db = new AppDbContext();

            SetSavingDropDown(db);
            SetDefaultField();
            ResetField();

            LoadSavingGrid(db);
        }

        private void btnNewSaving_Click(object sender, EventArgs e)
        {
            SetDefaultField();
            ResetField();
            btnApplySaving.Enabled = true;
            comboSavingMaster.SelectedIndex = 0;
            comboSavingMaster.Enabled = true;
        }

        private void btnReload_Click_1(object sender, EventArgs e)
        {
            AppDbContext db = new AppDbContext();

            SetSavingDropDown(db);
            SetDefaultField();
            ResetField();

            LoadSavingGrid(db);
        }
    }
}
