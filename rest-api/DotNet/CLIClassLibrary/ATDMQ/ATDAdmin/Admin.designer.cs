using AirtableDirect.CLI.Lib.DataClasses;
using AirtableToDotNet.APIWrapper;
using System;
using System.Linq;
using System.Collections.Generic;
using YP.SassyMQ.Lib.RabbitMQ;
using System.Security.Claims;

namespace CLIClassLibrary.ATDMQ
{
	public partial class ATDAdmin : ATDActorBase
    {
       public ClaimsIdentity UserIdentity { get; set; } // IsUpdate: false
       public AppUser AddAppUser(StandardPayload Payload) {
			
				AirtableDirectCLIAirtableAPIWrapper api = new AirtableDirectCLIAirtableAPIWrapper(Payload.ApiKey, Payload.BaseId);
				return api.Insert(Payload.AppUser.AdminCleanForAdd());
			}        
        private string WrapAdminAddAppUserWhere(string airtableWhere)
        {
                
        
        
            // AirtableWhere: 
            return airtableWhere; 
        }

      
 // IsUpdate: false
       public IEnumerable<AppUser> GetAppUsers(StandardPayload Payload) {
			
				AirtableDirectCLIAirtableAPIWrapper api = new AirtableDirectCLIAirtableAPIWrapper(Payload.ApiKey, Payload.BaseId);
				return api.GetAppUsers(WrapAdminGetAppUsersWhere(Payload.AirtableWhere), Payload.View, Payload.MaxPages).AdminCleanForGet();
			}        
        private string WrapAdminGetAppUsersWhere(string airtableWhere)
        {
                
        
        
            // AirtableWhere: 
            return airtableWhere; 
        }

      
 // IsUpdate: true
       public IEnumerable<AppUser> UpdateAppUser(StandardPayload Payload) {
			
				AirtableDirectCLIAirtableAPIWrapper api = new AirtableDirectCLIAirtableAPIWrapper(Payload.ApiKey, Payload.BaseId);
				
          if (!(Payload.AppUsers is null))
          {
              return this.UpdateAppUsers(api, Payload);
          }
          else
          {
              var updatedAppUser = api.Update(Payload.AppUser.AdminCleanForUpdate());
              return new List<AppUser>(new AppUser[] { updatedAppUser });
          }
        
			}        
        private string WrapAdminUpdateAppUserWhere(string airtableWhere)
        {
                
        
        
            // AirtableWhere: 
            return airtableWhere; 
        }

              
        private List<AppUser> UpdateAppUsers(AirtableDirectCLIAirtableAPIWrapper api, StandardPayload payload)
        {
            if (!(payload.AppUsers is null) && payload.AppUsers.Any())
            {
                var updatedItems = new List<AppUser>();
                payload.AppUsers.ForEach(item =>
                {
                    var updatedAppUsers = api.Update(item);
                    updatedItems.Add(updatedAppUsers);
                });
                return updatedItems;
            }
            else throw new Exception("Payload.Product or Payload.Products required to update products");
        }
      
 // IsUpdate: false
       public void DeleteAppUser(StandardPayload Payload) {
			
				AirtableDirectCLIAirtableAPIWrapper api = new AirtableDirectCLIAirtableAPIWrapper(Payload.ApiKey, Payload.BaseId);
				api.Delete(Payload.AppUser);
			}        
        private string WrapAdminDeleteAppUserWhere(string airtableWhere)
        {
                
        
        
            // AirtableWhere: 
            return airtableWhere; 
        }

      
 // IsUpdate: false
       public GenerationTransformer AddGenerationTransformer(StandardPayload Payload) {
			
				AirtableDirectCLIAirtableAPIWrapper api = new AirtableDirectCLIAirtableAPIWrapper(Payload.ApiKey, Payload.BaseId);
				return api.Insert(Payload.GenerationTransformer.AdminCleanForAdd());
			}        
        private string WrapAdminAddGenerationTransformerWhere(string airtableWhere)
        {
                
        
        
            // AirtableWhere: 
            return airtableWhere; 
        }

      
 // IsUpdate: false
       public IEnumerable<GenerationTransformer> GetGenerationTransformers(StandardPayload Payload) {
			
				AirtableDirectCLIAirtableAPIWrapper api = new AirtableDirectCLIAirtableAPIWrapper(Payload.ApiKey, Payload.BaseId);
				return api.GetGenerationTransformers(WrapAdminGetGenerationTransformersWhere(Payload.AirtableWhere), Payload.View, Payload.MaxPages).AdminCleanForGet();
			}        
        private string WrapAdminGetGenerationTransformersWhere(string airtableWhere)
        {
                
        
        
            // AirtableWhere: 
            return airtableWhere; 
        }

      
 // IsUpdate: true
       public IEnumerable<GenerationTransformer> UpdateGenerationTransformer(StandardPayload Payload) {
			
				AirtableDirectCLIAirtableAPIWrapper api = new AirtableDirectCLIAirtableAPIWrapper(Payload.ApiKey, Payload.BaseId);
				
          if (!(Payload.GenerationTransformers is null))
          {
              return this.UpdateGenerationTransformers(api, Payload);
          }
          else
          {
              var updatedGenerationTransformer = api.Update(Payload.GenerationTransformer.AdminCleanForUpdate());
              return new List<GenerationTransformer>(new GenerationTransformer[] { updatedGenerationTransformer });
          }
        
			}        
        private string WrapAdminUpdateGenerationTransformerWhere(string airtableWhere)
        {
                
        
        
            // AirtableWhere: 
            return airtableWhere; 
        }

              
        private List<GenerationTransformer> UpdateGenerationTransformers(AirtableDirectCLIAirtableAPIWrapper api, StandardPayload payload)
        {
            if (!(payload.GenerationTransformers is null) && payload.GenerationTransformers.Any())
            {
                var updatedItems = new List<GenerationTransformer>();
                payload.GenerationTransformers.ForEach(item =>
                {
                    var updatedGenerationTransformers = api.Update(item);
                    updatedItems.Add(updatedGenerationTransformers);
                });
                return updatedItems;
            }
            else throw new Exception("Payload.Product or Payload.Products required to update products");
        }
      
 // IsUpdate: false
       public void DeleteGenerationTransformer(StandardPayload Payload) {
			
				AirtableDirectCLIAirtableAPIWrapper api = new AirtableDirectCLIAirtableAPIWrapper(Payload.ApiKey, Payload.BaseId);
				api.Delete(Payload.GenerationTransformer);
			}        
        private string WrapAdminDeleteGenerationTransformerWhere(string airtableWhere)
        {
                
        
        
            // AirtableWhere: 
            return airtableWhere; 
        }

      
 // IsUpdate: false
       public Generation AddGeneration(StandardPayload Payload) {
			
				AirtableDirectCLIAirtableAPIWrapper api = new AirtableDirectCLIAirtableAPIWrapper(Payload.ApiKey, Payload.BaseId);
				return api.Insert(Payload.Generation.AdminCleanForAdd());
			}        
        private string WrapAdminAddGenerationWhere(string airtableWhere)
        {
                
        
        
            // AirtableWhere: 
            return airtableWhere; 
        }

      
 // IsUpdate: false
       public IEnumerable<Generation> GetGenerations(StandardPayload Payload) {
			
				AirtableDirectCLIAirtableAPIWrapper api = new AirtableDirectCLIAirtableAPIWrapper(Payload.ApiKey, Payload.BaseId);
				return api.GetGenerations(WrapAdminGetGenerationsWhere(Payload.AirtableWhere), Payload.View, Payload.MaxPages).AdminCleanForGet();
			}        
        private string WrapAdminGetGenerationsWhere(string airtableWhere)
        {
                
        
        
            // AirtableWhere: 
            return airtableWhere; 
        }

      
 // IsUpdate: true
       public IEnumerable<Generation> UpdateGeneration(StandardPayload Payload) {
			
				AirtableDirectCLIAirtableAPIWrapper api = new AirtableDirectCLIAirtableAPIWrapper(Payload.ApiKey, Payload.BaseId);
				
          if (!(Payload.Generations is null))
          {
              return this.UpdateGenerations(api, Payload);
          }
          else
          {
              var updatedGeneration = api.Update(Payload.Generation.AdminCleanForUpdate());
              return new List<Generation>(new Generation[] { updatedGeneration });
          }
        
			}        
        private string WrapAdminUpdateGenerationWhere(string airtableWhere)
        {
                
        
        
            // AirtableWhere: 
            return airtableWhere; 
        }

              
        private List<Generation> UpdateGenerations(AirtableDirectCLIAirtableAPIWrapper api, StandardPayload payload)
        {
            if (!(payload.Generations is null) && payload.Generations.Any())
            {
                var updatedItems = new List<Generation>();
                payload.Generations.ForEach(item =>
                {
                    var updatedGenerations = api.Update(item);
                    updatedItems.Add(updatedGenerations);
                });
                return updatedItems;
            }
            else throw new Exception("Payload.Product or Payload.Products required to update products");
        }
      
 // IsUpdate: false
       public void DeleteGeneration(StandardPayload Payload) {
			
				AirtableDirectCLIAirtableAPIWrapper api = new AirtableDirectCLIAirtableAPIWrapper(Payload.ApiKey, Payload.BaseId);
				api.Delete(Payload.Generation);
			}        
        private string WrapAdminDeleteGenerationWhere(string airtableWhere)
        {
                
        
        
            // AirtableWhere: 
            return airtableWhere; 
        }

      
 // IsUpdate: false
       public ExperimentTransformer AddExperimentTransformer(StandardPayload Payload) {
			
				AirtableDirectCLIAirtableAPIWrapper api = new AirtableDirectCLIAirtableAPIWrapper(Payload.ApiKey, Payload.BaseId);
				return api.Insert(Payload.ExperimentTransformer.AdminCleanForAdd());
			}        
        private string WrapAdminAddExperimentTransformerWhere(string airtableWhere)
        {
                
        
        
            // AirtableWhere: 
            return airtableWhere; 
        }

      
 // IsUpdate: false
       public IEnumerable<ExperimentTransformer> GetExperimentTransformers(StandardPayload Payload) {
			
				AirtableDirectCLIAirtableAPIWrapper api = new AirtableDirectCLIAirtableAPIWrapper(Payload.ApiKey, Payload.BaseId);
				return api.GetExperimentTransformers(WrapAdminGetExperimentTransformersWhere(Payload.AirtableWhere), Payload.View, Payload.MaxPages).AdminCleanForGet();
			}        
        private string WrapAdminGetExperimentTransformersWhere(string airtableWhere)
        {
                
        
        
            // AirtableWhere: 
            return airtableWhere; 
        }

      
 // IsUpdate: true
       public IEnumerable<ExperimentTransformer> UpdateExperimentTransformer(StandardPayload Payload) {
			
				AirtableDirectCLIAirtableAPIWrapper api = new AirtableDirectCLIAirtableAPIWrapper(Payload.ApiKey, Payload.BaseId);
				
          if (!(Payload.ExperimentTransformers is null))
          {
              return this.UpdateExperimentTransformers(api, Payload);
          }
          else
          {
              var updatedExperimentTransformer = api.Update(Payload.ExperimentTransformer.AdminCleanForUpdate());
              return new List<ExperimentTransformer>(new ExperimentTransformer[] { updatedExperimentTransformer });
          }
        
			}        
        private string WrapAdminUpdateExperimentTransformerWhere(string airtableWhere)
        {
                
        
        
            // AirtableWhere: 
            return airtableWhere; 
        }

              
        private List<ExperimentTransformer> UpdateExperimentTransformers(AirtableDirectCLIAirtableAPIWrapper api, StandardPayload payload)
        {
            if (!(payload.ExperimentTransformers is null) && payload.ExperimentTransformers.Any())
            {
                var updatedItems = new List<ExperimentTransformer>();
                payload.ExperimentTransformers.ForEach(item =>
                {
                    var updatedExperimentTransformers = api.Update(item);
                    updatedItems.Add(updatedExperimentTransformers);
                });
                return updatedItems;
            }
            else throw new Exception("Payload.Product or Payload.Products required to update products");
        }
      
 // IsUpdate: false
       public void DeleteExperimentTransformer(StandardPayload Payload) {
			
				AirtableDirectCLIAirtableAPIWrapper api = new AirtableDirectCLIAirtableAPIWrapper(Payload.ApiKey, Payload.BaseId);
				api.Delete(Payload.ExperimentTransformer);
			}        
        private string WrapAdminDeleteExperimentTransformerWhere(string airtableWhere)
        {
                
        
        
            // AirtableWhere: 
            return airtableWhere; 
        }

      
 // IsUpdate: false
       public ExperimentFeature AddExperimentFeature(StandardPayload Payload) {
			
				AirtableDirectCLIAirtableAPIWrapper api = new AirtableDirectCLIAirtableAPIWrapper(Payload.ApiKey, Payload.BaseId);
				return api.Insert(Payload.ExperimentFeature.AdminCleanForAdd());
			}        
        private string WrapAdminAddExperimentFeatureWhere(string airtableWhere)
        {
                
        
        
            // AirtableWhere: 
            return airtableWhere; 
        }

      
 // IsUpdate: false
       public IEnumerable<ExperimentFeature> GetExperimentFeatures(StandardPayload Payload) {
			
				AirtableDirectCLIAirtableAPIWrapper api = new AirtableDirectCLIAirtableAPIWrapper(Payload.ApiKey, Payload.BaseId);
				return api.GetExperimentFeatures(WrapAdminGetExperimentFeaturesWhere(Payload.AirtableWhere), Payload.View, Payload.MaxPages).AdminCleanForGet();
			}        
        private string WrapAdminGetExperimentFeaturesWhere(string airtableWhere)
        {
                
        
        
            // AirtableWhere: 
            return airtableWhere; 
        }

      
 // IsUpdate: true
       public IEnumerable<ExperimentFeature> UpdateExperimentFeature(StandardPayload Payload) {
			
				AirtableDirectCLIAirtableAPIWrapper api = new AirtableDirectCLIAirtableAPIWrapper(Payload.ApiKey, Payload.BaseId);
				
          if (!(Payload.ExperimentFeatures is null))
          {
              return this.UpdateExperimentFeatures(api, Payload);
          }
          else
          {
              var updatedExperimentFeature = api.Update(Payload.ExperimentFeature.AdminCleanForUpdate());
              return new List<ExperimentFeature>(new ExperimentFeature[] { updatedExperimentFeature });
          }
        
			}        
        private string WrapAdminUpdateExperimentFeatureWhere(string airtableWhere)
        {
                
        
        
            // AirtableWhere: 
            return airtableWhere; 
        }

              
        private List<ExperimentFeature> UpdateExperimentFeatures(AirtableDirectCLIAirtableAPIWrapper api, StandardPayload payload)
        {
            if (!(payload.ExperimentFeatures is null) && payload.ExperimentFeatures.Any())
            {
                var updatedItems = new List<ExperimentFeature>();
                payload.ExperimentFeatures.ForEach(item =>
                {
                    var updatedExperimentFeatures = api.Update(item);
                    updatedItems.Add(updatedExperimentFeatures);
                });
                return updatedItems;
            }
            else throw new Exception("Payload.Product or Payload.Products required to update products");
        }
      
 // IsUpdate: false
       public void DeleteExperimentFeature(StandardPayload Payload) {
			
				AirtableDirectCLIAirtableAPIWrapper api = new AirtableDirectCLIAirtableAPIWrapper(Payload.ApiKey, Payload.BaseId);
				api.Delete(Payload.ExperimentFeature);
			}        
        private string WrapAdminDeleteExperimentFeatureWhere(string airtableWhere)
        {
                
        
        
            // AirtableWhere: 
            return airtableWhere; 
        }

      
 // IsUpdate: false
       public TransformedArtifact AddTransformedArtifact(StandardPayload Payload) {
			
				AirtableDirectCLIAirtableAPIWrapper api = new AirtableDirectCLIAirtableAPIWrapper(Payload.ApiKey, Payload.BaseId);
				return api.Insert(Payload.TransformedArtifact.AdminCleanForAdd());
			}        
        private string WrapAdminAddTransformedArtifactWhere(string airtableWhere)
        {
                
        
        
            // AirtableWhere: 
            return airtableWhere; 
        }

      
 // IsUpdate: false
       public IEnumerable<TransformedArtifact> GetTransformedArtifacts(StandardPayload Payload) {
			
				AirtableDirectCLIAirtableAPIWrapper api = new AirtableDirectCLIAirtableAPIWrapper(Payload.ApiKey, Payload.BaseId);
				return api.GetTransformedArtifacts(WrapAdminGetTransformedArtifactsWhere(Payload.AirtableWhere), Payload.View, Payload.MaxPages).AdminCleanForGet();
			}        
        private string WrapAdminGetTransformedArtifactsWhere(string airtableWhere)
        {
                
        
        
            // AirtableWhere: 
            return airtableWhere; 
        }

      
 // IsUpdate: true
       public IEnumerable<TransformedArtifact> UpdateTransformedArtifact(StandardPayload Payload) {
			
				AirtableDirectCLIAirtableAPIWrapper api = new AirtableDirectCLIAirtableAPIWrapper(Payload.ApiKey, Payload.BaseId);
				
          if (!(Payload.TransformedArtifacts is null))
          {
              return this.UpdateTransformedArtifacts(api, Payload);
          }
          else
          {
              var updatedTransformedArtifact = api.Update(Payload.TransformedArtifact.AdminCleanForUpdate());
              return new List<TransformedArtifact>(new TransformedArtifact[] { updatedTransformedArtifact });
          }
        
			}        
        private string WrapAdminUpdateTransformedArtifactWhere(string airtableWhere)
        {
                
        
        
            // AirtableWhere: 
            return airtableWhere; 
        }

              
        private List<TransformedArtifact> UpdateTransformedArtifacts(AirtableDirectCLIAirtableAPIWrapper api, StandardPayload payload)
        {
            if (!(payload.TransformedArtifacts is null) && payload.TransformedArtifacts.Any())
            {
                var updatedItems = new List<TransformedArtifact>();
                payload.TransformedArtifacts.ForEach(item =>
                {
                    var updatedTransformedArtifacts = api.Update(item);
                    updatedItems.Add(updatedTransformedArtifacts);
                });
                return updatedItems;
            }
            else throw new Exception("Payload.Product or Payload.Products required to update products");
        }
      
 // IsUpdate: false
       public void DeleteTransformedArtifact(StandardPayload Payload) {
			
				AirtableDirectCLIAirtableAPIWrapper api = new AirtableDirectCLIAirtableAPIWrapper(Payload.ApiKey, Payload.BaseId);
				api.Delete(Payload.TransformedArtifact);
			}        
        private string WrapAdminDeleteTransformedArtifactWhere(string airtableWhere)
        {
                
        
        
            // AirtableWhere: 
            return airtableWhere; 
        }

      
 // IsUpdate: false
       public DesignDecision AddDesignDecision(StandardPayload Payload) {
			
				AirtableDirectCLIAirtableAPIWrapper api = new AirtableDirectCLIAirtableAPIWrapper(Payload.ApiKey, Payload.BaseId);
				return api.Insert(Payload.DesignDecision.AdminCleanForAdd());
			}        
        private string WrapAdminAddDesignDecisionWhere(string airtableWhere)
        {
                
        
        
            // AirtableWhere: 
            return airtableWhere; 
        }

      
 // IsUpdate: false
       public IEnumerable<DesignDecision> GetDesignDecisions(StandardPayload Payload) {
			
				AirtableDirectCLIAirtableAPIWrapper api = new AirtableDirectCLIAirtableAPIWrapper(Payload.ApiKey, Payload.BaseId);
				return api.GetDesignDecisions(WrapAdminGetDesignDecisionsWhere(Payload.AirtableWhere), Payload.View, Payload.MaxPages).AdminCleanForGet();
			}        
        private string WrapAdminGetDesignDecisionsWhere(string airtableWhere)
        {
                
        
        
            // AirtableWhere: 
            return airtableWhere; 
        }

      
 // IsUpdate: true
       public IEnumerable<DesignDecision> UpdateDesignDecision(StandardPayload Payload) {
			
				AirtableDirectCLIAirtableAPIWrapper api = new AirtableDirectCLIAirtableAPIWrapper(Payload.ApiKey, Payload.BaseId);
				
          if (!(Payload.DesignDecisions is null))
          {
              return this.UpdateDesignDecisions(api, Payload);
          }
          else
          {
              var updatedDesignDecision = api.Update(Payload.DesignDecision.AdminCleanForUpdate());
              return new List<DesignDecision>(new DesignDecision[] { updatedDesignDecision });
          }
        
			}        
        private string WrapAdminUpdateDesignDecisionWhere(string airtableWhere)
        {
                
        
        
            // AirtableWhere: 
            return airtableWhere; 
        }

              
        private List<DesignDecision> UpdateDesignDecisions(AirtableDirectCLIAirtableAPIWrapper api, StandardPayload payload)
        {
            if (!(payload.DesignDecisions is null) && payload.DesignDecisions.Any())
            {
                var updatedItems = new List<DesignDecision>();
                payload.DesignDecisions.ForEach(item =>
                {
                    var updatedDesignDecisions = api.Update(item);
                    updatedItems.Add(updatedDesignDecisions);
                });
                return updatedItems;
            }
            else throw new Exception("Payload.Product or Payload.Products required to update products");
        }
      
 // IsUpdate: false
       public void DeleteDesignDecision(StandardPayload Payload) {
			
				AirtableDirectCLIAirtableAPIWrapper api = new AirtableDirectCLIAirtableAPIWrapper(Payload.ApiKey, Payload.BaseId);
				api.Delete(Payload.DesignDecision);
			}        
        private string WrapAdminDeleteDesignDecisionWhere(string airtableWhere)
        {
                
        
        
            // AirtableWhere: 
            return airtableWhere; 
        }

      
 // IsUpdate: false
       public Experiment AddExperiment(StandardPayload Payload) {
			
				AirtableDirectCLIAirtableAPIWrapper api = new AirtableDirectCLIAirtableAPIWrapper(Payload.ApiKey, Payload.BaseId);
				return api.Insert(Payload.Experiment.AdminCleanForAdd());
			}        
        private string WrapAdminAddExperimentWhere(string airtableWhere)
        {
                
        
        
            // AirtableWhere: 
            return airtableWhere; 
        }

      
 // IsUpdate: false
       public IEnumerable<Experiment> GetExperiments(StandardPayload Payload) {
			
				AirtableDirectCLIAirtableAPIWrapper api = new AirtableDirectCLIAirtableAPIWrapper(Payload.ApiKey, Payload.BaseId);
				return api.GetExperiments(WrapAdminGetExperimentsWhere(Payload.AirtableWhere), Payload.View, Payload.MaxPages).AdminCleanForGet();
			}        
        private string WrapAdminGetExperimentsWhere(string airtableWhere)
        {
                
        
        
            // AirtableWhere: 
            return airtableWhere; 
        }

      
 // IsUpdate: true
       public IEnumerable<Experiment> UpdateExperiment(StandardPayload Payload) {
			
				AirtableDirectCLIAirtableAPIWrapper api = new AirtableDirectCLIAirtableAPIWrapper(Payload.ApiKey, Payload.BaseId);
				
          if (!(Payload.Experiments is null))
          {
              return this.UpdateExperiments(api, Payload);
          }
          else
          {
              var updatedExperiment = api.Update(Payload.Experiment.AdminCleanForUpdate());
              return new List<Experiment>(new Experiment[] { updatedExperiment });
          }
        
			}        
        private string WrapAdminUpdateExperimentWhere(string airtableWhere)
        {
                
        
        
            // AirtableWhere: 
            return airtableWhere; 
        }

              
        private List<Experiment> UpdateExperiments(AirtableDirectCLIAirtableAPIWrapper api, StandardPayload payload)
        {
            if (!(payload.Experiments is null) && payload.Experiments.Any())
            {
                var updatedItems = new List<Experiment>();
                payload.Experiments.ForEach(item =>
                {
                    var updatedExperiments = api.Update(item);
                    updatedItems.Add(updatedExperiments);
                });
                return updatedItems;
            }
            else throw new Exception("Payload.Product or Payload.Products required to update products");
        }
      
 // IsUpdate: false
       public void DeleteExperiment(StandardPayload Payload) {
			
				AirtableDirectCLIAirtableAPIWrapper api = new AirtableDirectCLIAirtableAPIWrapper(Payload.ApiKey, Payload.BaseId);
				api.Delete(Payload.Experiment);
			}        
        private string WrapAdminDeleteExperimentWhere(string airtableWhere)
        {
                
        
        
            // AirtableWhere: 
            return airtableWhere; 
        }

      
 // IsUpdate: false
       public LLM AddLLM(StandardPayload Payload) {
			
				AirtableDirectCLIAirtableAPIWrapper api = new AirtableDirectCLIAirtableAPIWrapper(Payload.ApiKey, Payload.BaseId);
				return api.Insert(Payload.LLM.AdminCleanForAdd());
			}        
        private string WrapAdminAddLLMWhere(string airtableWhere)
        {
                
        
        
            // AirtableWhere: 
            return airtableWhere; 
        }

      
 // IsUpdate: false
       public IEnumerable<LLM> GetLLMs(StandardPayload Payload) {
			
				AirtableDirectCLIAirtableAPIWrapper api = new AirtableDirectCLIAirtableAPIWrapper(Payload.ApiKey, Payload.BaseId);
				return api.GetLLMs(WrapAdminGetLLMsWhere(Payload.AirtableWhere), Payload.View, Payload.MaxPages).AdminCleanForGet();
			}        
        private string WrapAdminGetLLMsWhere(string airtableWhere)
        {
                
        
        
            // AirtableWhere: 
            return airtableWhere; 
        }

      
 // IsUpdate: true
       public IEnumerable<LLM> UpdateLLM(StandardPayload Payload) {
			
				AirtableDirectCLIAirtableAPIWrapper api = new AirtableDirectCLIAirtableAPIWrapper(Payload.ApiKey, Payload.BaseId);
				
          if (!(Payload.LLMs is null))
          {
              return this.UpdateLLMs(api, Payload);
          }
          else
          {
              var updatedLLM = api.Update(Payload.LLM.AdminCleanForUpdate());
              return new List<LLM>(new LLM[] { updatedLLM });
          }
        
			}        
        private string WrapAdminUpdateLLMWhere(string airtableWhere)
        {
                
        
        
            // AirtableWhere: 
            return airtableWhere; 
        }

              
        private List<LLM> UpdateLLMs(AirtableDirectCLIAirtableAPIWrapper api, StandardPayload payload)
        {
            if (!(payload.LLMs is null) && payload.LLMs.Any())
            {
                var updatedItems = new List<LLM>();
                payload.LLMs.ForEach(item =>
                {
                    var updatedLLMs = api.Update(item);
                    updatedItems.Add(updatedLLMs);
                });
                return updatedItems;
            }
            else throw new Exception("Payload.Product or Payload.Products required to update products");
        }
      
 // IsUpdate: false
       public void DeleteLLM(StandardPayload Payload) {
			
				AirtableDirectCLIAirtableAPIWrapper api = new AirtableDirectCLIAirtableAPIWrapper(Payload.ApiKey, Payload.BaseId);
				api.Delete(Payload.LLM);
			}        
        private string WrapAdminDeleteLLMWhere(string airtableWhere)
        {
                
        
        
            // AirtableWhere: 
            return airtableWhere; 
        }

      

    }
}
					    