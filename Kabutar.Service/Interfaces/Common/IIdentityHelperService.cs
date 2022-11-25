
namespace Kabutar.Service.Interfaces.Common;

public interface IIdentityHelperService
{
    long? GetUserId();
    string GetUserName();
    string GetUserEmail();
}
