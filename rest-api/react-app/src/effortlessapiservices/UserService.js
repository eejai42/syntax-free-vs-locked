
import BaseService from './BaseService';

class UserService extends BaseService {
    
        
    
    async AddTrialArtifact(TrialArtifact) { 
        return this.apiCall("POST", "User", "TrialArtifact", null, TrialArtifact); // TrialArtifact
   }
    
    
        
    
    async GetTrialArtifacts(view) { 
        return this.apiCall("GET", "User", "TrialArtifacts", view, null); // TrialArtifact
   }
    
    
        
    
    async UpdateTrialArtifact(TrialArtifact) {
        return this.apiCall("PUT", "User", "TrialArtifact", null, TrialArtifact); // TrialArtifact
   }
    
    
        
    
    async DeleteTrialArtifact(id) { 
        return this.apiCall("DELETE", "User", "TrialArtifact", null, id); // TrialArtifact
   }
    
    
        
    
    async AddArtifactAnalysis(ArtifactAnalysis) { 
        return this.apiCall("POST", "User", "ArtifactAnalysis", null, ArtifactAnalysis); // ArtifactAnalysis
   }
    
    
        
    
    async GetArtifactAnalyses(view) { 
        return this.apiCall("GET", "User", "ArtifactAnalyses", view, null); // ArtifactAnalysis
   }
    
    
        
    
    async UpdateArtifactAnalysis(ArtifactAnalysis) {
        return this.apiCall("PUT", "User", "ArtifactAnalysis", null, ArtifactAnalysis); // ArtifactAnalysis
   }
    
    
        
    
    async DeleteArtifactAnalysis(id) { 
        return this.apiCall("DELETE", "User", "ArtifactAnalysis", null, id); // ArtifactAnalysis
   }
    
    
        
    
    async AddAppUser(AppUser) { 
        return this.apiCall("POST", "User", "AppUser", null, AppUser); // AppUser
   }
    
    
        
    
    async GetAppUsers(view) { 
        return this.apiCall("GET", "User", "AppUsers", view, null); // AppUser
   }
    
    
        
    
    async UpdateAppUser(AppUser) {
        return this.apiCall("PUT", "User", "AppUser", null, AppUser); // AppUser
   }
    
    
        
    
    async DeleteAppUser(id) { 
        return this.apiCall("DELETE", "User", "AppUser", null, id); // AppUser
   }
    
    
        
    
    async AddGenerationTransformer(GenerationTransformer) { 
        return this.apiCall("POST", "User", "GenerationTransformer", null, GenerationTransformer); // GenerationTransformer
   }
    
    
        
    
    async GetGenerationTransformers(view) { 
        return this.apiCall("GET", "User", "GenerationTransformers", view, null); // GenerationTransformer
   }
    
    
        
    
    async UpdateGenerationTransformer(GenerationTransformer) {
        return this.apiCall("PUT", "User", "GenerationTransformer", null, GenerationTransformer); // GenerationTransformer
   }
    
    
        
    
    async DeleteGenerationTransformer(id) { 
        return this.apiCall("DELETE", "User", "GenerationTransformer", null, id); // GenerationTransformer
   }
    
    
        
    
    async AddGeneration(Generation) { 
        return this.apiCall("POST", "User", "Generation", null, Generation); // Generation
   }
    
    
        
    
    async GetGenerations(view) { 
        return this.apiCall("GET", "User", "Generations", view, null); // Generation
   }
    
    
        
    
    async UpdateGeneration(Generation) {
        return this.apiCall("PUT", "User", "Generation", null, Generation); // Generation
   }
    
    
        
    
    async DeleteGeneration(id) { 
        return this.apiCall("DELETE", "User", "Generation", null, id); // Generation
   }
    
    
        
    
    async AddTrial(Trial) { 
        return this.apiCall("POST", "User", "Trial", null, Trial); // Trial
   }
    
    
        
    
    async GetTrials(view) { 
        return this.apiCall("GET", "User", "Trials", view, null); // Trial
   }
    
    
        
    
    async UpdateTrial(Trial) {
        return this.apiCall("PUT", "User", "Trial", null, Trial); // Trial
   }
    
    
        
    
    async DeleteTrial(id) { 
        return this.apiCall("DELETE", "User", "Trial", null, id); // Trial
   }
    
    
        
    
    async AddExperimentTransformer(ExperimentTransformer) { 
        return this.apiCall("POST", "User", "ExperimentTransformer", null, ExperimentTransformer); // ExperimentTransformer
   }
    
    
        
    
    async GetExperimentTransformers(view) { 
        return this.apiCall("GET", "User", "ExperimentTransformers", view, null); // ExperimentTransformer
   }
    
    
        
    
    async UpdateExperimentTransformer(ExperimentTransformer) {
        return this.apiCall("PUT", "User", "ExperimentTransformer", null, ExperimentTransformer); // ExperimentTransformer
   }
    
    
        
    
    async DeleteExperimentTransformer(id) { 
        return this.apiCall("DELETE", "User", "ExperimentTransformer", null, id); // ExperimentTransformer
   }
    
    
        
    
    async AddExperimentFeature(ExperimentFeature) { 
        return this.apiCall("POST", "User", "ExperimentFeature", null, ExperimentFeature); // ExperimentFeature
   }
    
    
        
    
    async GetExperimentFeatures(view) { 
        return this.apiCall("GET", "User", "ExperimentFeatures", view, null); // ExperimentFeature
   }
    
    
        
    
    async UpdateExperimentFeature(ExperimentFeature) {
        return this.apiCall("PUT", "User", "ExperimentFeature", null, ExperimentFeature); // ExperimentFeature
   }
    
    
        
    
    async DeleteExperimentFeature(id) { 
        return this.apiCall("DELETE", "User", "ExperimentFeature", null, id); // ExperimentFeature
   }
    
    
        
    
    async AddDesignDecision(DesignDecision) { 
        return this.apiCall("POST", "User", "DesignDecision", null, DesignDecision); // DesignDecision
   }
    
    
        
    
    async GetDesignDecisions(view) { 
        return this.apiCall("GET", "User", "DesignDecisions", view, null); // DesignDecision
   }
    
    
        
    
    async UpdateDesignDecision(DesignDecision) {
        return this.apiCall("PUT", "User", "DesignDecision", null, DesignDecision); // DesignDecision
   }
    
    
        
    
    async DeleteDesignDecision(id) { 
        return this.apiCall("DELETE", "User", "DesignDecision", null, id); // DesignDecision
   }
    
    
        
    
    async AddExperiment(Experiment) { 
        return this.apiCall("POST", "User", "Experiment", null, Experiment); // Experiment
   }
    
    
        
    
    async GetExperiments(view) { 
        return this.apiCall("GET", "User", "Experiments", view, null); // Experiment
   }
    
    
        
    
    async UpdateExperiment(Experiment) {
        return this.apiCall("PUT", "User", "Experiment", null, Experiment); // Experiment
   }
    
    
        
    
    async DeleteExperiment(id) { 
        return this.apiCall("DELETE", "User", "Experiment", null, id); // Experiment
   }
    
    
        
    
    async AddLLM(LLM) { 
        return this.apiCall("POST", "User", "LLM", null, LLM); // LLM
   }
    
    
        
    
    async GetLLMs(view) { 
        return this.apiCall("GET", "User", "LLMs", view, null); // LLM
   }
    
    
        
    
    async UpdateLLM(LLM) {
        return this.apiCall("PUT", "User", "LLM", null, LLM); // LLM
   }
    
    
        
    
    async DeleteLLM(id) { 
        return this.apiCall("DELETE", "User", "LLM", null, id); // LLM
   }
    
    
}

export default new UserService();                        