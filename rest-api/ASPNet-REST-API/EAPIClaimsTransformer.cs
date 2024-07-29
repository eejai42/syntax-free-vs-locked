using CLIClassLibrary.ATDMQ;
using Microsoft.AspNetCore.Authentication;
using System.Security.Authentication;
using System.Security.Claims;
using System.Threading.Tasks;

namespace ASPNet_REST_API
{
    public class CustomClaimsTransformation : IClaimsTransformation
    {
        public Task<ClaimsPrincipal> TransformAsync(ClaimsPrincipal principal)
        {
            var identity = principal.Identity as ClaimsIdentity;

            var atdAdmin = new ATDAdmin();
            var payload = atdAdmin.CreatePayload();
            var emailAddress = principal.Claims.FirstOrDefault(c => c.Type == ClaimTypes.Email);
            payload.AirtableWhere = $"EmailAddress='{emailAddress?.Value}'";
            var appUsers = atdAdmin.GetAppUsers(payload);

            if (!appUsers.Any()) throw new AuthenticationException("AppUser not found");
            else if (appUsers.Count() > 1) throw new AuthenticationException("AppUser configuration error.");
            else
            {
                var appUser = appUsers.First();
                var roles = appUser.Roles;
                if (roles is null || !roles.Any()) throw new AuthenticationException("AppUser role configuration error.");
                else
                {
                    foreach (var role in roles)
                    {
                        identity?.AddClaim(new Claim(ClaimTypes.Role, role));
                    }
                }

                return Task.FromResult(principal);
            }
        }
    }
}
