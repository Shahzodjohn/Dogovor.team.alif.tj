using Entity.MailSettings;
using Entity.ResponseMessage;
using Microsoft.Extensions.Options;
using Repository.UserRepositories;
using MailKit.Net.Smtp;
using MailKit.Security;
using MimeKit;
using Repository;
using ConnectionProvider.Context;

namespace Service.Services.MailService
{
    public class MailServices : IMailServices
    {
        private readonly MailSettings _settings;
        private readonly IUserRepository _userRepository;
        private readonly ICodeResetRepository _reset;
        private readonly AppDbContext _context;

        public MailServices(IOptions<MailSettings> options, IUserRepository userRepository, ICodeResetRepository reset, AppDbContext context)
        {
            _settings = options.Value;
            _userRepository = userRepository;
            _reset = reset;
            _context = context;
        }
        Response response = new Response();
        public async Task<string> SendEmailResetAsync(string ToEmail)
        {
            try
            {
                var email = new MimeMessage();
                email.Sender = MailboxAddress.Parse(_settings.Mail);
                email.To.Add(MailboxAddress.Parse(ToEmail));
                var builder = new BodyBuilder();
                var random = new Random();
                var randomNumber = random.Next(1000, 9999);
                var ToUser = email.To.ToString();
                var compare = await _userRepository.GetUserbyEmail(ToUser);
                var UserCode = await _userRepository.GetUserCodeCompared(ToEmail);

                var date = DateTime.Now.AddHours(2);
                if (UserCode != null)
                {
                    UserCode.RandomNumber = randomNumber.ToString();
                }
                else
                {
                    await _reset.Insert(randomNumber.ToString(), compare.Id, date);
                }
                email.Subject = "Восстановление пароля";
                builder.HtmlBody = "Ваш идентификатор доступа. Никому не сообщайте код, даже сотрудникам организации. Ваш код - " + randomNumber.ToString();
                email.Body = builder.ToMessageBody();
                using (var smtp = new SmtpClient())
                {
                    smtp.Connect(_settings.Host, _settings.Port, SecureSocketOptions.StartTls);
                    smtp.Authenticate(_settings.Mail, _settings.Password);
                    await smtp.SendAsync(email);
                    smtp.Disconnect(true);
                }
                await _context.SaveChangesAsync();
            }
            catch (Exception ex)
            {
               return "SMTP ERROR ==> " + ex.Message.ToString();
            }
            return "Ok || 200";
        }
    }
}
