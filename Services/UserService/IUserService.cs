using Entity;
using Entity.ResponseMessage;
using Entity.Users.UserDTO;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Security.Claims;
using System.Text;
using System.Threading.Tasks;

namespace Service.Services
{
    public interface IUserService
    {
        public Task<string> RegisterUser(RegisterDTO dto);
        public Task<string> Login(AuthorizationDTO dto);
        public Task<UserDepartmentDTO> UsersInformation(ClaimsIdentity claim);
        public Task<string> SendEmailCode(MailResetDTO request);
        public string VerifyUser(RandomNumberDTO dto);
        public Task<string> ResetPassword(NewPasswordDTO dto);
    }
}
