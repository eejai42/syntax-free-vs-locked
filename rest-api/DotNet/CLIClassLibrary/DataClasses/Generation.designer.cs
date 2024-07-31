using System;
using System.ComponentModel;
using Newtonsoft.Json;
using System.Collections.Generic;
using System.Linq;
using CoreLibrary.Extensions;

namespace AirtableDirect.CLI.Lib.DataClasses
{                            
    public partial class Generation
    {
        private void InitPoco()
        {
        }
        
        partial void AfterGet();
        partial void BeforeInsert();
        partial void AfterInsert();
        partial void BeforeUpdate();
        partial void AfterUpdate();

        

        
        [JsonProperty(DefaultValueHandling = DefaultValueHandling.IgnoreAndPopulate, PropertyName = "GenerationId")]
        public String GenerationId { get; set; }
    
        [JsonProperty(DefaultValueHandling = DefaultValueHandling.IgnoreAndPopulate, PropertyName = "Name")]
        public String Name { get; set; }
    
        [JsonProperty(DefaultValueHandling = DefaultValueHandling.IgnoreAndPopulate, PropertyName = "GeneratioNumber")]
        public Nullable<Int32> GeneratioNumber { get; set; }
    
        [JsonProperty(DefaultValueHandling = DefaultValueHandling.IgnoreAndPopulate, PropertyName = "Model")]
        [RemoteIsCollection]
        public String Model { get; set; }
    
        [JsonProperty(DefaultValueHandling = DefaultValueHandling.IgnoreAndPopulate, PropertyName = "Experiment")]
        [RemoteIsCollection]
        public String Experiment { get; set; }
    
        [JsonProperty(DefaultValueHandling = DefaultValueHandling.IgnoreAndPopulate, PropertyName = "ExpName")]
        [RemoteIsCollection]
        public String ExpName { get; set; }
    
        [JsonProperty(DefaultValueHandling = DefaultValueHandling.IgnoreAndPopulate, PropertyName = "GenerationTransformers")]
        [RemoteIsCollection]
        public String[] GenerationTransformers { get; set; }
    
        [JsonProperty(DefaultValueHandling = DefaultValueHandling.IgnoreAndPopulate, PropertyName = "IsActiveExp")]
        [RemoteIsCollection]
        public Nullable<Boolean> IsActiveExp { get; set; }
    
        [JsonProperty(DefaultValueHandling = DefaultValueHandling.IgnoreAndPopulate, PropertyName = "ExpAbstract")]
        [RemoteIsCollection]
        public String ExpAbstract { get; set; }
    
        [JsonProperty(DefaultValueHandling = DefaultValueHandling.IgnoreAndPopulate, PropertyName = "ExpValidationPrompt")]
        [RemoteIsCollection]
        public String ExpValidationPrompt { get; set; }
    
        [JsonProperty(DefaultValueHandling = DefaultValueHandling.IgnoreAndPopulate, PropertyName = "GenerationTransformRawPrompts")]
        [RemoteIsCollection]
        public String[] GenerationTransformRawPrompts { get; set; }
    
        [JsonProperty(DefaultValueHandling = DefaultValueHandling.IgnoreAndPopulate, PropertyName = "TransformerNumbers")]
        [RemoteIsCollection]
        public Int32[] TransformerNumbers { get; set; }
    
        [JsonProperty(DefaultValueHandling = DefaultValueHandling.IgnoreAndPopulate, PropertyName = "SyntaxFreeTransformerNumbers")]
        [RemoteIsCollection]
        public Int32[] SyntaxFreeTransformerNumbers { get; set; }
    
        [JsonProperty(DefaultValueHandling = DefaultValueHandling.IgnoreAndPopulate, PropertyName = "SyntaxLockedTransformerNumbers")]
        [RemoteIsCollection]
        public Int32[] SyntaxLockedTransformerNumbers { get; set; }
    

        

        
        
        
    }
}
