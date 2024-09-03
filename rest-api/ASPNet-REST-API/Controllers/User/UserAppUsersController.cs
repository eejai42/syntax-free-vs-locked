using Auth0.AuthenticationApi.Models;
using Auth0.AuthenticationApi;
using Microsoft.AspNetCore.Mvc;

using CLIClassLibrary.ATDMQ;
using AirtableDirect.CLI.Lib.DataClasses;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Authentication.JwtBearer;
using Newtonsoft.Json;
using Swan.Formatters;
using YP.SassyMQ.Lib.RabbitMQ;

namespace ASPNet_REST_API.Controllers.Admin
{
    [ApiController]
    [Route("/User")]
    public class UserAppUsersController : Controller
    {
        

        [Authorize(Roles = "User", AuthenticationSchemes = JwtBearerDefaults.AuthenticationScheme)]
        [HttpGet("AppUsers")]
        public IActionResult Index(string airtableWhere = null, string view = null, int maxPages = 5)
        {
            var results = new List<AppUser>();
            try
            {
                ATDUser atdUser = new ATDUser();
                atdUser.EmailAddress = this.User.Identity.Name;
                atdUser.UserIdentity = this.User.Identities.FirstOrDefault();
                var payload = atdUser.CreatePayload("{}", airtableWhere, view, maxPages);
                results = atdUser.GetAppUsers(payload)?.ToList();
            }
            catch (Exception ex)
            {
                throw new Exception($"Error adding AppUsers: {ex.Message}", ex);
            }
            var json = JsonConvert.SerializeObject(results, Formatting.Indented);

            return Content(json, "application/json");

        }
                        

    
        [Authorize(Roles = "User", AuthenticationSchemes = JwtBearerDefaults.AuthenticationScheme)]
        [HttpPost("AppUsers")]
        [HttpPost("AppUser")]
        public IActionResult Add(string airtableWhere = null, string view = null, int maxPages = 5)
        {
            var result = default(AppUser);
            try
            {
                ATDUser atdUser = new ATDUser();
                atdUser.EmailAddress = this.User.Identity.Name;
                atdUser.UserIdentity = this.User.Identities.FirstOrDefault();
                using (var reader = new StreamReader(this.Request.Body))
                {
                    var body = reader.ReadToEndAsync().GetAwaiter().GetResult();
                    var payload = atdUser.CreatePayload("{}", airtableWhere, view, maxPages);
                    var bodyAsPayload = JsonConvert.DeserializeObject<StandardPayload>(body);
                    if (bodyAsPayload != null) payload.AppUser = bodyAsPayload.AppUser.UserCleanForAdd();
                    if (payload.AppUser is null) payload.AppUser = JsonConvert.DeserializeObject<AppUser>(body).UserCleanForAdd();
                    result = atdUser.AddAppUser(payload).UserCleanForGet();
                }
            }
            catch (Exception ex)
            {
                throw new Exception($"Error adding AppUsers: {ex.Message}", ex);
            }
            var json = JsonConvert.SerializeObject(result, Formatting.Indented);

            return Content(json, "application/json");

        }
                        

    
        [Authorize(Roles = "User", AuthenticationSchemes = JwtBearerDefaults.AuthenticationScheme)]
        [HttpPut("AppUser")]
        public IActionResult Update(string airtableWhere = null, string view = null, int maxPages = 5)
        {
            var result = new AppUser();
            try
            {
                using (var reader = new StreamReader(this.Request.Body))
                {
                    var body = reader.ReadToEndAsync().GetAwaiter().GetResult();
                    ATDUser atdUser = new ATDUser();
                    atdUser.EmailAddress = this.User.Identity.Name;
                    var payload = atdUser.CreatePayload("{}", airtableWhere, view, maxPages);
                    var bodyAsPayload = JsonConvert.DeserializeObject<StandardPayload>(body);
                    if (bodyAsPayload != null) payload.AppUser = bodyAsPayload.AppUser.UserCleanForAdd();
                    if (payload.AppUser is null) payload.AppUser = JsonConvert.DeserializeObject<AppUser>(body).UserCleanForAdd();
                    result = atdUser.UpdateAppUser(payload)?.FirstOrDefault();
                }

            }
            catch (Exception ex)
            {
                throw new Exception($"Error updating AppUsers: {ex.Message}", ex);
            }
            var json = JsonConvert.SerializeObject(result, Formatting.Indented);

            return Content(json, "application/json");

        }
                        

    
        [Authorize(Roles = "User", AuthenticationSchemes = JwtBearerDefaults.AuthenticationScheme)]
        [HttpDelete("AppUser")]
        public IActionResult Delete(string id)
        {
            try {
                ATDUser atdUser = new ATDUser();
                atdUser.EmailAddress = this.User.Identity.Name;
                var payload = atdUser.CreatePayload();
                payload.AppUser = new AppUser() { AppUserId = id };
                atdUser.DeleteAppUser(payload);
                var json = JsonConvert.SerializeObject(true, Formatting.Indented);
                return Content(json, "application/json");    
            } 
            catch (Exception ex) {
                throw new Exception($"Error updating AppUsers: {ex.Message}", ex);
            }
        }                        
    }
}
                    