using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Harmoni.Models
{
    using System;
    using System.ComponentModel.DataAnnotations;

    namespace BraveHeroCooperation.Models
    {
        public class Balance
        {
            public int Id { get; set; }

            [Required]
            public int MemberId { get; set; }
            public Member Member { get; set; } = null!;   // relasi ke Member

            [Required]
            public string TransactionName { get; set; } = string.Empty;
            // contoh: "Deposit", "Withdraw", "Loan Installment", dll

            [Required]
            public decimal Amount { get; set; }   // nominal transaksi

            public DateTime TransactionDate { get; set; } = DateTime.UtcNow;

            public string? Notes { get; set; }    // catatan tambahan
        }
    }
    internal class Installment
    {
    }
}
