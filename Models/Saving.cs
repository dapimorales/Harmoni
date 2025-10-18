using System;
using System.ComponentModel.DataAnnotations;

namespace Harmoni.Models
{
    public class Saving
    {
        // Id tabungan
        public int Id { get; set; }

        [Required] public int MemberId { get; set; }
        public Member Member { get; set; } = null!;

        // Nama transaksi, diinisialisasi string kosong supaya gak null
        public string TransactionName { get; set; } = string.Empty;

        // Jumlah tabungan
        public decimal Amount { get; set; }

        // Tanggal transaksi
        public DateTime TransactionDate { get; set; } = DateTime.Now;

        // Keterangan tambahan (boleh null)
        public string? Notes { get; set; }

        // Constructor default
        public Saving()
        {
            // Kalau perlu nilai default lain bisa di sini
            Id = 0;
            Amount = 0;
        }
    }
}