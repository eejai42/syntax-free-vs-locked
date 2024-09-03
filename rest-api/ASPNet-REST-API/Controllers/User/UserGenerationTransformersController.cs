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
    public class UserGenerationTransformersController : Controller
    {
        

        [Authorize(Roles = "User", AuthenticationSchemes = JwtBearerDefaults.AuthenticationScheme)]
        [HttpGet("GenerationTransformers")]
        public IActionResult Index(string airtableWhere = null, string view = null, int maxPages = 5)
        {
            var results = new List<GenerationTransformer>();
            try
            {
                ATDUser atdUser = new ATDUser();
                atdUser.EmailAddress = this.User.Identity.Name;
                atdUser.UserIdentity = this.User.Identities.FirstOrDefault();
                var payload = atdUser.CreatePayload("{}", airtableWhere, view, maxPages);
                results = atdUser.GetGenerationTransformers(payload)?.ToList();
            }
            catch (Exception ex)
            {
                throw new Exception($"Error adding GenerationTransformers: {ex.Message}", ex);
            }
            var json = JsonConvert.SerializeObject(results, Formatting.Indented);

            return Content(json, "application/json");

        }
                        

    
        [Authorize(Roles = "User", AuthenticationSchemes = JwtBearerDefaults.AuthenticationScheme)]
        [HttpPost("GenerationTransformers")]
        [HttpPost("GenerationTransformer")]
        public IActionResult Add(string airtableWhere = null, string view = null, int maxPages = 5)
        {
            var result = default(GenerationTransformer);
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
                    if (bodyAsPayload != null) payload.GenerationTransformer = bodyAsPayload.GenerationTransformer.UserCleanForAdd();
                    if (payload.GenerationTransformer is null) payload.GenerationTransformer = JsonConvert.DeserializeObject<GenerationTransformer>(body).UserCleanForAdd();
                    result = atdUser.AddGenerationTransformer(payload).UserCleanForGet();
                }
            }
            catch (Exception ex)
            {
                throw new Exception($"Error adding GenerationTransformers: {ex.Message}", ex);
            }
            var json = JsonConvert.SerializeObject(result, Formatting.Indented);

            return Content(json, "application/json");

        }
                        

    
        [Authorize(Roles = "User", AuthenticationSchemes = JwtBearerDefaults.AuthenticationScheme)]
        [HttpPut("GenerationTransformer")]
        public IActionResult Update(string airtableWhere = null, string view = null, int maxPages = 5)
        {
            var result = new GenerationTransformer();
            try
            {
                using (var reader = new StreamReader(this.Request.Body))
                {
                    var body = reader.ReadToEndAsync().GetAwaiter().GetResult();
                    ATDUser atdUser = new ATDUser();
                    atdUser.EmailAddress = this.User.Identity.Name;
                    var payload = atdUser.CreatePayload("{}", airtableWhere, view, maxPages);
                    var bodyAsPayload = JsonConvert.DeserializeObject<StandardPayload>(body);
                    if (bodyAsPayload != null) payload.GenerationTransformer = bodyAsPayload.GenerationTransformer.UserCleanForAdd();
                    if (payload.GenerationTransformer is null) payload.GenerationTransformer = JsonConvert.DeserializeObject<GenerationTransformer>(body).UserCleanForAdd();
                    result = atdUser.UpdateGenerationTransformer(payload)?.FirstOrDefault();
                }

            }
            catch (Exception ex)
            {
                throw new Exception($"Error updating GenerationTransformers: {ex.Message}", ex);
            }
            var json = JsonConvert.SerializeObject(result, Formatting.Indented);

            return Content(json, "application/json");

        }
                        

    
        [Authorize(Roles = "User", AuthenticationSchemes = JwtBearerDefaults.AuthenticationScheme)]
        [HttpDelete("GenerationTransformer")]
        public IActionResult Delete(string id)
        {
            try {
                ATDUser atdUser = new ATDUser();
                atdUser.EmailAddress = this.User.Identity.Name;
                var payload = atdUser.CreatePayload();
                payload.GenerationTransformer = new GenerationTransformer() { GenerationTransformerId = id };
                atdUser.DeleteGenerationTransformer(payload);
                var json = JsonConvert.SerializeObject(true, Formatting.Indented);
                return Content(json, "application/json");    
            } 
            catch (Exception ex) {
                throw new Exception($"Error updating GenerationTransformers: {ex.Message}", ex);
            }
        }                        
    }
}
                    