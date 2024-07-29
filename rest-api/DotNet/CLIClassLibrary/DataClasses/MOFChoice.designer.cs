using System;
using System.ComponentModel;
using Newtonsoft.Json;
using System.Collections.Generic;
using System.Linq;
using CoreLibrary.Extensions;

namespace AirtableDirect.CLI.Lib.DataClasses
{                            
    public partial class MOFChoice
    {
        private void InitPoco()
        {
        }
        
        partial void AfterGet();
        partial void BeforeInsert();
        partial void AfterInsert();
        partial void BeforeUpdate();
        partial void AfterUpdate();

        

        
        [JsonProperty(DefaultValueHandling = DefaultValueHandling.IgnoreAndPopulate, PropertyName = "MOFChoiceId")]
        public String MOFChoiceId { get; set; }
    
        [JsonProperty(DefaultValueHandling = DefaultValueHandling.IgnoreAndPopulate, PropertyName = "Name")]
        public String Name { get; set; }
    
        [JsonProperty(DefaultValueHandling = DefaultValueHandling.IgnoreAndPopulate, PropertyName = "Layers")]
        [RemoteIsCollection]
        public String[] Layers { get; set; }
    
        [JsonProperty(DefaultValueHandling = DefaultValueHandling.IgnoreAndPopulate, PropertyName = "FQNChoiceName")]
        public String FQNChoiceName { get; set; }
    
        [JsonProperty(DefaultValueHandling = DefaultValueHandling.IgnoreAndPopulate, PropertyName = "Node")]
        [RemoteIsCollection]
        public String Node { get; set; }
    
        [JsonProperty(DefaultValueHandling = DefaultValueHandling.IgnoreAndPopulate, PropertyName = "NodeName")]
        [RemoteIsCollection]
        public String NodeName { get; set; }
    
        [JsonProperty(DefaultValueHandling = DefaultValueHandling.IgnoreAndPopulate, PropertyName = "ToolInputChoice")]
        [RemoteIsCollection]
        public String ToolInputChoice { get; set; }
    
        [JsonProperty(DefaultValueHandling = DefaultValueHandling.IgnoreAndPopulate, PropertyName = "ToolDefaultFileName")]
        [RemoteIsCollection]
        public String ToolDefaultFileName { get; set; }
    
        [JsonProperty(DefaultValueHandling = DefaultValueHandling.IgnoreAndPopulate, PropertyName = "ToolName")]
        [RemoteIsCollection]
        public String ToolName { get; set; }
    
        [JsonProperty(DefaultValueHandling = DefaultValueHandling.IgnoreAndPopulate, PropertyName = "InputChoiceFileName")]
        [RemoteIsCollection]
        public String InputChoiceFileName { get; set; }
    
        [JsonProperty(DefaultValueHandling = DefaultValueHandling.IgnoreAndPopulate, PropertyName = "NodeDefaultFileName")]
        [RemoteIsCollection]
        public String NodeDefaultFileName { get; set; }
    
        [JsonProperty(DefaultValueHandling = DefaultValueHandling.IgnoreAndPopulate, PropertyName = "NodeAttachments")]
        [RemoteIsCollection]
        public AirtableAttachment[] NodeAttachments { get; set; }
    
        [JsonProperty(DefaultValueHandling = DefaultValueHandling.IgnoreAndPopulate, PropertyName = "ParentNodeDesiredColor")]
        [RemoteIsCollection]
        public String ParentNodeDesiredColor { get; set; }
    
        [JsonProperty(DefaultValueHandling = DefaultValueHandling.IgnoreAndPopulate, PropertyName = "NodeDesiredColor")]
        [RemoteIsCollection]
        public String NodeDesiredColor { get; set; }
    
        [JsonProperty(DefaultValueHandling = DefaultValueHandling.IgnoreAndPopulate, PropertyName = "Tool")]
        [RemoteIsCollection]
        public String Tool { get; set; }
    
        [JsonProperty(DefaultValueHandling = DefaultValueHandling.IgnoreAndPopulate, PropertyName = "ParentNodeAttachments")]
        [RemoteIsCollection]
        public AirtableAttachment[] ParentNodeAttachments { get; set; }
    
        [JsonProperty(DefaultValueHandling = DefaultValueHandling.IgnoreAndPopulate, PropertyName = "ToolTransformer")]
        [RemoteIsCollection]
        public String[] ToolTransformer { get; set; }
    
        [JsonProperty(DefaultValueHandling = DefaultValueHandling.IgnoreAndPopulate, PropertyName = "ParentChoiceName")]
        [RemoteIsCollection]
        public String ParentChoiceName { get; set; }
    
        [JsonProperty(DefaultValueHandling = DefaultValueHandling.IgnoreAndPopulate, PropertyName = "Notes")]
        public String Notes { get; set; }
    
        [JsonProperty(DefaultValueHandling = DefaultValueHandling.IgnoreAndPopulate, PropertyName = "ParentChoice")]
        [RemoteIsCollection]
        public String ParentChoice { get; set; }
    
        [JsonProperty(DefaultValueHandling = DefaultValueHandling.IgnoreAndPopulate, PropertyName = "IsSyntaxFree")]
        public Nullable<Boolean> IsSyntaxFree { get; set; }
    
        [JsonProperty(DefaultValueHandling = DefaultValueHandling.IgnoreAndPopulate, PropertyName = "MOFLayerNumber")]
        [RemoteIsCollection]
        public Int32[] MOFLayerNumber { get; set; }
    
        [JsonProperty(DefaultValueHandling = DefaultValueHandling.IgnoreAndPopulate, PropertyName = "ParentMOFLayerNumber")]
        [RemoteIsCollection]
        public Nullable<Int32> ParentMOFLayerNumber { get; set; }
    
        [JsonProperty(DefaultValueHandling = DefaultValueHandling.IgnoreAndPopulate, PropertyName = "MixedColor")]
        public String MixedColor { get; set; }
    
        [JsonProperty(DefaultValueHandling = DefaultValueHandling.IgnoreAndPopulate, PropertyName = "ExpectedColor")]
        public String ExpectedColor { get; set; }
    
        [JsonProperty(DefaultValueHandling = DefaultValueHandling.IgnoreAndPopulate, PropertyName = "ToolTransformerFileName")]
        [RemoteIsCollection]
        public String[] ToolTransformerFileName { get; set; }
    
        [JsonProperty(DefaultValueHandling = DefaultValueHandling.IgnoreAndPopulate, PropertyName = "IsInSync")]
        public Nullable<Int32> IsInSync { get; set; }
    
        [JsonProperty(DefaultValueHandling = DefaultValueHandling.IgnoreAndPopulate, PropertyName = "IsInSyncImage")]
        public String IsInSyncImage { get; set; }
    
        [JsonProperty(DefaultValueHandling = DefaultValueHandling.IgnoreAndPopulate, PropertyName = "ToolAttachments")]
        [RemoteIsCollection]
        public AirtableAttachment[] ToolAttachments { get; set; }
    
        [JsonProperty(DefaultValueHandling = DefaultValueHandling.IgnoreAndPopulate, PropertyName = "ToolInputAttachments")]
        [RemoteIsCollection]
        public AirtableAttachment[] ToolInputAttachments { get; set; }
    
        [JsonProperty(DefaultValueHandling = DefaultValueHandling.IgnoreAndPopulate, PropertyName = "ToolInputChoiceNodeAttachments")]
        [RemoteIsCollection]
        public AirtableAttachment[] ToolInputChoiceNodeAttachments { get; set; }
    
        [JsonProperty(DefaultValueHandling = DefaultValueHandling.IgnoreAndPopulate, PropertyName = "MOFDisplayOrder")]
        [RemoteIsCollection]
        public decimal[] MOFDisplayOrder { get; set; }
    
        [JsonProperty(DefaultValueHandling = DefaultValueHandling.IgnoreAndPopulate, PropertyName = "ParentMOFDisplayOrder")]
        [RemoteIsCollection]
        public Nullable<decimal> ParentMOFDisplayOrder { get; set; }
    
        [JsonProperty(DefaultValueHandling = DefaultValueHandling.IgnoreAndPopulate, PropertyName = "OutputIsDocs")]
        [RemoteIsCollection]
        public Nullable<Boolean> OutputIsDocs { get; set; }
    
        [JsonProperty(DefaultValueHandling = DefaultValueHandling.IgnoreAndPopulate, PropertyName = "DesiredColor")]
        public String DesiredColor { get; set; }
    
        [JsonProperty(DefaultValueHandling = DefaultValueHandling.IgnoreAndPopulate, PropertyName = "ToolPlatformAttachments")]
        [RemoteIsCollection]
        public AirtableAttachment[] ToolPlatformAttachments { get; set; }
    
        [JsonProperty(DefaultValueHandling = DefaultValueHandling.IgnoreAndPopulate, PropertyName = "NodePlatformAttachments")]
        [RemoteIsCollection]
        public AirtableAttachment[] NodePlatformAttachments { get; set; }
    

        

        
        
        
    }
}
