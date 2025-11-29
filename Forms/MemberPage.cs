using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Reflection.Emit;
using Harmoni.Models;
using Harmoni.Data;
using Harmoni.Services;

namespace Harmoni.Forms
{
    public partial class MemberPage : UserControl
    {
        public MemberPage()
        {
            InitializeComponent();
        }

        private void MemberPage_Load(object sender, EventArgs e)
        {
            loadGridMember();
            string? id = lblCardId.Text;
            if (id == null || id == "" || id == "...")
            {
                btnUpdate.Visible = false;
            }
        }


        private void loadGridMember()
        {
            AppDbContext db = new AppDbContext();
            MemberService service = new MemberService(db);
            //memberBindingSource.DataSource = service.SetGrid();
            dataGridViewMember.Columns[0].DataPropertyName = "Id";
            dataGridViewMember.Columns[0].Visible = false;
            dataGridViewMember.Columns[1].DataPropertyName = "MemberId";
            dataGridViewMember.Columns[2].DataPropertyName = "Fullname";
            dataGridViewMember.Columns[3].DataPropertyName = "ModDate";
        }

        private void btnUpdate_Click(object sender, EventArgs e)
        {
            AppDbContext db = new AppDbContext();
            MemberService service = new MemberService(db);
            int memberId = int.Parse(lblCardId.Text);
            Member? member = service.FindById(memberId);
            if (member != null)
            {
                if (cmbStatus.SelectedIndex == 0)
                    member.IsActive = true;
                else
                    member.IsActive = false;

                member.ModDate = DateTime.UtcNow;
                service.UpdateAsync(member);
            }
            loadGridMember();
        }

        private void dataGridViewMember_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            {
                if (e.RowIndex >= 0)
                {
                    int memberId = int.Parse(dataGridViewMember.Rows[e.RowIndex].Cells[0].Value.ToString());
                    AppDbContext db = new AppDbContext();
                    MemberService service = new MemberService(db);
                    Member? member = service.FindById(memberId);
                    if (member != null)
                    {
                        lblFullName.Text = member.FullName;
                        lblEmail.Text = member.Email;
                        lblPhone.Text = member.Phone;
                        lblPhoneAlt.Text = member.PhoneAlt;
                        lblAddress.Text = member.Address;
                        lblJoinDate.Text = member.JoinDate.ToString("f");
                        lblMemberId.Text = member.MemberId;
                        lblCardId.Text = member.IdCard;
                        //labelId.Text = member.Id.ToString();
                        if (member.IsActive)
                            cmbStatus.SelectedIndex = 0;
                        else
                            cmbStatus.SelectedIndex = 1;

                        btnUpdate.Visible = true;
                    }
                    else
                    {
                        btnUpdate.Visible = false;
                    }
                }
            }
        }
    }
}
