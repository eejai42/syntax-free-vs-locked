using AirtableDirect.CLI.Lib.DataClasses;
using AirtableToDotNet.APIWrapper;
using System;
using System.Linq;
using System.Collections.Generic;
using YP.SassyMQ.Lib.RabbitMQ;
using System.Security.Claims;

namespace CLIClassLibrary.ATDMQ
{
	public partial class ATDUser : ATDActorBase
    {
       public ClaimsIdentity UserIdentity { get; set; } // IsUpdate: false
       public TrialArtifact AddTrialArtifact(StandardPayload Payload) {
			
				AirtableDirectCLIAirtableAPIWrapper api = new AirtableDirectCLIAirtableAPIWrapper(Payload.ApiKey, Payload.BaseId);
				return api.Insert(Payload.TrialArtifact.UserCleanForAdd());
			}        
        private string WrapUserAddTrialArtifactWhere(string airtableWhere)
        {
                
        
        
            // AirtableWhere: 
            return airtableWhere; 
        }

      
 // IsUpdate: false
       public IEnumerable<TrialArtifact> GetTrialArtifacts(StandardPayload Payload) {
			
				AirtableDirectCLIAirtableAPIWrapper api = new AirtableDirectCLIAirtableAPIWrapper(Payload.ApiKey, Payload.BaseId);
				return api.GetTrialArtifacts(WrapUserGetTrialArtifactsWhere(Payload.AirtableWhere), Payload.View, Payload.MaxPages).UserCleanForGet();
			}        
        private string WrapUserGetTrialArtifactsWhere(string airtableWhere)
        {
                
        
        
            // AirtableWhere: 
            return airtableWhere; 
        }

      
 // IsUpdate: true
       public IEnumerable<TrialArtifact> UpdateTrialArtifact(StandardPayload Payload) {
			
				AirtableDirectCLIAirtableAPIWrapper api = new AirtableDirectCLIAirtableAPIWrapper(Payload.ApiKey, Payload.BaseId);
				
          if (!(Payload.TrialArtifacts is null))
          {
              return this.UpdateTrialArtifacts(api, Payload);
          }
          else
          {
              var updatedTrialArtifact = api.Update(Payload.TrialArtifact.UserCleanForUpdate());
              return new List<TrialArtifact>(new TrialArtifact[] { updatedTrialArtifact });
          }
        
			}        
        private string WrapUserUpdateTrialArtifactWhere(string airtableWhere)
        {
                
        
        
            // AirtableWhere: 
            return airtableWhere; 
        }

              
        private List<TrialArtifact> UpdateTrialArtifacts(AirtableDirectCLIAirtableAPIWrapper api, StandardPayload payload)
        {
            if (!(payload.TrialArtifacts is null) && payload.TrialArtifacts.Any())
            {
                var updatedItems = new List<TrialArtifact>();
                payload.TrialArtifacts.ForEach(item =>
                {
                    var updatedTrialArtifacts = api.Update(item);
                    updatedItems.Add(updatedTrialArtifacts);
                });
                return updatedItems;
            }
            else throw new Exception("Payload.Product or Payload.Products required to update products");
        }
      
 // IsUpdate: false
       public void DeleteTrialArtifact(StandardPayload Payload) {
			
				AirtableDirectCLIAirtableAPIWrapper api = new AirtableDirectCLIAirtableAPIWrapper(Payload.ApiKey, Payload.BaseId);
				api.Delete(Payload.TrialArtifact);
			}        
        private string WrapUserDeleteTrialArtifactWhere(string airtableWhere)
        {
                
        
        
            // AirtableWhere: 
            return airtableWhere; 
        }

      
 // IsUpdate: false
       public ArtifactAnalysis AddArtifactAnalysis(StandardPayload Payload) {
			
				AirtableDirectCLIAirtableAPIWrapper api = new AirtableDirectCLIAirtableAPIWrapper(Payload.ApiKey, Payload.BaseId);
				return api.Insert(Payload.ArtifactAnalysis.UserCleanForAdd());
			}        
        private string WrapUserAddArtifactAnalysisWhere(string airtableWhere)
        {
                
        
        
            // AirtableWhere: 
            return airtableWhere; 
        }

      
 // IsUpdate: false
       public IEnumerable<ArtifactAnalysis> GetArtifactAnalyses(StandardPayload Payload) {
			
				AirtableDirectCLIAirtableAPIWrapper api = new AirtableDirectCLIAirtableAPIWrapper(Payload.ApiKey, Payload.BaseId);
				return api.GetArtifactAnalyses(WrapUserGetArtifactAnalysesWhere(Payload.AirtableWhere), Payload.View, Payload.MaxPages).UserCleanForGet();
			}        
        private string WrapUserGetArtifactAnalysesWhere(string airtableWhere)
        {
                
        
        
            // AirtableWhere: 
            return airtableWhere; 
        }

      
 // IsUpdate: true
       public IEnumerable<ArtifactAnalysis> UpdateArtifactAnalysis(StandardPayload Payload) {
			
				AirtableDirectCLIAirtableAPIWrapper api = new AirtableDirectCLIAirtableAPIWrapper(Payload.ApiKey, Payload.BaseId);
				
          if (!(Payload.ArtifactAnalyses is null))
          {
              return this.UpdateArtifactAnalyses(api, Payload);
          }
          else
          {
              var updatedArtifactAnalysis = api.Update(Payload.ArtifactAnalysis.UserCleanForUpdate());
              return new List<ArtifactAnalysis>(new ArtifactAnalysis[] { updatedArtifactAnalysis });
          }
        
			}        
        private string WrapUserUpdateArtifactAnalysisWhere(string airtableWhere)
        {
                
        
        
            // AirtableWhere: 
            return airtableWhere; 
        }

              
        private List<ArtifactAnalysis> UpdateArtifactAnalyses(AirtableDirectCLIAirtableAPIWrapper api, StandardPayload payload)
        {
            if (!(payload.ArtifactAnalyses is null) && payload.ArtifactAnalyses.Any())
            {
                var updatedItems = new List<ArtifactAnalysis>();
                payload.ArtifactAnalyses.ForEach(item =>
                {
                    var updatedArtifactAnalyses = api.Update(item);
                    updatedItems.Add(updatedArtifactAnalyses);
                });
                return updatedItems;
            }
            else throw new Exception("Payload.Product or Payload.Products required to update products");
        }
      
 // IsUpdate: false
       public void DeleteArtifactAnalysis(StandardPayload Payload) {
			
				AirtableDirectCLIAirtableAPIWrapper api = new AirtableDirectCLIAirtableAPIWrapper(Payload.ApiKey, Payload.BaseId);
				api.Delete(Payload.ArtifactAnalysis);
			}        
        private string WrapUserDeleteArtifactAnalysisWhere(string airtableWhere)
        {
                
        
        
            // AirtableWhere: 
            return airtableWhere; 
        }

      
 // IsUpdate: false
       public AppUser AddAppUser(StandardPayload Payload) {
			
				AirtableDirectCLIAirtableAPIWrapper api = new AirtableDirectCLIAirtableAPIWrapper(Payload.ApiKey, Payload.BaseId);
				return api.Insert(Payload.AppUser.UserCleanForAdd());
			}        
        private string WrapUserAddAppUserWhere(string airtableWhere)
        {
                
        
        
            // AirtableWhere: EmailAddress='$AppUser.EmailAddress$'
            airtableWhere = String.IsNullOrEmpty(airtableWhere) ? "True()" : airtableWhere;
            return $"AND(EmailAddress='$AppUser.EmailAddress$',{airtableWhere})".Replace("$AppUser.EmailAddress$", this.EmailAddress); 
        }

      
 // IsUpdate: false
       public IEnumerable<AppUser> GetAppUsers(StandardPayload Payload) {
			
				AirtableDirectCLIAirtableAPIWrapper api = new AirtableDirectCLIAirtableAPIWrapper(Payload.ApiKey, Payload.BaseId);
				return api.GetAppUsers(WrapUserGetAppUsersWhere(Payload.AirtableWhere), Payload.View, Payload.MaxPages).UserCleanForGet();
			}        
        private string WrapUserGetAppUsersWhere(string airtableWhere)
        {
                
        
        
            // AirtableWhere: EmailAddress='$AppUser.EmailAddress$'
            airtableWhere = String.IsNullOrEmpty(airtableWhere) ? "True()" : airtableWhere;
            return $"AND(EmailAddress='$AppUser.EmailAddress$',{airtableWhere})".Replace("$AppUser.EmailAddress$", this.EmailAddress); 
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
              var updatedAppUser = api.Update(Payload.AppUser.UserCleanForUpdate());
              return new List<AppUser>(new AppUser[] { updatedAppUser });
          }
        
			}        
        private string WrapUserUpdateAppUserWhere(string airtableWhere)
        {
                
        
        
            // AirtableWhere: EmailAddress='$AppUser.EmailAddress$'
            airtableWhere = String.IsNullOrEmpty(airtableWhere) ? "True()" : airtableWhere;
            return $"AND(EmailAddress='$AppUser.EmailAddress$',{airtableWhere})".Replace("$AppUser.EmailAddress$", this.EmailAddress); 
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
        private string WrapUserDeleteAppUserWhere(string airtableWhere)
        {
                
        
        
            // AirtableWhere: 
            return airtableWhere; 
        }

      
 // IsUpdate: false
       public GenerationTransformer AddGenerationTransformer(StandardPayload Payload) {
			
				AirtableDirectCLIAirtableAPIWrapper api = new AirtableDirectCLIAirtableAPIWrapper(Payload.ApiKey, Payload.BaseId);
				return api.Insert(Payload.GenerationTransformer.UserCleanForAdd());
			}        
        private string WrapUserAddGenerationTransformerWhere(string airtableWhere)
        {
                
        
        
            // AirtableWhere: 
            return airtableWhere; 
        }

      
 // IsUpdate: false
       public IEnumerable<GenerationTransformer> GetGenerationTransformers(StandardPayload Payload) {
			
				AirtableDirectCLIAirtableAPIWrapper api = new AirtableDirectCLIAirtableAPIWrapper(Payload.ApiKey, Payload.BaseId);
				return api.GetGenerationTransformers(WrapUserGetGenerationTransformersWhere(Payload.AirtableWhere), Payload.View, Payload.MaxPages).UserCleanForGet();
			}        
        private string WrapUserGetGenerationTransformersWhere(string airtableWhere)
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
              var updatedGenerationTransformer = api.Update(Payload.GenerationTransformer.UserCleanForUpdate());
              return new List<GenerationTransformer>(new GenerationTransformer[] { updatedGenerationTransformer });
          }
        
			}        
        private string WrapUserUpdateGenerationTransformerWhere(string airtableWhere)
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
        private string WrapUserDeleteGenerationTransformerWhere(string airtableWhere)
        {
                
        
        
            // AirtableWhere: 
            return airtableWhere; 
        }

      
 // IsUpdate: false
       public Generation AddGeneration(StandardPayload Payload) {
			
				AirtableDirectCLIAirtableAPIWrapper api = new AirtableDirectCLIAirtableAPIWrapper(Payload.ApiKey, Payload.BaseId);
				return api.Insert(Payload.Generation.UserCleanForAdd());
			}        
        private string WrapUserAddGenerationWhere(string airtableWhere)
        {
                
        
        
            // AirtableWhere: 
            return airtableWhere; 
        }

      
 // IsUpdate: false
       public IEnumerable<Generation> GetGenerations(StandardPayload Payload) {
			
				AirtableDirectCLIAirtableAPIWrapper api = new AirtableDirectCLIAirtableAPIWrapper(Payload.ApiKey, Payload.BaseId);
				return api.GetGenerations(WrapUserGetGenerationsWhere(Payload.AirtableWhere), Payload.View, Payload.MaxPages).UserCleanForGet();
			}        
        private string WrapUserGetGenerationsWhere(string airtableWhere)
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
              var updatedGeneration = api.Update(Payload.Generation.UserCleanForUpdate());
              return new List<Generation>(new Generation[] { updatedGeneration });
          }
        
			}        
        private string WrapUserUpdateGenerationWhere(string airtableWhere)
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
        private string WrapUserDeleteGenerationWhere(string airtableWhere)
        {
                
        
        
            // AirtableWhere: 
            return airtableWhere; 
        }

      
 // IsUpdate: false
       public Trial AddTrial(StandardPayload Payload) {
			
				AirtableDirectCLIAirtableAPIWrapper api = new AirtableDirectCLIAirtableAPIWrapper(Payload.ApiKey, Payload.BaseId);
				return api.Insert(Payload.Trial.UserCleanForAdd());
			}        
        private string WrapUserAddTrialWhere(string airtableWhere)
        {
                
        
        
            // AirtableWhere: 
            return airtableWhere; 
        }

      
 // IsUpdate: false
       public IEnumerable<Trial> GetTrials(StandardPayload Payload) {
			
				AirtableDirectCLIAirtableAPIWrapper api = new AirtableDirectCLIAirtableAPIWrapper(Payload.ApiKey, Payload.BaseId);
				return api.GetTrials(WrapUserGetTrialsWhere(Payload.AirtableWhere), Payload.View, Payload.MaxPages).UserCleanForGet();
			}        
        private string WrapUserGetTrialsWhere(string airtableWhere)
        {
                
        
        
            // AirtableWhere: 
            return airtableWhere; 
        }

      
 // IsUpdate: true
       public IEnumerable<Trial> UpdateTrial(StandardPayload Payload) {
			
				AirtableDirectCLIAirtableAPIWrapper api = new AirtableDirectCLIAirtableAPIWrapper(Payload.ApiKey, Payload.BaseId);
				
          if (!(Payload.Trials is null))
          {
              return this.UpdateTrials(api, Payload);
          }
          else
          {
              var updatedTrial = api.Update(Payload.Trial.UserCleanForUpdate());
              return new List<Trial>(new Trial[] { updatedTrial });
          }
        
			}        
        private string WrapUserUpdateTrialWhere(string airtableWhere)
        {
                
        
        
            // AirtableWhere: 
            return airtableWhere; 
        }

              
        private List<Trial> UpdateTrials(AirtableDirectCLIAirtableAPIWrapper api, StandardPayload payload)
        {
            if (!(payload.Trials is null) && payload.Trials.Any())
            {
                var updatedItems = new List<Trial>();
                payload.Trials.ForEach(item =>
                {
                    var updatedTrials = api.Update(item);
                    updatedItems.Add(updatedTrials);
                });
                return updatedItems;
            }
            else throw new Exception("Payload.Product or Payload.Products required to update products");
        }
      
 // IsUpdate: false
       public void DeleteTrial(StandardPayload Payload) {
			
				AirtableDirectCLIAirtableAPIWrapper api = new AirtableDirectCLIAirtableAPIWrapper(Payload.ApiKey, Payload.BaseId);
				api.Delete(Payload.Trial);
			}        
        private string WrapUserDeleteTrialWhere(string airtableWhere)
        {
                
        
        
            // AirtableWhere: 
            return airtableWhere; 
        }

      
 // IsUpdate: false
       public ExperimentTransformer AddExperimentTransformer(StandardPayload Payload) {
			
				AirtableDirectCLIAirtableAPIWrapper api = new AirtableDirectCLIAirtableAPIWrapper(Payload.ApiKey, Payload.BaseId);
				return api.Insert(Payload.ExperimentTransformer.UserCleanForAdd());
			}        
        private string WrapUserAddExperimentTransformerWhere(string airtableWhere)
        {
                
        
        
            // AirtableWhere: 
            return airtableWhere; 
        }

      
 // IsUpdate: false
       public IEnumerable<ExperimentTransformer> GetExperimentTransformers(StandardPayload Payload) {
			
				AirtableDirectCLIAirtableAPIWrapper api = new AirtableDirectCLIAirtableAPIWrapper(Payload.ApiKey, Payload.BaseId);
				return api.GetExperimentTransformers(WrapUserGetExperimentTransformersWhere(Payload.AirtableWhere), Payload.View, Payload.MaxPages).UserCleanForGet();
			}        
        private string WrapUserGetExperimentTransformersWhere(string airtableWhere)
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
              var updatedExperimentTransformer = api.Update(Payload.ExperimentTransformer.UserCleanForUpdate());
              return new List<ExperimentTransformer>(new ExperimentTransformer[] { updatedExperimentTransformer });
          }
        
			}        
        private string WrapUserUpdateExperimentTransformerWhere(string airtableWhere)
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
        private string WrapUserDeleteExperimentTransformerWhere(string airtableWhere)
        {
                
        
        
            // AirtableWhere: 
            return airtableWhere; 
        }

      
 // IsUpdate: false
       public ExperimentFeature AddExperimentFeature(StandardPayload Payload) {
			
				AirtableDirectCLIAirtableAPIWrapper api = new AirtableDirectCLIAirtableAPIWrapper(Payload.ApiKey, Payload.BaseId);
				return api.Insert(Payload.ExperimentFeature.UserCleanForAdd());
			}        
        private string WrapUserAddExperimentFeatureWhere(string airtableWhere)
        {
                
        
        
            // AirtableWhere: 
            return airtableWhere; 
        }

      
 // IsUpdate: false
       public IEnumerable<ExperimentFeature> GetExperimentFeatures(StandardPayload Payload) {
			
				AirtableDirectCLIAirtableAPIWrapper api = new AirtableDirectCLIAirtableAPIWrapper(Payload.ApiKey, Payload.BaseId);
				return api.GetExperimentFeatures(WrapUserGetExperimentFeaturesWhere(Payload.AirtableWhere), Payload.View, Payload.MaxPages).UserCleanForGet();
			}        
        private string WrapUserGetExperimentFeaturesWhere(string airtableWhere)
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
              var updatedExperimentFeature = api.Update(Payload.ExperimentFeature.UserCleanForUpdate());
              return new List<ExperimentFeature>(new ExperimentFeature[] { updatedExperimentFeature });
          }
        
			}        
        private string WrapUserUpdateExperimentFeatureWhere(string airtableWhere)
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
        private string WrapUserDeleteExperimentFeatureWhere(string airtableWhere)
        {
                
        
        
            // AirtableWhere: 
            return airtableWhere; 
        }

      
 // IsUpdate: false
       public DesignDecision AddDesignDecision(StandardPayload Payload) {
			
				AirtableDirectCLIAirtableAPIWrapper api = new AirtableDirectCLIAirtableAPIWrapper(Payload.ApiKey, Payload.BaseId);
				return api.Insert(Payload.DesignDecision.UserCleanForAdd());
			}        
        private string WrapUserAddDesignDecisionWhere(string airtableWhere)
        {
                
        
        
            // AirtableWhere: 
            return airtableWhere; 
        }

      
 // IsUpdate: false
       public IEnumerable<DesignDecision> GetDesignDecisions(StandardPayload Payload) {
			
				AirtableDirectCLIAirtableAPIWrapper api = new AirtableDirectCLIAirtableAPIWrapper(Payload.ApiKey, Payload.BaseId);
				return api.GetDesignDecisions(WrapUserGetDesignDecisionsWhere(Payload.AirtableWhere), Payload.View, Payload.MaxPages).UserCleanForGet();
			}        
        private string WrapUserGetDesignDecisionsWhere(string airtableWhere)
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
              var updatedDesignDecision = api.Update(Payload.DesignDecision.UserCleanForUpdate());
              return new List<DesignDecision>(new DesignDecision[] { updatedDesignDecision });
          }
        
			}        
        private string WrapUserUpdateDesignDecisionWhere(string airtableWhere)
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
        private string WrapUserDeleteDesignDecisionWhere(string airtableWhere)
        {
                
        
        
            // AirtableWhere: 
            return airtableWhere; 
        }

      
 // IsUpdate: false
       public Experiment AddExperiment(StandardPayload Payload) {
			
				AirtableDirectCLIAirtableAPIWrapper api = new AirtableDirectCLIAirtableAPIWrapper(Payload.ApiKey, Payload.BaseId);
				return api.Insert(Payload.Experiment.UserCleanForAdd());
			}        
        private string WrapUserAddExperimentWhere(string airtableWhere)
        {
                
        
        
            // AirtableWhere: 
            return airtableWhere; 
        }

      
 // IsUpdate: false
       public IEnumerable<Experiment> GetExperiments(StandardPayload Payload) {
			
				AirtableDirectCLIAirtableAPIWrapper api = new AirtableDirectCLIAirtableAPIWrapper(Payload.ApiKey, Payload.BaseId);
				return api.GetExperiments(WrapUserGetExperimentsWhere(Payload.AirtableWhere), Payload.View, Payload.MaxPages).UserCleanForGet();
			}        
        private string WrapUserGetExperimentsWhere(string airtableWhere)
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
              var updatedExperiment = api.Update(Payload.Experiment.UserCleanForUpdate());
              return new List<Experiment>(new Experiment[] { updatedExperiment });
          }
        
			}        
        private string WrapUserUpdateExperimentWhere(string airtableWhere)
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
        private string WrapUserDeleteExperimentWhere(string airtableWhere)
        {
                
        
        
            // AirtableWhere: 
            return airtableWhere; 
        }

      
 // IsUpdate: false
       public LLM AddLLM(StandardPayload Payload) {
			
				AirtableDirectCLIAirtableAPIWrapper api = new AirtableDirectCLIAirtableAPIWrapper(Payload.ApiKey, Payload.BaseId);
				return api.Insert(Payload.LLM.UserCleanForAdd());
			}        
        private string WrapUserAddLLMWhere(string airtableWhere)
        {
                
        
        
            // AirtableWhere: 
            return airtableWhere; 
        }

      
 // IsUpdate: false
       public IEnumerable<LLM> GetLLMs(StandardPayload Payload) {
			
				AirtableDirectCLIAirtableAPIWrapper api = new AirtableDirectCLIAirtableAPIWrapper(Payload.ApiKey, Payload.BaseId);
				return api.GetLLMs(WrapUserGetLLMsWhere(Payload.AirtableWhere), Payload.View, Payload.MaxPages).UserCleanForGet();
			}        
        private string WrapUserGetLLMsWhere(string airtableWhere)
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
              var updatedLLM = api.Update(Payload.LLM.UserCleanForUpdate());
              return new List<LLM>(new LLM[] { updatedLLM });
          }
        
			}        
        private string WrapUserUpdateLLMWhere(string airtableWhere)
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
        private string WrapUserDeleteLLMWhere(string airtableWhere)
        {
                
        
        
            // AirtableWhere: 
            return airtableWhere; 
        }

      

    }
}
					    