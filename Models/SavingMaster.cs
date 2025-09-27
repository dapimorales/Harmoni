using System;
using System.Collections.Generic;

namespace Harmoni.Models
{
    public class SavingMaster
    {
        // ID unik
        public int Id { get; set; }

        // Nama pemilik tabungan, diinisialisasi supaya tidak null
        public string Member { get; set; } = string.Empty;

        // Nama transaksi, diinisialisasi supaya tidak null
        public string TransactionName { get; set; } = string.Empty;

        // Total saldo
        public decimal TotalBalance { get; set; }

        // Daftar detail transaksi tabungan (boleh null kalau belum ada)
        public List<Saving>? Savings { get; set; }

        // Tanggal dibuat
        public DateTime CreatedAt { get; set; } = DateTime.Now;

        // Constructor default
        public SavingMaster()
        {
            Id = 0;
            TotalBalance = 0;
        }
    }
}