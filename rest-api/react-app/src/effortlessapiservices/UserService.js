
import BaseService from './BaseService';

class UserService extends BaseService {
    
        
    
    async AddIdeaTransformer(IdeaTransformer) { 
        return this.apiCall("POST", "User", "IdeaTransformer", null, IdeaTransformer); // IdeaTransformer
   }
    
    
        
    
    async GetIdeaTransformers(view) { 
        return this.apiCall("GET", "User", "IdeaTransformers", view, null); // IdeaTransformer
   }
    
    
        
    
    async UpdateIdeaTransformer(IdeaTransformer) {
        return this.apiCall("PUT", "User", "IdeaTransformer", null, IdeaTransformer); // IdeaTransformer
   }
    
    
        
    
    async DeleteIdeaTransformer(id) { 
        return this.apiCall("DELETE", "User", "IdeaTransformer", null, id); // IdeaTransformer
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
    
    
        
    
    async AddIdeaFeature(IdeaFeature) { 
        return this.apiCall("POST", "User", "IdeaFeature", null, IdeaFeature); // IdeaFeature
   }
    
    
        
    
    async GetIdeaFeatures(view) { 
        return this.apiCall("GET", "User", "IdeaFeatures", view, null); // IdeaFeature
   }
    
    
        
    
    async UpdateIdeaFeature(IdeaFeature) {
        return this.apiCall("PUT", "User", "IdeaFeature", null, IdeaFeature); // IdeaFeature
   }
    
    
        
    
    async DeleteIdeaFeature(id) { 
        return this.apiCall("DELETE", "User", "IdeaFeature", null, id); // IdeaFeature
   }
    
    
        
    
    async AddTransformedArtifact(TransformedArtifact) { 
        return this.apiCall("POST", "User", "TransformedArtifact", null, TransformedArtifact); // TransformedArtifact
   }
    
    
        
    
    async GetTransformedArtifacts(view) { 
        return this.apiCall("GET", "User", "TransformedArtifacts", view, null); // TransformedArtifact
   }
    
    
        
    
    async UpdateTransformedArtifact(TransformedArtifact) {
        return this.apiCall("PUT", "User", "TransformedArtifact", null, TransformedArtifact); // TransformedArtifact
   }
    
    
        
    
    async DeleteTransformedArtifact(id) { 
        return this.apiCall("DELETE", "User", "TransformedArtifact", null, id); // TransformedArtifact
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
    
    
        
    
    async AddIdea(Idea) { 
        return this.apiCall("POST", "User", "Idea", null, Idea); // Idea
   }
    
    
        
    
    async GetIdeas(view) { 
        return this.apiCall("GET", "User", "Ideas", view, null); // Idea
   }
    
    
        
    
    async UpdateIdea(Idea) {
        return this.apiCall("PUT", "User", "Idea", null, Idea); // Idea
   }
    
    
        
    
    async DeleteIdea(id) { 
        return this.apiCall("DELETE", "User", "Idea", null, id); // Idea
   }
    
    
}

export default new UserService();                        