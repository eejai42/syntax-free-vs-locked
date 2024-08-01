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
                
                sb.AppendLine($"TrialArtifact: AddTrialArtifact");
                sb.AppendLine($"TrialArtifact: GetTrialArtifacts");
                sb.AppendLine($"TrialArtifact: UpdateTrialArtifact");
                sb.AppendLine($"void: DeleteTrialArtifact");
                sb.AppendLine($"ArtifactAnalysis: AddArtifactAnalysis");
                sb.AppendLine($"ArtifactAnalysis: GetArtifactAnalyses");
                sb.AppendLine($"ArtifactAnalysis: UpdateArtifactAnalysis");
                sb.AppendLine($"void: DeleteArtifactAnalysis");
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
                sb.AppendLine($"Trial: AddTrial");
                sb.AppendLine($"Trial: GetTrials");
                sb.AppendLine($"Trial: UpdateTrial");
                sb.AppendLine($"void: DeleteTrial");
                sb.AppendLine($"ExperimentTransformer: AddExperimentTransformer");
                sb.AppendLine($"ExperimentTransformer: GetExperimentTransformers");
                sb.AppendLine($"ExperimentTransformer: UpdateExperimentTransformer");
                sb.AppendLine($"void: DeleteExperimentTransformer");
                sb.AppendLine($"ExperimentFeature: AddExperimentFeature");
                sb.AppendLine($"ExperimentFeature: GetExperimentFeatures");
                sb.AppendLine($"ExperimentFeature: UpdateExperimentFeature");
                sb.AppendLine($"void: DeleteExperimentFeature");
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
            
            if ("addtrialartifact".Contains(helpTerm, StringComparison.OrdinalIgnoreCase))
            {
                sb.AppendLine($" - AddTrialArtifact");
                if ("addtrialartifact".Equals(helpTerm, StringComparison.OrdinalIgnoreCase)) 
                {
                    this.PrintAddTrialArtifactHelp(sb);
                }
                found = true;
            }
            if ("gettrialartifacts".Contains(helpTerm, StringComparison.OrdinalIgnoreCase))
            {
                sb.AppendLine($" - GetTrialArtifacts");
                if ("gettrialartifacts".Equals(helpTerm, StringComparison.OrdinalIgnoreCase)) 
                {
                    this.PrintGetTrialArtifactsHelp(sb);
                }
                found = true;
            }
            if ("updatetrialartifact".Contains(helpTerm, StringComparison.OrdinalIgnoreCase))
            {
                sb.AppendLine($" - UpdateTrialArtifact");
                if ("updatetrialartifact".Equals(helpTerm, StringComparison.OrdinalIgnoreCase)) 
                {
                    this.PrintUpdateTrialArtifactHelp(sb);
                }
                found = true;
            }
            if ("deletetrialartifact".Contains(helpTerm, StringComparison.OrdinalIgnoreCase))
            {
                sb.AppendLine($" - DeleteTrialArtifact");
                if ("deletetrialartifact".Equals(helpTerm, StringComparison.OrdinalIgnoreCase)) 
                {
                    this.PrintDeleteTrialArtifactHelp(sb);
                }
                found = true;
            }
            if ("addartifactanalysis".Contains(helpTerm, StringComparison.OrdinalIgnoreCase))
            {
                sb.AppendLine($" - AddArtifactAnalysis");
                if ("addartifactanalysis".Equals(helpTerm, StringComparison.OrdinalIgnoreCase)) 
                {
                    this.PrintAddArtifactAnalysisHelp(sb);
                }
                found = true;
            }
            if ("getartifactanalyses".Contains(helpTerm, StringComparison.OrdinalIgnoreCase))
            {
                sb.AppendLine($" - GetArtifactAnalyses");
                if ("getartifactanalyses".Equals(helpTerm, StringComparison.OrdinalIgnoreCase)) 
                {
                    this.PrintGetArtifactAnalysesHelp(sb);
                }
                found = true;
            }
            if ("updateartifactanalysis".Contains(helpTerm, StringComparison.OrdinalIgnoreCase))
            {
                sb.AppendLine($" - UpdateArtifactAnalysis");
                if ("updateartifactanalysis".Equals(helpTerm, StringComparison.OrdinalIgnoreCase)) 
                {
                    this.PrintUpdateArtifactAnalysisHelp(sb);
                }
                found = true;
            }
            if ("deleteartifactanalysis".Contains(helpTerm, StringComparison.OrdinalIgnoreCase))
            {
                sb.AppendLine($" - DeleteArtifactAnalysis");
                if ("deleteartifactanalysis".Equals(helpTerm, StringComparison.OrdinalIgnoreCase)) 
                {
                    this.PrintDeleteArtifactAnalysisHelp(sb);
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
            if ("addtrial".Contains(helpTerm, StringComparison.OrdinalIgnoreCase))
            {
                sb.AppendLine($" - AddTrial");
                if ("addtrial".Equals(helpTerm, StringComparison.OrdinalIgnoreCase)) 
                {
                    this.PrintAddTrialHelp(sb);
                }
                found = true;
            }
            if ("gettrials".Contains(helpTerm, StringComparison.OrdinalIgnoreCase))
            {
                sb.AppendLine($" - GetTrials");
                if ("gettrials".Equals(helpTerm, StringComparison.OrdinalIgnoreCase)) 
                {
                    this.PrintGetTrialsHelp(sb);
                }
                found = true;
            }
            if ("updatetrial".Contains(helpTerm, StringComparison.OrdinalIgnoreCase))
            {
                sb.AppendLine($" - UpdateTrial");
                if ("updatetrial".Equals(helpTerm, StringComparison.OrdinalIgnoreCase)) 
                {
                    this.PrintUpdateTrialHelp(sb);
                }
                found = true;
            }
            if ("deletetrial".Contains(helpTerm, StringComparison.OrdinalIgnoreCase))
            {
                sb.AppendLine($" - DeleteTrial");
                if ("deletetrial".Equals(helpTerm, StringComparison.OrdinalIgnoreCase)) 
                {
                    this.PrintDeleteTrialHelp(sb);
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
                case "addtrialartifact":
				    reply = this.ATDActor.AddTrialArtifact(payload);
                    result = JsonConvert.SerializeObject(reply, Formatting.Indented);
                    break;                   

                case "gettrialartifacts":
				    reply = this.ATDActor.GetTrialArtifacts(payload);
                    result = JsonConvert.SerializeObject(reply, Formatting.Indented);
                    break;                   

                case "updatetrialartifact":
				    reply = this.ATDActor.UpdateTrialArtifact(payload);
                    result = JsonConvert.SerializeObject(reply, Formatting.Indented);
                    break;                   

                case "deletetrialartifact":
				    this.ATDActor.DeleteTrialArtifact(payload);
				    result = JsonConvert.SerializeObject(payload, Formatting.Indented);
                    break;                   

                case "addartifactanalysis":
				    reply = this.ATDActor.AddArtifactAnalysis(payload);
                    result = JsonConvert.SerializeObject(reply, Formatting.Indented);
                    break;                   

                case "getartifactanalyses":
				    reply = this.ATDActor.GetArtifactAnalyses(payload);
                    result = JsonConvert.SerializeObject(reply, Formatting.Indented);
                    break;                   

                case "updateartifactanalysis":
				    reply = this.ATDActor.UpdateArtifactAnalysis(payload);
                    result = JsonConvert.SerializeObject(reply, Formatting.Indented);
                    break;                   

                case "deleteartifactanalysis":
				    this.ATDActor.DeleteArtifactAnalysis(payload);
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

                case "addtrial":
				    reply = this.ATDActor.AddTrial(payload);
                    result = JsonConvert.SerializeObject(reply, Formatting.Indented);
                    break;                   

                case "gettrials":
				    reply = this.ATDActor.GetTrials(payload);
                    result = JsonConvert.SerializeObject(reply, Formatting.Indented);
                    break;                   

                case "updatetrial":
				    reply = this.ATDActor.UpdateTrial(payload);
                    result = JsonConvert.SerializeObject(reply, Formatting.Indented);
                    break;                   

                case "deletetrial":
				    this.ATDActor.DeleteTrial(payload);
				    result = JsonConvert.SerializeObject(payload, Formatting.Indented);
                    break;                   

                case "addexperimenttransformer":
				    reply = this.ATDActor.AddExperimentTransformer(payload);
                    result = JsonConvert.SerializeObject(reply, Formatting.Indented);
                    break;                   

                case "getexperimenttransformers":
				    reply = this.ATDActor.GetExperimentTransformers(payload);
                    result = JsonConvert.SerializeObject(reply, Formatting.Indented);
                    break;                   

                case "updateexperimenttransformer":
				    reply = this.ATDActor.UpdateExperimentTransformer(payload);
                    result = JsonConvert.SerializeObject(reply, Formatting.Indented);
                    break;                   

                case "deleteexperimenttransformer":
				    this.ATDActor.DeleteExperimentTransformer(payload);
				    result = JsonConvert.SerializeObject(payload, Formatting.Indented);
                    break;                   

                case "addexperimentfeature":
				    reply = this.ATDActor.AddExperimentFeature(payload);
                    result = JsonConvert.SerializeObject(reply, Formatting.Indented);
                    break;                   

                case "getexperimentfeatures":
				    reply = this.ATDActor.GetExperimentFeatures(payload);
                    result = JsonConvert.SerializeObject(reply, Formatting.Indented);
                    break;                   

                case "updateexperimentfeature":
				    reply = this.ATDActor.UpdateExperimentFeature(payload);
                    result = JsonConvert.SerializeObject(reply, Formatting.Indented);
                    break;                   

                case "deleteexperimentfeature":
				    this.ATDActor.DeleteExperimentFeature(payload);
				    result = JsonConvert.SerializeObject(payload, Formatting.Indented);
                    break;                   

                case "adddesigndecision":
				    reply = this.ATDActor.AddDesignDecision(payload);
                    result = JsonConvert.SerializeObject(reply, Formatting.Indented);
                    break;                   

                case "getdesigndecisions":
				    reply = this.ATDActor.GetDesignDecisions(payload);
                    result = JsonConvert.SerializeObject(reply, Formatting.Indented);
                    break;                   

                case "updatedesigndecision":
				    reply = this.ATDActor.UpdateDesignDecision(payload);
                    result = JsonConvert.SerializeObject(reply, Formatting.Indented);
                    break;                   

                case "deletedesigndecision":
				    this.ATDActor.DeleteDesignDecision(payload);
				    result = JsonConvert.SerializeObject(payload, Formatting.Indented);
                    break;                   

                case "addexperiment":
				    reply = this.ATDActor.AddExperiment(payload);
                    result = JsonConvert.SerializeObject(reply, Formatting.Indented);
                    break;                   

                case "getexperiments":
				    reply = this.ATDActor.GetExperiments(payload);
                    result = JsonConvert.SerializeObject(reply, Formatting.Indented);
                    break;                   

                case "updateexperiment":
				    reply = this.ATDActor.UpdateExperiment(payload);
                    result = JsonConvert.SerializeObject(reply, Formatting.Indented);
                    break;                   

                case "deleteexperiment":
				    this.ATDActor.DeleteExperiment(payload);
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

                default:
                    throw new Exception($"Invalid request: {invokeRequest}");
            }

            return result;
        }
        
        
        public void PrintAddTrialArtifactHelp(StringBuilder sb)
        {
            
                
                sb.AppendLine();
                sb.AppendLine($"* * * * * * * * * * * * * * * * * * * * * * * * * * *");
                sb.AppendLine($"* *  OBJECT DEF: TrialArtifact     *");
                sb.AppendLine($"* * * * * * * * * * * * * * * * * * * * * * * * * * *");
                sb.AppendLine();
                
                    sb.AppendLine($"CRUD      - TrialArtifactId");
                    sb.AppendLine($"CRUD      - Name");
                    sb.AppendLine($"CRUD      - ActualPrompt");
                    sb.AppendLine($"CRUD      - ActualValidationPrompt");
                    sb.AppendLine($"CRUD      - ValidationResponse");
                    sb.AppendLine($"CRUD      - ExtensionOf");
                    sb.AppendLine($"CRUD      - Created");
                    sb.AppendLine($"CRUD      - AutoNumber");
                    sb.AppendLine($"CRUD      - IsRetiredArtifact");
                    sb.AppendLine($"CRUD      - Modified");
                    sb.AppendLine($"CRUD      - LongName");
                    sb.AppendLine($"CRUD      - ArtifactIdentifier");
                    sb.AppendLine($"CRUD      - ExtensionOfArtifactIdentifier");
                    sb.AppendLine($"CRUD      - CustomRootIdentifier");
                    sb.AppendLine($"CRUD      - Trial");
                    sb.AppendLine($"CRUD      - GenerationTransformer");
                    sb.AppendLine($"CRUD      - ExpTransformerIsSyntaxFree");
                    sb.AppendLine($"CRUD      - GenerationName");
                    sb.AppendLine($"CRUD      - GeneratioNumber");
                    sb.AppendLine($"CRUD      - GenerationTransformerNumber");
                    sb.AppendLine($"CRUD      - TransformerRawPrompt");
                    sb.AppendLine($"CRUD      - IsActiveExp");
                    sb.AppendLine($"CRUD      - TransformerNumber");
                    sb.AppendLine($"CRUD      - TransformerGeneratioNumber");
                    sb.AppendLine($"CRUD      - TransformerGenerationExpName");
                    sb.AppendLine($"CRUD      - TransformerGenerationName");
                    sb.AppendLine($"CRUD      - ExpValidationPrompt");
                    sb.AppendLine($"CRUD      - ExpAbstract");
                    sb.AppendLine($"CRUD      - Response");
                    sb.AppendLine($"CRUD      - PrimaryExtensionArtifact");
                    sb.AppendLine($"CRUD      - ResponseOfArtifactBeingExtended");
                    sb.AppendLine($"CRUD      - SuggestedPrompt");
                    sb.AppendLine($"CRUD      - ResponseBeingValidated");
                    sb.AppendLine($"CRUD      - SuggestedValidationPrompt");
                    sb.AppendLine($"CRUD      - RootArtifactIdentifier");
                    sb.AppendLine($"CRUD      - SuggestedRootIdentifier");
                    sb.AppendLine($"CRUD      - RootIdentifierMismatch");
                    sb.AppendLine($"CRUD      - ArtifactAnalysis");
                    sb.AppendLine($"CRUD      - TrailIdentifier");
                
            
        }
        
        public void PrintGetTrialArtifactsHelp(StringBuilder sb)
        {
            
                
                sb.AppendLine();
                sb.AppendLine($"* * * * * * * * * * * * * * * * * * * * * * * * * * *");
                sb.AppendLine($"* *  OBJECT DEF: TrialArtifact     *");
                sb.AppendLine($"* * * * * * * * * * * * * * * * * * * * * * * * * * *");
                sb.AppendLine();
                
                    sb.AppendLine($"CRUD      - TrialArtifactId");
                    sb.AppendLine($"CRUD      - Name");
                    sb.AppendLine($"CRUD      - ActualPrompt");
                    sb.AppendLine($"CRUD      - ActualValidationPrompt");
                    sb.AppendLine($"CRUD      - ValidationResponse");
                    sb.AppendLine($"CRUD      - ExtensionOf");
                    sb.AppendLine($"CRUD      - Created");
                    sb.AppendLine($"CRUD      - AutoNumber");
                    sb.AppendLine($"CRUD      - IsRetiredArtifact");
                    sb.AppendLine($"CRUD      - Modified");
                    sb.AppendLine($"CRUD      - LongName");
                    sb.AppendLine($"CRUD      - ArtifactIdentifier");
                    sb.AppendLine($"CRUD      - ExtensionOfArtifactIdentifier");
                    sb.AppendLine($"CRUD      - CustomRootIdentifier");
                    sb.AppendLine($"CRUD      - Trial");
                    sb.AppendLine($"CRUD      - GenerationTransformer");
                    sb.AppendLine($"CRUD      - ExpTransformerIsSyntaxFree");
                    sb.AppendLine($"CRUD      - GenerationName");
                    sb.AppendLine($"CRUD      - GeneratioNumber");
                    sb.AppendLine($"CRUD      - GenerationTransformerNumber");
                    sb.AppendLine($"CRUD      - TransformerRawPrompt");
                    sb.AppendLine($"CRUD      - IsActiveExp");
                    sb.AppendLine($"CRUD      - TransformerNumber");
                    sb.AppendLine($"CRUD      - TransformerGeneratioNumber");
                    sb.AppendLine($"CRUD      - TransformerGenerationExpName");
                    sb.AppendLine($"CRUD      - TransformerGenerationName");
                    sb.AppendLine($"CRUD      - ExpValidationPrompt");
                    sb.AppendLine($"CRUD      - ExpAbstract");
                    sb.AppendLine($"CRUD      - Response");
                    sb.AppendLine($"CRUD      - PrimaryExtensionArtifact");
                    sb.AppendLine($"CRUD      - ResponseOfArtifactBeingExtended");
                    sb.AppendLine($"CRUD      - SuggestedPrompt");
                    sb.AppendLine($"CRUD      - ResponseBeingValidated");
                    sb.AppendLine($"CRUD      - SuggestedValidationPrompt");
                    sb.AppendLine($"CRUD      - RootArtifactIdentifier");
                    sb.AppendLine($"CRUD      - SuggestedRootIdentifier");
                    sb.AppendLine($"CRUD      - RootIdentifierMismatch");
                    sb.AppendLine($"CRUD      - ArtifactAnalysis");
                    sb.AppendLine($"CRUD      - TrailIdentifier");
                
            
        }
        
        public void PrintUpdateTrialArtifactHelp(StringBuilder sb)
        {
            
                
                sb.AppendLine();
                sb.AppendLine($"* * * * * * * * * * * * * * * * * * * * * * * * * * *");
                sb.AppendLine($"* *  OBJECT DEF: TrialArtifact     *");
                sb.AppendLine($"* * * * * * * * * * * * * * * * * * * * * * * * * * *");
                sb.AppendLine();
                
                    sb.AppendLine($"CRUD      - TrialArtifactId");
                    sb.AppendLine($"CRUD      - Name");
                    sb.AppendLine($"CRUD      - ActualPrompt");
                    sb.AppendLine($"CRUD      - ActualValidationPrompt");
                    sb.AppendLine($"CRUD      - ValidationResponse");
                    sb.AppendLine($"CRUD      - ExtensionOf");
                    sb.AppendLine($"CRUD      - Created");
                    sb.AppendLine($"CRUD      - AutoNumber");
                    sb.AppendLine($"CRUD      - IsRetiredArtifact");
                    sb.AppendLine($"CRUD      - Modified");
                    sb.AppendLine($"CRUD      - LongName");
                    sb.AppendLine($"CRUD      - ArtifactIdentifier");
                    sb.AppendLine($"CRUD      - ExtensionOfArtifactIdentifier");
                    sb.AppendLine($"CRUD      - CustomRootIdentifier");
                    sb.AppendLine($"CRUD      - Trial");
                    sb.AppendLine($"CRUD      - GenerationTransformer");
                    sb.AppendLine($"CRUD      - ExpTransformerIsSyntaxFree");
                    sb.AppendLine($"CRUD      - GenerationName");
                    sb.AppendLine($"CRUD      - GeneratioNumber");
                    sb.AppendLine($"CRUD      - GenerationTransformerNumber");
                    sb.AppendLine($"CRUD      - TransformerRawPrompt");
                    sb.AppendLine($"CRUD      - IsActiveExp");
                    sb.AppendLine($"CRUD      - TransformerNumber");
                    sb.AppendLine($"CRUD      - TransformerGeneratioNumber");
                    sb.AppendLine($"CRUD      - TransformerGenerationExpName");
                    sb.AppendLine($"CRUD      - TransformerGenerationName");
                    sb.AppendLine($"CRUD      - ExpValidationPrompt");
                    sb.AppendLine($"CRUD      - ExpAbstract");
                    sb.AppendLine($"CRUD      - Response");
                    sb.AppendLine($"CRUD      - PrimaryExtensionArtifact");
                    sb.AppendLine($"CRUD      - ResponseOfArtifactBeingExtended");
                    sb.AppendLine($"CRUD      - SuggestedPrompt");
                    sb.AppendLine($"CRUD      - ResponseBeingValidated");
                    sb.AppendLine($"CRUD      - SuggestedValidationPrompt");
                    sb.AppendLine($"CRUD      - RootArtifactIdentifier");
                    sb.AppendLine($"CRUD      - SuggestedRootIdentifier");
                    sb.AppendLine($"CRUD      - RootIdentifierMismatch");
                    sb.AppendLine($"CRUD      - ArtifactAnalysis");
                    sb.AppendLine($"CRUD      - TrailIdentifier");
                
            
        }
        
        public void PrintDeleteTrialArtifactHelp(StringBuilder sb)
        {
            
        }
        
        public void PrintAddArtifactAnalysisHelp(StringBuilder sb)
        {
            
                
                sb.AppendLine();
                sb.AppendLine($"* * * * * * * * * * * * * * * * * * * * * * * * * * *");
                sb.AppendLine($"* *  OBJECT DEF: ArtifactAnalysis     *");
                sb.AppendLine($"* * * * * * * * * * * * * * * * * * * * * * * * * * *");
                sb.AppendLine();
                
                    sb.AppendLine($"CRUD      - ArtifactAnalysisId");
                    sb.AppendLine($"CRUD      - Name");
                    sb.AppendLine($"CRUD      - PreviousGeneration");
                    sb.AppendLine($"CRUD      - PrevGenName");
                    sb.AppendLine($"CRUD      - PrevGenArtifactIdentifier");
                    sb.AppendLine($"CRUD      - PrevGenTransformerNumber");
                    sb.AppendLine($"CRUD      - TrialArtifact");
                    sb.AppendLine($"CRUD      - TrialArtifactExtensionOf");
                    sb.AppendLine($"CRUD      - ExpTransformerIsSyntaxFree");
                    sb.AppendLine($"CRUD      - RootArtifactIdentifier");
                    sb.AppendLine($"CRUD      - GenerationName");
                    sb.AppendLine($"CRUD      - ArtifactIdentifier");
                    sb.AppendLine($"CRUD      - GenerationTransformerNumber");
                    sb.AppendLine($"CRUD      - TrialArtifactLongName");
                    sb.AppendLine($"CRUD      - TrialArtifactGeneratioNumber");
                    sb.AppendLine($"CRUD      - TransformerGeneratioNumber");
                    sb.AppendLine($"CRUD      - TransformerGenerationName");
                    sb.AppendLine($"CRUD      - ResponseBeingValidated");
                    sb.AppendLine($"CRUD      - TrialArtifactActualPrompt");
                    sb.AppendLine($"CRUD      - TrialArtifactResponse");
                    sb.AppendLine($"CRUD      - TrialArtifactActualValidationPrompt");
                    sb.AppendLine($"CRUD      - TrialArtifactValidationResponse");
                    sb.AppendLine($"CRUD      - CleanValidationJson");
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
                    sb.AppendLine($"CRUD      - PrevGenToDoItems");
                    sb.AppendLine($"CRUD      - PrevGenToDoItemsAKA");
                    sb.AppendLine($"CRUD      - PrevGenToDoItemsMismatched");
                    sb.AppendLine($"CRUD      - PrevGenCategories");
                    sb.AppendLine($"CRUD      - PrevGenCategoriesAKA");
                    sb.AppendLine($"CRUD      - PrevGenCategoriesMismatched");
                    sb.AppendLine($"CRUD      - PrevGenDueDates");
                    sb.AppendLine($"CRUD      - PrevGenDueDatesAKA");
                    sb.AppendLine($"CRUD      - PrevGenDueDatesMismatched");
                    sb.AppendLine($"CRUD      - PrevGenPriorities");
                    sb.AppendLine($"CRUD      - PrevGenPrioritiesAKA");
                    sb.AppendLine($"CRUD      - PrevGenPrioritiesMismatched");
                    sb.AppendLine($"CRUD      - PrevGenProgress");
                    sb.AppendLine($"CRUD      - PrevGenProgressAKA");
                    sb.AppendLine($"CRUD      - PrevGenProgressMismatched");
                    sb.AppendLine($"CRUD      - PrevGenStatuses");
                    sb.AppendLine($"CRUD      - PrevGenStatusesAKA");
                    sb.AppendLine($"CRUD      - PrevGenStatusesMismatched");
                    sb.AppendLine($"CRUD      - PrevGenReminders");
                    sb.AppendLine($"CRUD      - PrevGenRemindersAKA");
                    sb.AppendLine($"CRUD      - PrevGenRemindersMismatched");
                    sb.AppendLine($"CRUD      - PrevGenNotifications");
                    sb.AppendLine($"CRUD      - PrevGenNotificationsAKA");
                    sb.AppendLine($"CRUD      - PrevGenNotificationsMismatched");
                    sb.AppendLine($"CRUD      - PrevGenCompletion");
                    sb.AppendLine($"CRUD      - PrevGenCompletionAKA");
                    sb.AppendLine($"CRUD      - PrevGenCompletionMismatched");
                    sb.AppendLine($"CRUD      - PrevGenToDoEmployees");
                    sb.AppendLine($"CRUD      - PrevGenToDoEmployeesAKA");
                    sb.AppendLine($"CRUD      - PrevGenToDoEmployeesMismatched");
                    sb.AppendLine($"CRUD      - PrevGenDuration");
                    sb.AppendLine($"CRUD      - PrevGenDurationAKA");
                    sb.AppendLine($"CRUD      - PrevGenDurationMismatched");
                    sb.AppendLine($"CRUD      - PrevGenCompletedDate");
                    sb.AppendLine($"CRUD      - PrevGenCompletedDateAKA");
                    sb.AppendLine($"CRUD      - PrevGenCompletedDateMismatched");
                    sb.AppendLine($"CRUD      - PrevGenToDoColors");
                    sb.AppendLine($"CRUD      - PrevGenToDoColorsAKA");
                    sb.AppendLine($"CRUD      - PrevGenToDoColorsMismatched");
                    sb.AppendLine($"CRUD      - Modified");
                    sb.AppendLine($"CRUD      - TrailIdentifier");
                    sb.AppendLine($"CRUD      - Ready");
                    sb.AppendLine($"CRUD      - HasBeenAnalyzed");
                
            
        }
        
        public void PrintGetArtifactAnalysesHelp(StringBuilder sb)
        {
            
                
                sb.AppendLine();
                sb.AppendLine($"* * * * * * * * * * * * * * * * * * * * * * * * * * *");
                sb.AppendLine($"* *  OBJECT DEF: ArtifactAnalysis     *");
                sb.AppendLine($"* * * * * * * * * * * * * * * * * * * * * * * * * * *");
                sb.AppendLine();
                
                    sb.AppendLine($"CRUD      - ArtifactAnalysisId");
                    sb.AppendLine($"CRUD      - Name");
                    sb.AppendLine($"CRUD      - PreviousGeneration");
                    sb.AppendLine($"CRUD      - PrevGenName");
                    sb.AppendLine($"CRUD      - PrevGenArtifactIdentifier");
                    sb.AppendLine($"CRUD      - PrevGenTransformerNumber");
                    sb.AppendLine($"CRUD      - TrialArtifact");
                    sb.AppendLine($"CRUD      - TrialArtifactExtensionOf");
                    sb.AppendLine($"CRUD      - ExpTransformerIsSyntaxFree");
                    sb.AppendLine($"CRUD      - RootArtifactIdentifier");
                    sb.AppendLine($"CRUD      - GenerationName");
                    sb.AppendLine($"CRUD      - ArtifactIdentifier");
                    sb.AppendLine($"CRUD      - GenerationTransformerNumber");
                    sb.AppendLine($"CRUD      - TrialArtifactLongName");
                    sb.AppendLine($"CRUD      - TrialArtifactGeneratioNumber");
                    sb.AppendLine($"CRUD      - TransformerGeneratioNumber");
                    sb.AppendLine($"CRUD      - TransformerGenerationName");
                    sb.AppendLine($"CRUD      - ResponseBeingValidated");
                    sb.AppendLine($"CRUD      - TrialArtifactActualPrompt");
                    sb.AppendLine($"CRUD      - TrialArtifactResponse");
                    sb.AppendLine($"CRUD      - TrialArtifactActualValidationPrompt");
                    sb.AppendLine($"CRUD      - TrialArtifactValidationResponse");
                    sb.AppendLine($"CRUD      - CleanValidationJson");
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
                    sb.AppendLine($"CRUD      - PrevGenToDoItems");
                    sb.AppendLine($"CRUD      - PrevGenToDoItemsAKA");
                    sb.AppendLine($"CRUD      - PrevGenToDoItemsMismatched");
                    sb.AppendLine($"CRUD      - PrevGenCategories");
                    sb.AppendLine($"CRUD      - PrevGenCategoriesAKA");
                    sb.AppendLine($"CRUD      - PrevGenCategoriesMismatched");
                    sb.AppendLine($"CRUD      - PrevGenDueDates");
                    sb.AppendLine($"CRUD      - PrevGenDueDatesAKA");
                    sb.AppendLine($"CRUD      - PrevGenDueDatesMismatched");
                    sb.AppendLine($"CRUD      - PrevGenPriorities");
                    sb.AppendLine($"CRUD      - PrevGenPrioritiesAKA");
                    sb.AppendLine($"CRUD      - PrevGenPrioritiesMismatched");
                    sb.AppendLine($"CRUD      - PrevGenProgress");
                    sb.AppendLine($"CRUD      - PrevGenProgressAKA");
                    sb.AppendLine($"CRUD      - PrevGenProgressMismatched");
                    sb.AppendLine($"CRUD      - PrevGenStatuses");
                    sb.AppendLine($"CRUD      - PrevGenStatusesAKA");
                    sb.AppendLine($"CRUD      - PrevGenStatusesMismatched");
                    sb.AppendLine($"CRUD      - PrevGenReminders");
                    sb.AppendLine($"CRUD      - PrevGenRemindersAKA");
                    sb.AppendLine($"CRUD      - PrevGenRemindersMismatched");
                    sb.AppendLine($"CRUD      - PrevGenNotifications");
                    sb.AppendLine($"CRUD      - PrevGenNotificationsAKA");
                    sb.AppendLine($"CRUD      - PrevGenNotificationsMismatched");
                    sb.AppendLine($"CRUD      - PrevGenCompletion");
                    sb.AppendLine($"CRUD      - PrevGenCompletionAKA");
                    sb.AppendLine($"CRUD      - PrevGenCompletionMismatched");
                    sb.AppendLine($"CRUD      - PrevGenToDoEmployees");
                    sb.AppendLine($"CRUD      - PrevGenToDoEmployeesAKA");
                    sb.AppendLine($"CRUD      - PrevGenToDoEmployeesMismatched");
                    sb.AppendLine($"CRUD      - PrevGenDuration");
                    sb.AppendLine($"CRUD      - PrevGenDurationAKA");
                    sb.AppendLine($"CRUD      - PrevGenDurationMismatched");
                    sb.AppendLine($"CRUD      - PrevGenCompletedDate");
                    sb.AppendLine($"CRUD      - PrevGenCompletedDateAKA");
                    sb.AppendLine($"CRUD      - PrevGenCompletedDateMismatched");
                    sb.AppendLine($"CRUD      - PrevGenToDoColors");
                    sb.AppendLine($"CRUD      - PrevGenToDoColorsAKA");
                    sb.AppendLine($"CRUD      - PrevGenToDoColorsMismatched");
                    sb.AppendLine($"CRUD      - Modified");
                    sb.AppendLine($"CRUD      - TrailIdentifier");
                    sb.AppendLine($"CRUD      - Ready");
                    sb.AppendLine($"CRUD      - HasBeenAnalyzed");
                
            
        }
        
        public void PrintUpdateArtifactAnalysisHelp(StringBuilder sb)
        {
            
                
                sb.AppendLine();
                sb.AppendLine($"* * * * * * * * * * * * * * * * * * * * * * * * * * *");
                sb.AppendLine($"* *  OBJECT DEF: ArtifactAnalysis     *");
                sb.AppendLine($"* * * * * * * * * * * * * * * * * * * * * * * * * * *");
                sb.AppendLine();
                
                    sb.AppendLine($"CRUD      - ArtifactAnalysisId");
                    sb.AppendLine($"CRUD      - Name");
                    sb.AppendLine($"CRUD      - PreviousGeneration");
                    sb.AppendLine($"CRUD      - PrevGenName");
                    sb.AppendLine($"CRUD      - PrevGenArtifactIdentifier");
                    sb.AppendLine($"CRUD      - PrevGenTransformerNumber");
                    sb.AppendLine($"CRUD      - TrialArtifact");
                    sb.AppendLine($"CRUD      - TrialArtifactExtensionOf");
                    sb.AppendLine($"CRUD      - ExpTransformerIsSyntaxFree");
                    sb.AppendLine($"CRUD      - RootArtifactIdentifier");
                    sb.AppendLine($"CRUD      - GenerationName");
                    sb.AppendLine($"CRUD      - ArtifactIdentifier");
                    sb.AppendLine($"CRUD      - GenerationTransformerNumber");
                    sb.AppendLine($"CRUD      - TrialArtifactLongName");
                    sb.AppendLine($"CRUD      - TrialArtifactGeneratioNumber");
                    sb.AppendLine($"CRUD      - TransformerGeneratioNumber");
                    sb.AppendLine($"CRUD      - TransformerGenerationName");
                    sb.AppendLine($"CRUD      - ResponseBeingValidated");
                    sb.AppendLine($"CRUD      - TrialArtifactActualPrompt");
                    sb.AppendLine($"CRUD      - TrialArtifactResponse");
                    sb.AppendLine($"CRUD      - TrialArtifactActualValidationPrompt");
                    sb.AppendLine($"CRUD      - TrialArtifactValidationResponse");
                    sb.AppendLine($"CRUD      - CleanValidationJson");
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
                    sb.AppendLine($"CRUD      - PrevGenToDoItems");
                    sb.AppendLine($"CRUD      - PrevGenToDoItemsAKA");
                    sb.AppendLine($"CRUD      - PrevGenToDoItemsMismatched");
                    sb.AppendLine($"CRUD      - PrevGenCategories");
                    sb.AppendLine($"CRUD      - PrevGenCategoriesAKA");
                    sb.AppendLine($"CRUD      - PrevGenCategoriesMismatched");
                    sb.AppendLine($"CRUD      - PrevGenDueDates");
                    sb.AppendLine($"CRUD      - PrevGenDueDatesAKA");
                    sb.AppendLine($"CRUD      - PrevGenDueDatesMismatched");
                    sb.AppendLine($"CRUD      - PrevGenPriorities");
                    sb.AppendLine($"CRUD      - PrevGenPrioritiesAKA");
                    sb.AppendLine($"CRUD      - PrevGenPrioritiesMismatched");
                    sb.AppendLine($"CRUD      - PrevGenProgress");
                    sb.AppendLine($"CRUD      - PrevGenProgressAKA");
                    sb.AppendLine($"CRUD      - PrevGenProgressMismatched");
                    sb.AppendLine($"CRUD      - PrevGenStatuses");
                    sb.AppendLine($"CRUD      - PrevGenStatusesAKA");
                    sb.AppendLine($"CRUD      - PrevGenStatusesMismatched");
                    sb.AppendLine($"CRUD      - PrevGenReminders");
                    sb.AppendLine($"CRUD      - PrevGenRemindersAKA");
                    sb.AppendLine($"CRUD      - PrevGenRemindersMismatched");
                    sb.AppendLine($"CRUD      - PrevGenNotifications");
                    sb.AppendLine($"CRUD      - PrevGenNotificationsAKA");
                    sb.AppendLine($"CRUD      - PrevGenNotificationsMismatched");
                    sb.AppendLine($"CRUD      - PrevGenCompletion");
                    sb.AppendLine($"CRUD      - PrevGenCompletionAKA");
                    sb.AppendLine($"CRUD      - PrevGenCompletionMismatched");
                    sb.AppendLine($"CRUD      - PrevGenToDoEmployees");
                    sb.AppendLine($"CRUD      - PrevGenToDoEmployeesAKA");
                    sb.AppendLine($"CRUD      - PrevGenToDoEmployeesMismatched");
                    sb.AppendLine($"CRUD      - PrevGenDuration");
                    sb.AppendLine($"CRUD      - PrevGenDurationAKA");
                    sb.AppendLine($"CRUD      - PrevGenDurationMismatched");
                    sb.AppendLine($"CRUD      - PrevGenCompletedDate");
                    sb.AppendLine($"CRUD      - PrevGenCompletedDateAKA");
                    sb.AppendLine($"CRUD      - PrevGenCompletedDateMismatched");
                    sb.AppendLine($"CRUD      - PrevGenToDoColors");
                    sb.AppendLine($"CRUD      - PrevGenToDoColorsAKA");
                    sb.AppendLine($"CRUD      - PrevGenToDoColorsMismatched");
                    sb.AppendLine($"CRUD      - Modified");
                    sb.AppendLine($"CRUD      - TrailIdentifier");
                    sb.AppendLine($"CRUD      - Ready");
                    sb.AppendLine($"CRUD      - HasBeenAnalyzed");
                
            
        }
        
        public void PrintDeleteArtifactAnalysisHelp(StringBuilder sb)
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
                    sb.AppendLine($"CRUD      - AutoNumber");
                    sb.AppendLine($"CRUD      - TransformerNumber");
                    sb.AppendLine($"CRUD      - IsArtifactValidator");
                    sb.AppendLine($"CRUD      - ExpAbstract");
                    sb.AppendLine($"CRUD      - GenerationExp");
                    sb.AppendLine($"CRUD      - GenerationExpName");
                    sb.AppendLine($"CRUD      - IsActiveExp");
                    sb.AppendLine($"CRUD      - ExpValidationPrompt");
                    sb.AppendLine($"CRUD      - GenerationNumber");
                    sb.AppendLine($"CRUD      - ParentTransformer");
                    sb.AppendLine($"CRUD      - ParentTransformerNumber");
                    sb.AppendLine($"CRUD      - AddDataCommand");
                    sb.AppendLine($"CRUD      - ExpTransformer");
                    sb.AppendLine($"CRUD      - TrialArtifacts");
                    sb.AppendLine($"CRUD      - ExpTransformerIsSyntaxFree");
                
            
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
                    sb.AppendLine($"CRUD      - AutoNumber");
                    sb.AppendLine($"CRUD      - TransformerNumber");
                    sb.AppendLine($"CRUD      - IsArtifactValidator");
                    sb.AppendLine($"CRUD      - ExpAbstract");
                    sb.AppendLine($"CRUD      - GenerationExp");
                    sb.AppendLine($"CRUD      - GenerationExpName");
                    sb.AppendLine($"CRUD      - IsActiveExp");
                    sb.AppendLine($"CRUD      - ExpValidationPrompt");
                    sb.AppendLine($"CRUD      - GenerationNumber");
                    sb.AppendLine($"CRUD      - ParentTransformer");
                    sb.AppendLine($"CRUD      - ParentTransformerNumber");
                    sb.AppendLine($"CRUD      - AddDataCommand");
                    sb.AppendLine($"CRUD      - ExpTransformer");
                    sb.AppendLine($"CRUD      - TrialArtifacts");
                    sb.AppendLine($"CRUD      - ExpTransformerIsSyntaxFree");
                
            
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
                    sb.AppendLine($"CRUD      - AutoNumber");
                    sb.AppendLine($"CRUD      - TransformerNumber");
                    sb.AppendLine($"CRUD      - IsArtifactValidator");
                    sb.AppendLine($"CRUD      - ExpAbstract");
                    sb.AppendLine($"CRUD      - GenerationExp");
                    sb.AppendLine($"CRUD      - GenerationExpName");
                    sb.AppendLine($"CRUD      - IsActiveExp");
                    sb.AppendLine($"CRUD      - ExpValidationPrompt");
                    sb.AppendLine($"CRUD      - GenerationNumber");
                    sb.AppendLine($"CRUD      - ParentTransformer");
                    sb.AppendLine($"CRUD      - ParentTransformerNumber");
                    sb.AppendLine($"CRUD      - AddDataCommand");
                    sb.AppendLine($"CRUD      - ExpTransformer");
                    sb.AppendLine($"CRUD      - TrialArtifacts");
                    sb.AppendLine($"CRUD      - ExpTransformerIsSyntaxFree");
                
            
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
                    sb.AppendLine($"CRUD      - GenerationTransformerAddDataCommands");
                    sb.AppendLine($"CRUD      - AddDataCommandScript");
                
            
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
                    sb.AppendLine($"CRUD      - GenerationTransformerAddDataCommands");
                    sb.AppendLine($"CRUD      - AddDataCommandScript");
                
            
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
                    sb.AppendLine($"CRUD      - GenerationTransformerAddDataCommands");
                    sb.AppendLine($"CRUD      - AddDataCommandScript");
                
            
        }
        
        public void PrintDeleteGenerationHelp(StringBuilder sb)
        {
            
        }
        
        public void PrintAddTrialHelp(StringBuilder sb)
        {
            
                
                sb.AppendLine();
                sb.AppendLine($"* * * * * * * * * * * * * * * * * * * * * * * * * * *");
                sb.AppendLine($"* *  OBJECT DEF: Trial     *");
                sb.AppendLine($"* * * * * * * * * * * * * * * * * * * * * * * * * * *");
                sb.AppendLine();
                
                    sb.AppendLine($"CRUD      - TrialId");
                    sb.AppendLine($"CRUD      - Name");
                    sb.AppendLine($"CRUD      - Experiement");
                    sb.AppendLine($"CRUD      - TrialArtifacts");
                    sb.AppendLine($"CRUD      - AutoNumber");
                    sb.AppendLine($"CRUD      - TrailIdentifier");
                    sb.AppendLine($"CRUD      - Created");
                    sb.AppendLine($"CRUD      - DesiredPromptChainCount");
                    sb.AppendLine($"CRUD      - TrialArtifactCount");
                    sb.AppendLine($"CRUD      - GatherTrialDataScript");
                    sb.AppendLine($"CRUD      - ExperimentRunTrialScript");
                
            
        }
        
        public void PrintGetTrialsHelp(StringBuilder sb)
        {
            
                
                sb.AppendLine();
                sb.AppendLine($"* * * * * * * * * * * * * * * * * * * * * * * * * * *");
                sb.AppendLine($"* *  OBJECT DEF: Trial     *");
                sb.AppendLine($"* * * * * * * * * * * * * * * * * * * * * * * * * * *");
                sb.AppendLine();
                
                    sb.AppendLine($"CRUD      - TrialId");
                    sb.AppendLine($"CRUD      - Name");
                    sb.AppendLine($"CRUD      - Experiement");
                    sb.AppendLine($"CRUD      - TrialArtifacts");
                    sb.AppendLine($"CRUD      - AutoNumber");
                    sb.AppendLine($"CRUD      - TrailIdentifier");
                    sb.AppendLine($"CRUD      - Created");
                    sb.AppendLine($"CRUD      - DesiredPromptChainCount");
                    sb.AppendLine($"CRUD      - TrialArtifactCount");
                    sb.AppendLine($"CRUD      - GatherTrialDataScript");
                    sb.AppendLine($"CRUD      - ExperimentRunTrialScript");
                
            
        }
        
        public void PrintUpdateTrialHelp(StringBuilder sb)
        {
            
                
                sb.AppendLine();
                sb.AppendLine($"* * * * * * * * * * * * * * * * * * * * * * * * * * *");
                sb.AppendLine($"* *  OBJECT DEF: Trial     *");
                sb.AppendLine($"* * * * * * * * * * * * * * * * * * * * * * * * * * *");
                sb.AppendLine();
                
                    sb.AppendLine($"CRUD      - TrialId");
                    sb.AppendLine($"CRUD      - Name");
                    sb.AppendLine($"CRUD      - Experiement");
                    sb.AppendLine($"CRUD      - TrialArtifacts");
                    sb.AppendLine($"CRUD      - AutoNumber");
                    sb.AppendLine($"CRUD      - TrailIdentifier");
                    sb.AppendLine($"CRUD      - Created");
                    sb.AppendLine($"CRUD      - DesiredPromptChainCount");
                    sb.AppendLine($"CRUD      - TrialArtifactCount");
                    sb.AppendLine($"CRUD      - GatherTrialDataScript");
                    sb.AppendLine($"CRUD      - ExperimentRunTrialScript");
                
            
        }
        
        public void PrintDeleteTrialHelp(StringBuilder sb)
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
                    sb.AppendLine($"CRUD      - AutoNumber");
                    sb.AppendLine($"CRUD      - TransformerIdentifier");
                    sb.AppendLine($"CRUD      - IsSyntaxFree");
                    sb.AppendLine($"CRUD      - GenerationTransformer");
                
            
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
                    sb.AppendLine($"CRUD      - AutoNumber");
                    sb.AppendLine($"CRUD      - TransformerIdentifier");
                    sb.AppendLine($"CRUD      - IsSyntaxFree");
                    sb.AppendLine($"CRUD      - GenerationTransformer");
                
            
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
                    sb.AppendLine($"CRUD      - AutoNumber");
                    sb.AppendLine($"CRUD      - TransformerIdentifier");
                    sb.AppendLine($"CRUD      - IsSyntaxFree");
                    sb.AppendLine($"CRUD      - GenerationTransformer");
                
            
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
                    sb.AppendLine($"CRUD      - Variations");
                    sb.AppendLine($"CRUD      - PartialMatches");
                    sb.AppendLine($"CRUD      - AutoNumber");
                
            
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
                    sb.AppendLine($"CRUD      - Variations");
                    sb.AppendLine($"CRUD      - PartialMatches");
                    sb.AppendLine($"CRUD      - AutoNumber");
                
            
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
                    sb.AppendLine($"CRUD      - Variations");
                    sb.AppendLine($"CRUD      - PartialMatches");
                    sb.AppendLine($"CRUD      - AutoNumber");
                
            
        }
        
        public void PrintDeleteExperimentFeatureHelp(StringBuilder sb)
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
                    sb.AppendLine($"CRUD      - SyntaxLockedTransformerNumbers");
                    sb.AppendLine($"CRUD      - SyntaxFreeTransformerNumbers");
                    sb.AppendLine($"CRUD      - Trials");
                    sb.AppendLine($"CRUD      - RunTrialScript");
                    sb.AppendLine($"CRUD      - GenerationAddDataCommandScripts");
                    sb.AppendLine($"CRUD      - PromptChainsToCreate");
                
            
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
                    sb.AppendLine($"CRUD      - SyntaxLockedTransformerNumbers");
                    sb.AppendLine($"CRUD      - SyntaxFreeTransformerNumbers");
                    sb.AppendLine($"CRUD      - Trials");
                    sb.AppendLine($"CRUD      - RunTrialScript");
                    sb.AppendLine($"CRUD      - GenerationAddDataCommandScripts");
                    sb.AppendLine($"CRUD      - PromptChainsToCreate");
                
            
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
                    sb.AppendLine($"CRUD      - SyntaxLockedTransformerNumbers");
                    sb.AppendLine($"CRUD      - SyntaxFreeTransformerNumbers");
                    sb.AppendLine($"CRUD      - Trials");
                    sb.AppendLine($"CRUD      - RunTrialScript");
                    sb.AppendLine($"CRUD      - GenerationAddDataCommandScripts");
                    sb.AppendLine($"CRUD      - PromptChainsToCreate");
                
            
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
