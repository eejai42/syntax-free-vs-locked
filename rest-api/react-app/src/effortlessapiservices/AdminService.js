
import BaseService from './BaseService';

class AdminService extends BaseService {
    
        
    
    async AddPromptInputAnswerKey(PromptInputAnswerKey) { 
        return this.apiCall("POST", "Admin", "PromptInputAnswerKey", null, PromptInputAnswerKey); // PromptInputAnswerKey
   }
    
    
        
    
    async GetPromptInputAnswerKeies(view) { 
        return this.apiCall("GET", "Admin", "PromptInputAnswerKeies", view, null); // PromptInputAnswerKey
   }
    
    
        
    
    async UpdatePromptInputAnswerKey(PromptInputAnswerKey) {
        return this.apiCall("PUT", "Admin", "PromptInputAnswerKey", null, PromptInputAnswerKey); // PromptInputAnswerKey
   }
    
    
        
    
    async DeletePromptInputAnswerKey(id) { 
        return this.apiCall("DELETE", "Admin", "PromptInputAnswerKey", null, id); // PromptInputAnswerKey
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
    
    
        
    
    async AddMOFNode(MOFNode) { 
        return this.apiCall("POST", "Admin", "MOFNode", null, MOFNode); // MOFNode
   }
    
    
        
    
    async GetMOFNodes(view) { 
        return this.apiCall("GET", "Admin", "MOFNodes", view, null); // MOFNode
   }
    
    
        
    
    async UpdateMOFNode(MOFNode) {
        return this.apiCall("PUT", "Admin", "MOFNode", null, MOFNode); // MOFNode
   }
    
    
        
    
    async DeleteMOFNode(id) { 
        return this.apiCall("DELETE", "Admin", "MOFNode", null, id); // MOFNode
   }
    
    
        
    
    async AddMOFChoice(MOFChoice) { 
        return this.apiCall("POST", "Admin", "MOFChoice", null, MOFChoice); // MOFChoice
   }
    
    
        
    
    async GetMOFChoices(view) { 
        return this.apiCall("GET", "Admin", "MOFChoices", view, null); // MOFChoice
   }
    
    
        
    
    async UpdateMOFChoice(MOFChoice) {
        return this.apiCall("PUT", "Admin", "MOFChoice", null, MOFChoice); // MOFChoice
   }
    
    
        
    
    async DeleteMOFChoice(id) { 
        return this.apiCall("DELETE", "Admin", "MOFChoice", null, id); // MOFChoice
   }
    
    
        
    
    async AddDataFormat(DataFormat) { 
        return this.apiCall("POST", "Admin", "DataFormat", null, DataFormat); // DataFormat
   }
    
    
        
    
    async GetDataFormats(view) { 
        return this.apiCall("GET", "Admin", "DataFormats", view, null); // DataFormat
   }
    
    
        
    
    async UpdateDataFormat(DataFormat) {
        return this.apiCall("PUT", "Admin", "DataFormat", null, DataFormat); // DataFormat
   }
    
    
        
    
    async DeleteDataFormat(id) { 
        return this.apiCall("DELETE", "Admin", "DataFormat", null, id); // DataFormat
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
    
    
        
    
    async AddMOFLayer(MOFLayer) { 
        return this.apiCall("POST", "Admin", "MOFLayer", null, MOFLayer); // MOFLayer
   }
    
    
        
    
    async GetMOFLayers(view) { 
        return this.apiCall("GET", "Admin", "MOFLayers", view, null); // MOFLayer
   }
    
    
        
    
    async UpdateMOFLayer(MOFLayer) {
        return this.apiCall("PUT", "Admin", "MOFLayer", null, MOFLayer); // MOFLayer
   }
    
    
        
    
    async DeleteMOFLayer(id) { 
        return this.apiCall("DELETE", "Admin", "MOFLayer", null, id); // MOFLayer
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
    
    
        
    
    async AddOutputFormatRequest(OutputFormatRequest) { 
        return this.apiCall("POST", "Admin", "OutputFormatRequest", null, OutputFormatRequest); // OutputFormatRequest
   }
    
    
        
    
    async GetOutputFormatRequests(view) { 
        return this.apiCall("GET", "Admin", "OutputFormatRequests", view, null); // OutputFormatRequest
   }
    
    
        
    
    async UpdateOutputFormatRequest(OutputFormatRequest) {
        return this.apiCall("PUT", "Admin", "OutputFormatRequest", null, OutputFormatRequest); // OutputFormatRequest
   }
    
    
        
    
    async DeleteOutputFormatRequest(id) { 
        return this.apiCall("DELETE", "Admin", "OutputFormatRequest", null, id); // OutputFormatRequest
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