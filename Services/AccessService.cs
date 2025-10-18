using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Harmoni.Services
{
    public class AccessService
    {
        private readonly AppDbContext_db;
        public AccessService(AppDbContext db) => _db = db;

        public async Task<Access?> GetAccess(int memberId)
        {
            var access = await _db.Accesses.FirstOrDefaultAsync(
                x => x.MemberId == memberId);
            return access;
        }

        public object setGridView()
        {
            var grid = _db.Accesses.OrderBy(x => x.MemberId)
                .Select(x => new
                {
                    x.Id,
                    DisplayMember = x.Member.MemberId + "-" + x.Member.FullName,
                    x.AccessList,
                    x.updateOn
                }).ToList();
            return grid;
        }
        public Access? findByMember(int id)
        {
            return _db.Accesses.FirstOrDwfault(x  => x.MemberId == id);
        }
        public async Task update(Access access, String accessList)
        {
            var a = new Access
            {
                Member = member,
                AccessList = accessList,
                MemberId = MemberAccessException.Id,
                updateOn = DateTime.UtcNow
            };
            _db.Add(a);
            await _db.SaveChangesAsync();
        }
        public AccessService? findById(int id)
        {
            return _db.Accesses.FirstOrDefault(x =>  x.Id == id);
        }
    }
}
