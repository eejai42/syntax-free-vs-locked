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
    public class UserExperimentsController : Controller
    {
        

        [Authorize(Roles = "User", AuthenticationSchemes = JwtBearerDefaults.AuthenticationScheme)]
        [HttpGet("Experiments")]
        public IActionResult Index(string airtableWhere = null, string view = null, int maxPages = 5)
        {
            var results = new List<Experiment>();
            try
            {
                ATDUser atdUser = new ATDUser();
                atdUser.EmailAddress = this.User.Identity.Name;
                atdUser.UserIdentity = this.User.Identities.FirstOrDefault();
                var payload = atdUser.CreatePayload("{}", airtableWhere, view, maxPages);
                results = atdUser.GetExperiments(payload)?.ToList();
            }
            catch (Exception ex)
            {
                throw new Exception($"Error adding Experiments: {ex.Message}", ex);
            }
            var json = JsonConvert.SerializeObject(results, Formatting.Indented);

            return Content(json, "application/json");

        }
                        

    
        [Authorize(Roles = "User", AuthenticationSchemes = JwtBearerDefaults.AuthenticationScheme)]
        [HttpPost("Experiments")]
        [HttpPost("Experiment")]
        public IActionResult Add(string airtableWhere = null, string view = null, int maxPages = 5)
        {
            var result = default(Experiment);
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
                    if (bodyAsPayload != null) payload.Experiment = bodyAsPayload.Experiment.UserCleanForAdd();
                    if (payload.Experiment is null) payload.Experiment = JsonConvert.DeserializeObject<Experiment>(body).UserCleanForAdd();
                    result = atdUser.AddExperiment(payload).UserCleanForGet();
                }
            }
            catch (Exception ex)
            {
                throw new Exception($"Error adding Experiments: {ex.Message}", ex);
            }
            var json = JsonConvert.SerializeObject(result, Formatting.Indented);

            return Content(json, "application/json");

        }
                        

    
        [Authorize(Roles = "User", AuthenticationSchemes = JwtBearerDefaults.AuthenticationScheme)]
        [HttpPut("Experiment")]
        public IActionResult Update(string airtableWhere = null, string view = null, int maxPages = 5)
        {
            var result = new Experiment();
            try
            {
                using (var reader = new StreamReader(this.Request.Body))
                {
                    var body = reader.ReadToEndAsync().GetAwaiter().GetResult();
                    ATDUser atdUser = new ATDUser();
                    atdUser.EmailAddress = this.User.Identity.Name;
                    var payload = atdUser.CreatePayload("{}", airtableWhere, view, maxPages);
                    var bodyAsPayload = JsonConvert.DeserializeObject<StandardPayload>(body);
                    if (bodyAsPayload != null) payload.Experiment = bodyAsPayload.Experiment.UserCleanForAdd();
                    if (payload.Experiment is null) payload.Experiment = JsonConvert.DeserializeObject<Experiment>(body).UserCleanForAdd();
                    result = atdUser.UpdateExperiment(payload)?.FirstOrDefault();
                }

            }
            catch (Exception ex)
            {
                throw new Exception($"Error updating Experiments: {ex.Message}", ex);
            }
            var json = JsonConvert.SerializeObject(result, Formatting.Indented);

            return Content(json, "application/json");

        }
                        

    
        [Authorize(Roles = "User", AuthenticationSchemes = JwtBearerDefaults.AuthenticationScheme)]
        [HttpDelete("Experiment")]
        public IActionResult Delete(string id)
        {
            try {
                ATDUser atdUser = new ATDUser();
                atdUser.EmailAddress = this.User.Identity.Name;
                var payload = atdUser.CreatePayload();
                payload.Experiment = new Experiment() { ExperimentId = id };
                atdUser.DeleteExperiment(payload);
                var json = JsonConvert.SerializeObject(true, Formatting.Indented);
                return Content(json, "application/json");    
            } 
            catch (Exception ex) {
                throw new Exception($"Error updating Experiments: {ex.Message}", ex);
            }
        }                        
    }
}
                    