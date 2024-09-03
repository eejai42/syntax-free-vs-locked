using System;
using System.ComponentModel;
using Newtonsoft.Json;
using System.Collections.Generic;
using System.Linq;
using CoreLibrary.Extensions;

namespace AirtableDirect.CLI.Lib.DataClasses
{                            
    public partial class Trial
    {
        private void InitPoco()
        {
        }
        
        partial void AfterGet();
        partial void BeforeInsert();
        partial void AfterInsert();
        partial void BeforeUpdate();
        partial void AfterUpdate();

        

        
        [JsonProperty(DefaultValueHandling = DefaultValueHandling.IgnoreAndPopulate, PropertyName = "TrialId")]
        public String TrialId { get; set; }
    
        [JsonProperty(DefaultValueHandling = DefaultValueHandling.IgnoreAndPopulate, PropertyName = "Name")]
        public String Name { get; set; }
    
        [JsonProperty(DefaultValueHandling = DefaultValueHandling.IgnoreAndPopulate, PropertyName = "Experiement")]
        [RemoteIsCollection]
        public String Experiement { get; set; }
    
        [JsonProperty(DefaultValueHandling = DefaultValueHandling.IgnoreAndPopulate, PropertyName = "TrialArtifacts")]
        [RemoteIsCollection]
        public String[] TrialArtifacts { get; set; }
    
        [JsonProperty(DefaultValueHandling = DefaultValueHandling.IgnoreAndPopulate, PropertyName = "AutoNumber")]
        public String AutoNumber { get; set; }
    
        [JsonProperty(DefaultValueHandling = DefaultValueHandling.IgnoreAndPopulate, PropertyName = "TrailIdentifier")]
        public Nullable<Int32> TrailIdentifier { get; set; }
    
        [JsonProperty(DefaultValueHandling = DefaultValueHandling.IgnoreAndPopulate, PropertyName = "Created")]
        public Nullable<DateTime> Created { get; set; }
    
        [JsonProperty(DefaultValueHandling = DefaultValueHandling.IgnoreAndPopulate, PropertyName = "DesiredPromptChainCount")]
        public Nullable<Int32> DesiredPromptChainCount { get; set; }
    
        [JsonProperty(DefaultValueHandling = DefaultValueHandling.IgnoreAndPopulate, PropertyName = "TrialArtifactCount")]
        public Nullable<Int32> TrialArtifactCount { get; set; }
    
        [JsonProperty(DefaultValueHandling = DefaultValueHandling.IgnoreAndPopulate, PropertyName = "GatherTrialDataScript")]
        public String GatherTrialDataScript { get; set; }
    
        [JsonProperty(DefaultValueHandling = DefaultValueHandling.IgnoreAndPopulate, PropertyName = "ExperimentRunTrialScript")]
        [RemoteIsCollection]
        public String ExperimentRunTrialScript { get; set; }
    

        

        
        
        
    }
}
