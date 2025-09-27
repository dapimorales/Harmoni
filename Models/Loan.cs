using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Harmoni.Models
{
    internal class Loan
    {
        [Key] public int Id { get; set; }
        [Required] public int MemberId { get; set; }
        public Member Member { get; set; } = null!; 
    }
}
