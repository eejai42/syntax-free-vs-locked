
import BaseService from './BaseService';

class UserService extends BaseService {
    
        
    
    async AddPromptInputAnswerKey(PromptInputAnswerKey) { 
        return this.apiCall("POST", "User", "PromptInputAnswerKey", null, PromptInputAnswerKey); // PromptInputAnswerKey
   }
    
    
        
    
    async GetPromptInputAnswerKeies(view) { 
        return this.apiCall("GET", "User", "PromptInputAnswerKeies", view, null); // PromptInputAnswerKey
   }
    
    
        
    
    async UpdatePromptInputAnswerKey(PromptInputAnswerKey) {
        return this.apiCall("PUT", "User", "PromptInputAnswerKey", null, PromptInputAnswerKey); // PromptInputAnswerKey
   }
    
    
        
    
    async DeletePromptInputAnswerKey(id) { 
        return this.apiCall("DELETE", "User", "PromptInputAnswerKey", null, id); // PromptInputAnswerKey
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
    
    
        
    
    async AddMOFNode(MOFNode) { 
        return this.apiCall("POST", "User", "MOFNode", null, MOFNode); // MOFNode
   }
    
    
        
    
    async GetMOFNodes(view) { 
        return this.apiCall("GET", "User", "MOFNodes", view, null); // MOFNode
   }
    
    
        
    
    async UpdateMOFNode(MOFNode) {
        return this.apiCall("PUT", "User", "MOFNode", null, MOFNode); // MOFNode
   }
    
    
        
    
    async DeleteMOFNode(id) { 
        return this.apiCall("DELETE", "User", "MOFNode", null, id); // MOFNode
   }
    
    
        
    
    async AddMOFChoice(MOFChoice) { 
        return this.apiCall("POST", "User", "MOFChoice", null, MOFChoice); // MOFChoice
   }
    
    
        
    
    async GetMOFChoices(view) { 
        return this.apiCall("GET", "User", "MOFChoices", view, null); // MOFChoice
   }
    
    
        
    
    async UpdateMOFChoice(MOFChoice) {
        return this.apiCall("PUT", "User", "MOFChoice", null, MOFChoice); // MOFChoice
   }
    
    
        
    
    async DeleteMOFChoice(id) { 
        return this.apiCall("DELETE", "User", "MOFChoice", null, id); // MOFChoice
   }
    
    
        
    
    async AddDataFormat(DataFormat) { 
        return this.apiCall("POST", "User", "DataFormat", null, DataFormat); // DataFormat
   }
    
    
        
    
    async GetDataFormats(view) { 
        return this.apiCall("GET", "User", "DataFormats", view, null); // DataFormat
   }
    
    
        
    
    async UpdateDataFormat(DataFormat) {
        return this.apiCall("PUT", "User", "DataFormat", null, DataFormat); // DataFormat
   }
    
    
        
    
    async DeleteDataFormat(id) { 
        return this.apiCall("DELETE", "User", "DataFormat", null, id); // DataFormat
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
    
    
        
    
    async AddMOFLayer(MOFLayer) { 
        return this.apiCall("POST", "User", "MOFLayer", null, MOFLayer); // MOFLayer
   }
    
    
        
    
    async GetMOFLayers(view) { 
        return this.apiCall("GET", "User", "MOFLayers", view, null); // MOFLayer
   }
    
    
        
    
    async UpdateMOFLayer(MOFLayer) {
        return this.apiCall("PUT", "User", "MOFLayer", null, MOFLayer); // MOFLayer
   }
    
    
        
    
    async DeleteMOFLayer(id) { 
        return this.apiCall("DELETE", "User", "MOFLayer", null, id); // MOFLayer
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
    
    
        
    
    async AddOutputFormatRequest(OutputFormatRequest) { 
        return this.apiCall("POST", "User", "OutputFormatRequest", null, OutputFormatRequest); // OutputFormatRequest
   }
    
    
        
    
    async GetOutputFormatRequests(view) { 
        return this.apiCall("GET", "User", "OutputFormatRequests", view, null); // OutputFormatRequest
   }
    
    
        
    
    async UpdateOutputFormatRequest(OutputFormatRequest) {
        return this.apiCall("PUT", "User", "OutputFormatRequest", null, OutputFormatRequest); // OutputFormatRequest
   }
    
    
        
    
    async DeleteOutputFormatRequest(id) { 
        return this.apiCall("DELETE", "User", "OutputFormatRequest", null, id); // OutputFormatRequest
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