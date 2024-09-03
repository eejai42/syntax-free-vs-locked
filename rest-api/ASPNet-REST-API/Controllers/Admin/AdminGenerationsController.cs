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
    public class AdminGenerationsController : Controller
    {
        

        [Authorize(Roles = "Admin", AuthenticationSchemes = JwtBearerDefaults.AuthenticationScheme)]
        [HttpGet("Generations")]
        public IActionResult Index(string airtableWhere = null, string view = null, int maxPages = 5)
        {
            var results = new List<Generation>();
            try
            {
                ATDAdmin atdAdmin = new ATDAdmin();
                atdAdmin.EmailAddress = this.User.Identity.Name;
                atdAdmin.UserIdentity = this.User.Identities.FirstOrDefault();
                var payload = atdAdmin.CreatePayload("{}", airtableWhere, view, maxPages);
                results = atdAdmin.GetGenerations(payload)?.ToList();
            }
            catch (Exception ex)
            {
                throw new Exception($"Error adding Generations: {ex.Message}", ex);
            }
            var json = JsonConvert.SerializeObject(results, Formatting.Indented);

            return Content(json, "application/json");

        }
                        

    
        [Authorize(Roles = "Admin", AuthenticationSchemes = JwtBearerDefaults.AuthenticationScheme)]
        [HttpPost("Generations")]
        [HttpPost("Generation")]
        public IActionResult Add(string airtableWhere = null, string view = null, int maxPages = 5)
        {
            var result = default(Generation);
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
                    if (bodyAsPayload != null) payload.Generation = bodyAsPayload.Generation.AdminCleanForAdd();
                    if (payload.Generation is null) payload.Generation = JsonConvert.DeserializeObject<Generation>(body).AdminCleanForAdd();
                    result = atdAdmin.AddGeneration(payload).AdminCleanForGet();
                }
            }
            catch (Exception ex)
            {
                throw new Exception($"Error adding Generations: {ex.Message}", ex);
            }
            var json = JsonConvert.SerializeObject(result, Formatting.Indented);

            return Content(json, "application/json");

        }
                        

    
        [Authorize(Roles = "Admin", AuthenticationSchemes = JwtBearerDefaults.AuthenticationScheme)]
        [HttpPut("Generation")]
        public IActionResult Update(string airtableWhere = null, string view = null, int maxPages = 5)
        {
            var result = new Generation();
            try
            {
                using (var reader = new StreamReader(this.Request.Body))
                {
                    var body = reader.ReadToEndAsync().GetAwaiter().GetResult();
                    ATDAdmin atdAdmin = new ATDAdmin();
                    atdAdmin.EmailAddress = this.User.Identity.Name;
                    var payload = atdAdmin.CreatePayload("{}", airtableWhere, view, maxPages);
                    var bodyAsPayload = JsonConvert.DeserializeObject<StandardPayload>(body);
                    if (bodyAsPayload != null) payload.Generation = bodyAsPayload.Generation.AdminCleanForAdd();
                    if (payload.Generation is null) payload.Generation = JsonConvert.DeserializeObject<Generation>(body).AdminCleanForAdd();
                    result = atdAdmin.UpdateGeneration(payload)?.FirstOrDefault();
                }

            }
            catch (Exception ex)
            {
                throw new Exception($"Error updating Generations: {ex.Message}", ex);
            }
            var json = JsonConvert.SerializeObject(result, Formatting.Indented);

            return Content(json, "application/json");

        }
                        

    
        [Authorize(Roles = "Admin", AuthenticationSchemes = JwtBearerDefaults.AuthenticationScheme)]
        [HttpDelete("Generation")]
        public IActionResult Delete(string id)
        {
            try {
                ATDAdmin atdAdmin = new ATDAdmin();
                atdAdmin.EmailAddress = this.User.Identity.Name;
                var payload = atdAdmin.CreatePayload();
                payload.Generation = new Generation() { GenerationId = id };
                atdAdmin.DeleteGeneration(payload);
                var json = JsonConvert.SerializeObject(true, Formatting.Indented);
                return Content(json, "application/json");    
            } 
            catch (Exception ex) {
                throw new Exception($"Error updating Generations: {ex.Message}", ex);
            }
        }                        
    }
}
                    