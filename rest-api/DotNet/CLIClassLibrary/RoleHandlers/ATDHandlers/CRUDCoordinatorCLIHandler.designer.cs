using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Text;
using AirtableDirect.CLI.Lib.DataClasses;
using YP.SassyMQ.Lib.RabbitMQ;
using System.Threading.Tasks;
using RabbitMQ.Client.Events;
using CLIClassLibrary.AirtableAPI;
using static SSoT.me.AirtableToDotNetLib.AirtableExtensions;

namespace CLIClassLibrary.RoleHandlers.ATDHandlers
{
    public partial class CRUDCoordinatorCLIHandler
    {
        public override void AddHelp(StringBuilder sb, string helpTerm)
        {
            sb.AppendLine($"Help for CRUDCoordinator.");
            
            helpTerm = helpTerm.ToLower();
            var found = helpTerm == "general";
            
            if (helpTerm == "general")
            {
                sb.AppendLine();
                
                sb.AppendLine($"void: ResetRabbitSassyMQConfiguration");
                sb.AppendLine($"void: ResetJWTSecretKey");                                            
            }
            
            sb.AppendLine($"{Environment.NewLine}Available Actions Matching: {helpTerm}");
            
            if ("resetrabbitsassymqconfiguration".Contains(helpTerm, StringComparison.OrdinalIgnoreCase))
            {
                sb.AppendLine($" - ResetRabbitSassyMQConfiguration");
                if ("resetrabbitsassymqconfiguration".Equals(helpTerm, StringComparison.OrdinalIgnoreCase)) 
                {
                    this.PrintResetRabbitSassyMQConfigurationHelp(sb);
                }
                found = true;
            }
            if ("resetjwtsecretkey".Contains(helpTerm, StringComparison.OrdinalIgnoreCase))
            {
                sb.AppendLine($" - ResetJWTSecretKey");
                if ("resetjwtsecretkey".Equals(helpTerm, StringComparison.OrdinalIgnoreCase)) 
                {
                    this.PrintResetJWTSecretKeyHelp(sb);
                }
                found = true;
            }
                       
            if (!found)
            {
                sb.AppendLine();
                sb.AppendLine($"{Environment.NewLine}UNABLE TO FIND COMMAND: {helpTerm} not found.");
            }
        }

        private string HandlerFactory(string invokeRequest, string payloadString, string where, Int32 maxPages)
        {
            var result = "";
            var payload = JsonConvert.DeserializeObject<StandardPayload>(payloadString, new JsonSerializerSettings() { 
                    FloatParseHandling = FloatParseHandling.Decimal, 
                    ContractResolver = new CustomContractResolver<StandardPayload>()
            });
            payload.SetActor(this.ATDActor);
            payload.AccessToken = this.ATDActor.AccessToken;
            payload.ApiKey = AirtableKey.CurrentKey.APIKey;
            payload.BaseId = StageInfo.CurrentStage.BaseID;
            payload.AirtableWhere = where;
            payload.MaxPages = maxPages < 1 ? 5 : maxPages;
            Object reply;
			
            switch (invokeRequest.ToLower())
            {
                case "resetrabbitsassymqconfiguration":
				    this.ATDActor.ResetRabbitSassyMQConfiguration(payload);
				    result = JsonConvert.SerializeObject(payload, Formatting.Indented);
                    break;                   

                case "resetjwtsecretkey":
				    this.ATDActor.ResetJWTSecretKey(payload);
				    result = JsonConvert.SerializeObject(payload, Formatting.Indented);
                    break;                   

                default:
                    throw new Exception($"Invalid request: {invokeRequest}");
            }

            return result;
        }
        
        
        public void PrintResetRabbitSassyMQConfigurationHelp(StringBuilder sb)
        {
            
        }
        
        public void PrintResetJWTSecretKeyHelp(StringBuilder sb)
        {
            
        }
        

    }
}
