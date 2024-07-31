using System;
using System.ComponentModel;
using Newtonsoft.Json;
using System.Collections.Generic;
using System.Linq;
using CoreLibrary.Extensions;

namespace AirtableDirect.CLI.Lib.DataClasses
{                            
    public partial class GenerationTransformer
    {
        private void InitPoco()
        {
        }
        
        partial void AfterGet();
        partial void BeforeInsert();
        partial void AfterInsert();
        partial void BeforeUpdate();
        partial void AfterUpdate();

        

        
        [JsonProperty(DefaultValueHandling = DefaultValueHandling.IgnoreAndPopulate, PropertyName = "GenerationTransformerId")]
        public String GenerationTransformerId { get; set; }
    
        [JsonProperty(DefaultValueHandling = DefaultValueHandling.IgnoreAndPopulate, PropertyName = "Name")]
        public String Name { get; set; }
    
        [JsonProperty(DefaultValueHandling = DefaultValueHandling.IgnoreAndPopulate, PropertyName = "Generation")]
        [RemoteIsCollection]
        public String Generation { get; set; }
    
        [JsonProperty(DefaultValueHandling = DefaultValueHandling.IgnoreAndPopulate, PropertyName = "RawPrompt")]
        [RemoteIsCollection]
        public String RawPrompt { get; set; }
    
        [JsonProperty(DefaultValueHandling = DefaultValueHandling.IgnoreAndPopulate, PropertyName = "GenerationName")]
        [RemoteIsCollection]
        public String GenerationName { get; set; }
    
        [JsonProperty(DefaultValueHandling = DefaultValueHandling.IgnoreAndPopulate, PropertyName = "GeneratioNumber")]
        [RemoteIsCollection]
        public Nullable<Int32> GeneratioNumber { get; set; }
    
        [JsonProperty(DefaultValueHandling = DefaultValueHandling.IgnoreAndPopulate, PropertyName = "TransformedArtifacts")]
        [RemoteIsCollection]
        public String[] TransformedArtifacts { get; set; }
    
        [JsonProperty(DefaultValueHandling = DefaultValueHandling.IgnoreAndPopulate, PropertyName = "AutoNumber")]
        public String AutoNumber { get; set; }
    
        [JsonProperty(DefaultValueHandling = DefaultValueHandling.IgnoreAndPopulate, PropertyName = "TransformerNumber")]
        public Nullable<Int32> TransformerNumber { get; set; }
    
        [JsonProperty(DefaultValueHandling = DefaultValueHandling.IgnoreAndPopulate, PropertyName = "IsArtifactValidator")]
        public Nullable<Boolean> IsArtifactValidator { get; set; }
    
        [JsonProperty(DefaultValueHandling = DefaultValueHandling.IgnoreAndPopulate, PropertyName = "ExpAbstract")]
        [RemoteIsCollection]
        public String ExpAbstract { get; set; }
    
        [JsonProperty(DefaultValueHandling = DefaultValueHandling.IgnoreAndPopulate, PropertyName = "ExpTransformer")]
        [RemoteIsCollection]
        public String ExpTransformer { get; set; }
    
        [JsonProperty(DefaultValueHandling = DefaultValueHandling.IgnoreAndPopulate, PropertyName = "GenerationExp")]
        [RemoteIsCollection]
        public String GenerationExp { get; set; }
    
        [JsonProperty(DefaultValueHandling = DefaultValueHandling.IgnoreAndPopulate, PropertyName = "GenerationExpName")]
        [RemoteIsCollection]
        public String GenerationExpName { get; set; }
    
        [JsonProperty(DefaultValueHandling = DefaultValueHandling.IgnoreAndPopulate, PropertyName = "IsActiveExp")]
        [RemoteIsCollection]
        public Nullable<Boolean> IsActiveExp { get; set; }
    
        [JsonProperty(DefaultValueHandling = DefaultValueHandling.IgnoreAndPopulate, PropertyName = "ExpTransformerIsSyntaxFree")]
        [RemoteIsCollection]
        public Nullable<Boolean> ExpTransformerIsSyntaxFree { get; set; }
    
        [JsonProperty(DefaultValueHandling = DefaultValueHandling.IgnoreAndPopulate, PropertyName = "ExpValidationPrompt")]
        [RemoteIsCollection]
        public String ExpValidationPrompt { get; set; }
    

        

        
        
        
    }
}
