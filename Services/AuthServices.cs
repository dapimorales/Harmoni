using System.Security.Cryptography;
using Harmoni.Models;
using Microsoft.EntityFrameworkCore;

namespace Harmoni.Services
{
    public class AuthService
    {
        private readonly AppDbContext _db;

        public AuthService(AppDbContext db)
        {
            _db = db;
        }

        public async Task<Member?> LoginAsync(string username, string password)
        {
            var user = await _db.Members.FirstOrDefaultAsync(x => x.Username == username && x.IsActive);
            if (user != null && BCrypt.Net.BCrypt.Verify(password, user.PasswordHash))
            {
                return user;
            }
            return null;
        }

        public async Task RegisterAsync(string username, string password, string fullName)
        {
            var hash = BCrypt.Net.BCrypt.HashPassword(password);
            var newMember = new Member
            {
                Username = username,
                PasswordHash = hash,
                FullName = fullName,
                IsActive = true
            };
            _db.Members.Add(newMember);
            await _db.SaveChangesAsync();
        }

        public async Task RegisterAsync(
            string address,
            string cardId,
            string email,
            string fullName,
            string password,
            string phone,
            string phoneAlt,
            string referenceId,
            string username,
            string quest1,
            string quest2)
        {
            var hash = BCrypt.Net.BCrypt.HashPassword(password);
            var memberId = Guid.NewGuid().ToString("N").Substring(0, 6);

            var member = new Member
            {
                Username = username,
                PasswordHash = hash,
                FullName = fullName,
                Email = email,
                Address = address,
                Phone = phone,
                PhoneAlt = phoneAlt,
                CardId = cardId,
                ReferenceId = referenceId,
                IsActive = true,
                Status = "public",
                Quest1 = quest1,
                Quest2 = quest2,
                MemberId = memberId
            };

            _db.Members.Add(member);
            await _db.SaveChangesAsync();
        }

        public async Task<string> ResetPasswordAsync(string username, string quest1, string quest2)
        {
            var user = await _db.Members.FirstOrDefaultAsync(x =>
                x.Username == username &&
                x.IsActive &&
                x.Quest1.Trim() == quest1.Trim() &&
                x.Quest2.Trim() == quest2.Trim());

            if (user != null)
            {
                string newPassword = Guid.NewGuid().ToString("N").Substring(0, 8);
                var hash = BCrypt.Net.BCrypt.HashPassword(newPassword);
                user.PasswordHash = hash;

                _db.Members.Update(user);
                await _db.SaveChangesAsync();

                return newPassword;
            }

            return "";
        }
    }
}
