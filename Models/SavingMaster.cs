using System;
using System.Collections.Generic;

namespace Harmoni.Models
{
    public class SavingMaster
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public string Description { get; set; }
        public decimal Interest { get; set; }
        public decimal Fine { get; set; }
        public decimal AdminFee { get; set; }
        public decimal MinAmount { get; set; } = 0;
        public decimal MaxAmount { get; set; } = 0;
        public int Tenor { get; set; }
        public DateTime UpdateOn { get; set; }
    }
}