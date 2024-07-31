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
    public class AdminExperimentTransformersController : Controller
    {
        

        [Authorize(Roles = "Admin", AuthenticationSchemes = JwtBearerDefaults.AuthenticationScheme)]
        [HttpGet("ExperimentTransformers")]
        public IActionResult Index(string airtableWhere = null, string view = null, int maxPages = 5)
        {
            var results = new List<ExperimentTransformer>();
            try
            {
                ATDAdmin atdAdmin = new ATDAdmin();
                atdAdmin.EmailAddress = this.User.Identity.Name;
                atdAdmin.UserIdentity = this.User.Identities.FirstOrDefault();
                var payload = atdAdmin.CreatePayload("{}", airtableWhere, view, maxPages);
                results = atdAdmin.GetExperimentTransformers(payload)?.ToList();
            }
            catch (Exception ex)
            {
                throw new Exception($"Error adding ExperimentTransformers: {ex.Message}", ex);
            }
            var json = JsonConvert.SerializeObject(results, Formatting.Indented);

            return Content(json, "application/json");

        }
                        

    
        [Authorize(Roles = "Admin", AuthenticationSchemes = JwtBearerDefaults.AuthenticationScheme)]
        [HttpPost("ExperimentTransformers")]
        [HttpPost("ExperimentTransformer")]
        public IActionResult Add(string airtableWhere = null, string view = null, int maxPages = 5)
        {
            var result = default(ExperimentTransformer);
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
                    if (bodyAsPayload != null) payload.ExperimentTransformer = bodyAsPayload.ExperimentTransformer.AdminCleanForAdd();
                    if (payload.ExperimentTransformer is null) payload.ExperimentTransformer = JsonConvert.DeserializeObject<ExperimentTransformer>(body).AdminCleanForAdd();
                    result = atdAdmin.AddExperimentTransformer(payload).AdminCleanForGet();
                }
            }
            catch (Exception ex)
            {
                throw new Exception($"Error adding ExperimentTransformers: {ex.Message}", ex);
            }
            var json = JsonConvert.SerializeObject(result, Formatting.Indented);

            return Content(json, "application/json");

        }
                        

    
        [Authorize(Roles = "Admin", AuthenticationSchemes = JwtBearerDefaults.AuthenticationScheme)]
        [HttpPut("ExperimentTransformer")]
        public IActionResult Update(string airtableWhere = null, string view = null, int maxPages = 5)
        {
            var result = new ExperimentTransformer();
            try
            {
                using (var reader = new StreamReader(this.Request.Body))
                {
                    var body = reader.ReadToEndAsync().GetAwaiter().GetResult();
                    ATDAdmin atdAdmin = new ATDAdmin();
                    atdAdmin.EmailAddress = this.User.Identity.Name;
                    var payload = atdAdmin.CreatePayload("{}", airtableWhere, view, maxPages);
                    var bodyAsPayload = JsonConvert.DeserializeObject<StandardPayload>(body);
                    if (bodyAsPayload != null) payload.ExperimentTransformer = bodyAsPayload.ExperimentTransformer.AdminCleanForAdd();
                    if (payload.ExperimentTransformer is null) payload.ExperimentTransformer = JsonConvert.DeserializeObject<ExperimentTransformer>(body).AdminCleanForAdd();
                    result = atdAdmin.UpdateExperimentTransformer(payload)?.FirstOrDefault();
                }

            }
            catch (Exception ex)
            {
                throw new Exception($"Error updating ExperimentTransformers: {ex.Message}", ex);
            }
            var json = JsonConvert.SerializeObject(result, Formatting.Indented);

            return Content(json, "application/json");

        }
                        

    
        [Authorize(Roles = "Admin", AuthenticationSchemes = JwtBearerDefaults.AuthenticationScheme)]
        [HttpDelete("ExperimentTransformer")]
        public IActionResult Delete(string id)
        {
            try {
                ATDAdmin atdAdmin = new ATDAdmin();
                atdAdmin.EmailAddress = this.User.Identity.Name;
                var payload = atdAdmin.CreatePayload();
                payload.ExperimentTransformer = new ExperimentTransformer() { ExperimentTransformerId = id };
                atdAdmin.DeleteExperimentTransformer(payload);
                var json = JsonConvert.SerializeObject(true, Formatting.Indented);
                return Content(json, "application/json");    
            } 
            catch (Exception ex) {
                throw new Exception($"Error updating ExperimentTransformers: {ex.Message}", ex);
            }
        }                        
    }
}
                    