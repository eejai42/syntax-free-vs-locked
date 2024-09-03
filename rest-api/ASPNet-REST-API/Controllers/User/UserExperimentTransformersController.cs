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
    public class UserExperimentTransformersController : Controller
    {
        

        [Authorize(Roles = "User", AuthenticationSchemes = JwtBearerDefaults.AuthenticationScheme)]
        [HttpGet("ExperimentTransformers")]
        public IActionResult Index(string airtableWhere = null, string view = null, int maxPages = 5)
        {
            var results = new List<ExperimentTransformer>();
            try
            {
                ATDUser atdUser = new ATDUser();
                atdUser.EmailAddress = this.User.Identity.Name;
                atdUser.UserIdentity = this.User.Identities.FirstOrDefault();
                var payload = atdUser.CreatePayload("{}", airtableWhere, view, maxPages);
                results = atdUser.GetExperimentTransformers(payload)?.ToList();
            }
            catch (Exception ex)
            {
                throw new Exception($"Error adding ExperimentTransformers: {ex.Message}", ex);
            }
            var json = JsonConvert.SerializeObject(results, Formatting.Indented);

            return Content(json, "application/json");

        }
                        

    
        [Authorize(Roles = "User", AuthenticationSchemes = JwtBearerDefaults.AuthenticationScheme)]
        [HttpPost("ExperimentTransformers")]
        [HttpPost("ExperimentTransformer")]
        public IActionResult Add(string airtableWhere = null, string view = null, int maxPages = 5)
        {
            var result = default(ExperimentTransformer);
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
                    if (bodyAsPayload != null) payload.ExperimentTransformer = bodyAsPayload.ExperimentTransformer.UserCleanForAdd();
                    if (payload.ExperimentTransformer is null) payload.ExperimentTransformer = JsonConvert.DeserializeObject<ExperimentTransformer>(body).UserCleanForAdd();
                    result = atdUser.AddExperimentTransformer(payload).UserCleanForGet();
                }
            }
            catch (Exception ex)
            {
                throw new Exception($"Error adding ExperimentTransformers: {ex.Message}", ex);
            }
            var json = JsonConvert.SerializeObject(result, Formatting.Indented);

            return Content(json, "application/json");

        }
                        

    
        [Authorize(Roles = "User", AuthenticationSchemes = JwtBearerDefaults.AuthenticationScheme)]
        [HttpPut("ExperimentTransformer")]
        public IActionResult Update(string airtableWhere = null, string view = null, int maxPages = 5)
        {
            var result = new ExperimentTransformer();
            try
            {
                using (var reader = new StreamReader(this.Request.Body))
                {
                    var body = reader.ReadToEndAsync().GetAwaiter().GetResult();
                    ATDUser atdUser = new ATDUser();
                    atdUser.EmailAddress = this.User.Identity.Name;
                    var payload = atdUser.CreatePayload("{}", airtableWhere, view, maxPages);
                    var bodyAsPayload = JsonConvert.DeserializeObject<StandardPayload>(body);
                    if (bodyAsPayload != null) payload.ExperimentTransformer = bodyAsPayload.ExperimentTransformer.UserCleanForAdd();
                    if (payload.ExperimentTransformer is null) payload.ExperimentTransformer = JsonConvert.DeserializeObject<ExperimentTransformer>(body).UserCleanForAdd();
                    result = atdUser.UpdateExperimentTransformer(payload)?.FirstOrDefault();
                }

            }
            catch (Exception ex)
            {
                throw new Exception($"Error updating ExperimentTransformers: {ex.Message}", ex);
            }
            var json = JsonConvert.SerializeObject(result, Formatting.Indented);

            return Content(json, "application/json");

        }
                        

    
        [Authorize(Roles = "User", AuthenticationSchemes = JwtBearerDefaults.AuthenticationScheme)]
        [HttpDelete("ExperimentTransformer")]
        public IActionResult Delete(string id)
        {
            try {
                ATDUser atdUser = new ATDUser();
                atdUser.EmailAddress = this.User.Identity.Name;
                var payload = atdUser.CreatePayload();
                payload.ExperimentTransformer = new ExperimentTransformer() { ExperimentTransformerId = id };
                atdUser.DeleteExperimentTransformer(payload);
                var json = JsonConvert.SerializeObject(true, Formatting.Indented);
                return Content(json, "application/json");    
            } 
            catch (Exception ex) {
                throw new Exception($"Error updating ExperimentTransformers: {ex.Message}", ex);
            }
        }                        
    }
}
                    