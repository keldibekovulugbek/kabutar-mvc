using Kabutar.Domain.Entities;

namespace Kabutar.Service.Interfaces.Common;

public interface IAuthManager
{
    public string GenerateToken(User user);
}
