using ConnectionProvider.Context;
using Entity.Reset;
using Microsoft.EntityFrameworkCore;
namespace Repository.Interfaces
{
    public class CodeResetRepository : ICodeResetRepository
    {
        private readonly AppDbContext _context;

        public CodeResetRepository(AppDbContext context)
        {
            _context = context;
        }

        public async Task<ResetPassword> GetUserCodebyId(int id)
        {
            return await _context.ResetPasswords.FirstOrDefaultAsync(x=>x.UserId == id);
        }

        public async Task<ResetPassword> Insert(string randomNumber, int UserId, DateTime date)
        {
            var dataInsert = new ResetPassword
            {
                RandomNumber = randomNumber.ToString(),
                UserId = UserId,
                ValidDate = date
            };
            await _context.ResetPasswords.AddAsync(dataInsert);
            await _context.SaveChangesAsync();
            return dataInsert;
        }
    }
}
