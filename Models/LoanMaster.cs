using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Harmoni.Models
{
    public class LoanMaster
    {
        [Key] public int Id { get; set; }
        [Required, MaxLength(100)] public string Name { get; set; } = string.Empty; public string? Description { get; set; }
        [Required] public decimal Interest { get; set; }
        [Required] public int Tenor { get; set; } 
    }
}
