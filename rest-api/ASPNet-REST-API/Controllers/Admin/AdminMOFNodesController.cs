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
    public class AdminMOFNodesController : Controller
    {
        

        [Authorize(Roles = "Admin", AuthenticationSchemes = JwtBearerDefaults.AuthenticationScheme)]
        [HttpGet("MOFNodes")]
        public IActionResult Index(string airtableWhere = null, string view = null, int maxPages = 5)
        {
            var results = new List<MOFNode>();
            try
            {
                ATDAdmin atdAdmin = new ATDAdmin();
                atdAdmin.EmailAddress = this.User.Identity.Name;
                atdAdmin.UserIdentity = this.User.Identities.FirstOrDefault();
                var payload = atdAdmin.CreatePayload("{}", airtableWhere, view, maxPages);
                results = atdAdmin.GetMOFNodes(payload)?.ToList();
            }
            catch (Exception ex)
            {
                throw new Exception($"Error adding MOFNodes: {ex.Message}", ex);
            }
            var json = JsonConvert.SerializeObject(results, Formatting.Indented);

            return Content(json, "application/json");

        }
                        

    
        [Authorize(Roles = "Admin", AuthenticationSchemes = JwtBearerDefaults.AuthenticationScheme)]
        [HttpPost("MOFNodes")]
        [HttpPost("MOFNode")]
        public IActionResult Add(string airtableWhere = null, string view = null, int maxPages = 5)
        {
            var result = default(MOFNode);
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
                    if (bodyAsPayload != null) payload.MOFNode = bodyAsPayload.MOFNode.AdminCleanForAdd();
                    if (payload.MOFNode is null) payload.MOFNode = JsonConvert.DeserializeObject<MOFNode>(body).AdminCleanForAdd();
                    result = atdAdmin.AddMOFNode(payload).AdminCleanForGet();
                }
            }
            catch (Exception ex)
            {
                throw new Exception($"Error adding MOFNodes: {ex.Message}", ex);
            }
            var json = JsonConvert.SerializeObject(result, Formatting.Indented);

            return Content(json, "application/json");

        }
                        

    
        [Authorize(Roles = "Admin", AuthenticationSchemes = JwtBearerDefaults.AuthenticationScheme)]
        [HttpPut("MOFNode")]
        public IActionResult Update(string airtableWhere = null, string view = null, int maxPages = 5)
        {
            var result = new MOFNode();
            try
            {
                using (var reader = new StreamReader(this.Request.Body))
                {
                    var body = reader.ReadToEndAsync().GetAwaiter().GetResult();
                    ATDAdmin atdAdmin = new ATDAdmin();
                    atdAdmin.EmailAddress = this.User.Identity.Name;
                    var payload = atdAdmin.CreatePayload("{}", airtableWhere, view, maxPages);
                    var bodyAsPayload = JsonConvert.DeserializeObject<StandardPayload>(body);
                    if (bodyAsPayload != null) payload.MOFNode = bodyAsPayload.MOFNode.AdminCleanForAdd();
                    if (payload.MOFNode is null) payload.MOFNode = JsonConvert.DeserializeObject<MOFNode>(body).AdminCleanForAdd();
                    result = atdAdmin.UpdateMOFNode(payload)?.FirstOrDefault();
                }

            }
            catch (Exception ex)
            {
                throw new Exception($"Error updating MOFNodes: {ex.Message}", ex);
            }
            var json = JsonConvert.SerializeObject(result, Formatting.Indented);

            return Content(json, "application/json");

        }
                        

    
        [Authorize(Roles = "Admin", AuthenticationSchemes = JwtBearerDefaults.AuthenticationScheme)]
        [HttpDelete("MOFNode")]
        public IActionResult Delete(string id)
        {
            try {
                ATDAdmin atdAdmin = new ATDAdmin();
                atdAdmin.EmailAddress = this.User.Identity.Name;
                var payload = atdAdmin.CreatePayload();
                payload.MOFNode = new MOFNode() { MOFNodeId = id };
                atdAdmin.DeleteMOFNode(payload);
                var json = JsonConvert.SerializeObject(true, Formatting.Indented);
                return Content(json, "application/json");    
            } 
            catch (Exception ex) {
                throw new Exception($"Error updating MOFNodes: {ex.Message}", ex);
            }
        }                        
    }
}
                    