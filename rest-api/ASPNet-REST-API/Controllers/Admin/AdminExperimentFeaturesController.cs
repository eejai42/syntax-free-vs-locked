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
    public class AdminExperimentFeaturesController : Controller
    {
        

        [Authorize(Roles = "Admin", AuthenticationSchemes = JwtBearerDefaults.AuthenticationScheme)]
        [HttpGet("ExperimentFeatures")]
        public IActionResult Index(string airtableWhere = null, string view = null, int maxPages = 5)
        {
            var results = new List<ExperimentFeature>();
            try
            {
                ATDAdmin atdAdmin = new ATDAdmin();
                atdAdmin.EmailAddress = this.User.Identity.Name;
                atdAdmin.UserIdentity = this.User.Identities.FirstOrDefault();
                var payload = atdAdmin.CreatePayload("{}", airtableWhere, view, maxPages);
                results = atdAdmin.GetExperimentFeatures(payload)?.ToList();
            }
            catch (Exception ex)
            {
                throw new Exception($"Error adding ExperimentFeatures: {ex.Message}", ex);
            }
            var json = JsonConvert.SerializeObject(results, Formatting.Indented);

            return Content(json, "application/json");

        }
                        

    
        [Authorize(Roles = "Admin", AuthenticationSchemes = JwtBearerDefaults.AuthenticationScheme)]
        [HttpPost("ExperimentFeatures")]
        [HttpPost("ExperimentFeature")]
        public IActionResult Add(string airtableWhere = null, string view = null, int maxPages = 5)
        {
            var result = default(ExperimentFeature);
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
                    if (bodyAsPayload != null) payload.ExperimentFeature = bodyAsPayload.ExperimentFeature.AdminCleanForAdd();
                    if (payload.ExperimentFeature is null) payload.ExperimentFeature = JsonConvert.DeserializeObject<ExperimentFeature>(body).AdminCleanForAdd();
                    result = atdAdmin.AddExperimentFeature(payload).AdminCleanForGet();
                }
            }
            catch (Exception ex)
            {
                throw new Exception($"Error adding ExperimentFeatures: {ex.Message}", ex);
            }
            var json = JsonConvert.SerializeObject(result, Formatting.Indented);

            return Content(json, "application/json");

        }
                        

    
        [Authorize(Roles = "Admin", AuthenticationSchemes = JwtBearerDefaults.AuthenticationScheme)]
        [HttpPut("ExperimentFeature")]
        public IActionResult Update(string airtableWhere = null, string view = null, int maxPages = 5)
        {
            var result = new ExperimentFeature();
            try
            {
                using (var reader = new StreamReader(this.Request.Body))
                {
                    var body = reader.ReadToEndAsync().GetAwaiter().GetResult();
                    ATDAdmin atdAdmin = new ATDAdmin();
                    atdAdmin.EmailAddress = this.User.Identity.Name;
                    var payload = atdAdmin.CreatePayload("{}", airtableWhere, view, maxPages);
                    var bodyAsPayload = JsonConvert.DeserializeObject<StandardPayload>(body);
                    if (bodyAsPayload != null) payload.ExperimentFeature = bodyAsPayload.ExperimentFeature.AdminCleanForAdd();
                    if (payload.ExperimentFeature is null) payload.ExperimentFeature = JsonConvert.DeserializeObject<ExperimentFeature>(body).AdminCleanForAdd();
                    result = atdAdmin.UpdateExperimentFeature(payload)?.FirstOrDefault();
                }

            }
            catch (Exception ex)
            {
                throw new Exception($"Error updating ExperimentFeatures: {ex.Message}", ex);
            }
            var json = JsonConvert.SerializeObject(result, Formatting.Indented);

            return Content(json, "application/json");

        }
                        

    
        [Authorize(Roles = "Admin", AuthenticationSchemes = JwtBearerDefaults.AuthenticationScheme)]
        [HttpDelete("ExperimentFeature")]
        public IActionResult Delete(string id)
        {
            try {
                ATDAdmin atdAdmin = new ATDAdmin();
                atdAdmin.EmailAddress = this.User.Identity.Name;
                var payload = atdAdmin.CreatePayload();
                payload.ExperimentFeature = new ExperimentFeature() { ExperimentFeatureId = id };
                atdAdmin.DeleteExperimentFeature(payload);
                var json = JsonConvert.SerializeObject(true, Formatting.Indented);
                return Content(json, "application/json");    
            } 
            catch (Exception ex) {
                throw new Exception($"Error updating ExperimentFeatures: {ex.Message}", ex);
            }
        }                        
    }
}
                    