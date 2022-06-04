using Entity.ResponseMessage;
using Entity.Users.UserDTO;
using Repository.Interfaces;
using Repository.Interfaces.DepartmentRepository;
using Repository.UserRepositories;
using Service.Services.MailService;
using System.Security.Claims;
using System.Text;
using System.Threading.Tasks;

namespace Service.Services
{
    public class UserService : IUserService
    {
        private readonly IUserRepository _uRepository;
        private readonly IMailServices _mailService;
        private readonly IRoleRepository _roleRepository;
        private readonly IDepartmentRepository _departmentRepository;

        public UserService(IUserRepository uRepository, IRoleRepository roleRepository, IMailServices mailService, IDepartmentRepository departmentRepository)
        {
            _uRepository = uRepository;
            _roleRepository = roleRepository;
            _mailService = mailService;
            _departmentRepository = departmentRepository;
        }

        Response response = new Response();
        public async Task<string> Login(AuthorizationDTO dto)
        {
            var user = await _uRepository.GetUserbyEmail(dto.EmailAddress);
            try
            {
                if (user == null)
                {
                    return response.ToLog("400", "This User does not exists!");
                }
                if (!BCrypt.Net.BCrypt.Verify(dto.Password, user.Password))
                {
                    var msq = response.ToLog("400", "Invalid credentials");
                    return msq;
                }
                var tokenJWT = await _uRepository.JSONToken(user);
                return tokenJWT;
            }
            catch (Exception ex)
            {
                return response.Log(null, ex.Message.ToString());
            }
        }

        public async Task<string> RegisterUser(RegisterDTO dto)
        {
            try
            {
                if (dto.Password != dto.RepeatPassword)
                    return response.ToLog("400", "The password doesn't match with repeated one!");
                //if (!dto.EmailAddress.Contains("@team.alif.tj"))
                //    return response.ToLog("400", "Error while adding a user, please enter a valid email address!");
                else
                    await _uRepository.InsertUser(dto); return "Success! User is registered!";
            }
            catch (Exception ex)
            {
               return response.ToLog(null, ex.Message.ToString());
            }
        }

        public async Task<UserDepartmentDTO> UsersInformation(ClaimsIdentity claim)
        {
            var user = await _uRepository.GetUserbyEmail(claim.Name);
            var Department = await _departmentRepository.GetDepartmentbyId(user.DepartmentId);
            var role = await _roleRepository.GetRoleById(user.RoleId);
            var userInfo = new UserDepartmentDTO
            {
                UserId = user.Id,
                EmailAddress = user.EmailAddress,
                DepartmentId = Department.Id,
                DepartmentName = Department.DepartmentName,
                RoleId = role.Id,
                RoleName = role.RoleName,
                Password = "you do not have to see the password"
            };
            return userInfo;
        }
        public async Task<string> SendEmailCode(MailResetDTO request)
        {
            var ValidUser = await _uRepository.GetUserbyEmail(request.ToEmail);
            if (ValidUser == null)
                return response.ToLog("400", "User not found!");
            var message = await _mailService.SendEmailResetAsync(request.ToEmail);
            if (!message.Contains("200"))
                return response.ToLog(null, message);
            return message;
        }

        public string VerifyUser(RandomNumberDTO dto)
        {
            try
            {
                var message = _uRepository.GetUserByEmailAndCode(dto);
                if (message == null)
                    return response.ToLog("Error", "Invalid user's code, try to resend a valid code!");
                return message;
            }
            catch (Exception ex)
            {
                return response.ToLog(null, "400 || Error while checking out the code!" + ex.Message.ToString());
            }
        }

        public async Task<string> ResetPassword(NewPasswordDTO dto)
        {
            try
            {
                var message = await _uRepository.ResetPassword(dto);
                if (message == null)
                    return response.ToLog("Error", "Invalid code");
                return "Success";
            }
            catch (Exception ex)
            {
                return response.ToLog(null, "400 || Error while checking out the code!" + ex.InnerException.ToString());
            }
        }
    }}
