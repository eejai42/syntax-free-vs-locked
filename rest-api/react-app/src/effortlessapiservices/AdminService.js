
import BaseService from './BaseService';

class AdminService extends BaseService {
    
        
    
    async AddTrialArtifact(TrialArtifact) { 
        return this.apiCall("POST", "Admin", "TrialArtifact", null, TrialArtifact); // TrialArtifact
   }
    
    
        
    
    async GetTrialArtifacts(view) { 
        return this.apiCall("GET", "Admin", "TrialArtifacts", view, null); // TrialArtifact
   }
    
    
        
    
    async UpdateTrialArtifact(TrialArtifact) {
        return this.apiCall("PUT", "Admin", "TrialArtifact", null, TrialArtifact); // TrialArtifact
   }
    
    
        
    
    async DeleteTrialArtifact(id) { 
        return this.apiCall("DELETE", "Admin", "TrialArtifact", null, id); // TrialArtifact
   }
    
    
        
    
    async AddArtifactAnalysis(ArtifactAnalysis) { 
        return this.apiCall("POST", "Admin", "ArtifactAnalysis", null, ArtifactAnalysis); // ArtifactAnalysis
   }
    
    
        
    
    async GetArtifactAnalyses(view) { 
        return this.apiCall("GET", "Admin", "ArtifactAnalyses", view, null); // ArtifactAnalysis
   }
    
    
        
    
    async UpdateArtifactAnalysis(ArtifactAnalysis) {
        return this.apiCall("PUT", "Admin", "ArtifactAnalysis", null, ArtifactAnalysis); // ArtifactAnalysis
   }
    
    
        
    
    async DeleteArtifactAnalysis(id) { 
        return this.apiCall("DELETE", "Admin", "ArtifactAnalysis", null, id); // ArtifactAnalysis
   }
    
    
        
    
    async AddAppUser(AppUser) { 
        return this.apiCall("POST", "Admin", "AppUser", null, AppUser); // AppUser
   }
    
    
        
    
    async GetAppUsers(view) { 
        return this.apiCall("GET", "Admin", "AppUsers", view, null); // AppUser
   }
    
    
        
    
    async UpdateAppUser(AppUser) {
        return this.apiCall("PUT", "Admin", "AppUser", null, AppUser); // AppUser
   }
    
    
        
    
    async DeleteAppUser(id) { 
        return this.apiCall("DELETE", "Admin", "AppUser", null, id); // AppUser
   }
    
    
        
    
    async AddGenerationTransformer(GenerationTransformer) { 
        return this.apiCall("POST", "Admin", "GenerationTransformer", null, GenerationTransformer); // GenerationTransformer
   }
    
    
        
    
    async GetGenerationTransformers(view) { 
        return this.apiCall("GET", "Admin", "GenerationTransformers", view, null); // GenerationTransformer
   }
    
    
        
    
    async UpdateGenerationTransformer(GenerationTransformer) {
        return this.apiCall("PUT", "Admin", "GenerationTransformer", null, GenerationTransformer); // GenerationTransformer
   }
    
    
        
    
    async DeleteGenerationTransformer(id) { 
        return this.apiCall("DELETE", "Admin", "GenerationTransformer", null, id); // GenerationTransformer
   }
    
    
        
    
    async AddGeneration(Generation) { 
        return this.apiCall("POST", "Admin", "Generation", null, Generation); // Generation
   }
    
    
        
    
    async GetGenerations(view) { 
        return this.apiCall("GET", "Admin", "Generations", view, null); // Generation
   }
    
    
        
    
    async UpdateGeneration(Generation) {
        return this.apiCall("PUT", "Admin", "Generation", null, Generation); // Generation
   }
    
    
        
    
    async DeleteGeneration(id) { 
        return this.apiCall("DELETE", "Admin", "Generation", null, id); // Generation
   }
    
    
        
    
    async AddTrial(Trial) { 
        return this.apiCall("POST", "Admin", "Trial", null, Trial); // Trial
   }
    
    
        
    
    async GetTrials(view) { 
        return this.apiCall("GET", "Admin", "Trials", view, null); // Trial
   }
    
    
        
    
    async UpdateTrial(Trial) {
        return this.apiCall("PUT", "Admin", "Trial", null, Trial); // Trial
   }
    
    
        
    
    async DeleteTrial(id) { 
        return this.apiCall("DELETE", "Admin", "Trial", null, id); // Trial
   }
    
    
        
    
    async AddExperimentTransformer(ExperimentTransformer) { 
        return this.apiCall("POST", "Admin", "ExperimentTransformer", null, ExperimentTransformer); // ExperimentTransformer
   }
    
    
        
    
    async GetExperimentTransformers(view) { 
        return this.apiCall("GET", "Admin", "ExperimentTransformers", view, null); // ExperimentTransformer
   }
    
    
        
    
    async UpdateExperimentTransformer(ExperimentTransformer) {
        return this.apiCall("PUT", "Admin", "ExperimentTransformer", null, ExperimentTransformer); // ExperimentTransformer
   }
    
    
        
    
    async DeleteExperimentTransformer(id) { 
        return this.apiCall("DELETE", "Admin", "ExperimentTransformer", null, id); // ExperimentTransformer
   }
    
    
        
    
    async AddExperimentFeature(ExperimentFeature) { 
        return this.apiCall("POST", "Admin", "ExperimentFeature", null, ExperimentFeature); // ExperimentFeature
   }
    
    
        
    
    async GetExperimentFeatures(view) { 
        return this.apiCall("GET", "Admin", "ExperimentFeatures", view, null); // ExperimentFeature
   }
    
    
        
    
    async UpdateExperimentFeature(ExperimentFeature) {
        return this.apiCall("PUT", "Admin", "ExperimentFeature", null, ExperimentFeature); // ExperimentFeature
   }
    
    
        
    
    async DeleteExperimentFeature(id) { 
        return this.apiCall("DELETE", "Admin", "ExperimentFeature", null, id); // ExperimentFeature
   }
    
    
        
    
    async AddDesignDecision(DesignDecision) { 
        return this.apiCall("POST", "Admin", "DesignDecision", null, DesignDecision); // DesignDecision
   }
    
    
        
    
    async GetDesignDecisions(view) { 
        return this.apiCall("GET", "Admin", "DesignDecisions", view, null); // DesignDecision
   }
    
    
        
    
    async UpdateDesignDecision(DesignDecision) {
        return this.apiCall("PUT", "Admin", "DesignDecision", null, DesignDecision); // DesignDecision
   }
    
    
        
    
    async DeleteDesignDecision(id) { 
        return this.apiCall("DELETE", "Admin", "DesignDecision", null, id); // DesignDecision
   }
    
    
        
    
    async AddExperiment(Experiment) { 
        return this.apiCall("POST", "Admin", "Experiment", null, Experiment); // Experiment
   }
    
    
        
    
    async GetExperiments(view) { 
        return this.apiCall("GET", "Admin", "Experiments", view, null); // Experiment
   }
    
    
        
    
    async UpdateExperiment(Experiment) {
        return this.apiCall("PUT", "Admin", "Experiment", null, Experiment); // Experiment
   }
    
    
        
    
    async DeleteExperiment(id) { 
        return this.apiCall("DELETE", "Admin", "Experiment", null, id); // Experiment
   }
    
    
        
    
    async AddLLM(LLM) { 
        return this.apiCall("POST", "Admin", "LLM", null, LLM); // LLM
   }
    
    
        
    
    async GetLLMs(view) { 
        return this.apiCall("GET", "Admin", "LLMs", view, null); // LLM
   }
    
    
        
    
    async UpdateLLM(LLM) {
        return this.apiCall("PUT", "Admin", "LLM", null, LLM); // LLM
   }
    
    
        
    
    async DeleteLLM(id) { 
        return this.apiCall("DELETE", "Admin", "LLM", null, id); // LLM
   }
    
    
}

export default new AdminService();                        