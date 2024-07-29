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
    [Route("/Admin")]
    public class AdminTransformedArtifactsController : Controller
    {
        

        [Authorize(Roles = "Admin", AuthenticationSchemes = JwtBearerDefaults.AuthenticationScheme)]
        [HttpGet("TransformedArtifacts")]
        public IActionResult Index(string airtableWhere = null, string view = null, int maxPages = 5)
        {
            var results = new List<TransformedArtifact>();
            try
            {
                ATDAdmin atdAdmin = new ATDAdmin();
                atdAdmin.EmailAddress = this.User.Identity.Name;
                atdAdmin.UserIdentity = this.User.Identities.FirstOrDefault();
                var payload = atdAdmin.CreatePayload("{}", airtableWhere, view, maxPages);
                results = atdAdmin.GetTransformedArtifacts(payload)?.ToList();
            }
            catch (Exception ex)
            {
                throw new Exception($"Error adding TransformedArtifacts: {ex.Message}", ex);
            }
            var json = JsonConvert.SerializeObject(results, Formatting.Indented);

            return Content(json, "application/json");

        }
                        

    
        [Authorize(Roles = "Admin", AuthenticationSchemes = JwtBearerDefaults.AuthenticationScheme)]
        [HttpPost("TransformedArtifacts")]
        [HttpPost("TransformedArtifact")]
        public IActionResult Add(string airtableWhere = null, string view = null, int maxPages = 5)
        {
            var result = default(TransformedArtifact);
            try
            {
                ATDAdmin atdAdmin = new ATDAdmin();
                atdAdmin.EmailAddress = this.User.Identity.Name;
                atdAdmin.UserIdentity = this.User.Identities.FirstOrDefault();
                using (var reader = new StreamReader(this.Request.Body))
                {
                    var body = reader.ReadToEndAsync().GetAwaiter().GetResult();
                    var payload = atdAdmin.CreatePayload("{}", airtableWhere, view, maxPages);
                    var bodyAsPayload = JsonConvert.DeserializeObject<StandardPayload>(body);
                    if (bodyAsPayload != null) payload.TransformedArtifact = bodyAsPayload.TransformedArtifact.AdminCleanForAdd();
                    if (payload.TransformedArtifact is null) payload.TransformedArtifact = JsonConvert.DeserializeObject<TransformedArtifact>(body).AdminCleanForAdd();
                    result = atdAdmin.AddTransformedArtifact(payload).AdminCleanForGet();
                }
            }
            catch (Exception ex)
            {
                throw new Exception($"Error adding TransformedArtifacts: {ex.Message}", ex);
            }
            var json = JsonConvert.SerializeObject(result, Formatting.Indented);

            return Content(json, "application/json");

        }
                        

    
        [Authorize(Roles = "Admin", AuthenticationSchemes = JwtBearerDefaults.AuthenticationScheme)]
        [HttpPut("TransformedArtifact")]
        public IActionResult Update(string airtableWhere = null, string view = null, int maxPages = 5)
        {
            var result = new TransformedArtifact();
            try
            {
                using (var reader = new StreamReader(this.Request.Body))
                {
                    var body = reader.ReadToEndAsync().GetAwaiter().GetResult();
                    ATDAdmin atdAdmin = new ATDAdmin();
                    atdAdmin.EmailAddress = this.User.Identity.Name;
                    var payload = atdAdmin.CreatePayload("{}", airtableWhere, view, maxPages);
                    var bodyAsPayload = JsonConvert.DeserializeObject<StandardPayload>(body);
                    if (bodyAsPayload != null) payload.TransformedArtifact = bodyAsPayload.TransformedArtifact.AdminCleanForAdd();
                    if (payload.TransformedArtifact is null) payload.TransformedArtifact = JsonConvert.DeserializeObject<TransformedArtifact>(body).AdminCleanForAdd();
                    result = atdAdmin.UpdateTransformedArtifact(payload)?.FirstOrDefault();
                }

            }
            catch (Exception ex)
            {
                throw new Exception($"Error updating TransformedArtifacts: {ex.Message}", ex);
            }
            var json = JsonConvert.SerializeObject(result, Formatting.Indented);

            return Content(json, "application/json");

        }
                        

    
        [Authorize(Roles = "Admin", AuthenticationSchemes = JwtBearerDefaults.AuthenticationScheme)]
        [HttpDelete("TransformedArtifact")]
        public IActionResult Delete(string id)
        {
            try {
                ATDAdmin atdAdmin = new ATDAdmin();
                atdAdmin.EmailAddress = this.User.Identity.Name;
                var payload = atdAdmin.CreatePayload();
                payload.TransformedArtifact = new TransformedArtifact() { TransformedArtifactId = id };
                atdAdmin.DeleteTransformedArtifact(payload);
                var json = JsonConvert.SerializeObject(true, Formatting.Indented);
                return Content(json, "application/json");    
            } 
            catch (Exception ex) {
                throw new Exception($"Error updating TransformedArtifacts: {ex.Message}", ex);
            }
        }                        
    }
}
                    