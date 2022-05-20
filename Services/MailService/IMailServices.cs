using Entity.Mail;

namespace Service.Services.MailService
{
    public interface IMailServices
    {
        Task<string> SendEmailResetAsync(string ToEmail);
    }
}
