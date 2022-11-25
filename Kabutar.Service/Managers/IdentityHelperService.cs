using Kabutar.Service.Interfaces.Common;
using Microsoft.AspNetCore.Http;

namespace Kabutar.Service.Managers
{
    public class IdentityHelperService : IIdentityHelperService
    {
        private readonly IHttpContextAccessor _accessor;

        public IdentityHelperService(IHttpContextAccessor accessor)
        {
            this._accessor = accessor;
        }

        public string GetUserEmail()
        {
            var res = _accessor.HttpContext!.User.FindFirst("http://schemas.xmlsoap.org/ws/2005/05/identity/claims/emailaddress");
            return res is not null ? res.Value : string.Empty;
        }

        public long? GetUserId()
        {
            var res = _accessor.HttpContext!.User.FindFirst("Id");
            return res is not null ? long.Parse(res.Value) : null; 
        }

        public string GetUserName()
        {
            var res = _accessor.HttpContext!.User.FindFirst("http://schemas.xmlsoap.org/ws/2005/05/identity/claims/name");
            return res is not null ? res.Value : string.Empty;
        }

       
    }
}
