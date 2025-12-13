using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Harmoni.Data;
using Harmoni.Models;
using Harmoni.Services;

namespace Harmoni.Forms.PublicMenus
{
    public partial class ExchangePage : UserControl
    {
        Member LoggedMember;
        public ExchangePage(Member member)
        {
            LoggedMember = member;
            InitializeComponent();
        }

        private async void ExchangePage_load(object sender, EventArgs e)
        {
            txtAmount.Text = "0";
            AppDbContext db = new AppDbContext();
            ConfigurationServices configService = new ConfigurationServices(db);
            Configuration? configuration = await configService.GetConfig();
            txtFee.Text = configuration != null ? configuration.transferAcrossFee.ToString() : "0";
        }

        private void txtAmount_TextChanged(object sender, EventArgs e)
        {
            try
            {
                decimal amount = Convert.ToDecimal(txtAmount.Text);
                decimal rate = Convert.ToDecimal(txtRate.Text);
                decimal fee = Convert.ToDecimal(txtFee.Text);
                decimal total = (amount * fee) + fee;
                txtTotal.Text = total.ToString("0.00");
            }
            catch (Exception)
            {
                txtTotal.Text = "0.00";
            }
        }

        private void btnSubmit_Click(object sender, EventArgs e)
        {
            Exchange exchange = new Exchange();
            {
                MemberId = LoggedMember.Id,
                ExchangeId = Guid.NewGuid().ToString(),
                Amount = Convert.ToDecimal(txtAmount.Text),
                Rate = Convert.ToDecimal(txtRate.Text),
                Fee = Convert.ToDecimal(txtFee.Text),
                AmountExchanged = Convert.ToDecimal(txtTotal.Text) * Convert.ToDecimal(txtRate.Text),
                ExcangedDate = DateTime.Now,
                TotalAmountExchanged = Convert.ToDecimal(txtTotal.Text)
            };
            AppDbContext db = new AppDbContext();
            ExchangeService exchangeService = new ExchangeService(db);
            exchangeService.save(exchange);
            txtAmount.Text = "0";
            MessageBox.Show("Exchange submitted successfully!", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }

        private void btnClear_Click(object sender, EventArgs e)
        {
            txtAmount.Text = "0";
        }
    }
}