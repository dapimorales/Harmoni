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
    }
}
