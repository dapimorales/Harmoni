using Harmoni.Data;
using Harmoni.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Harmoni.Services
{
    public class MemberService
    {
        private readonly AppDbContext _db;

        public MemberService(AppDbContext db)
        {
            _db = db;
        }

        // Fungsi untuk membuat dropdown list member
        public List<object> SetDropdown()
        {
            var list = _db.Members
                .OrderBy(m => m.FullName)
                .Select(m => new
                {
                    m.Id,
                    DisplayName = m.MemberId + " - " + m.FullName
                })
                .ToList<object>();

            return list;
        }

        // Cari member berdasarkan ID
        public Member? FindById(int id)
        {
            return _db.Members.FirstOrDefault(x => x.Id == id);
        }

        // Menampilkan list member untuk grid/table
        public List<Member> SetGrid()
        {
            return _db.Members
                .OrderByDescending(m => m.ModDate)
                .ToList<Member>();
        }

        // Update data member
        public async Task UpdateAsync(Member member)
        {
            _db.Members.Update(member);
            await _db.SaveChangesAsync();
        }
    }
}
