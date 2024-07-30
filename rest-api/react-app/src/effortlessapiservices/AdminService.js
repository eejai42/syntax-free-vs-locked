
import BaseService from './BaseService';

class AdminService extends BaseService {
    
        
    
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
    
    
        
    
    async AddIdeaTransformer(IdeaTransformer) { 
        return this.apiCall("POST", "Admin", "IdeaTransformer", null, IdeaTransformer); // IdeaTransformer
   }
    
    
        
    
    async GetIdeaTransformers(view) { 
        return this.apiCall("GET", "Admin", "IdeaTransformers", view, null); // IdeaTransformer
   }
    
    
        
    
    async UpdateIdeaTransformer(IdeaTransformer) {
        return this.apiCall("PUT", "Admin", "IdeaTransformer", null, IdeaTransformer); // IdeaTransformer
   }
    
    
        
    
    async DeleteIdeaTransformer(id) { 
        return this.apiCall("DELETE", "Admin", "IdeaTransformer", null, id); // IdeaTransformer
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
    
    
        
    
    async AddIdeaFeature(IdeaFeature) { 
        return this.apiCall("POST", "Admin", "IdeaFeature", null, IdeaFeature); // IdeaFeature
   }
    
    
        
    
    async GetIdeaFeatures(view) { 
        return this.apiCall("GET", "Admin", "IdeaFeatures", view, null); // IdeaFeature
   }
    
    
        
    
    async UpdateIdeaFeature(IdeaFeature) {
        return this.apiCall("PUT", "Admin", "IdeaFeature", null, IdeaFeature); // IdeaFeature
   }
    
    
        
    
    async DeleteIdeaFeature(id) { 
        return this.apiCall("DELETE", "Admin", "IdeaFeature", null, id); // IdeaFeature
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
    
    
        
    
    async AddTransformedArtifact(TransformedArtifact) { 
        return this.apiCall("POST", "Admin", "TransformedArtifact", null, TransformedArtifact); // TransformedArtifact
   }
    
    
        
    
    async GetTransformedArtifacts(view) { 
        return this.apiCall("GET", "Admin", "TransformedArtifacts", view, null); // TransformedArtifact
   }
    
    
        
    
    async UpdateTransformedArtifact(TransformedArtifact) {
        return this.apiCall("PUT", "Admin", "TransformedArtifact", null, TransformedArtifact); // TransformedArtifact
   }
    
    
        
    
    async DeleteTransformedArtifact(id) { 
        return this.apiCall("DELETE", "Admin", "TransformedArtifact", null, id); // TransformedArtifact
   }
    
    
        
    
    async AddIdea(Idea) { 
        return this.apiCall("POST", "Admin", "Idea", null, Idea); // Idea
   }
    
    
        
    
    async GetIdeas(view) { 
        return this.apiCall("GET", "Admin", "Ideas", view, null); // Idea
   }
    
    
        
    
    async UpdateIdea(Idea) {
        return this.apiCall("PUT", "Admin", "Idea", null, Idea); // Idea
   }
    
    
        
    
    async DeleteIdea(id) { 
        return this.apiCall("DELETE", "Admin", "Idea", null, id); // Idea
   }
    
    
}

export default new AdminService();                        