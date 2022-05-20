using Entity.Reset;
using Entity.Users;
using Entity.Users.UserDTO;
using Microsoft.EntityFrameworkCore.ChangeTracking;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Repository.UserRepositories
{
    public interface IUserRepository
    {
        public Task<EntityEntry<User>> InsertUser(RegisterDTO dto);
        public Task<User> GetUserbyEmail(string email);
        public Task<string> JSONToken(User user);
        public Task<User> GetUserById(int Id);
        public Task<ResetPassword> GetUserCodeCompared(string email);
        public string GetUserByEmailAndCode(RandomNumberDTO dto);
        public Task<User> ResetPassword(NewPasswordDTO dto);
    }
}
