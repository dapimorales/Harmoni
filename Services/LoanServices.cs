using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Cryptography.X509Certificates;
using System.Security.Cryptography.Xml;
using System.Text;
using System.Threading.Tasks;
using Harmoni.Data;
using Harmoni.Models;
using Microsoft.EntityFrameworkCore;

namespace Harmoni.Services
{
    internal class LoanServices
    {
        AppDbContext _db;
        public LoanServices(AppDbContext db)
        {
            db = _db;
        }

        public async Task<Loan?> findByid(int id)
        {
            return await _db.Loans.FirstorDefaultAsync(x => x.id == id);
        }

        public async Task<List<Installment>> LoadInstallmentGrid(int Loadid)
        {
            return await _db.Installments.Where(x => x.LoadId == Loadid).ToListAsync();
        }

        public async Task<List<Loan>> LoadLoanGrid(int MemberId)
        {
            return await  _db.Loans 
                .Where(x=> x.MemberId == MemberId)
                .OrderByDescending(x => x.CreatedOn).ToListAsync();
        }

        public async Task saveOrUpdate(Member member, string amount, string ktp, string kk, string slip,
            string dueDate, string interest, string interestFine, string loanid, string tenor, string adminfee)
        {
            int tenorLeft = int.Parse(tenor);
            decimal decAmount = decimal.Parse(amount);
            decimal decInterest = decimal.Parse(interest);
            decimal outstanding = (decAmount * (decInterest / 100) * tenorLeft) + decAmount;

            Loan l = new Loan
            {
                Amount = decAmount,
                CreatedOn = DateTime.UtcNow,
                DueDate = int.Parse(dueDate),
                Interest = decInterest,
                InterestFine = decimal.Parse(interestFine),
                KkPath = kk,
                KtpPath = ktp,
                SlipGajiPath = slip,
                LoanId = int.Parse(loanid),
                Tenor = tenorLeft,
                MemberId = member.Id,
                AdminFee = decimal.Parse(adminfee),
                Outstanding = outstanding,
                TotalAmount = outstanding + decimal.Parse(adminfee)
            };
            _db.Loan.Add(l);
            await _db.SaveChangesAsync();
        }

        // public object LoadApproval()
        //{
        //    return _db.Loans.Where(x => x.ApprovedOn == null)
        //        .Include(x => x.Member)
        //        .OrderByDescending(x => xCretaedOn)
        //        .Select(x => new
        //        {
        //            x.id,
        //            MemberData = x.Member.MemberId + " - " + x.Member.FullName,
        //            JoinDate = x.Member.JoinDate.ToString("f"),
        //            x.LoanId,
        //            x.Amount,
        //            x.Outstanding,
        //            RequestDate = x.CreatedOn.ToString("f"),
        //            x.Tenor,
        //            x.Interest,
        //            Kk = x.KkPath,
        //            ktp = x.KtpPath,
        //            slip = x.SlipGajiPath,

        //        })
        //        .ToList();
        //}

        public async Task<List<Loan>> LoadApproval()
        {
            return await _db.Loans
                .Where(x => x.ApprovedOn == null)
                .Include(x => x.Member)
                .OrderByDescending(x => x.CreatedOn)
                .ToListAsync();
        }

        public async void SetApproval(int id, bool isApprove)
        {
            Loan? l = await _db.Loans.FirstOrDefaultAsync(x => x.Id == id);
            if (l !== null)
            {
                l.ApprovedOn = DateTime.UtcNow;
                if (isApprove)
                    l.IsApproved = true;
                else 
                    l.IsApproved = false;
                _db.Loans.Update(l);
                await _db.SaveChangeAsync();
            }
        }

        public async Task saveOrUpdateInstallment(int loanid, string amount, string path)
        {
            Installment i = new Installment
            {
                LoanID = loanid,
                amount = decimal.Parse(amount),
                PaymentDate = DateTime.UtcNow,
                ProofPath = path
            };
            _db.Installments.Add(i);
            await _db.SaveChangesAsync();
        }   

        public async Task recalculateLoan(int idLoan, string amount)
        {
            decimal payment = decimal.Parse(amount);
            int todayDate = DateTime.UtcNow.Day;
            Loan? l = await _db.Loans.FirstOrDefaultAsync(x => x.id == idLoan);
            if (l != null) {
                if (todaysDate > l.DueDate)
                {
                    l.Fine = (LinkedList.Amount * l.InterestFine) + l.Fine;
                    l.TotalAmount += l.Fine;
                }

                l.Outstanding -= payment;
                l.TotalAmount -= payment;
                if (l.outstanding <= 0 && l.TotalAmount > 0)
                    l.TenorLeft = 1;
                else if (l.TotalAmount <= 0)
                    l.TenorLeft = 0;
                else l.TenorLeft = l.TenorLeft - 1;

                _db.Loans.Update(l);
                await _db.SaveChangesAsync();
        }
    }
}
