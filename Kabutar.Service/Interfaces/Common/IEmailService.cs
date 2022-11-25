using Kabutar.Service.Dtos;

namespace Kabutar.Service.Interfaces.Common;

public interface IEmailService
{
    public Task SendAsync(EmailMessage message);
}
