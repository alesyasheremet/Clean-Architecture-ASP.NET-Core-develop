using CustomerData.Domain.Services.Mail;
using System.Threading.Tasks;

namespace CustomerData.Application.Contracts.Infrastructure
{
    public interface IEmailService
    {
        Task SendEmailAsync(MailRequest mailRequest);
    }
}
