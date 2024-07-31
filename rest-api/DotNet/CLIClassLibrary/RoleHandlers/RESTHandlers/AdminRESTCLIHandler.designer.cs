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
using System.Net.Http;

namespace CLIClassLibrary.RoleHandlers.RESTHandlers
{
    public partial class AdminRESTCLIHandler
    {
        public override void AddHelp(StringBuilder sb, string helpTerm)
        {
            sb.AppendLine($"Help for Admin.");
            
            helpTerm = helpTerm.ToLower();
            var found = helpTerm == "general";
            
            if (helpTerm == "general")
            {
                sb.AppendLine();
                
                sb.AppendLine($"AppUser: AddAppUser");
                sb.AppendLine($"AppUser: GetAppUsers");
                sb.AppendLine($"AppUser: UpdateAppUser");
                sb.AppendLine($"void: DeleteAppUser");
                sb.AppendLine($"GenerationTransformer: AddGenerationTransformer");
                sb.AppendLine($"GenerationTransformer: GetGenerationTransformers");
                sb.AppendLine($"GenerationTransformer: UpdateGenerationTransformer");
                sb.AppendLine($"void: DeleteGenerationTransformer");
                sb.AppendLine($"Generation: AddGeneration");
                sb.AppendLine($"Generation: GetGenerations");
                sb.AppendLine($"Generation: UpdateGeneration");
                sb.AppendLine($"void: DeleteGeneration");
                sb.AppendLine($"ExperimentTransformer: AddExperimentTransformer");
                sb.AppendLine($"ExperimentTransformer: GetExperimentTransformers");
                sb.AppendLine($"ExperimentTransformer: UpdateExperimentTransformer");
                sb.AppendLine($"void: DeleteExperimentTransformer");
                sb.AppendLine($"ExperimentFeature: AddExperimentFeature");
                sb.AppendLine($"ExperimentFeature: GetExperimentFeatures");
                sb.AppendLine($"ExperimentFeature: UpdateExperimentFeature");
                sb.AppendLine($"void: DeleteExperimentFeature");
                sb.AppendLine($"TransformedArtifact: AddTransformedArtifact");
                sb.AppendLine($"TransformedArtifact: GetTransformedArtifacts");
                sb.AppendLine($"TransformedArtifact: UpdateTransformedArtifact");
                sb.AppendLine($"void: DeleteTransformedArtifact");
                sb.AppendLine($"DesignDecision: AddDesignDecision");
                sb.AppendLine($"DesignDecision: GetDesignDecisions");
                sb.AppendLine($"DesignDecision: UpdateDesignDecision");
                sb.AppendLine($"void: DeleteDesignDecision");
                sb.AppendLine($"Experiment: AddExperiment");
                sb.AppendLine($"Experiment: GetExperiments");
                sb.AppendLine($"Experiment: UpdateExperiment");
                sb.AppendLine($"void: DeleteExperiment");
                sb.AppendLine($"LLM: AddLLM");
                sb.AppendLine($"LLM: GetLLMs");
                sb.AppendLine($"LLM: UpdateLLM");
                sb.AppendLine($"void: DeleteLLM");                                            
            }
            
            sb.AppendLine($"{Environment.NewLine}Available Actions Matching: {helpTerm}");
            
            if ("addappuser".Contains(helpTerm, StringComparison.OrdinalIgnoreCase))
            {
                sb.AppendLine($" - AddAppUser");
                if ("addappuser".Equals(helpTerm, StringComparison.OrdinalIgnoreCase)) 
                {
                    this.PrintAddAppUserHelp(sb);
                }
                found = true;
            }
            if ("getappusers".Contains(helpTerm, StringComparison.OrdinalIgnoreCase))
            {
                sb.AppendLine($" - GetAppUsers");
                if ("getappusers".Equals(helpTerm, StringComparison.OrdinalIgnoreCase)) 
                {
                    this.PrintGetAppUsersHelp(sb);
                }
                found = true;
            }
            if ("updateappuser".Contains(helpTerm, StringComparison.OrdinalIgnoreCase))
            {
                sb.AppendLine($" - UpdateAppUser");
                if ("updateappuser".Equals(helpTerm, StringComparison.OrdinalIgnoreCase)) 
                {
                    this.PrintUpdateAppUserHelp(sb);
                }
                found = true;
            }
            if ("deleteappuser".Contains(helpTerm, StringComparison.OrdinalIgnoreCase))
            {
                sb.AppendLine($" - DeleteAppUser");
                if ("deleteappuser".Equals(helpTerm, StringComparison.OrdinalIgnoreCase)) 
                {
                    this.PrintDeleteAppUserHelp(sb);
                }
                found = true;
            }
            if ("addgenerationtransformer".Contains(helpTerm, StringComparison.OrdinalIgnoreCase))
            {
                sb.AppendLine($" - AddGenerationTransformer");
                if ("addgenerationtransformer".Equals(helpTerm, StringComparison.OrdinalIgnoreCase)) 
                {
                    this.PrintAddGenerationTransformerHelp(sb);
                }
                found = true;
            }
            if ("getgenerationtransformers".Contains(helpTerm, StringComparison.OrdinalIgnoreCase))
            {
                sb.AppendLine($" - GetGenerationTransformers");
                if ("getgenerationtransformers".Equals(helpTerm, StringComparison.OrdinalIgnoreCase)) 
                {
                    this.PrintGetGenerationTransformersHelp(sb);
                }
                found = true;
            }
            if ("updategenerationtransformer".Contains(helpTerm, StringComparison.OrdinalIgnoreCase))
            {
                sb.AppendLine($" - UpdateGenerationTransformer");
                if ("updategenerationtransformer".Equals(helpTerm, StringComparison.OrdinalIgnoreCase)) 
                {
                    this.PrintUpdateGenerationTransformerHelp(sb);
                }
                found = true;
            }
            if ("deletegenerationtransformer".Contains(helpTerm, StringComparison.OrdinalIgnoreCase))
            {
                sb.AppendLine($" - DeleteGenerationTransformer");
                if ("deletegenerationtransformer".Equals(helpTerm, StringComparison.OrdinalIgnoreCase)) 
                {
                    this.PrintDeleteGenerationTransformerHelp(sb);
                }
                found = true;
            }
            if ("addgeneration".Contains(helpTerm, StringComparison.OrdinalIgnoreCase))
            {
                sb.AppendLine($" - AddGeneration");
                if ("addgeneration".Equals(helpTerm, StringComparison.OrdinalIgnoreCase)) 
                {
                    this.PrintAddGenerationHelp(sb);
                }
                found = true;
            }
            if ("getgenerations".Contains(helpTerm, StringComparison.OrdinalIgnoreCase))
            {
                sb.AppendLine($" - GetGenerations");
                if ("getgenerations".Equals(helpTerm, StringComparison.OrdinalIgnoreCase)) 
                {
                    this.PrintGetGenerationsHelp(sb);
                }
                found = true;
            }
            if ("updategeneration".Contains(helpTerm, StringComparison.OrdinalIgnoreCase))
            {
                sb.AppendLine($" - UpdateGeneration");
                if ("updategeneration".Equals(helpTerm, StringComparison.OrdinalIgnoreCase)) 
                {
                    this.PrintUpdateGenerationHelp(sb);
                }
                found = true;
            }
            if ("deletegeneration".Contains(helpTerm, StringComparison.OrdinalIgnoreCase))
            {
                sb.AppendLine($" - DeleteGeneration");
                if ("deletegeneration".Equals(helpTerm, StringComparison.OrdinalIgnoreCase)) 
                {
                    this.PrintDeleteGenerationHelp(sb);
                }
                found = true;
            }
            if ("addexperimenttransformer".Contains(helpTerm, StringComparison.OrdinalIgnoreCase))
            {
                sb.AppendLine($" - AddExperimentTransformer");
                if ("addexperimenttransformer".Equals(helpTerm, StringComparison.OrdinalIgnoreCase)) 
                {
                    this.PrintAddExperimentTransformerHelp(sb);
                }
                found = true;
            }
            if ("getexperimenttransformers".Contains(helpTerm, StringComparison.OrdinalIgnoreCase))
            {
                sb.AppendLine($" - GetExperimentTransformers");
                if ("getexperimenttransformers".Equals(helpTerm, StringComparison.OrdinalIgnoreCase)) 
                {
                    this.PrintGetExperimentTransformersHelp(sb);
                }
                found = true;
            }
            if ("updateexperimenttransformer".Contains(helpTerm, StringComparison.OrdinalIgnoreCase))
            {
                sb.AppendLine($" - UpdateExperimentTransformer");
                if ("updateexperimenttransformer".Equals(helpTerm, StringComparison.OrdinalIgnoreCase)) 
                {
                    this.PrintUpdateExperimentTransformerHelp(sb);
                }
                found = true;
            }
            if ("deleteexperimenttransformer".Contains(helpTerm, StringComparison.OrdinalIgnoreCase))
            {
                sb.AppendLine($" - DeleteExperimentTransformer");
                if ("deleteexperimenttransformer".Equals(helpTerm, StringComparison.OrdinalIgnoreCase)) 
                {
                    this.PrintDeleteExperimentTransformerHelp(sb);
                }
                found = true;
            }
            if ("addexperimentfeature".Contains(helpTerm, StringComparison.OrdinalIgnoreCase))
            {
                sb.AppendLine($" - AddExperimentFeature");
                if ("addexperimentfeature".Equals(helpTerm, StringComparison.OrdinalIgnoreCase)) 
                {
                    this.PrintAddExperimentFeatureHelp(sb);
                }
                found = true;
            }
            if ("getexperimentfeatures".Contains(helpTerm, StringComparison.OrdinalIgnoreCase))
            {
                sb.AppendLine($" - GetExperimentFeatures");
                if ("getexperimentfeatures".Equals(helpTerm, StringComparison.OrdinalIgnoreCase)) 
                {
                    this.PrintGetExperimentFeaturesHelp(sb);
                }
                found = true;
            }
            if ("updateexperimentfeature".Contains(helpTerm, StringComparison.OrdinalIgnoreCase))
            {
                sb.AppendLine($" - UpdateExperimentFeature");
                if ("updateexperimentfeature".Equals(helpTerm, StringComparison.OrdinalIgnoreCase)) 
                {
                    this.PrintUpdateExperimentFeatureHelp(sb);
                }
                found = true;
            }
            if ("deleteexperimentfeature".Contains(helpTerm, StringComparison.OrdinalIgnoreCase))
            {
                sb.AppendLine($" - DeleteExperimentFeature");
                if ("deleteexperimentfeature".Equals(helpTerm, StringComparison.OrdinalIgnoreCase)) 
                {
                    this.PrintDeleteExperimentFeatureHelp(sb);
                }
                found = true;
            }
            if ("addtransformedartifact".Contains(helpTerm, StringComparison.OrdinalIgnoreCase))
            {
                sb.AppendLine($" - AddTransformedArtifact");
                if ("addtransformedartifact".Equals(helpTerm, StringComparison.OrdinalIgnoreCase)) 
                {
                    this.PrintAddTransformedArtifactHelp(sb);
                }
                found = true;
            }
            if ("gettransformedartifacts".Contains(helpTerm, StringComparison.OrdinalIgnoreCase))
            {
                sb.AppendLine($" - GetTransformedArtifacts");
                if ("gettransformedartifacts".Equals(helpTerm, StringComparison.OrdinalIgnoreCase)) 
                {
                    this.PrintGetTransformedArtifactsHelp(sb);
                }
                found = true;
            }
            if ("updatetransformedartifact".Contains(helpTerm, StringComparison.OrdinalIgnoreCase))
            {
                sb.AppendLine($" - UpdateTransformedArtifact");
                if ("updatetransformedartifact".Equals(helpTerm, StringComparison.OrdinalIgnoreCase)) 
                {
                    this.PrintUpdateTransformedArtifactHelp(sb);
                }
                found = true;
            }
            if ("deletetransformedartifact".Contains(helpTerm, StringComparison.OrdinalIgnoreCase))
            {
                sb.AppendLine($" - DeleteTransformedArtifact");
                if ("deletetransformedartifact".Equals(helpTerm, StringComparison.OrdinalIgnoreCase)) 
                {
                    this.PrintDeleteTransformedArtifactHelp(sb);
                }
                found = true;
            }
            if ("adddesigndecision".Contains(helpTerm, StringComparison.OrdinalIgnoreCase))
            {
                sb.AppendLine($" - AddDesignDecision");
                if ("adddesigndecision".Equals(helpTerm, StringComparison.OrdinalIgnoreCase)) 
                {
                    this.PrintAddDesignDecisionHelp(sb);
                }
                found = true;
            }
            if ("getdesigndecisions".Contains(helpTerm, StringComparison.OrdinalIgnoreCase))
            {
                sb.AppendLine($" - GetDesignDecisions");
                if ("getdesigndecisions".Equals(helpTerm, StringComparison.OrdinalIgnoreCase)) 
                {
                    this.PrintGetDesignDecisionsHelp(sb);
                }
                found = true;
            }
            if ("updatedesigndecision".Contains(helpTerm, StringComparison.OrdinalIgnoreCase))
            {
                sb.AppendLine($" - UpdateDesignDecision");
                if ("updatedesigndecision".Equals(helpTerm, StringComparison.OrdinalIgnoreCase)) 
                {
                    this.PrintUpdateDesignDecisionHelp(sb);
                }
                found = true;
            }
            if ("deletedesigndecision".Contains(helpTerm, StringComparison.OrdinalIgnoreCase))
            {
                sb.AppendLine($" - DeleteDesignDecision");
                if ("deletedesigndecision".Equals(helpTerm, StringComparison.OrdinalIgnoreCase)) 
                {
                    this.PrintDeleteDesignDecisionHelp(sb);
                }
                found = true;
            }
            if ("addexperiment".Contains(helpTerm, StringComparison.OrdinalIgnoreCase))
            {
                sb.AppendLine($" - AddExperiment");
                if ("addexperiment".Equals(helpTerm, StringComparison.OrdinalIgnoreCase)) 
                {
                    this.PrintAddExperimentHelp(sb);
                }
                found = true;
            }
            if ("getexperiments".Contains(helpTerm, StringComparison.OrdinalIgnoreCase))
            {
                sb.AppendLine($" - GetExperiments");
                if ("getexperiments".Equals(helpTerm, StringComparison.OrdinalIgnoreCase)) 
                {
                    this.PrintGetExperimentsHelp(sb);
                }
                found = true;
            }
            if ("updateexperiment".Contains(helpTerm, StringComparison.OrdinalIgnoreCase))
            {
                sb.AppendLine($" - UpdateExperiment");
                if ("updateexperiment".Equals(helpTerm, StringComparison.OrdinalIgnoreCase)) 
                {
                    this.PrintUpdateExperimentHelp(sb);
                }
                found = true;
            }
            if ("deleteexperiment".Contains(helpTerm, StringComparison.OrdinalIgnoreCase))
            {
                sb.AppendLine($" - DeleteExperiment");
                if ("deleteexperiment".Equals(helpTerm, StringComparison.OrdinalIgnoreCase)) 
                {
                    this.PrintDeleteExperimentHelp(sb);
                }
                found = true;
            }
            if ("addllm".Contains(helpTerm, StringComparison.OrdinalIgnoreCase))
            {
                sb.AppendLine($" - AddLLM");
                if ("addllm".Equals(helpTerm, StringComparison.OrdinalIgnoreCase)) 
                {
                    this.PrintAddLLMHelp(sb);
                }
                found = true;
            }
            if ("getllms".Contains(helpTerm, StringComparison.OrdinalIgnoreCase))
            {
                sb.AppendLine($" - GetLLMs");
                if ("getllms".Equals(helpTerm, StringComparison.OrdinalIgnoreCase)) 
                {
                    this.PrintGetLLMsHelp(sb);
                }
                found = true;
            }
            if ("updatellm".Contains(helpTerm, StringComparison.OrdinalIgnoreCase))
            {
                sb.AppendLine($" - UpdateLLM");
                if ("updatellm".Equals(helpTerm, StringComparison.OrdinalIgnoreCase)) 
                {
                    this.PrintUpdateLLMHelp(sb);
                }
                found = true;
            }
            if ("deletellm".Contains(helpTerm, StringComparison.OrdinalIgnoreCase))
            {
                sb.AppendLine($" - DeleteLLM");
                if ("deletellm".Equals(helpTerm, StringComparison.OrdinalIgnoreCase)) 
                {
                    this.PrintDeleteLLMHelp(sb);
                }
                found = true;
            }
                       
            if (!found)
            {
                sb.AppendLine();
                sb.AppendLine($"{Environment.NewLine}UNABLE TO FIND COMMAND: {helpTerm} not found.");
            }
        }

        private async Task<string> HandlerFactory(string invokeRequest, string payloadString, string where, Int32 maxPages)
        {
            string result = null;
            var payload = JsonConvert.DeserializeObject<StandardPayload>(payloadString, new JsonSerializerSettings() { 
                    FloatParseHandling = FloatParseHandling.Decimal, 
                    ContractResolver = new CustomContractResolver<StandardPayload>()
            });
            payload.AirtableWhere = where;
            payload.MaxPages = maxPages < 1 ? 5 : maxPages;
			
            switch (invokeRequest.ToLower())
            {
                
                
                case "addappuser":
                    // AppUser
                    result = await this.GETRequest("AppUsers", payload);
                    break;

                    
                
                
                case "getappusers":
                    // AppUser
                    result = await this.GETRequest("AppUsers", payload);
                    break;

                    
                
                
                case "updateappuser":
                    // AppUser
                    result = await this.GETRequest("AppUsers", payload);
                    break;

                    
                
                
                case "deleteappuser":
                    break;

                    
                
                
                case "addgenerationtransformer":
                    // GenerationTransformer
                    result = await this.GETRequest("GenerationTransformers", payload);
                    break;

                    
                
                
                case "getgenerationtransformers":
                    // GenerationTransformer
                    result = await this.GETRequest("GenerationTransformers", payload);
                    break;

                    
                
                
                case "updategenerationtransformer":
                    // GenerationTransformer
                    result = await this.GETRequest("GenerationTransformers", payload);
                    break;

                    
                
                
                case "deletegenerationtransformer":
                    break;

                    
                
                
                case "addgeneration":
                    // Generation
                    result = await this.GETRequest("Generations", payload);
                    break;

                    
                
                
                case "getgenerations":
                    // Generation
                    result = await this.GETRequest("Generations", payload);
                    break;

                    
                
                
                case "updategeneration":
                    // Generation
                    result = await this.GETRequest("Generations", payload);
                    break;

                    
                
                
                case "deletegeneration":
                    break;

                    
                
                
                case "addexperimenttransformer":
                    // ExperimentTransformer
                    result = await this.GETRequest("ExperimentTransformers", payload);
                    break;

                    
                
                
                case "getexperimenttransformers":
                    // ExperimentTransformer
                    result = await this.GETRequest("ExperimentTransformers", payload);
                    break;

                    
                
                
                case "updateexperimenttransformer":
                    // ExperimentTransformer
                    result = await this.GETRequest("ExperimentTransformers", payload);
                    break;

                    
                
                
                case "deleteexperimenttransformer":
                    break;

                    
                
                
                case "addexperimentfeature":
                    // ExperimentFeature
                    result = await this.GETRequest("ExperimentFeatures", payload);
                    break;

                    
                
                
                case "getexperimentfeatures":
                    // ExperimentFeature
                    result = await this.GETRequest("ExperimentFeatures", payload);
                    break;

                    
                
                
                case "updateexperimentfeature":
                    // ExperimentFeature
                    result = await this.GETRequest("ExperimentFeatures", payload);
                    break;

                    
                
                
                case "deleteexperimentfeature":
                    break;

                    
                
                
                case "addtransformedartifact":
                    // TransformedArtifact
                    result = await this.GETRequest("TransformedArtifacts", payload);
                    break;

                    
                
                
                case "gettransformedartifacts":
                    // TransformedArtifact
                    result = await this.GETRequest("TransformedArtifacts", payload);
                    break;

                    
                
                
                case "updatetransformedartifact":
                    // TransformedArtifact
                    result = await this.GETRequest("TransformedArtifacts", payload);
                    break;

                    
                
                
                case "deletetransformedartifact":
                    break;

                    
                
                
                case "adddesigndecision":
                    // DesignDecision
                    result = await this.GETRequest("DesignDecisions", payload);
                    break;

                    
                
                
                case "getdesigndecisions":
                    // DesignDecision
                    result = await this.GETRequest("DesignDecisions", payload);
                    break;

                    
                
                
                case "updatedesigndecision":
                    // DesignDecision
                    result = await this.GETRequest("DesignDecisions", payload);
                    break;

                    
                
                
                case "deletedesigndecision":
                    break;

                    
                
                
                case "addexperiment":
                    // Experiment
                    result = await this.GETRequest("Experiments", payload);
                    break;

                    
                
                
                case "getexperiments":
                    // Experiment
                    result = await this.GETRequest("Experiments", payload);
                    break;

                    
                
                
                case "updateexperiment":
                    // Experiment
                    result = await this.GETRequest("Experiments", payload);
                    break;

                    
                
                
                case "deleteexperiment":
                    break;

                    
                
                
                case "addllm":
                    // LLM
                    result = await this.GETRequest("LLMs", payload);
                    break;

                    
                
                
                case "getllms":
                    // LLM
                    result = await this.GETRequest("LLMs", payload);
                    break;

                    
                
                
                case "updatellm":
                    // LLM
                    result = await this.GETRequest("LLMs", payload);
                    break;

                    
                
                
                case "deletellm":
                    break;

                    
                default:
                    throw new Exception($"Invalid request: {invokeRequest}");
            }

            return result;
        }
        
        private async Task<string> POSTRequest(string methodName, StandardPayload payload)
        {
            var role = "Admin";
            var client = new HttpClient();
            var requestUrl = $"{this.RestEndpoint}/{role}/{methodName}";

            // Serialize the payload to JSON
            var jsonPayload = JsonConvert.SerializeObject(payload);
            var httpContent = new StringContent(jsonPayload, Encoding.UTF8, "application/json");

            // Make the POST request
            var response = await Client.PostAsync(requestUrl, httpContent);

            return await response.Content.ReadAsStringAsync();
        }
        
        private async Task<string> GETRequest(string pluralName, StandardPayload payload)
        {
            var role = "Admin";
            var requestUrl = $"{this.RestEndpoint}/{role}/{pluralName}";
            this.AddBearerToken();
            var results = await Client.GetStringAsync(requestUrl);

            return results;
        }
        
        
        public void PrintAddAppUserHelp(StringBuilder sb)
        {
            
                
                sb.AppendLine();
                sb.AppendLine($"* * * * * * * * * * * * * * * * * * * * * * * * * * *");
                sb.AppendLine($"* *  OBJECT DEF: AppUser     *");
                sb.AppendLine($"* * * * * * * * * * * * * * * * * * * * * * * * * * *");
                sb.AppendLine();
                
                    sb.AppendLine($"CRUD      - AppUserId");
                    sb.AppendLine($"CRUD      - Name");
                    sb.AppendLine($"CRUD      - Roles");
                    sb.AppendLine($"CRUD      - EmailAddress");
                
            
        }
        
        public void PrintGetAppUsersHelp(StringBuilder sb)
        {
            
                
                sb.AppendLine();
                sb.AppendLine($"* * * * * * * * * * * * * * * * * * * * * * * * * * *");
                sb.AppendLine($"* *  OBJECT DEF: AppUser     *");
                sb.AppendLine($"* * * * * * * * * * * * * * * * * * * * * * * * * * *");
                sb.AppendLine();
                
                    sb.AppendLine($"CRUD      - AppUserId");
                    sb.AppendLine($"CRUD      - Name");
                    sb.AppendLine($"CRUD      - Roles");
                    sb.AppendLine($"CRUD      - EmailAddress");
                
            
        }
        
        public void PrintUpdateAppUserHelp(StringBuilder sb)
        {
            
                
                sb.AppendLine();
                sb.AppendLine($"* * * * * * * * * * * * * * * * * * * * * * * * * * *");
                sb.AppendLine($"* *  OBJECT DEF: AppUser     *");
                sb.AppendLine($"* * * * * * * * * * * * * * * * * * * * * * * * * * *");
                sb.AppendLine();
                
                    sb.AppendLine($"CRUD      - AppUserId");
                    sb.AppendLine($"CRUD      - Name");
                    sb.AppendLine($"CRUD      - Roles");
                    sb.AppendLine($"CRUD      - EmailAddress");
                
            
        }
        
        public void PrintDeleteAppUserHelp(StringBuilder sb)
        {
            
        }
        
        public void PrintAddGenerationTransformerHelp(StringBuilder sb)
        {
            
                
                sb.AppendLine();
                sb.AppendLine($"* * * * * * * * * * * * * * * * * * * * * * * * * * *");
                sb.AppendLine($"* *  OBJECT DEF: GenerationTransformer     *");
                sb.AppendLine($"* * * * * * * * * * * * * * * * * * * * * * * * * * *");
                sb.AppendLine();
                
                    sb.AppendLine($"CRUD      - GenerationTransformerId");
                    sb.AppendLine($"CRUD      - Name");
                    sb.AppendLine($"CRUD      - Generation");
                    sb.AppendLine($"CRUD      - RawPrompt");
                    sb.AppendLine($"CRUD      - GenerationName");
                    sb.AppendLine($"CRUD      - GeneratioNumber");
                    sb.AppendLine($"CRUD      - TransformedArtifacts");
                    sb.AppendLine($"CRUD      - AutoNumber");
                    sb.AppendLine($"CRUD      - TransformerNumber");
                    sb.AppendLine($"CRUD      - IsArtifactValidator");
                    sb.AppendLine($"CRUD      - ExpAbstract");
                    sb.AppendLine($"CRUD      - ExpTransformer");
                    sb.AppendLine($"CRUD      - GenerationExp");
                    sb.AppendLine($"CRUD      - GenerationExpName");
                    sb.AppendLine($"CRUD      - IsActiveExp");
                    sb.AppendLine($"CRUD      - ExpTransformerIsSyntaxFree");
                    sb.AppendLine($"CRUD      - ExpValidationPrompt");
                
            
        }
        
        public void PrintGetGenerationTransformersHelp(StringBuilder sb)
        {
            
                
                sb.AppendLine();
                sb.AppendLine($"* * * * * * * * * * * * * * * * * * * * * * * * * * *");
                sb.AppendLine($"* *  OBJECT DEF: GenerationTransformer     *");
                sb.AppendLine($"* * * * * * * * * * * * * * * * * * * * * * * * * * *");
                sb.AppendLine();
                
                    sb.AppendLine($"CRUD      - GenerationTransformerId");
                    sb.AppendLine($"CRUD      - Name");
                    sb.AppendLine($"CRUD      - Generation");
                    sb.AppendLine($"CRUD      - RawPrompt");
                    sb.AppendLine($"CRUD      - GenerationName");
                    sb.AppendLine($"CRUD      - GeneratioNumber");
                    sb.AppendLine($"CRUD      - TransformedArtifacts");
                    sb.AppendLine($"CRUD      - AutoNumber");
                    sb.AppendLine($"CRUD      - TransformerNumber");
                    sb.AppendLine($"CRUD      - IsArtifactValidator");
                    sb.AppendLine($"CRUD      - ExpAbstract");
                    sb.AppendLine($"CRUD      - ExpTransformer");
                    sb.AppendLine($"CRUD      - GenerationExp");
                    sb.AppendLine($"CRUD      - GenerationExpName");
                    sb.AppendLine($"CRUD      - IsActiveExp");
                    sb.AppendLine($"CRUD      - ExpTransformerIsSyntaxFree");
                    sb.AppendLine($"CRUD      - ExpValidationPrompt");
                
            
        }
        
        public void PrintUpdateGenerationTransformerHelp(StringBuilder sb)
        {
            
                
                sb.AppendLine();
                sb.AppendLine($"* * * * * * * * * * * * * * * * * * * * * * * * * * *");
                sb.AppendLine($"* *  OBJECT DEF: GenerationTransformer     *");
                sb.AppendLine($"* * * * * * * * * * * * * * * * * * * * * * * * * * *");
                sb.AppendLine();
                
                    sb.AppendLine($"CRUD      - GenerationTransformerId");
                    sb.AppendLine($"CRUD      - Name");
                    sb.AppendLine($"CRUD      - Generation");
                    sb.AppendLine($"CRUD      - RawPrompt");
                    sb.AppendLine($"CRUD      - GenerationName");
                    sb.AppendLine($"CRUD      - GeneratioNumber");
                    sb.AppendLine($"CRUD      - TransformedArtifacts");
                    sb.AppendLine($"CRUD      - AutoNumber");
                    sb.AppendLine($"CRUD      - TransformerNumber");
                    sb.AppendLine($"CRUD      - IsArtifactValidator");
                    sb.AppendLine($"CRUD      - ExpAbstract");
                    sb.AppendLine($"CRUD      - ExpTransformer");
                    sb.AppendLine($"CRUD      - GenerationExp");
                    sb.AppendLine($"CRUD      - GenerationExpName");
                    sb.AppendLine($"CRUD      - IsActiveExp");
                    sb.AppendLine($"CRUD      - ExpTransformerIsSyntaxFree");
                    sb.AppendLine($"CRUD      - ExpValidationPrompt");
                
            
        }
        
        public void PrintDeleteGenerationTransformerHelp(StringBuilder sb)
        {
            
        }
        
        public void PrintAddGenerationHelp(StringBuilder sb)
        {
            
                
                sb.AppendLine();
                sb.AppendLine($"* * * * * * * * * * * * * * * * * * * * * * * * * * *");
                sb.AppendLine($"* *  OBJECT DEF: Generation     *");
                sb.AppendLine($"* * * * * * * * * * * * * * * * * * * * * * * * * * *");
                sb.AppendLine();
                
                    sb.AppendLine($"CRUD      - GenerationId");
                    sb.AppendLine($"CRUD      - Name");
                    sb.AppendLine($"CRUD      - GeneratioNumber");
                    sb.AppendLine($"CRUD      - Model");
                    sb.AppendLine($"CRUD      - Experiment");
                    sb.AppendLine($"CRUD      - ExpName");
                    sb.AppendLine($"CRUD      - GenerationTransformers");
                    sb.AppendLine($"CRUD      - IsActiveExp");
                    sb.AppendLine($"CRUD      - ExpAbstract");
                    sb.AppendLine($"CRUD      - ExpValidationPrompt");
                    sb.AppendLine($"CRUD      - GenerationTransformRawPrompts");
                    sb.AppendLine($"CRUD      - TransformerNumbers");
                    sb.AppendLine($"CRUD      - SyntaxFreeTransformerNumbers");
                    sb.AppendLine($"CRUD      - SyntaxLockedTransformerNumbers");
                
            
        }
        
        public void PrintGetGenerationsHelp(StringBuilder sb)
        {
            
                
                sb.AppendLine();
                sb.AppendLine($"* * * * * * * * * * * * * * * * * * * * * * * * * * *");
                sb.AppendLine($"* *  OBJECT DEF: Generation     *");
                sb.AppendLine($"* * * * * * * * * * * * * * * * * * * * * * * * * * *");
                sb.AppendLine();
                
                    sb.AppendLine($"CRUD      - GenerationId");
                    sb.AppendLine($"CRUD      - Name");
                    sb.AppendLine($"CRUD      - GeneratioNumber");
                    sb.AppendLine($"CRUD      - Model");
                    sb.AppendLine($"CRUD      - Experiment");
                    sb.AppendLine($"CRUD      - ExpName");
                    sb.AppendLine($"CRUD      - GenerationTransformers");
                    sb.AppendLine($"CRUD      - IsActiveExp");
                    sb.AppendLine($"CRUD      - ExpAbstract");
                    sb.AppendLine($"CRUD      - ExpValidationPrompt");
                    sb.AppendLine($"CRUD      - GenerationTransformRawPrompts");
                    sb.AppendLine($"CRUD      - TransformerNumbers");
                    sb.AppendLine($"CRUD      - SyntaxFreeTransformerNumbers");
                    sb.AppendLine($"CRUD      - SyntaxLockedTransformerNumbers");
                
            
        }
        
        public void PrintUpdateGenerationHelp(StringBuilder sb)
        {
            
                
                sb.AppendLine();
                sb.AppendLine($"* * * * * * * * * * * * * * * * * * * * * * * * * * *");
                sb.AppendLine($"* *  OBJECT DEF: Generation     *");
                sb.AppendLine($"* * * * * * * * * * * * * * * * * * * * * * * * * * *");
                sb.AppendLine();
                
                    sb.AppendLine($"CRUD      - GenerationId");
                    sb.AppendLine($"CRUD      - Name");
                    sb.AppendLine($"CRUD      - GeneratioNumber");
                    sb.AppendLine($"CRUD      - Model");
                    sb.AppendLine($"CRUD      - Experiment");
                    sb.AppendLine($"CRUD      - ExpName");
                    sb.AppendLine($"CRUD      - GenerationTransformers");
                    sb.AppendLine($"CRUD      - IsActiveExp");
                    sb.AppendLine($"CRUD      - ExpAbstract");
                    sb.AppendLine($"CRUD      - ExpValidationPrompt");
                    sb.AppendLine($"CRUD      - GenerationTransformRawPrompts");
                    sb.AppendLine($"CRUD      - TransformerNumbers");
                    sb.AppendLine($"CRUD      - SyntaxFreeTransformerNumbers");
                    sb.AppendLine($"CRUD      - SyntaxLockedTransformerNumbers");
                
            
        }
        
        public void PrintDeleteGenerationHelp(StringBuilder sb)
        {
            
        }
        
        public void PrintAddExperimentTransformerHelp(StringBuilder sb)
        {
            
                
                sb.AppendLine();
                sb.AppendLine($"* * * * * * * * * * * * * * * * * * * * * * * * * * *");
                sb.AppendLine($"* *  OBJECT DEF: ExperimentTransformer     *");
                sb.AppendLine($"* * * * * * * * * * * * * * * * * * * * * * * * * * *");
                sb.AppendLine();
                
                    sb.AppendLine($"CRUD      - ExperimentTransformerId");
                    sb.AppendLine($"CRUD      - Name");
                    sb.AppendLine($"CRUD      - Experiment");
                    sb.AppendLine($"CRUD      - ExpName");
                    sb.AppendLine($"CRUD      - ExpAbstract");
                    sb.AppendLine($"CRUD      - IsActiveExp");
                    sb.AppendLine($"CRUD      - FullPrompt");
                    sb.AppendLine($"CRUD      - TransformedTransformers");
                    sb.AppendLine($"CRUD      - AutoNumber");
                    sb.AppendLine($"CRUD      - TransformerIdentifier");
                    sb.AppendLine($"CRUD      - IsSyntaxFree");
                
            
        }
        
        public void PrintGetExperimentTransformersHelp(StringBuilder sb)
        {
            
                
                sb.AppendLine();
                sb.AppendLine($"* * * * * * * * * * * * * * * * * * * * * * * * * * *");
                sb.AppendLine($"* *  OBJECT DEF: ExperimentTransformer     *");
                sb.AppendLine($"* * * * * * * * * * * * * * * * * * * * * * * * * * *");
                sb.AppendLine();
                
                    sb.AppendLine($"CRUD      - ExperimentTransformerId");
                    sb.AppendLine($"CRUD      - Name");
                    sb.AppendLine($"CRUD      - Experiment");
                    sb.AppendLine($"CRUD      - ExpName");
                    sb.AppendLine($"CRUD      - ExpAbstract");
                    sb.AppendLine($"CRUD      - IsActiveExp");
                    sb.AppendLine($"CRUD      - FullPrompt");
                    sb.AppendLine($"CRUD      - TransformedTransformers");
                    sb.AppendLine($"CRUD      - AutoNumber");
                    sb.AppendLine($"CRUD      - TransformerIdentifier");
                    sb.AppendLine($"CRUD      - IsSyntaxFree");
                
            
        }
        
        public void PrintUpdateExperimentTransformerHelp(StringBuilder sb)
        {
            
                
                sb.AppendLine();
                sb.AppendLine($"* * * * * * * * * * * * * * * * * * * * * * * * * * *");
                sb.AppendLine($"* *  OBJECT DEF: ExperimentTransformer     *");
                sb.AppendLine($"* * * * * * * * * * * * * * * * * * * * * * * * * * *");
                sb.AppendLine();
                
                    sb.AppendLine($"CRUD      - ExperimentTransformerId");
                    sb.AppendLine($"CRUD      - Name");
                    sb.AppendLine($"CRUD      - Experiment");
                    sb.AppendLine($"CRUD      - ExpName");
                    sb.AppendLine($"CRUD      - ExpAbstract");
                    sb.AppendLine($"CRUD      - IsActiveExp");
                    sb.AppendLine($"CRUD      - FullPrompt");
                    sb.AppendLine($"CRUD      - TransformedTransformers");
                    sb.AppendLine($"CRUD      - AutoNumber");
                    sb.AppendLine($"CRUD      - TransformerIdentifier");
                    sb.AppendLine($"CRUD      - IsSyntaxFree");
                
            
        }
        
        public void PrintDeleteExperimentTransformerHelp(StringBuilder sb)
        {
            
        }
        
        public void PrintAddExperimentFeatureHelp(StringBuilder sb)
        {
            
                
                sb.AppendLine();
                sb.AppendLine($"* * * * * * * * * * * * * * * * * * * * * * * * * * *");
                sb.AppendLine($"* *  OBJECT DEF: ExperimentFeature     *");
                sb.AppendLine($"* * * * * * * * * * * * * * * * * * * * * * * * * * *");
                sb.AppendLine();
                
                    sb.AppendLine($"CRUD      - ExperimentFeatureId");
                    sb.AppendLine($"CRUD      - Name");
                    sb.AppendLine($"CRUD      - LowerName");
                    sb.AppendLine($"CRUD      - Description");
                    sb.AppendLine($"CRUD      - RequiredStartingAtGeneration");
                    sb.AppendLine($"CRUD      - ExplicitlyRemovedAtGeneration");
                    sb.AppendLine($"CRUD      - ExpAbstract");
                    sb.AppendLine($"CRUD      - Experiment");
                    sb.AppendLine($"CRUD      - IsActiveExp");
                
            
        }
        
        public void PrintGetExperimentFeaturesHelp(StringBuilder sb)
        {
            
                
                sb.AppendLine();
                sb.AppendLine($"* * * * * * * * * * * * * * * * * * * * * * * * * * *");
                sb.AppendLine($"* *  OBJECT DEF: ExperimentFeature     *");
                sb.AppendLine($"* * * * * * * * * * * * * * * * * * * * * * * * * * *");
                sb.AppendLine();
                
                    sb.AppendLine($"CRUD      - ExperimentFeatureId");
                    sb.AppendLine($"CRUD      - Name");
                    sb.AppendLine($"CRUD      - LowerName");
                    sb.AppendLine($"CRUD      - Description");
                    sb.AppendLine($"CRUD      - RequiredStartingAtGeneration");
                    sb.AppendLine($"CRUD      - ExplicitlyRemovedAtGeneration");
                    sb.AppendLine($"CRUD      - ExpAbstract");
                    sb.AppendLine($"CRUD      - Experiment");
                    sb.AppendLine($"CRUD      - IsActiveExp");
                
            
        }
        
        public void PrintUpdateExperimentFeatureHelp(StringBuilder sb)
        {
            
                
                sb.AppendLine();
                sb.AppendLine($"* * * * * * * * * * * * * * * * * * * * * * * * * * *");
                sb.AppendLine($"* *  OBJECT DEF: ExperimentFeature     *");
                sb.AppendLine($"* * * * * * * * * * * * * * * * * * * * * * * * * * *");
                sb.AppendLine();
                
                    sb.AppendLine($"CRUD      - ExperimentFeatureId");
                    sb.AppendLine($"CRUD      - Name");
                    sb.AppendLine($"CRUD      - LowerName");
                    sb.AppendLine($"CRUD      - Description");
                    sb.AppendLine($"CRUD      - RequiredStartingAtGeneration");
                    sb.AppendLine($"CRUD      - ExplicitlyRemovedAtGeneration");
                    sb.AppendLine($"CRUD      - ExpAbstract");
                    sb.AppendLine($"CRUD      - Experiment");
                    sb.AppendLine($"CRUD      - IsActiveExp");
                
            
        }
        
        public void PrintDeleteExperimentFeatureHelp(StringBuilder sb)
        {
            
        }
        
        public void PrintAddTransformedArtifactHelp(StringBuilder sb)
        {
            
                
                sb.AppendLine();
                sb.AppendLine($"* * * * * * * * * * * * * * * * * * * * * * * * * * *");
                sb.AppendLine($"* *  OBJECT DEF: TransformedArtifact     *");
                sb.AppendLine($"* * * * * * * * * * * * * * * * * * * * * * * * * * *");
                sb.AppendLine();
                
                    sb.AppendLine($"CRUD      - TransformedArtifactId");
                    sb.AppendLine($"CRUD      - Name");
                    sb.AppendLine($"CRUD      - GenerationTransformer");
                    sb.AppendLine($"CRUD      - SuggestedPrompt");
                    sb.AppendLine($"CRUD      - ActualPrompt");
                    sb.AppendLine($"CRUD      - Response");
                    sb.AppendLine($"CRUD      - Created");
                    sb.AppendLine($"CRUD      - AutoNumber");
                    sb.AppendLine($"CRUD      - ResponseOfArtifactBeingExtended");
                    sb.AppendLine($"CRUD      - TransformerRawPrompt");
                    sb.AppendLine($"CRUD      - IsRetiredArtifact");
                    sb.AppendLine($"CRUD      - Modified");
                    sb.AppendLine($"CRUD      - ExtensionOf");
                    sb.AppendLine($"CRUD      - TransformerNumber");
                    sb.AppendLine($"CRUD      - LongName");
                    sb.AppendLine($"CRUD      - TransformerGeneratioNumber");
                    sb.AppendLine($"CRUD      - TransformerGenerationName");
                    sb.AppendLine($"CRUD      - ArtifactIdentifier");
                    sb.AppendLine($"CRUD      - PrimaryExtensionArtifact");
                    sb.AppendLine($"CRUD      - ToDoItems");
                    sb.AppendLine($"CRUD      - ToDoItemsAKA");
                    sb.AppendLine($"CRUD      - ToDoItemsMismatched");
                    sb.AppendLine($"CRUD      - Categories");
                    sb.AppendLine($"CRUD      - CategoriesAKA");
                    sb.AppendLine($"CRUD      - CategoriesMismatched");
                    sb.AppendLine($"CRUD      - DueDates");
                    sb.AppendLine($"CRUD      - DueDatesAKA");
                    sb.AppendLine($"CRUD      - DueDatesMismatched");
                    sb.AppendLine($"CRUD      - Priorities");
                    sb.AppendLine($"CRUD      - PrioritiesAKA");
                    sb.AppendLine($"CRUD      - PrioritiesMismatched");
                    sb.AppendLine($"CRUD      - Progress");
                    sb.AppendLine($"CRUD      - ProgressAKA");
                    sb.AppendLine($"CRUD      - ProgressMismatched");
                    sb.AppendLine($"CRUD      - Statuses");
                    sb.AppendLine($"CRUD      - StatusesAKA");
                    sb.AppendLine($"CRUD      - StatusesMismatched");
                    sb.AppendLine($"CRUD      - Reminders");
                    sb.AppendLine($"CRUD      - RemindersAKA");
                    sb.AppendLine($"CRUD      - RemindersMismatched");
                    sb.AppendLine($"CRUD      - Notifications");
                    sb.AppendLine($"CRUD      - NotificationsAKA");
                    sb.AppendLine($"CRUD      - NotificationsMismatched");
                    sb.AppendLine($"CRUD      - Completion");
                    sb.AppendLine($"CRUD      - CompletionAKA");
                    sb.AppendLine($"CRUD      - CompletionMismatched");
                    sb.AppendLine($"CRUD      - ToDoEmployees");
                    sb.AppendLine($"CRUD      - ToDoEmployeesAKA");
                    sb.AppendLine($"CRUD      - ToDoEmployeesMismatched");
                    sb.AppendLine($"CRUD      - Duration");
                    sb.AppendLine($"CRUD      - DurationAKA");
                    sb.AppendLine($"CRUD      - DurationMismatched");
                    sb.AppendLine($"CRUD      - CompletedDate");
                    sb.AppendLine($"CRUD      - CompletedDateAKA");
                    sb.AppendLine($"CRUD      - CompletedDateMismatched");
                    sb.AppendLine($"CRUD      - ToDoColors");
                    sb.AppendLine($"CRUD      - ToDoColorsAKA");
                    sb.AppendLine($"CRUD      - ToDoColorsMismatched");
                    sb.AppendLine($"CRUD      - ResponseBeingValidated");
                    sb.AppendLine($"CRUD      - SuggestedValidationPrompt");
                    sb.AppendLine($"CRUD      - ActualValidationPrompt");
                    sb.AppendLine($"CRUD      - ValidationResponse");
                    sb.AppendLine($"CRUD      - GenerationName");
                    sb.AppendLine($"CRUD      - GeneratioNumber");
                    sb.AppendLine($"CRUD      - GenerationTransformerNumber");
                    sb.AppendLine($"CRUD      - ExtensionOfArtifactIdentifier");
                    sb.AppendLine($"CRUD      - RootArtifactIdentifier");
                    sb.AppendLine($"CRUD      - SuggestedRootIdentifier");
                    sb.AppendLine($"CRUD      - CustomRootIdentifier");
                    sb.AppendLine($"CRUD      - RootIdentifierMismatch");
                    sb.AppendLine($"CRUD      - ExpTransformerIsSyntaxFree");
                    sb.AppendLine($"CRUD      - IsActiveExp");
                    sb.AppendLine($"CRUD      - TransformerGenerationExpName");
                    sb.AppendLine($"CRUD      - ExpValidationPrompt");
                    sb.AppendLine($"CRUD      - ExpAbstract");
                
            
        }
        
        public void PrintGetTransformedArtifactsHelp(StringBuilder sb)
        {
            
                
                sb.AppendLine();
                sb.AppendLine($"* * * * * * * * * * * * * * * * * * * * * * * * * * *");
                sb.AppendLine($"* *  OBJECT DEF: TransformedArtifact     *");
                sb.AppendLine($"* * * * * * * * * * * * * * * * * * * * * * * * * * *");
                sb.AppendLine();
                
                    sb.AppendLine($"CRUD      - TransformedArtifactId");
                    sb.AppendLine($"CRUD      - Name");
                    sb.AppendLine($"CRUD      - GenerationTransformer");
                    sb.AppendLine($"CRUD      - SuggestedPrompt");
                    sb.AppendLine($"CRUD      - ActualPrompt");
                    sb.AppendLine($"CRUD      - Response");
                    sb.AppendLine($"CRUD      - Created");
                    sb.AppendLine($"CRUD      - AutoNumber");
                    sb.AppendLine($"CRUD      - ResponseOfArtifactBeingExtended");
                    sb.AppendLine($"CRUD      - TransformerRawPrompt");
                    sb.AppendLine($"CRUD      - IsRetiredArtifact");
                    sb.AppendLine($"CRUD      - Modified");
                    sb.AppendLine($"CRUD      - ExtensionOf");
                    sb.AppendLine($"CRUD      - TransformerNumber");
                    sb.AppendLine($"CRUD      - LongName");
                    sb.AppendLine($"CRUD      - TransformerGeneratioNumber");
                    sb.AppendLine($"CRUD      - TransformerGenerationName");
                    sb.AppendLine($"CRUD      - ArtifactIdentifier");
                    sb.AppendLine($"CRUD      - PrimaryExtensionArtifact");
                    sb.AppendLine($"CRUD      - ToDoItems");
                    sb.AppendLine($"CRUD      - ToDoItemsAKA");
                    sb.AppendLine($"CRUD      - ToDoItemsMismatched");
                    sb.AppendLine($"CRUD      - Categories");
                    sb.AppendLine($"CRUD      - CategoriesAKA");
                    sb.AppendLine($"CRUD      - CategoriesMismatched");
                    sb.AppendLine($"CRUD      - DueDates");
                    sb.AppendLine($"CRUD      - DueDatesAKA");
                    sb.AppendLine($"CRUD      - DueDatesMismatched");
                    sb.AppendLine($"CRUD      - Priorities");
                    sb.AppendLine($"CRUD      - PrioritiesAKA");
                    sb.AppendLine($"CRUD      - PrioritiesMismatched");
                    sb.AppendLine($"CRUD      - Progress");
                    sb.AppendLine($"CRUD      - ProgressAKA");
                    sb.AppendLine($"CRUD      - ProgressMismatched");
                    sb.AppendLine($"CRUD      - Statuses");
                    sb.AppendLine($"CRUD      - StatusesAKA");
                    sb.AppendLine($"CRUD      - StatusesMismatched");
                    sb.AppendLine($"CRUD      - Reminders");
                    sb.AppendLine($"CRUD      - RemindersAKA");
                    sb.AppendLine($"CRUD      - RemindersMismatched");
                    sb.AppendLine($"CRUD      - Notifications");
                    sb.AppendLine($"CRUD      - NotificationsAKA");
                    sb.AppendLine($"CRUD      - NotificationsMismatched");
                    sb.AppendLine($"CRUD      - Completion");
                    sb.AppendLine($"CRUD      - CompletionAKA");
                    sb.AppendLine($"CRUD      - CompletionMismatched");
                    sb.AppendLine($"CRUD      - ToDoEmployees");
                    sb.AppendLine($"CRUD      - ToDoEmployeesAKA");
                    sb.AppendLine($"CRUD      - ToDoEmployeesMismatched");
                    sb.AppendLine($"CRUD      - Duration");
                    sb.AppendLine($"CRUD      - DurationAKA");
                    sb.AppendLine($"CRUD      - DurationMismatched");
                    sb.AppendLine($"CRUD      - CompletedDate");
                    sb.AppendLine($"CRUD      - CompletedDateAKA");
                    sb.AppendLine($"CRUD      - CompletedDateMismatched");
                    sb.AppendLine($"CRUD      - ToDoColors");
                    sb.AppendLine($"CRUD      - ToDoColorsAKA");
                    sb.AppendLine($"CRUD      - ToDoColorsMismatched");
                    sb.AppendLine($"CRUD      - ResponseBeingValidated");
                    sb.AppendLine($"CRUD      - SuggestedValidationPrompt");
                    sb.AppendLine($"CRUD      - ActualValidationPrompt");
                    sb.AppendLine($"CRUD      - ValidationResponse");
                    sb.AppendLine($"CRUD      - GenerationName");
                    sb.AppendLine($"CRUD      - GeneratioNumber");
                    sb.AppendLine($"CRUD      - GenerationTransformerNumber");
                    sb.AppendLine($"CRUD      - ExtensionOfArtifactIdentifier");
                    sb.AppendLine($"CRUD      - RootArtifactIdentifier");
                    sb.AppendLine($"CRUD      - SuggestedRootIdentifier");
                    sb.AppendLine($"CRUD      - CustomRootIdentifier");
                    sb.AppendLine($"CRUD      - RootIdentifierMismatch");
                    sb.AppendLine($"CRUD      - ExpTransformerIsSyntaxFree");
                    sb.AppendLine($"CRUD      - IsActiveExp");
                    sb.AppendLine($"CRUD      - TransformerGenerationExpName");
                    sb.AppendLine($"CRUD      - ExpValidationPrompt");
                    sb.AppendLine($"CRUD      - ExpAbstract");
                
            
        }
        
        public void PrintUpdateTransformedArtifactHelp(StringBuilder sb)
        {
            
                
                sb.AppendLine();
                sb.AppendLine($"* * * * * * * * * * * * * * * * * * * * * * * * * * *");
                sb.AppendLine($"* *  OBJECT DEF: TransformedArtifact     *");
                sb.AppendLine($"* * * * * * * * * * * * * * * * * * * * * * * * * * *");
                sb.AppendLine();
                
                    sb.AppendLine($"CRUD      - TransformedArtifactId");
                    sb.AppendLine($"CRUD      - Name");
                    sb.AppendLine($"CRUD      - GenerationTransformer");
                    sb.AppendLine($"CRUD      - SuggestedPrompt");
                    sb.AppendLine($"CRUD      - ActualPrompt");
                    sb.AppendLine($"CRUD      - Response");
                    sb.AppendLine($"CRUD      - Created");
                    sb.AppendLine($"CRUD      - AutoNumber");
                    sb.AppendLine($"CRUD      - ResponseOfArtifactBeingExtended");
                    sb.AppendLine($"CRUD      - TransformerRawPrompt");
                    sb.AppendLine($"CRUD      - IsRetiredArtifact");
                    sb.AppendLine($"CRUD      - Modified");
                    sb.AppendLine($"CRUD      - ExtensionOf");
                    sb.AppendLine($"CRUD      - TransformerNumber");
                    sb.AppendLine($"CRUD      - LongName");
                    sb.AppendLine($"CRUD      - TransformerGeneratioNumber");
                    sb.AppendLine($"CRUD      - TransformerGenerationName");
                    sb.AppendLine($"CRUD      - ArtifactIdentifier");
                    sb.AppendLine($"CRUD      - PrimaryExtensionArtifact");
                    sb.AppendLine($"CRUD      - ToDoItems");
                    sb.AppendLine($"CRUD      - ToDoItemsAKA");
                    sb.AppendLine($"CRUD      - ToDoItemsMismatched");
                    sb.AppendLine($"CRUD      - Categories");
                    sb.AppendLine($"CRUD      - CategoriesAKA");
                    sb.AppendLine($"CRUD      - CategoriesMismatched");
                    sb.AppendLine($"CRUD      - DueDates");
                    sb.AppendLine($"CRUD      - DueDatesAKA");
                    sb.AppendLine($"CRUD      - DueDatesMismatched");
                    sb.AppendLine($"CRUD      - Priorities");
                    sb.AppendLine($"CRUD      - PrioritiesAKA");
                    sb.AppendLine($"CRUD      - PrioritiesMismatched");
                    sb.AppendLine($"CRUD      - Progress");
                    sb.AppendLine($"CRUD      - ProgressAKA");
                    sb.AppendLine($"CRUD      - ProgressMismatched");
                    sb.AppendLine($"CRUD      - Statuses");
                    sb.AppendLine($"CRUD      - StatusesAKA");
                    sb.AppendLine($"CRUD      - StatusesMismatched");
                    sb.AppendLine($"CRUD      - Reminders");
                    sb.AppendLine($"CRUD      - RemindersAKA");
                    sb.AppendLine($"CRUD      - RemindersMismatched");
                    sb.AppendLine($"CRUD      - Notifications");
                    sb.AppendLine($"CRUD      - NotificationsAKA");
                    sb.AppendLine($"CRUD      - NotificationsMismatched");
                    sb.AppendLine($"CRUD      - Completion");
                    sb.AppendLine($"CRUD      - CompletionAKA");
                    sb.AppendLine($"CRUD      - CompletionMismatched");
                    sb.AppendLine($"CRUD      - ToDoEmployees");
                    sb.AppendLine($"CRUD      - ToDoEmployeesAKA");
                    sb.AppendLine($"CRUD      - ToDoEmployeesMismatched");
                    sb.AppendLine($"CRUD      - Duration");
                    sb.AppendLine($"CRUD      - DurationAKA");
                    sb.AppendLine($"CRUD      - DurationMismatched");
                    sb.AppendLine($"CRUD      - CompletedDate");
                    sb.AppendLine($"CRUD      - CompletedDateAKA");
                    sb.AppendLine($"CRUD      - CompletedDateMismatched");
                    sb.AppendLine($"CRUD      - ToDoColors");
                    sb.AppendLine($"CRUD      - ToDoColorsAKA");
                    sb.AppendLine($"CRUD      - ToDoColorsMismatched");
                    sb.AppendLine($"CRUD      - ResponseBeingValidated");
                    sb.AppendLine($"CRUD      - SuggestedValidationPrompt");
                    sb.AppendLine($"CRUD      - ActualValidationPrompt");
                    sb.AppendLine($"CRUD      - ValidationResponse");
                    sb.AppendLine($"CRUD      - GenerationName");
                    sb.AppendLine($"CRUD      - GeneratioNumber");
                    sb.AppendLine($"CRUD      - GenerationTransformerNumber");
                    sb.AppendLine($"CRUD      - ExtensionOfArtifactIdentifier");
                    sb.AppendLine($"CRUD      - RootArtifactIdentifier");
                    sb.AppendLine($"CRUD      - SuggestedRootIdentifier");
                    sb.AppendLine($"CRUD      - CustomRootIdentifier");
                    sb.AppendLine($"CRUD      - RootIdentifierMismatch");
                    sb.AppendLine($"CRUD      - ExpTransformerIsSyntaxFree");
                    sb.AppendLine($"CRUD      - IsActiveExp");
                    sb.AppendLine($"CRUD      - TransformerGenerationExpName");
                    sb.AppendLine($"CRUD      - ExpValidationPrompt");
                    sb.AppendLine($"CRUD      - ExpAbstract");
                
            
        }
        
        public void PrintDeleteTransformedArtifactHelp(StringBuilder sb)
        {
            
        }
        
        public void PrintAddDesignDecisionHelp(StringBuilder sb)
        {
            
                
                sb.AppendLine();
                sb.AppendLine($"* * * * * * * * * * * * * * * * * * * * * * * * * * *");
                sb.AppendLine($"* *  OBJECT DEF: DesignDecision     *");
                sb.AppendLine($"* * * * * * * * * * * * * * * * * * * * * * * * * * *");
                sb.AppendLine();
                
                    sb.AppendLine($"CRUD      - DesignDecisionId");
                    sb.AppendLine($"CRUD      - Name");
                    sb.AppendLine($"CRUD      - Notes");
                    sb.AppendLine($"CRUD      - TypeOfDecision");
                
            
        }
        
        public void PrintGetDesignDecisionsHelp(StringBuilder sb)
        {
            
                
                sb.AppendLine();
                sb.AppendLine($"* * * * * * * * * * * * * * * * * * * * * * * * * * *");
                sb.AppendLine($"* *  OBJECT DEF: DesignDecision     *");
                sb.AppendLine($"* * * * * * * * * * * * * * * * * * * * * * * * * * *");
                sb.AppendLine();
                
                    sb.AppendLine($"CRUD      - DesignDecisionId");
                    sb.AppendLine($"CRUD      - Name");
                    sb.AppendLine($"CRUD      - Notes");
                    sb.AppendLine($"CRUD      - TypeOfDecision");
                
            
        }
        
        public void PrintUpdateDesignDecisionHelp(StringBuilder sb)
        {
            
                
                sb.AppendLine();
                sb.AppendLine($"* * * * * * * * * * * * * * * * * * * * * * * * * * *");
                sb.AppendLine($"* *  OBJECT DEF: DesignDecision     *");
                sb.AppendLine($"* * * * * * * * * * * * * * * * * * * * * * * * * * *");
                sb.AppendLine();
                
                    sb.AppendLine($"CRUD      - DesignDecisionId");
                    sb.AppendLine($"CRUD      - Name");
                    sb.AppendLine($"CRUD      - Notes");
                    sb.AppendLine($"CRUD      - TypeOfDecision");
                
            
        }
        
        public void PrintDeleteDesignDecisionHelp(StringBuilder sb)
        {
            
        }
        
        public void PrintAddExperimentHelp(StringBuilder sb)
        {
            
                
                sb.AppendLine();
                sb.AppendLine($"* * * * * * * * * * * * * * * * * * * * * * * * * * *");
                sb.AppendLine($"* *  OBJECT DEF: Experiment     *");
                sb.AppendLine($"* * * * * * * * * * * * * * * * * * * * * * * * * * *");
                sb.AppendLine();
                
                    sb.AppendLine($"CRUD      - ExperimentId");
                    sb.AppendLine($"CRUD      - Name");
                    sb.AppendLine($"CRUD      - ExpName");
                    sb.AppendLine($"CRUD      - ExpIdentifier");
                    sb.AppendLine($"CRUD      - ExpAbstract");
                    sb.AppendLine($"CRUD      - Generations");
                    sb.AppendLine($"CRUD      - ExpTransformers");
                    sb.AppendLine($"CRUD      - ExpTransformerNames");
                    sb.AppendLine($"CRUD      - ExpTransformerFullPrompts");
                    sb.AppendLine($"CRUD      - IsActiveExp");
                    sb.AppendLine($"CRUD      - ExpFeatures");
                    sb.AppendLine($"CRUD      - ExpFeatureLowerNames");
                    sb.AppendLine($"CRUD      - ExpFeatureNames");
                    sb.AppendLine($"CRUD      - FeaturesArray");
                    sb.AppendLine($"CRUD      - ValidationPrompt");
                    sb.AppendLine($"CRUD      - AutoNumber");
                
            
        }
        
        public void PrintGetExperimentsHelp(StringBuilder sb)
        {
            
                
                sb.AppendLine();
                sb.AppendLine($"* * * * * * * * * * * * * * * * * * * * * * * * * * *");
                sb.AppendLine($"* *  OBJECT DEF: Experiment     *");
                sb.AppendLine($"* * * * * * * * * * * * * * * * * * * * * * * * * * *");
                sb.AppendLine();
                
                    sb.AppendLine($"CRUD      - ExperimentId");
                    sb.AppendLine($"CRUD      - Name");
                    sb.AppendLine($"CRUD      - ExpName");
                    sb.AppendLine($"CRUD      - ExpIdentifier");
                    sb.AppendLine($"CRUD      - ExpAbstract");
                    sb.AppendLine($"CRUD      - Generations");
                    sb.AppendLine($"CRUD      - ExpTransformers");
                    sb.AppendLine($"CRUD      - ExpTransformerNames");
                    sb.AppendLine($"CRUD      - ExpTransformerFullPrompts");
                    sb.AppendLine($"CRUD      - IsActiveExp");
                    sb.AppendLine($"CRUD      - ExpFeatures");
                    sb.AppendLine($"CRUD      - ExpFeatureLowerNames");
                    sb.AppendLine($"CRUD      - ExpFeatureNames");
                    sb.AppendLine($"CRUD      - FeaturesArray");
                    sb.AppendLine($"CRUD      - ValidationPrompt");
                    sb.AppendLine($"CRUD      - AutoNumber");
                
            
        }
        
        public void PrintUpdateExperimentHelp(StringBuilder sb)
        {
            
                
                sb.AppendLine();
                sb.AppendLine($"* * * * * * * * * * * * * * * * * * * * * * * * * * *");
                sb.AppendLine($"* *  OBJECT DEF: Experiment     *");
                sb.AppendLine($"* * * * * * * * * * * * * * * * * * * * * * * * * * *");
                sb.AppendLine();
                
                    sb.AppendLine($"CRUD      - ExperimentId");
                    sb.AppendLine($"CRUD      - Name");
                    sb.AppendLine($"CRUD      - ExpName");
                    sb.AppendLine($"CRUD      - ExpIdentifier");
                    sb.AppendLine($"CRUD      - ExpAbstract");
                    sb.AppendLine($"CRUD      - Generations");
                    sb.AppendLine($"CRUD      - ExpTransformers");
                    sb.AppendLine($"CRUD      - ExpTransformerNames");
                    sb.AppendLine($"CRUD      - ExpTransformerFullPrompts");
                    sb.AppendLine($"CRUD      - IsActiveExp");
                    sb.AppendLine($"CRUD      - ExpFeatures");
                    sb.AppendLine($"CRUD      - ExpFeatureLowerNames");
                    sb.AppendLine($"CRUD      - ExpFeatureNames");
                    sb.AppendLine($"CRUD      - FeaturesArray");
                    sb.AppendLine($"CRUD      - ValidationPrompt");
                    sb.AppendLine($"CRUD      - AutoNumber");
                
            
        }
        
        public void PrintDeleteExperimentHelp(StringBuilder sb)
        {
            
        }
        
        public void PrintAddLLMHelp(StringBuilder sb)
        {
            
                
                sb.AppendLine();
                sb.AppendLine($"* * * * * * * * * * * * * * * * * * * * * * * * * * *");
                sb.AppendLine($"* *  OBJECT DEF: LLM     *");
                sb.AppendLine($"* * * * * * * * * * * * * * * * * * * * * * * * * * *");
                sb.AppendLine();
                
                    sb.AppendLine($"CRUD      - LLMId");
                    sb.AppendLine($"CRUD      - Name");
                    sb.AppendLine($"CRUD      - Notes");
                    sb.AppendLine($"CRUD      - TestRuns");
                    sb.AppendLine($"CRUD      - Generations");
                
            
        }
        
        public void PrintGetLLMsHelp(StringBuilder sb)
        {
            
                
                sb.AppendLine();
                sb.AppendLine($"* * * * * * * * * * * * * * * * * * * * * * * * * * *");
                sb.AppendLine($"* *  OBJECT DEF: LLM     *");
                sb.AppendLine($"* * * * * * * * * * * * * * * * * * * * * * * * * * *");
                sb.AppendLine();
                
                    sb.AppendLine($"CRUD      - LLMId");
                    sb.AppendLine($"CRUD      - Name");
                    sb.AppendLine($"CRUD      - Notes");
                    sb.AppendLine($"CRUD      - TestRuns");
                    sb.AppendLine($"CRUD      - Generations");
                
            
        }
        
        public void PrintUpdateLLMHelp(StringBuilder sb)
        {
            
                
                sb.AppendLine();
                sb.AppendLine($"* * * * * * * * * * * * * * * * * * * * * * * * * * *");
                sb.AppendLine($"* *  OBJECT DEF: LLM     *");
                sb.AppendLine($"* * * * * * * * * * * * * * * * * * * * * * * * * * *");
                sb.AppendLine();
                
                    sb.AppendLine($"CRUD      - LLMId");
                    sb.AppendLine($"CRUD      - Name");
                    sb.AppendLine($"CRUD      - Notes");
                    sb.AppendLine($"CRUD      - TestRuns");
                    sb.AppendLine($"CRUD      - Generations");
                
            
        }
        
        public void PrintDeleteLLMHelp(StringBuilder sb)
        {
            
        }
        

    }
}
