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
    public partial class UserCLIHandler
    {
        public override void AddHelp(StringBuilder sb, string helpTerm)
        {
            sb.AppendLine($"Help for User.");
            
            helpTerm = helpTerm.ToLower();
            var found = helpTerm == "general";
            
            if (helpTerm == "general")
            {
                sb.AppendLine();
                
                sb.AppendLine($"PromptInputAnswerKey: AddPromptInputAnswerKey");
                sb.AppendLine($"PromptInputAnswerKey: GetPromptInputAnswerKeies");
                sb.AppendLine($"PromptInputAnswerKey: UpdatePromptInputAnswerKey");
                sb.AppendLine($"void: DeletePromptInputAnswerKey");
                sb.AppendLine($"GenerationTransformer: AddGenerationTransformer");
                sb.AppendLine($"GenerationTransformer: GetGenerationTransformers");
                sb.AppendLine($"GenerationTransformer: UpdateGenerationTransformer");
                sb.AppendLine($"void: DeleteGenerationTransformer");
                sb.AppendLine($"IdeaTransformer: AddIdeaTransformer");
                sb.AppendLine($"IdeaTransformer: GetIdeaTransformers");
                sb.AppendLine($"IdeaTransformer: UpdateIdeaTransformer");
                sb.AppendLine($"void: DeleteIdeaTransformer");
                sb.AppendLine($"MOFNode: AddMOFNode");
                sb.AppendLine($"MOFNode: GetMOFNodes");
                sb.AppendLine($"MOFNode: UpdateMOFNode");
                sb.AppendLine($"void: DeleteMOFNode");
                sb.AppendLine($"MOFChoice: AddMOFChoice");
                sb.AppendLine($"MOFChoice: GetMOFChoices");
                sb.AppendLine($"MOFChoice: UpdateMOFChoice");
                sb.AppendLine($"void: DeleteMOFChoice");
                sb.AppendLine($"DataFormat: AddDataFormat");
                sb.AppendLine($"DataFormat: GetDataFormats");
                sb.AppendLine($"DataFormat: UpdateDataFormat");
                sb.AppendLine($"void: DeleteDataFormat");
                sb.AppendLine($"Generation: AddGeneration");
                sb.AppendLine($"Generation: GetGenerations");
                sb.AppendLine($"Generation: UpdateGeneration");
                sb.AppendLine($"void: DeleteGeneration");
                sb.AppendLine($"AppUser: AddAppUser");
                sb.AppendLine($"AppUser: GetAppUsers");
                sb.AppendLine($"AppUser: UpdateAppUser");
                sb.AppendLine($"void: DeleteAppUser");
                sb.AppendLine($"MOFLayer: AddMOFLayer");
                sb.AppendLine($"MOFLayer: GetMOFLayers");
                sb.AppendLine($"MOFLayer: UpdateMOFLayer");
                sb.AppendLine($"void: DeleteMOFLayer");
                sb.AppendLine($"LLM: AddLLM");
                sb.AppendLine($"LLM: GetLLMs");
                sb.AppendLine($"LLM: UpdateLLM");
                sb.AppendLine($"void: DeleteLLM");
                sb.AppendLine($"OutputFormatRequest: AddOutputFormatRequest");
                sb.AppendLine($"OutputFormatRequest: GetOutputFormatRequests");
                sb.AppendLine($"OutputFormatRequest: UpdateOutputFormatRequest");
                sb.AppendLine($"void: DeleteOutputFormatRequest");
                sb.AppendLine($"TransformedArtifact: AddTransformedArtifact");
                sb.AppendLine($"TransformedArtifact: GetTransformedArtifacts");
                sb.AppendLine($"TransformedArtifact: UpdateTransformedArtifact");
                sb.AppendLine($"void: DeleteTransformedArtifact");
                sb.AppendLine($"Idea: AddIdea");
                sb.AppendLine($"Idea: GetIdeas");
                sb.AppendLine($"Idea: UpdateIdea");
                sb.AppendLine($"void: DeleteIdea");                                            
            }
            
            sb.AppendLine($"{Environment.NewLine}Available Actions Matching: {helpTerm}");
            
            if ("addpromptinputanswerkey".Contains(helpTerm, StringComparison.OrdinalIgnoreCase))
            {
                sb.AppendLine($" - AddPromptInputAnswerKey");
                if ("addpromptinputanswerkey".Equals(helpTerm, StringComparison.OrdinalIgnoreCase)) 
                {
                    this.PrintAddPromptInputAnswerKeyHelp(sb);
                }
                found = true;
            }
            if ("getpromptinputanswerkeies".Contains(helpTerm, StringComparison.OrdinalIgnoreCase))
            {
                sb.AppendLine($" - GetPromptInputAnswerKeies");
                if ("getpromptinputanswerkeies".Equals(helpTerm, StringComparison.OrdinalIgnoreCase)) 
                {
                    this.PrintGetPromptInputAnswerKeiesHelp(sb);
                }
                found = true;
            }
            if ("updatepromptinputanswerkey".Contains(helpTerm, StringComparison.OrdinalIgnoreCase))
            {
                sb.AppendLine($" - UpdatePromptInputAnswerKey");
                if ("updatepromptinputanswerkey".Equals(helpTerm, StringComparison.OrdinalIgnoreCase)) 
                {
                    this.PrintUpdatePromptInputAnswerKeyHelp(sb);
                }
                found = true;
            }
            if ("deletepromptinputanswerkey".Contains(helpTerm, StringComparison.OrdinalIgnoreCase))
            {
                sb.AppendLine($" - DeletePromptInputAnswerKey");
                if ("deletepromptinputanswerkey".Equals(helpTerm, StringComparison.OrdinalIgnoreCase)) 
                {
                    this.PrintDeletePromptInputAnswerKeyHelp(sb);
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
            if ("addideatransformer".Contains(helpTerm, StringComparison.OrdinalIgnoreCase))
            {
                sb.AppendLine($" - AddIdeaTransformer");
                if ("addideatransformer".Equals(helpTerm, StringComparison.OrdinalIgnoreCase)) 
                {
                    this.PrintAddIdeaTransformerHelp(sb);
                }
                found = true;
            }
            if ("getideatransformers".Contains(helpTerm, StringComparison.OrdinalIgnoreCase))
            {
                sb.AppendLine($" - GetIdeaTransformers");
                if ("getideatransformers".Equals(helpTerm, StringComparison.OrdinalIgnoreCase)) 
                {
                    this.PrintGetIdeaTransformersHelp(sb);
                }
                found = true;
            }
            if ("updateideatransformer".Contains(helpTerm, StringComparison.OrdinalIgnoreCase))
            {
                sb.AppendLine($" - UpdateIdeaTransformer");
                if ("updateideatransformer".Equals(helpTerm, StringComparison.OrdinalIgnoreCase)) 
                {
                    this.PrintUpdateIdeaTransformerHelp(sb);
                }
                found = true;
            }
            if ("deleteideatransformer".Contains(helpTerm, StringComparison.OrdinalIgnoreCase))
            {
                sb.AppendLine($" - DeleteIdeaTransformer");
                if ("deleteideatransformer".Equals(helpTerm, StringComparison.OrdinalIgnoreCase)) 
                {
                    this.PrintDeleteIdeaTransformerHelp(sb);
                }
                found = true;
            }
            if ("addmofnode".Contains(helpTerm, StringComparison.OrdinalIgnoreCase))
            {
                sb.AppendLine($" - AddMOFNode");
                if ("addmofnode".Equals(helpTerm, StringComparison.OrdinalIgnoreCase)) 
                {
                    this.PrintAddMOFNodeHelp(sb);
                }
                found = true;
            }
            if ("getmofnodes".Contains(helpTerm, StringComparison.OrdinalIgnoreCase))
            {
                sb.AppendLine($" - GetMOFNodes");
                if ("getmofnodes".Equals(helpTerm, StringComparison.OrdinalIgnoreCase)) 
                {
                    this.PrintGetMOFNodesHelp(sb);
                }
                found = true;
            }
            if ("updatemofnode".Contains(helpTerm, StringComparison.OrdinalIgnoreCase))
            {
                sb.AppendLine($" - UpdateMOFNode");
                if ("updatemofnode".Equals(helpTerm, StringComparison.OrdinalIgnoreCase)) 
                {
                    this.PrintUpdateMOFNodeHelp(sb);
                }
                found = true;
            }
            if ("deletemofnode".Contains(helpTerm, StringComparison.OrdinalIgnoreCase))
            {
                sb.AppendLine($" - DeleteMOFNode");
                if ("deletemofnode".Equals(helpTerm, StringComparison.OrdinalIgnoreCase)) 
                {
                    this.PrintDeleteMOFNodeHelp(sb);
                }
                found = true;
            }
            if ("addmofchoice".Contains(helpTerm, StringComparison.OrdinalIgnoreCase))
            {
                sb.AppendLine($" - AddMOFChoice");
                if ("addmofchoice".Equals(helpTerm, StringComparison.OrdinalIgnoreCase)) 
                {
                    this.PrintAddMOFChoiceHelp(sb);
                }
                found = true;
            }
            if ("getmofchoices".Contains(helpTerm, StringComparison.OrdinalIgnoreCase))
            {
                sb.AppendLine($" - GetMOFChoices");
                if ("getmofchoices".Equals(helpTerm, StringComparison.OrdinalIgnoreCase)) 
                {
                    this.PrintGetMOFChoicesHelp(sb);
                }
                found = true;
            }
            if ("updatemofchoice".Contains(helpTerm, StringComparison.OrdinalIgnoreCase))
            {
                sb.AppendLine($" - UpdateMOFChoice");
                if ("updatemofchoice".Equals(helpTerm, StringComparison.OrdinalIgnoreCase)) 
                {
                    this.PrintUpdateMOFChoiceHelp(sb);
                }
                found = true;
            }
            if ("deletemofchoice".Contains(helpTerm, StringComparison.OrdinalIgnoreCase))
            {
                sb.AppendLine($" - DeleteMOFChoice");
                if ("deletemofchoice".Equals(helpTerm, StringComparison.OrdinalIgnoreCase)) 
                {
                    this.PrintDeleteMOFChoiceHelp(sb);
                }
                found = true;
            }
            if ("adddataformat".Contains(helpTerm, StringComparison.OrdinalIgnoreCase))
            {
                sb.AppendLine($" - AddDataFormat");
                if ("adddataformat".Equals(helpTerm, StringComparison.OrdinalIgnoreCase)) 
                {
                    this.PrintAddDataFormatHelp(sb);
                }
                found = true;
            }
            if ("getdataformats".Contains(helpTerm, StringComparison.OrdinalIgnoreCase))
            {
                sb.AppendLine($" - GetDataFormats");
                if ("getdataformats".Equals(helpTerm, StringComparison.OrdinalIgnoreCase)) 
                {
                    this.PrintGetDataFormatsHelp(sb);
                }
                found = true;
            }
            if ("updatedataformat".Contains(helpTerm, StringComparison.OrdinalIgnoreCase))
            {
                sb.AppendLine($" - UpdateDataFormat");
                if ("updatedataformat".Equals(helpTerm, StringComparison.OrdinalIgnoreCase)) 
                {
                    this.PrintUpdateDataFormatHelp(sb);
                }
                found = true;
            }
            if ("deletedataformat".Contains(helpTerm, StringComparison.OrdinalIgnoreCase))
            {
                sb.AppendLine($" - DeleteDataFormat");
                if ("deletedataformat".Equals(helpTerm, StringComparison.OrdinalIgnoreCase)) 
                {
                    this.PrintDeleteDataFormatHelp(sb);
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
            if ("addmoflayer".Contains(helpTerm, StringComparison.OrdinalIgnoreCase))
            {
                sb.AppendLine($" - AddMOFLayer");
                if ("addmoflayer".Equals(helpTerm, StringComparison.OrdinalIgnoreCase)) 
                {
                    this.PrintAddMOFLayerHelp(sb);
                }
                found = true;
            }
            if ("getmoflayers".Contains(helpTerm, StringComparison.OrdinalIgnoreCase))
            {
                sb.AppendLine($" - GetMOFLayers");
                if ("getmoflayers".Equals(helpTerm, StringComparison.OrdinalIgnoreCase)) 
                {
                    this.PrintGetMOFLayersHelp(sb);
                }
                found = true;
            }
            if ("updatemoflayer".Contains(helpTerm, StringComparison.OrdinalIgnoreCase))
            {
                sb.AppendLine($" - UpdateMOFLayer");
                if ("updatemoflayer".Equals(helpTerm, StringComparison.OrdinalIgnoreCase)) 
                {
                    this.PrintUpdateMOFLayerHelp(sb);
                }
                found = true;
            }
            if ("deletemoflayer".Contains(helpTerm, StringComparison.OrdinalIgnoreCase))
            {
                sb.AppendLine($" - DeleteMOFLayer");
                if ("deletemoflayer".Equals(helpTerm, StringComparison.OrdinalIgnoreCase)) 
                {
                    this.PrintDeleteMOFLayerHelp(sb);
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
            if ("addoutputformatrequest".Contains(helpTerm, StringComparison.OrdinalIgnoreCase))
            {
                sb.AppendLine($" - AddOutputFormatRequest");
                if ("addoutputformatrequest".Equals(helpTerm, StringComparison.OrdinalIgnoreCase)) 
                {
                    this.PrintAddOutputFormatRequestHelp(sb);
                }
                found = true;
            }
            if ("getoutputformatrequests".Contains(helpTerm, StringComparison.OrdinalIgnoreCase))
            {
                sb.AppendLine($" - GetOutputFormatRequests");
                if ("getoutputformatrequests".Equals(helpTerm, StringComparison.OrdinalIgnoreCase)) 
                {
                    this.PrintGetOutputFormatRequestsHelp(sb);
                }
                found = true;
            }
            if ("updateoutputformatrequest".Contains(helpTerm, StringComparison.OrdinalIgnoreCase))
            {
                sb.AppendLine($" - UpdateOutputFormatRequest");
                if ("updateoutputformatrequest".Equals(helpTerm, StringComparison.OrdinalIgnoreCase)) 
                {
                    this.PrintUpdateOutputFormatRequestHelp(sb);
                }
                found = true;
            }
            if ("deleteoutputformatrequest".Contains(helpTerm, StringComparison.OrdinalIgnoreCase))
            {
                sb.AppendLine($" - DeleteOutputFormatRequest");
                if ("deleteoutputformatrequest".Equals(helpTerm, StringComparison.OrdinalIgnoreCase)) 
                {
                    this.PrintDeleteOutputFormatRequestHelp(sb);
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
            if ("addidea".Contains(helpTerm, StringComparison.OrdinalIgnoreCase))
            {
                sb.AppendLine($" - AddIdea");
                if ("addidea".Equals(helpTerm, StringComparison.OrdinalIgnoreCase)) 
                {
                    this.PrintAddIdeaHelp(sb);
                }
                found = true;
            }
            if ("getideas".Contains(helpTerm, StringComparison.OrdinalIgnoreCase))
            {
                sb.AppendLine($" - GetIdeas");
                if ("getideas".Equals(helpTerm, StringComparison.OrdinalIgnoreCase)) 
                {
                    this.PrintGetIdeasHelp(sb);
                }
                found = true;
            }
            if ("updateidea".Contains(helpTerm, StringComparison.OrdinalIgnoreCase))
            {
                sb.AppendLine($" - UpdateIdea");
                if ("updateidea".Equals(helpTerm, StringComparison.OrdinalIgnoreCase)) 
                {
                    this.PrintUpdateIdeaHelp(sb);
                }
                found = true;
            }
            if ("deleteidea".Contains(helpTerm, StringComparison.OrdinalIgnoreCase))
            {
                sb.AppendLine($" - DeleteIdea");
                if ("deleteidea".Equals(helpTerm, StringComparison.OrdinalIgnoreCase)) 
                {
                    this.PrintDeleteIdeaHelp(sb);
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
                case "addpromptinputanswerkey":
				    reply = this.ATDActor.AddPromptInputAnswerKey(payload);
                    result = JsonConvert.SerializeObject(reply, Formatting.Indented);
                    break;                   

                case "getpromptinputanswerkeies":
				    reply = this.ATDActor.GetPromptInputAnswerKeies(payload);
                    result = JsonConvert.SerializeObject(reply, Formatting.Indented);
                    break;                   

                case "updatepromptinputanswerkey":
				    reply = this.ATDActor.UpdatePromptInputAnswerKey(payload);
                    result = JsonConvert.SerializeObject(reply, Formatting.Indented);
                    break;                   

                case "deletepromptinputanswerkey":
				    this.ATDActor.DeletePromptInputAnswerKey(payload);
				    result = JsonConvert.SerializeObject(payload, Formatting.Indented);
                    break;                   

                case "addgenerationtransformer":
				    reply = this.ATDActor.AddGenerationTransformer(payload);
                    result = JsonConvert.SerializeObject(reply, Formatting.Indented);
                    break;                   

                case "getgenerationtransformers":
				    reply = this.ATDActor.GetGenerationTransformers(payload);
                    result = JsonConvert.SerializeObject(reply, Formatting.Indented);
                    break;                   

                case "updategenerationtransformer":
				    reply = this.ATDActor.UpdateGenerationTransformer(payload);
                    result = JsonConvert.SerializeObject(reply, Formatting.Indented);
                    break;                   

                case "deletegenerationtransformer":
				    this.ATDActor.DeleteGenerationTransformer(payload);
				    result = JsonConvert.SerializeObject(payload, Formatting.Indented);
                    break;                   

                case "addideatransformer":
				    reply = this.ATDActor.AddIdeaTransformer(payload);
                    result = JsonConvert.SerializeObject(reply, Formatting.Indented);
                    break;                   

                case "getideatransformers":
				    reply = this.ATDActor.GetIdeaTransformers(payload);
                    result = JsonConvert.SerializeObject(reply, Formatting.Indented);
                    break;                   

                case "updateideatransformer":
				    reply = this.ATDActor.UpdateIdeaTransformer(payload);
                    result = JsonConvert.SerializeObject(reply, Formatting.Indented);
                    break;                   

                case "deleteideatransformer":
				    this.ATDActor.DeleteIdeaTransformer(payload);
				    result = JsonConvert.SerializeObject(payload, Formatting.Indented);
                    break;                   

                case "addmofnode":
				    reply = this.ATDActor.AddMOFNode(payload);
                    result = JsonConvert.SerializeObject(reply, Formatting.Indented);
                    break;                   

                case "getmofnodes":
				    reply = this.ATDActor.GetMOFNodes(payload);
                    result = JsonConvert.SerializeObject(reply, Formatting.Indented);
                    break;                   

                case "updatemofnode":
				    reply = this.ATDActor.UpdateMOFNode(payload);
                    result = JsonConvert.SerializeObject(reply, Formatting.Indented);
                    break;                   

                case "deletemofnode":
				    this.ATDActor.DeleteMOFNode(payload);
				    result = JsonConvert.SerializeObject(payload, Formatting.Indented);
                    break;                   

                case "addmofchoice":
				    reply = this.ATDActor.AddMOFChoice(payload);
                    result = JsonConvert.SerializeObject(reply, Formatting.Indented);
                    break;                   

                case "getmofchoices":
				    reply = this.ATDActor.GetMOFChoices(payload);
                    result = JsonConvert.SerializeObject(reply, Formatting.Indented);
                    break;                   

                case "updatemofchoice":
				    reply = this.ATDActor.UpdateMOFChoice(payload);
                    result = JsonConvert.SerializeObject(reply, Formatting.Indented);
                    break;                   

                case "deletemofchoice":
				    this.ATDActor.DeleteMOFChoice(payload);
				    result = JsonConvert.SerializeObject(payload, Formatting.Indented);
                    break;                   

                case "adddataformat":
				    reply = this.ATDActor.AddDataFormat(payload);
                    result = JsonConvert.SerializeObject(reply, Formatting.Indented);
                    break;                   

                case "getdataformats":
				    reply = this.ATDActor.GetDataFormats(payload);
                    result = JsonConvert.SerializeObject(reply, Formatting.Indented);
                    break;                   

                case "updatedataformat":
				    reply = this.ATDActor.UpdateDataFormat(payload);
                    result = JsonConvert.SerializeObject(reply, Formatting.Indented);
                    break;                   

                case "deletedataformat":
				    this.ATDActor.DeleteDataFormat(payload);
				    result = JsonConvert.SerializeObject(payload, Formatting.Indented);
                    break;                   

                case "addgeneration":
				    reply = this.ATDActor.AddGeneration(payload);
                    result = JsonConvert.SerializeObject(reply, Formatting.Indented);
                    break;                   

                case "getgenerations":
				    reply = this.ATDActor.GetGenerations(payload);
                    result = JsonConvert.SerializeObject(reply, Formatting.Indented);
                    break;                   

                case "updategeneration":
				    reply = this.ATDActor.UpdateGeneration(payload);
                    result = JsonConvert.SerializeObject(reply, Formatting.Indented);
                    break;                   

                case "deletegeneration":
				    this.ATDActor.DeleteGeneration(payload);
				    result = JsonConvert.SerializeObject(payload, Formatting.Indented);
                    break;                   

                case "addappuser":
				    reply = this.ATDActor.AddAppUser(payload);
                    result = JsonConvert.SerializeObject(reply, Formatting.Indented);
                    break;                   

                case "getappusers":
				    reply = this.ATDActor.GetAppUsers(payload);
                    result = JsonConvert.SerializeObject(reply, Formatting.Indented);
                    break;                   

                case "updateappuser":
				    reply = this.ATDActor.UpdateAppUser(payload);
                    result = JsonConvert.SerializeObject(reply, Formatting.Indented);
                    break;                   

                case "deleteappuser":
				    this.ATDActor.DeleteAppUser(payload);
				    result = JsonConvert.SerializeObject(payload, Formatting.Indented);
                    break;                   

                case "addmoflayer":
				    reply = this.ATDActor.AddMOFLayer(payload);
                    result = JsonConvert.SerializeObject(reply, Formatting.Indented);
                    break;                   

                case "getmoflayers":
				    reply = this.ATDActor.GetMOFLayers(payload);
                    result = JsonConvert.SerializeObject(reply, Formatting.Indented);
                    break;                   

                case "updatemoflayer":
				    reply = this.ATDActor.UpdateMOFLayer(payload);
                    result = JsonConvert.SerializeObject(reply, Formatting.Indented);
                    break;                   

                case "deletemoflayer":
				    this.ATDActor.DeleteMOFLayer(payload);
				    result = JsonConvert.SerializeObject(payload, Formatting.Indented);
                    break;                   

                case "addllm":
				    reply = this.ATDActor.AddLLM(payload);
                    result = JsonConvert.SerializeObject(reply, Formatting.Indented);
                    break;                   

                case "getllms":
				    reply = this.ATDActor.GetLLMs(payload);
                    result = JsonConvert.SerializeObject(reply, Formatting.Indented);
                    break;                   

                case "updatellm":
				    reply = this.ATDActor.UpdateLLM(payload);
                    result = JsonConvert.SerializeObject(reply, Formatting.Indented);
                    break;                   

                case "deletellm":
				    this.ATDActor.DeleteLLM(payload);
				    result = JsonConvert.SerializeObject(payload, Formatting.Indented);
                    break;                   

                case "addoutputformatrequest":
				    reply = this.ATDActor.AddOutputFormatRequest(payload);
                    result = JsonConvert.SerializeObject(reply, Formatting.Indented);
                    break;                   

                case "getoutputformatrequests":
				    reply = this.ATDActor.GetOutputFormatRequests(payload);
                    result = JsonConvert.SerializeObject(reply, Formatting.Indented);
                    break;                   

                case "updateoutputformatrequest":
				    reply = this.ATDActor.UpdateOutputFormatRequest(payload);
                    result = JsonConvert.SerializeObject(reply, Formatting.Indented);
                    break;                   

                case "deleteoutputformatrequest":
				    this.ATDActor.DeleteOutputFormatRequest(payload);
				    result = JsonConvert.SerializeObject(payload, Formatting.Indented);
                    break;                   

                case "addtransformedartifact":
				    reply = this.ATDActor.AddTransformedArtifact(payload);
                    result = JsonConvert.SerializeObject(reply, Formatting.Indented);
                    break;                   

                case "gettransformedartifacts":
				    reply = this.ATDActor.GetTransformedArtifacts(payload);
                    result = JsonConvert.SerializeObject(reply, Formatting.Indented);
                    break;                   

                case "updatetransformedartifact":
				    reply = this.ATDActor.UpdateTransformedArtifact(payload);
                    result = JsonConvert.SerializeObject(reply, Formatting.Indented);
                    break;                   

                case "deletetransformedartifact":
				    this.ATDActor.DeleteTransformedArtifact(payload);
				    result = JsonConvert.SerializeObject(payload, Formatting.Indented);
                    break;                   

                case "addidea":
				    reply = this.ATDActor.AddIdea(payload);
                    result = JsonConvert.SerializeObject(reply, Formatting.Indented);
                    break;                   

                case "getideas":
				    reply = this.ATDActor.GetIdeas(payload);
                    result = JsonConvert.SerializeObject(reply, Formatting.Indented);
                    break;                   

                case "updateidea":
				    reply = this.ATDActor.UpdateIdea(payload);
                    result = JsonConvert.SerializeObject(reply, Formatting.Indented);
                    break;                   

                case "deleteidea":
				    this.ATDActor.DeleteIdea(payload);
				    result = JsonConvert.SerializeObject(payload, Formatting.Indented);
                    break;                   

                default:
                    throw new Exception($"Invalid request: {invokeRequest}");
            }

            return result;
        }
        
        
        public void PrintAddPromptInputAnswerKeyHelp(StringBuilder sb)
        {
            
                
                sb.AppendLine();
                sb.AppendLine($"* * * * * * * * * * * * * * * * * * * * * * * * * * *");
                sb.AppendLine($"* *  OBJECT DEF: PromptInputAnswerKey     *");
                sb.AppendLine($"* * * * * * * * * * * * * * * * * * * * * * * * * * *");
                sb.AppendLine();
                
                    sb.AppendLine($"CRUD      - PromptInputAnswerKeyId");
                    sb.AppendLine($"CRUD      - Name");
                    sb.AppendLine($"CRUD      - Question");
                    sb.AppendLine($"CRUD      - Answer");
                    sb.AppendLine($"CRUD      - PromptInput");
                    sb.AppendLine($"CRUD      - AnswerKey");
                    sb.AppendLine($"CRUD      - AnswerKeycopy");
                
            
        }
        
        public void PrintGetPromptInputAnswerKeiesHelp(StringBuilder sb)
        {
            
                
                sb.AppendLine();
                sb.AppendLine($"* * * * * * * * * * * * * * * * * * * * * * * * * * *");
                sb.AppendLine($"* *  OBJECT DEF: PromptInputAnswerKey     *");
                sb.AppendLine($"* * * * * * * * * * * * * * * * * * * * * * * * * * *");
                sb.AppendLine();
                
                    sb.AppendLine($"CRUD      - PromptInputAnswerKeyId");
                    sb.AppendLine($"CRUD      - Name");
                    sb.AppendLine($"CRUD      - Question");
                    sb.AppendLine($"CRUD      - Answer");
                    sb.AppendLine($"CRUD      - PromptInput");
                    sb.AppendLine($"CRUD      - AnswerKey");
                    sb.AppendLine($"CRUD      - AnswerKeycopy");
                
            
        }
        
        public void PrintUpdatePromptInputAnswerKeyHelp(StringBuilder sb)
        {
            
                
                sb.AppendLine();
                sb.AppendLine($"* * * * * * * * * * * * * * * * * * * * * * * * * * *");
                sb.AppendLine($"* *  OBJECT DEF: PromptInputAnswerKey     *");
                sb.AppendLine($"* * * * * * * * * * * * * * * * * * * * * * * * * * *");
                sb.AppendLine();
                
                    sb.AppendLine($"CRUD      - PromptInputAnswerKeyId");
                    sb.AppendLine($"CRUD      - Name");
                    sb.AppendLine($"CRUD      - Question");
                    sb.AppendLine($"CRUD      - Answer");
                    sb.AppendLine($"CRUD      - PromptInput");
                    sb.AppendLine($"CRUD      - AnswerKey");
                    sb.AppendLine($"CRUD      - AnswerKeycopy");
                
            
        }
        
        public void PrintDeletePromptInputAnswerKeyHelp(StringBuilder sb)
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
                    sb.AppendLine($"CRUD      - IdeaPrompt");
                    sb.AppendLine($"CRUD      - GenerationSourceIdea");
                    sb.AppendLine($"CRUD      - Transformer");
                    sb.AppendLine($"CRUD      - GenerationName");
                    sb.AppendLine($"CRUD      - GenerationIdea");
                    sb.AppendLine($"CRUD      - GenerationIdeaName");
                    sb.AppendLine($"CRUD      - GeneratioNumber");
                    sb.AppendLine($"CRUD      - IsActiveIdea");
                    sb.AppendLine($"CRUD      - TransformedArtifacts");
                    sb.AppendLine($"CRUD      - AutoNumber");
                    sb.AppendLine($"CRUD      - TransformerNumber");
                    sb.AppendLine($"CRUD      - IsArtifactValidator");
                
            
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
                    sb.AppendLine($"CRUD      - IdeaPrompt");
                    sb.AppendLine($"CRUD      - GenerationSourceIdea");
                    sb.AppendLine($"CRUD      - Transformer");
                    sb.AppendLine($"CRUD      - GenerationName");
                    sb.AppendLine($"CRUD      - GenerationIdea");
                    sb.AppendLine($"CRUD      - GenerationIdeaName");
                    sb.AppendLine($"CRUD      - GeneratioNumber");
                    sb.AppendLine($"CRUD      - IsActiveIdea");
                    sb.AppendLine($"CRUD      - TransformedArtifacts");
                    sb.AppendLine($"CRUD      - AutoNumber");
                    sb.AppendLine($"CRUD      - TransformerNumber");
                    sb.AppendLine($"CRUD      - IsArtifactValidator");
                
            
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
                    sb.AppendLine($"CRUD      - IdeaPrompt");
                    sb.AppendLine($"CRUD      - GenerationSourceIdea");
                    sb.AppendLine($"CRUD      - Transformer");
                    sb.AppendLine($"CRUD      - GenerationName");
                    sb.AppendLine($"CRUD      - GenerationIdea");
                    sb.AppendLine($"CRUD      - GenerationIdeaName");
                    sb.AppendLine($"CRUD      - GeneratioNumber");
                    sb.AppendLine($"CRUD      - IsActiveIdea");
                    sb.AppendLine($"CRUD      - TransformedArtifacts");
                    sb.AppendLine($"CRUD      - AutoNumber");
                    sb.AppendLine($"CRUD      - TransformerNumber");
                    sb.AppendLine($"CRUD      - IsArtifactValidator");
                
            
        }
        
        public void PrintDeleteGenerationTransformerHelp(StringBuilder sb)
        {
            
        }
        
        public void PrintAddIdeaTransformerHelp(StringBuilder sb)
        {
            
                
                sb.AppendLine();
                sb.AppendLine($"* * * * * * * * * * * * * * * * * * * * * * * * * * *");
                sb.AppendLine($"* *  OBJECT DEF: IdeaTransformer     *");
                sb.AppendLine($"* * * * * * * * * * * * * * * * * * * * * * * * * * *");
                sb.AppendLine();
                
                    sb.AppendLine($"CRUD      - IdeaTransformerId");
                    sb.AppendLine($"CRUD      - Name");
                    sb.AppendLine($"CRUD      - Idea");
                    sb.AppendLine($"CRUD      - IdeaName");
                    sb.AppendLine($"CRUD      - IdeasSourceIdea");
                    sb.AppendLine($"CRUD      - IsActiveIdea");
                    sb.AppendLine($"CRUD      - FullPrompt");
                    sb.AppendLine($"CRUD      - TransformedArtifacts");
                
            
        }
        
        public void PrintGetIdeaTransformersHelp(StringBuilder sb)
        {
            
                
                sb.AppendLine();
                sb.AppendLine($"* * * * * * * * * * * * * * * * * * * * * * * * * * *");
                sb.AppendLine($"* *  OBJECT DEF: IdeaTransformer     *");
                sb.AppendLine($"* * * * * * * * * * * * * * * * * * * * * * * * * * *");
                sb.AppendLine();
                
                    sb.AppendLine($"CRUD      - IdeaTransformerId");
                    sb.AppendLine($"CRUD      - Name");
                    sb.AppendLine($"CRUD      - Idea");
                    sb.AppendLine($"CRUD      - IdeaName");
                    sb.AppendLine($"CRUD      - IdeasSourceIdea");
                    sb.AppendLine($"CRUD      - IsActiveIdea");
                    sb.AppendLine($"CRUD      - FullPrompt");
                    sb.AppendLine($"CRUD      - TransformedArtifacts");
                
            
        }
        
        public void PrintUpdateIdeaTransformerHelp(StringBuilder sb)
        {
            
                
                sb.AppendLine();
                sb.AppendLine($"* * * * * * * * * * * * * * * * * * * * * * * * * * *");
                sb.AppendLine($"* *  OBJECT DEF: IdeaTransformer     *");
                sb.AppendLine($"* * * * * * * * * * * * * * * * * * * * * * * * * * *");
                sb.AppendLine();
                
                    sb.AppendLine($"CRUD      - IdeaTransformerId");
                    sb.AppendLine($"CRUD      - Name");
                    sb.AppendLine($"CRUD      - Idea");
                    sb.AppendLine($"CRUD      - IdeaName");
                    sb.AppendLine($"CRUD      - IdeasSourceIdea");
                    sb.AppendLine($"CRUD      - IsActiveIdea");
                    sb.AppendLine($"CRUD      - FullPrompt");
                    sb.AppendLine($"CRUD      - TransformedArtifacts");
                
            
        }
        
        public void PrintDeleteIdeaTransformerHelp(StringBuilder sb)
        {
            
        }
        
        public void PrintAddMOFNodeHelp(StringBuilder sb)
        {
            
                
                sb.AppendLine();
                sb.AppendLine($"* * * * * * * * * * * * * * * * * * * * * * * * * * *");
                sb.AppendLine($"* *  OBJECT DEF: MOFNode     *");
                sb.AppendLine($"* * * * * * * * * * * * * * * * * * * * * * * * * * *");
                sb.AppendLine();
                
                    sb.AppendLine($"CRUD      - MOFNodeId");
                    sb.AppendLine($"CRUD      - Name");
                    sb.AppendLine($"CRUD      - NodeName");
                    sb.AppendLine($"CRUD      - NodeType");
                    sb.AppendLine($"CRUD      - Attachments");
                    sb.AppendLine($"CRUD      - PlatformAttachments");
                    sb.AppendLine($"CRUD      - FileExtensions");
                    sb.AppendLine($"CRUD      - FromNodes");
                    sb.AppendLine($"CRUD      - ToNodes");
                    sb.AppendLine($"CRUD      - ToNodeEdges");
                    sb.AppendLine($"CRUD      - TranspilerForEdge");
                    sb.AppendLine($"CRUD      - Notes");
                    sb.AppendLine($"CRUD      - SortOrder");
                    sb.AppendLine($"CRUD      - IsQueriable");
                    sb.AppendLine($"CRUD      - DesiredColor");
                    sb.AppendLine($"CRUD      - CurrentCodeFor");
                    sb.AppendLine($"CRUD      - CurrentDocsFor");
                    sb.AppendLine($"CRUD      - OutputIsDocs");
                    sb.AppendLine($"CRUD      - OutputIsCode");
                    sb.AppendLine($"CRUD      - NodeEdges");
                    sb.AppendLine($"CRUD      - NodeChoices");
                    sb.AppendLine($"CRUD      - DefaultFileName");
                    sb.AppendLine($"CRUD      - ToolForChoices");
                    sb.AppendLine($"CRUD      - ToolTransformerForChoices");
                
            
        }
        
        public void PrintGetMOFNodesHelp(StringBuilder sb)
        {
            
                
                sb.AppendLine();
                sb.AppendLine($"* * * * * * * * * * * * * * * * * * * * * * * * * * *");
                sb.AppendLine($"* *  OBJECT DEF: MOFNode     *");
                sb.AppendLine($"* * * * * * * * * * * * * * * * * * * * * * * * * * *");
                sb.AppendLine();
                
                    sb.AppendLine($"CRUD      - MOFNodeId");
                    sb.AppendLine($"CRUD      - Name");
                    sb.AppendLine($"CRUD      - NodeName");
                    sb.AppendLine($"CRUD      - NodeType");
                    sb.AppendLine($"CRUD      - Attachments");
                    sb.AppendLine($"CRUD      - PlatformAttachments");
                    sb.AppendLine($"CRUD      - FileExtensions");
                    sb.AppendLine($"CRUD      - FromNodes");
                    sb.AppendLine($"CRUD      - ToNodes");
                    sb.AppendLine($"CRUD      - ToNodeEdges");
                    sb.AppendLine($"CRUD      - TranspilerForEdge");
                    sb.AppendLine($"CRUD      - Notes");
                    sb.AppendLine($"CRUD      - SortOrder");
                    sb.AppendLine($"CRUD      - IsQueriable");
                    sb.AppendLine($"CRUD      - DesiredColor");
                    sb.AppendLine($"CRUD      - CurrentCodeFor");
                    sb.AppendLine($"CRUD      - CurrentDocsFor");
                    sb.AppendLine($"CRUD      - OutputIsDocs");
                    sb.AppendLine($"CRUD      - OutputIsCode");
                    sb.AppendLine($"CRUD      - NodeEdges");
                    sb.AppendLine($"CRUD      - NodeChoices");
                    sb.AppendLine($"CRUD      - DefaultFileName");
                    sb.AppendLine($"CRUD      - ToolForChoices");
                    sb.AppendLine($"CRUD      - ToolTransformerForChoices");
                
            
        }
        
        public void PrintUpdateMOFNodeHelp(StringBuilder sb)
        {
            
                
                sb.AppendLine();
                sb.AppendLine($"* * * * * * * * * * * * * * * * * * * * * * * * * * *");
                sb.AppendLine($"* *  OBJECT DEF: MOFNode     *");
                sb.AppendLine($"* * * * * * * * * * * * * * * * * * * * * * * * * * *");
                sb.AppendLine();
                
                    sb.AppendLine($"CRUD      - MOFNodeId");
                    sb.AppendLine($"CRUD      - Name");
                    sb.AppendLine($"CRUD      - NodeName");
                    sb.AppendLine($"CRUD      - NodeType");
                    sb.AppendLine($"CRUD      - Attachments");
                    sb.AppendLine($"CRUD      - PlatformAttachments");
                    sb.AppendLine($"CRUD      - FileExtensions");
                    sb.AppendLine($"CRUD      - FromNodes");
                    sb.AppendLine($"CRUD      - ToNodes");
                    sb.AppendLine($"CRUD      - ToNodeEdges");
                    sb.AppendLine($"CRUD      - TranspilerForEdge");
                    sb.AppendLine($"CRUD      - Notes");
                    sb.AppendLine($"CRUD      - SortOrder");
                    sb.AppendLine($"CRUD      - IsQueriable");
                    sb.AppendLine($"CRUD      - DesiredColor");
                    sb.AppendLine($"CRUD      - CurrentCodeFor");
                    sb.AppendLine($"CRUD      - CurrentDocsFor");
                    sb.AppendLine($"CRUD      - OutputIsDocs");
                    sb.AppendLine($"CRUD      - OutputIsCode");
                    sb.AppendLine($"CRUD      - NodeEdges");
                    sb.AppendLine($"CRUD      - NodeChoices");
                    sb.AppendLine($"CRUD      - DefaultFileName");
                    sb.AppendLine($"CRUD      - ToolForChoices");
                    sb.AppendLine($"CRUD      - ToolTransformerForChoices");
                
            
        }
        
        public void PrintDeleteMOFNodeHelp(StringBuilder sb)
        {
            
        }
        
        public void PrintAddMOFChoiceHelp(StringBuilder sb)
        {
            
                
                sb.AppendLine();
                sb.AppendLine($"* * * * * * * * * * * * * * * * * * * * * * * * * * *");
                sb.AppendLine($"* *  OBJECT DEF: MOFChoice     *");
                sb.AppendLine($"* * * * * * * * * * * * * * * * * * * * * * * * * * *");
                sb.AppendLine();
                
                    sb.AppendLine($"CRUD      - MOFChoiceId");
                    sb.AppendLine($"CRUD      - Name");
                    sb.AppendLine($"CRUD      - Layers");
                    sb.AppendLine($"CRUD      - FQNChoiceName");
                    sb.AppendLine($"CRUD      - Node");
                    sb.AppendLine($"CRUD      - NodeName");
                    sb.AppendLine($"CRUD      - ToolInputChoice");
                    sb.AppendLine($"CRUD      - ToolDefaultFileName");
                    sb.AppendLine($"CRUD      - ToolName");
                    sb.AppendLine($"CRUD      - InputChoiceFileName");
                    sb.AppendLine($"CRUD      - NodeDefaultFileName");
                    sb.AppendLine($"CRUD      - NodeAttachments");
                    sb.AppendLine($"CRUD      - ParentNodeDesiredColor");
                    sb.AppendLine($"CRUD      - NodeDesiredColor");
                    sb.AppendLine($"CRUD      - Tool");
                    sb.AppendLine($"CRUD      - ParentNodeAttachments");
                    sb.AppendLine($"CRUD      - ToolTransformer");
                    sb.AppendLine($"CRUD      - ParentChoiceName");
                    sb.AppendLine($"CRUD      - Notes");
                    sb.AppendLine($"CRUD      - ParentChoice");
                    sb.AppendLine($"CRUD      - IsSyntaxFree");
                    sb.AppendLine($"CRUD      - MOFLayerNumber");
                    sb.AppendLine($"CRUD      - ParentMOFLayerNumber");
                    sb.AppendLine($"CRUD      - MixedColor");
                    sb.AppendLine($"CRUD      - ExpectedColor");
                    sb.AppendLine($"CRUD      - ToolTransformerFileName");
                    sb.AppendLine($"CRUD      - IsInSync");
                    sb.AppendLine($"CRUD      - IsInSyncImage");
                    sb.AppendLine($"CRUD      - ToolAttachments");
                    sb.AppendLine($"CRUD      - ToolInputAttachments");
                    sb.AppendLine($"CRUD      - ToolInputChoiceNodeAttachments");
                    sb.AppendLine($"CRUD      - MOFDisplayOrder");
                    sb.AppendLine($"CRUD      - ParentMOFDisplayOrder");
                    sb.AppendLine($"CRUD      - OutputIsDocs");
                    sb.AppendLine($"CRUD      - DesiredColor");
                    sb.AppendLine($"CRUD      - ToolPlatformAttachments");
                    sb.AppendLine($"CRUD      - NodePlatformAttachments");
                
            
        }
        
        public void PrintGetMOFChoicesHelp(StringBuilder sb)
        {
            
                
                sb.AppendLine();
                sb.AppendLine($"* * * * * * * * * * * * * * * * * * * * * * * * * * *");
                sb.AppendLine($"* *  OBJECT DEF: MOFChoice     *");
                sb.AppendLine($"* * * * * * * * * * * * * * * * * * * * * * * * * * *");
                sb.AppendLine();
                
                    sb.AppendLine($"CRUD      - MOFChoiceId");
                    sb.AppendLine($"CRUD      - Name");
                    sb.AppendLine($"CRUD      - Layers");
                    sb.AppendLine($"CRUD      - FQNChoiceName");
                    sb.AppendLine($"CRUD      - Node");
                    sb.AppendLine($"CRUD      - NodeName");
                    sb.AppendLine($"CRUD      - ToolInputChoice");
                    sb.AppendLine($"CRUD      - ToolDefaultFileName");
                    sb.AppendLine($"CRUD      - ToolName");
                    sb.AppendLine($"CRUD      - InputChoiceFileName");
                    sb.AppendLine($"CRUD      - NodeDefaultFileName");
                    sb.AppendLine($"CRUD      - NodeAttachments");
                    sb.AppendLine($"CRUD      - ParentNodeDesiredColor");
                    sb.AppendLine($"CRUD      - NodeDesiredColor");
                    sb.AppendLine($"CRUD      - Tool");
                    sb.AppendLine($"CRUD      - ParentNodeAttachments");
                    sb.AppendLine($"CRUD      - ToolTransformer");
                    sb.AppendLine($"CRUD      - ParentChoiceName");
                    sb.AppendLine($"CRUD      - Notes");
                    sb.AppendLine($"CRUD      - ParentChoice");
                    sb.AppendLine($"CRUD      - IsSyntaxFree");
                    sb.AppendLine($"CRUD      - MOFLayerNumber");
                    sb.AppendLine($"CRUD      - ParentMOFLayerNumber");
                    sb.AppendLine($"CRUD      - MixedColor");
                    sb.AppendLine($"CRUD      - ExpectedColor");
                    sb.AppendLine($"CRUD      - ToolTransformerFileName");
                    sb.AppendLine($"CRUD      - IsInSync");
                    sb.AppendLine($"CRUD      - IsInSyncImage");
                    sb.AppendLine($"CRUD      - ToolAttachments");
                    sb.AppendLine($"CRUD      - ToolInputAttachments");
                    sb.AppendLine($"CRUD      - ToolInputChoiceNodeAttachments");
                    sb.AppendLine($"CRUD      - MOFDisplayOrder");
                    sb.AppendLine($"CRUD      - ParentMOFDisplayOrder");
                    sb.AppendLine($"CRUD      - OutputIsDocs");
                    sb.AppendLine($"CRUD      - DesiredColor");
                    sb.AppendLine($"CRUD      - ToolPlatformAttachments");
                    sb.AppendLine($"CRUD      - NodePlatformAttachments");
                
            
        }
        
        public void PrintUpdateMOFChoiceHelp(StringBuilder sb)
        {
            
                
                sb.AppendLine();
                sb.AppendLine($"* * * * * * * * * * * * * * * * * * * * * * * * * * *");
                sb.AppendLine($"* *  OBJECT DEF: MOFChoice     *");
                sb.AppendLine($"* * * * * * * * * * * * * * * * * * * * * * * * * * *");
                sb.AppendLine();
                
                    sb.AppendLine($"CRUD      - MOFChoiceId");
                    sb.AppendLine($"CRUD      - Name");
                    sb.AppendLine($"CRUD      - Layers");
                    sb.AppendLine($"CRUD      - FQNChoiceName");
                    sb.AppendLine($"CRUD      - Node");
                    sb.AppendLine($"CRUD      - NodeName");
                    sb.AppendLine($"CRUD      - ToolInputChoice");
                    sb.AppendLine($"CRUD      - ToolDefaultFileName");
                    sb.AppendLine($"CRUD      - ToolName");
                    sb.AppendLine($"CRUD      - InputChoiceFileName");
                    sb.AppendLine($"CRUD      - NodeDefaultFileName");
                    sb.AppendLine($"CRUD      - NodeAttachments");
                    sb.AppendLine($"CRUD      - ParentNodeDesiredColor");
                    sb.AppendLine($"CRUD      - NodeDesiredColor");
                    sb.AppendLine($"CRUD      - Tool");
                    sb.AppendLine($"CRUD      - ParentNodeAttachments");
                    sb.AppendLine($"CRUD      - ToolTransformer");
                    sb.AppendLine($"CRUD      - ParentChoiceName");
                    sb.AppendLine($"CRUD      - Notes");
                    sb.AppendLine($"CRUD      - ParentChoice");
                    sb.AppendLine($"CRUD      - IsSyntaxFree");
                    sb.AppendLine($"CRUD      - MOFLayerNumber");
                    sb.AppendLine($"CRUD      - ParentMOFLayerNumber");
                    sb.AppendLine($"CRUD      - MixedColor");
                    sb.AppendLine($"CRUD      - ExpectedColor");
                    sb.AppendLine($"CRUD      - ToolTransformerFileName");
                    sb.AppendLine($"CRUD      - IsInSync");
                    sb.AppendLine($"CRUD      - IsInSyncImage");
                    sb.AppendLine($"CRUD      - ToolAttachments");
                    sb.AppendLine($"CRUD      - ToolInputAttachments");
                    sb.AppendLine($"CRUD      - ToolInputChoiceNodeAttachments");
                    sb.AppendLine($"CRUD      - MOFDisplayOrder");
                    sb.AppendLine($"CRUD      - ParentMOFDisplayOrder");
                    sb.AppendLine($"CRUD      - OutputIsDocs");
                    sb.AppendLine($"CRUD      - DesiredColor");
                    sb.AppendLine($"CRUD      - ToolPlatformAttachments");
                    sb.AppendLine($"CRUD      - NodePlatformAttachments");
                
            
        }
        
        public void PrintDeleteMOFChoiceHelp(StringBuilder sb)
        {
            
        }
        
        public void PrintAddDataFormatHelp(StringBuilder sb)
        {
            
                
                sb.AppendLine();
                sb.AppendLine($"* * * * * * * * * * * * * * * * * * * * * * * * * * *");
                sb.AppendLine($"* *  OBJECT DEF: DataFormat     *");
                sb.AppendLine($"* * * * * * * * * * * * * * * * * * * * * * * * * * *");
                sb.AppendLine();
                
                    sb.AppendLine($"CRUD      - DataFormatId");
                    sb.AppendLine($"CRUD      - Name");
                    sb.AppendLine($"CRUD      - PromptInputs");
                    sb.AppendLine($"CRUD      - PromptVariations");
                    sb.AppendLine($"CRUD      - OutputFormatRequests");
                
            
        }
        
        public void PrintGetDataFormatsHelp(StringBuilder sb)
        {
            
                
                sb.AppendLine();
                sb.AppendLine($"* * * * * * * * * * * * * * * * * * * * * * * * * * *");
                sb.AppendLine($"* *  OBJECT DEF: DataFormat     *");
                sb.AppendLine($"* * * * * * * * * * * * * * * * * * * * * * * * * * *");
                sb.AppendLine();
                
                    sb.AppendLine($"CRUD      - DataFormatId");
                    sb.AppendLine($"CRUD      - Name");
                    sb.AppendLine($"CRUD      - PromptInputs");
                    sb.AppendLine($"CRUD      - PromptVariations");
                    sb.AppendLine($"CRUD      - OutputFormatRequests");
                
            
        }
        
        public void PrintUpdateDataFormatHelp(StringBuilder sb)
        {
            
                
                sb.AppendLine();
                sb.AppendLine($"* * * * * * * * * * * * * * * * * * * * * * * * * * *");
                sb.AppendLine($"* *  OBJECT DEF: DataFormat     *");
                sb.AppendLine($"* * * * * * * * * * * * * * * * * * * * * * * * * * *");
                sb.AppendLine();
                
                    sb.AppendLine($"CRUD      - DataFormatId");
                    sb.AppendLine($"CRUD      - Name");
                    sb.AppendLine($"CRUD      - PromptInputs");
                    sb.AppendLine($"CRUD      - PromptVariations");
                    sb.AppendLine($"CRUD      - OutputFormatRequests");
                
            
        }
        
        public void PrintDeleteDataFormatHelp(StringBuilder sb)
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
                    sb.AppendLine($"CRUD      - Idea");
                    sb.AppendLine($"CRUD      - IdeaName");
                    sb.AppendLine($"CRUD      - GeneratioNumber");
                    sb.AppendLine($"CRUD      - TransformedArtifacts");
                    sb.AppendLine($"CRUD      - IsActiveIdea");
                    sb.AppendLine($"CRUD      - IdeaSourceIdea");
                    sb.AppendLine($"CRUD      - Model");
                
            
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
                    sb.AppendLine($"CRUD      - Idea");
                    sb.AppendLine($"CRUD      - IdeaName");
                    sb.AppendLine($"CRUD      - GeneratioNumber");
                    sb.AppendLine($"CRUD      - TransformedArtifacts");
                    sb.AppendLine($"CRUD      - IsActiveIdea");
                    sb.AppendLine($"CRUD      - IdeaSourceIdea");
                    sb.AppendLine($"CRUD      - Model");
                
            
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
                    sb.AppendLine($"CRUD      - Idea");
                    sb.AppendLine($"CRUD      - IdeaName");
                    sb.AppendLine($"CRUD      - GeneratioNumber");
                    sb.AppendLine($"CRUD      - TransformedArtifacts");
                    sb.AppendLine($"CRUD      - IsActiveIdea");
                    sb.AppendLine($"CRUD      - IdeaSourceIdea");
                    sb.AppendLine($"CRUD      - Model");
                
            
        }
        
        public void PrintDeleteGenerationHelp(StringBuilder sb)
        {
            
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
        
        public void PrintAddMOFLayerHelp(StringBuilder sb)
        {
            
                
                sb.AppendLine();
                sb.AppendLine($"* * * * * * * * * * * * * * * * * * * * * * * * * * *");
                sb.AppendLine($"* *  OBJECT DEF: MOFLayer     *");
                sb.AppendLine($"* * * * * * * * * * * * * * * * * * * * * * * * * * *");
                sb.AppendLine();
                
                    sb.AppendLine($"CRUD      - MOFLayerId");
                    sb.AppendLine($"CRUD      - Name");
                    sb.AppendLine($"CRUD      - MOFLayerName");
                    sb.AppendLine($"CRUD      - Notes");
                    sb.AppendLine($"CRUD      - MOFLayerNumber");
                    sb.AppendLine($"CRUD      - LayerChoices");
                    sb.AppendLine($"CRUD      - MOFDisplayOrder");
                
            
        }
        
        public void PrintGetMOFLayersHelp(StringBuilder sb)
        {
            
                
                sb.AppendLine();
                sb.AppendLine($"* * * * * * * * * * * * * * * * * * * * * * * * * * *");
                sb.AppendLine($"* *  OBJECT DEF: MOFLayer     *");
                sb.AppendLine($"* * * * * * * * * * * * * * * * * * * * * * * * * * *");
                sb.AppendLine();
                
                    sb.AppendLine($"CRUD      - MOFLayerId");
                    sb.AppendLine($"CRUD      - Name");
                    sb.AppendLine($"CRUD      - MOFLayerName");
                    sb.AppendLine($"CRUD      - Notes");
                    sb.AppendLine($"CRUD      - MOFLayerNumber");
                    sb.AppendLine($"CRUD      - LayerChoices");
                    sb.AppendLine($"CRUD      - MOFDisplayOrder");
                
            
        }
        
        public void PrintUpdateMOFLayerHelp(StringBuilder sb)
        {
            
                
                sb.AppendLine();
                sb.AppendLine($"* * * * * * * * * * * * * * * * * * * * * * * * * * *");
                sb.AppendLine($"* *  OBJECT DEF: MOFLayer     *");
                sb.AppendLine($"* * * * * * * * * * * * * * * * * * * * * * * * * * *");
                sb.AppendLine();
                
                    sb.AppendLine($"CRUD      - MOFLayerId");
                    sb.AppendLine($"CRUD      - Name");
                    sb.AppendLine($"CRUD      - MOFLayerName");
                    sb.AppendLine($"CRUD      - Notes");
                    sb.AppendLine($"CRUD      - MOFLayerNumber");
                    sb.AppendLine($"CRUD      - LayerChoices");
                    sb.AppendLine($"CRUD      - MOFDisplayOrder");
                
            
        }
        
        public void PrintDeleteMOFLayerHelp(StringBuilder sb)
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
        
        public void PrintAddOutputFormatRequestHelp(StringBuilder sb)
        {
            
                
                sb.AppendLine();
                sb.AppendLine($"* * * * * * * * * * * * * * * * * * * * * * * * * * *");
                sb.AppendLine($"* *  OBJECT DEF: OutputFormatRequest     *");
                sb.AppendLine($"* * * * * * * * * * * * * * * * * * * * * * * * * * *");
                sb.AppendLine();
                
                    sb.AppendLine($"CRUD      - OutputFormatRequestId");
                    sb.AppendLine($"CRUD      - Name");
                    sb.AppendLine($"CRUD      - Prompt");
                    sb.AppendLine($"CRUD      - PromptVariations");
                    sb.AppendLine($"CRUD      - OutputFormat");
                
            
        }
        
        public void PrintGetOutputFormatRequestsHelp(StringBuilder sb)
        {
            
                
                sb.AppendLine();
                sb.AppendLine($"* * * * * * * * * * * * * * * * * * * * * * * * * * *");
                sb.AppendLine($"* *  OBJECT DEF: OutputFormatRequest     *");
                sb.AppendLine($"* * * * * * * * * * * * * * * * * * * * * * * * * * *");
                sb.AppendLine();
                
                    sb.AppendLine($"CRUD      - OutputFormatRequestId");
                    sb.AppendLine($"CRUD      - Name");
                    sb.AppendLine($"CRUD      - Prompt");
                    sb.AppendLine($"CRUD      - PromptVariations");
                    sb.AppendLine($"CRUD      - OutputFormat");
                
            
        }
        
        public void PrintUpdateOutputFormatRequestHelp(StringBuilder sb)
        {
            
                
                sb.AppendLine();
                sb.AppendLine($"* * * * * * * * * * * * * * * * * * * * * * * * * * *");
                sb.AppendLine($"* *  OBJECT DEF: OutputFormatRequest     *");
                sb.AppendLine($"* * * * * * * * * * * * * * * * * * * * * * * * * * *");
                sb.AppendLine();
                
                    sb.AppendLine($"CRUD      - OutputFormatRequestId");
                    sb.AppendLine($"CRUD      - Name");
                    sb.AppendLine($"CRUD      - Prompt");
                    sb.AppendLine($"CRUD      - PromptVariations");
                    sb.AppendLine($"CRUD      - OutputFormat");
                
            
        }
        
        public void PrintDeleteOutputFormatRequestHelp(StringBuilder sb)
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
                    sb.AppendLine($"CRUD      - ValidationArtifact");
                    sb.AppendLine($"CRUD      - ResponseOfArtifactBeingValidated");
                    sb.AppendLine($"CRUD      - TransformerRawPrompt");
                    sb.AppendLine($"CRUD      - TransformerIdeaPrompt");
                    sb.AppendLine($"CRUD      - ActualPrompt");
                    sb.AppendLine($"CRUD      - Response");
                    sb.AppendLine($"CRUD      - Created");
                    sb.AppendLine($"CRUD      - AutoNumber");
                    sb.AppendLine($"CRUD      - IsRetiredArtifact");
                    sb.AppendLine($"CRUD      - IsActiveIdea");
                    sb.AppendLine($"CRUD      - Modified");
                    sb.AppendLine($"CRUD      - SuggestedPrompt");
                    sb.AppendLine($"CRUD      - ExtensionOf");
                    sb.AppendLine($"CRUD      - TransformerNumber");
                
            
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
                    sb.AppendLine($"CRUD      - ValidationArtifact");
                    sb.AppendLine($"CRUD      - ResponseOfArtifactBeingValidated");
                    sb.AppendLine($"CRUD      - TransformerRawPrompt");
                    sb.AppendLine($"CRUD      - TransformerIdeaPrompt");
                    sb.AppendLine($"CRUD      - ActualPrompt");
                    sb.AppendLine($"CRUD      - Response");
                    sb.AppendLine($"CRUD      - Created");
                    sb.AppendLine($"CRUD      - AutoNumber");
                    sb.AppendLine($"CRUD      - IsRetiredArtifact");
                    sb.AppendLine($"CRUD      - IsActiveIdea");
                    sb.AppendLine($"CRUD      - Modified");
                    sb.AppendLine($"CRUD      - SuggestedPrompt");
                    sb.AppendLine($"CRUD      - ExtensionOf");
                    sb.AppendLine($"CRUD      - TransformerNumber");
                
            
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
                    sb.AppendLine($"CRUD      - ValidationArtifact");
                    sb.AppendLine($"CRUD      - ResponseOfArtifactBeingValidated");
                    sb.AppendLine($"CRUD      - TransformerRawPrompt");
                    sb.AppendLine($"CRUD      - TransformerIdeaPrompt");
                    sb.AppendLine($"CRUD      - ActualPrompt");
                    sb.AppendLine($"CRUD      - Response");
                    sb.AppendLine($"CRUD      - Created");
                    sb.AppendLine($"CRUD      - AutoNumber");
                    sb.AppendLine($"CRUD      - IsRetiredArtifact");
                    sb.AppendLine($"CRUD      - IsActiveIdea");
                    sb.AppendLine($"CRUD      - Modified");
                    sb.AppendLine($"CRUD      - SuggestedPrompt");
                    sb.AppendLine($"CRUD      - ExtensionOf");
                    sb.AppendLine($"CRUD      - TransformerNumber");
                
            
        }
        
        public void PrintDeleteTransformedArtifactHelp(StringBuilder sb)
        {
            
        }
        
        public void PrintAddIdeaHelp(StringBuilder sb)
        {
            
                
                sb.AppendLine();
                sb.AppendLine($"* * * * * * * * * * * * * * * * * * * * * * * * * * *");
                sb.AppendLine($"* *  OBJECT DEF: Idea     *");
                sb.AppendLine($"* * * * * * * * * * * * * * * * * * * * * * * * * * *");
                sb.AppendLine();
                
                    sb.AppendLine($"CRUD      - IdeaId");
                    sb.AppendLine($"CRUD      - Name");
                    sb.AppendLine($"CRUD      - SourceIdea");
                    sb.AppendLine($"CRUD      - Generations");
                    sb.AppendLine($"CRUD      - GenerationTransformers");
                    sb.AppendLine($"CRUD      - GenerationTransformerNames");
                    sb.AppendLine($"CRUD      - GenerationTransformerFullPrompts");
                    sb.AppendLine($"CRUD      - IsActiveIdea");
                
            
        }
        
        public void PrintGetIdeasHelp(StringBuilder sb)
        {
            
                
                sb.AppendLine();
                sb.AppendLine($"* * * * * * * * * * * * * * * * * * * * * * * * * * *");
                sb.AppendLine($"* *  OBJECT DEF: Idea     *");
                sb.AppendLine($"* * * * * * * * * * * * * * * * * * * * * * * * * * *");
                sb.AppendLine();
                
                    sb.AppendLine($"CRUD      - IdeaId");
                    sb.AppendLine($"CRUD      - Name");
                    sb.AppendLine($"CRUD      - SourceIdea");
                    sb.AppendLine($"CRUD      - Generations");
                    sb.AppendLine($"CRUD      - GenerationTransformers");
                    sb.AppendLine($"CRUD      - GenerationTransformerNames");
                    sb.AppendLine($"CRUD      - GenerationTransformerFullPrompts");
                    sb.AppendLine($"CRUD      - IsActiveIdea");
                
            
        }
        
        public void PrintUpdateIdeaHelp(StringBuilder sb)
        {
            
                
                sb.AppendLine();
                sb.AppendLine($"* * * * * * * * * * * * * * * * * * * * * * * * * * *");
                sb.AppendLine($"* *  OBJECT DEF: Idea     *");
                sb.AppendLine($"* * * * * * * * * * * * * * * * * * * * * * * * * * *");
                sb.AppendLine();
                
                    sb.AppendLine($"CRUD      - IdeaId");
                    sb.AppendLine($"CRUD      - Name");
                    sb.AppendLine($"CRUD      - SourceIdea");
                    sb.AppendLine($"CRUD      - Generations");
                    sb.AppendLine($"CRUD      - GenerationTransformers");
                    sb.AppendLine($"CRUD      - GenerationTransformerNames");
                    sb.AppendLine($"CRUD      - GenerationTransformerFullPrompts");
                    sb.AppendLine($"CRUD      - IsActiveIdea");
                
            
        }
        
        public void PrintDeleteIdeaHelp(StringBuilder sb)
        {
            
        }
        

    }
}
