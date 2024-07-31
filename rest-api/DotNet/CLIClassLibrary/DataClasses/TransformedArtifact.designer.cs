using System;
using System.ComponentModel;
using Newtonsoft.Json;
using System.Collections.Generic;
using System.Linq;
using CoreLibrary.Extensions;

namespace AirtableDirect.CLI.Lib.DataClasses
{                            
    public partial class TransformedArtifact
    {
        private void InitPoco()
        {
        }
        
        partial void AfterGet();
        partial void BeforeInsert();
        partial void AfterInsert();
        partial void BeforeUpdate();
        partial void AfterUpdate();

        

        
        [JsonProperty(DefaultValueHandling = DefaultValueHandling.IgnoreAndPopulate, PropertyName = "TransformedArtifactId")]
        public String TransformedArtifactId { get; set; }
    
        [JsonProperty(DefaultValueHandling = DefaultValueHandling.IgnoreAndPopulate, PropertyName = "Name")]
        public String Name { get; set; }
    
        [JsonProperty(DefaultValueHandling = DefaultValueHandling.IgnoreAndPopulate, PropertyName = "GenerationTransformer")]
        [RemoteIsCollection]
        public String[] GenerationTransformer { get; set; }
    
        [JsonProperty(DefaultValueHandling = DefaultValueHandling.IgnoreAndPopulate, PropertyName = "SuggestedPrompt")]
        public String SuggestedPrompt { get; set; }
    
        [JsonProperty(DefaultValueHandling = DefaultValueHandling.IgnoreAndPopulate, PropertyName = "ActualPrompt")]
        public String ActualPrompt { get; set; }
    
        [JsonProperty(DefaultValueHandling = DefaultValueHandling.IgnoreAndPopulate, PropertyName = "Response")]
        public String Response { get; set; }
    
        [JsonProperty(DefaultValueHandling = DefaultValueHandling.IgnoreAndPopulate, PropertyName = "Created")]
        public Nullable<DateTime> Created { get; set; }
    
        [JsonProperty(DefaultValueHandling = DefaultValueHandling.IgnoreAndPopulate, PropertyName = "AutoNumber")]
        public String AutoNumber { get; set; }
    
        [JsonProperty(DefaultValueHandling = DefaultValueHandling.IgnoreAndPopulate, PropertyName = "ResponseOfArtifactBeingExtended")]
        [RemoteIsCollection]
        public String ResponseOfArtifactBeingExtended { get; set; }
    
        [JsonProperty(DefaultValueHandling = DefaultValueHandling.IgnoreAndPopulate, PropertyName = "TransformerRawPrompt")]
        [RemoteIsCollection]
        public String[] TransformerRawPrompt { get; set; }
    
        [JsonProperty(DefaultValueHandling = DefaultValueHandling.IgnoreAndPopulate, PropertyName = "IsRetiredArtifact")]
        public Nullable<Boolean> IsRetiredArtifact { get; set; }
    
        [JsonProperty(DefaultValueHandling = DefaultValueHandling.IgnoreAndPopulate, PropertyName = "Modified")]
        public Nullable<DateTime> Modified { get; set; }
    
        [JsonProperty(DefaultValueHandling = DefaultValueHandling.IgnoreAndPopulate, PropertyName = "ExtensionOf")]
        [RemoteIsCollection]
        public String ExtensionOf { get; set; }
    
        [JsonProperty(DefaultValueHandling = DefaultValueHandling.IgnoreAndPopulate, PropertyName = "TransformerNumber")]
        [RemoteIsCollection]
        public Int32[] TransformerNumber { get; set; }
    
        [JsonProperty(DefaultValueHandling = DefaultValueHandling.IgnoreAndPopulate, PropertyName = "LongName")]
        public String LongName { get; set; }
    
        [JsonProperty(DefaultValueHandling = DefaultValueHandling.IgnoreAndPopulate, PropertyName = "TransformerGeneratioNumber")]
        [RemoteIsCollection]
        public Int32[] TransformerGeneratioNumber { get; set; }
    
        [JsonProperty(DefaultValueHandling = DefaultValueHandling.IgnoreAndPopulate, PropertyName = "TransformerGenerationName")]
        [RemoteIsCollection]
        public String[] TransformerGenerationName { get; set; }
    
        [JsonProperty(DefaultValueHandling = DefaultValueHandling.IgnoreAndPopulate, PropertyName = "ArtifactIdentifier")]
        public Nullable<Int32> ArtifactIdentifier { get; set; }
    
        [JsonProperty(DefaultValueHandling = DefaultValueHandling.IgnoreAndPopulate, PropertyName = "PrimaryExtensionArtifact")]
        [RemoteIsCollection]
        public String PrimaryExtensionArtifact { get; set; }
    
        [JsonProperty(DefaultValueHandling = DefaultValueHandling.IgnoreAndPopulate, PropertyName = "ToDoItems")]
        public Nullable<Boolean> ToDoItems { get; set; }
    
        [JsonProperty(DefaultValueHandling = DefaultValueHandling.IgnoreAndPopulate, PropertyName = "ToDoItemsAKA")]
        public String ToDoItemsAKA { get; set; }
    
        [JsonProperty(DefaultValueHandling = DefaultValueHandling.IgnoreAndPopulate, PropertyName = "ToDoItemsMismatched")]
        public Nullable<Boolean> ToDoItemsMismatched { get; set; }
    
        [JsonProperty(DefaultValueHandling = DefaultValueHandling.IgnoreAndPopulate, PropertyName = "Categories")]
        public Nullable<Boolean> Categories { get; set; }
    
        [JsonProperty(DefaultValueHandling = DefaultValueHandling.IgnoreAndPopulate, PropertyName = "CategoriesAKA")]
        public String CategoriesAKA { get; set; }
    
        [JsonProperty(DefaultValueHandling = DefaultValueHandling.IgnoreAndPopulate, PropertyName = "CategoriesMismatched")]
        public Nullable<Boolean> CategoriesMismatched { get; set; }
    
        [JsonProperty(DefaultValueHandling = DefaultValueHandling.IgnoreAndPopulate, PropertyName = "DueDates")]
        public Nullable<Boolean> DueDates { get; set; }
    
        [JsonProperty(DefaultValueHandling = DefaultValueHandling.IgnoreAndPopulate, PropertyName = "DueDatesAKA")]
        public String DueDatesAKA { get; set; }
    
        [JsonProperty(DefaultValueHandling = DefaultValueHandling.IgnoreAndPopulate, PropertyName = "DueDatesMismatched")]
        public Nullable<Boolean> DueDatesMismatched { get; set; }
    
        [JsonProperty(DefaultValueHandling = DefaultValueHandling.IgnoreAndPopulate, PropertyName = "Priorities")]
        public Nullable<Boolean> Priorities { get; set; }
    
        [JsonProperty(DefaultValueHandling = DefaultValueHandling.IgnoreAndPopulate, PropertyName = "PrioritiesAKA")]
        public String PrioritiesAKA { get; set; }
    
        [JsonProperty(DefaultValueHandling = DefaultValueHandling.IgnoreAndPopulate, PropertyName = "PrioritiesMismatched")]
        public Nullable<Boolean> PrioritiesMismatched { get; set; }
    
        [JsonProperty(DefaultValueHandling = DefaultValueHandling.IgnoreAndPopulate, PropertyName = "Progress")]
        public Nullable<Boolean> Progress { get; set; }
    
        [JsonProperty(DefaultValueHandling = DefaultValueHandling.IgnoreAndPopulate, PropertyName = "ProgressAKA")]
        public String ProgressAKA { get; set; }
    
        [JsonProperty(DefaultValueHandling = DefaultValueHandling.IgnoreAndPopulate, PropertyName = "ProgressMismatched")]
        public Nullable<Boolean> ProgressMismatched { get; set; }
    
        [JsonProperty(DefaultValueHandling = DefaultValueHandling.IgnoreAndPopulate, PropertyName = "Statuses")]
        public Nullable<Boolean> Statuses { get; set; }
    
        [JsonProperty(DefaultValueHandling = DefaultValueHandling.IgnoreAndPopulate, PropertyName = "StatusesAKA")]
        public String StatusesAKA { get; set; }
    
        [JsonProperty(DefaultValueHandling = DefaultValueHandling.IgnoreAndPopulate, PropertyName = "StatusesMismatched")]
        public Nullable<Boolean> StatusesMismatched { get; set; }
    
        [JsonProperty(DefaultValueHandling = DefaultValueHandling.IgnoreAndPopulate, PropertyName = "Reminders")]
        public Nullable<Boolean> Reminders { get; set; }
    
        [JsonProperty(DefaultValueHandling = DefaultValueHandling.IgnoreAndPopulate, PropertyName = "RemindersAKA")]
        public String RemindersAKA { get; set; }
    
        [JsonProperty(DefaultValueHandling = DefaultValueHandling.IgnoreAndPopulate, PropertyName = "RemindersMismatched")]
        public Nullable<Boolean> RemindersMismatched { get; set; }
    
        [JsonProperty(DefaultValueHandling = DefaultValueHandling.IgnoreAndPopulate, PropertyName = "Notifications")]
        public Nullable<Boolean> Notifications { get; set; }
    
        [JsonProperty(DefaultValueHandling = DefaultValueHandling.IgnoreAndPopulate, PropertyName = "NotificationsAKA")]
        public String NotificationsAKA { get; set; }
    
        [JsonProperty(DefaultValueHandling = DefaultValueHandling.IgnoreAndPopulate, PropertyName = "NotificationsMismatched")]
        public Nullable<Boolean> NotificationsMismatched { get; set; }
    
        [JsonProperty(DefaultValueHandling = DefaultValueHandling.IgnoreAndPopulate, PropertyName = "Completion")]
        public Nullable<Boolean> Completion { get; set; }
    
        [JsonProperty(DefaultValueHandling = DefaultValueHandling.IgnoreAndPopulate, PropertyName = "CompletionAKA")]
        public String CompletionAKA { get; set; }
    
        [JsonProperty(DefaultValueHandling = DefaultValueHandling.IgnoreAndPopulate, PropertyName = "CompletionMismatched")]
        public Nullable<Boolean> CompletionMismatched { get; set; }
    
        [JsonProperty(DefaultValueHandling = DefaultValueHandling.IgnoreAndPopulate, PropertyName = "ToDoEmployees")]
        public Nullable<Boolean> ToDoEmployees { get; set; }
    
        [JsonProperty(DefaultValueHandling = DefaultValueHandling.IgnoreAndPopulate, PropertyName = "ToDoEmployeesAKA")]
        public String ToDoEmployeesAKA { get; set; }
    
        [JsonProperty(DefaultValueHandling = DefaultValueHandling.IgnoreAndPopulate, PropertyName = "ToDoEmployeesMismatched")]
        public String ToDoEmployeesMismatched { get; set; }
    
        [JsonProperty(DefaultValueHandling = DefaultValueHandling.IgnoreAndPopulate, PropertyName = "Duration")]
        public Nullable<Boolean> Duration { get; set; }
    
        [JsonProperty(DefaultValueHandling = DefaultValueHandling.IgnoreAndPopulate, PropertyName = "DurationAKA")]
        public String DurationAKA { get; set; }
    
        [JsonProperty(DefaultValueHandling = DefaultValueHandling.IgnoreAndPopulate, PropertyName = "DurationMismatched")]
        public Nullable<Boolean> DurationMismatched { get; set; }
    
        [JsonProperty(DefaultValueHandling = DefaultValueHandling.IgnoreAndPopulate, PropertyName = "CompletedDate")]
        public Nullable<Boolean> CompletedDate { get; set; }
    
        [JsonProperty(DefaultValueHandling = DefaultValueHandling.IgnoreAndPopulate, PropertyName = "CompletedDateAKA")]
        public String CompletedDateAKA { get; set; }
    
        [JsonProperty(DefaultValueHandling = DefaultValueHandling.IgnoreAndPopulate, PropertyName = "CompletedDateMismatched")]
        public Nullable<Boolean> CompletedDateMismatched { get; set; }
    
        [JsonProperty(DefaultValueHandling = DefaultValueHandling.IgnoreAndPopulate, PropertyName = "ToDoColors")]
        public Nullable<Boolean> ToDoColors { get; set; }
    
        [JsonProperty(DefaultValueHandling = DefaultValueHandling.IgnoreAndPopulate, PropertyName = "ToDoColorsAKA")]
        public String ToDoColorsAKA { get; set; }
    
        [JsonProperty(DefaultValueHandling = DefaultValueHandling.IgnoreAndPopulate, PropertyName = "ToDoColorsMismatched")]
        public Nullable<Boolean> ToDoColorsMismatched { get; set; }
    
        [JsonProperty(DefaultValueHandling = DefaultValueHandling.IgnoreAndPopulate, PropertyName = "ResponseBeingValidated")]
        public String ResponseBeingValidated { get; set; }
    
        [JsonProperty(DefaultValueHandling = DefaultValueHandling.IgnoreAndPopulate, PropertyName = "SuggestedValidationPrompt")]
        public String SuggestedValidationPrompt { get; set; }
    
        [JsonProperty(DefaultValueHandling = DefaultValueHandling.IgnoreAndPopulate, PropertyName = "ActualValidationPrompt")]
        public String ActualValidationPrompt { get; set; }
    
        [JsonProperty(DefaultValueHandling = DefaultValueHandling.IgnoreAndPopulate, PropertyName = "ValidationResponse")]
        public String ValidationResponse { get; set; }
    
        [JsonProperty(DefaultValueHandling = DefaultValueHandling.IgnoreAndPopulate, PropertyName = "GenerationName")]
        [RemoteIsCollection]
        public String[] GenerationName { get; set; }
    
        [JsonProperty(DefaultValueHandling = DefaultValueHandling.IgnoreAndPopulate, PropertyName = "GeneratioNumber")]
        [RemoteIsCollection]
        public Int32[] GeneratioNumber { get; set; }
    
        [JsonProperty(DefaultValueHandling = DefaultValueHandling.IgnoreAndPopulate, PropertyName = "GenerationTransformerNumber")]
        [RemoteIsCollection]
        public Int32[] GenerationTransformerNumber { get; set; }
    
        [JsonProperty(DefaultValueHandling = DefaultValueHandling.IgnoreAndPopulate, PropertyName = "ExtensionOfArtifactIdentifier")]
        [RemoteIsCollection]
        public Nullable<Int32> ExtensionOfArtifactIdentifier { get; set; }
    
        [JsonProperty(DefaultValueHandling = DefaultValueHandling.IgnoreAndPopulate, PropertyName = "RootArtifactIdentifier")]
        public Nullable<Int32> RootArtifactIdentifier { get; set; }
    
        [JsonProperty(DefaultValueHandling = DefaultValueHandling.IgnoreAndPopulate, PropertyName = "SuggestedRootIdentifier")]
        [RemoteIsCollection]
        public Nullable<Int32> SuggestedRootIdentifier { get; set; }
    
        [JsonProperty(DefaultValueHandling = DefaultValueHandling.IgnoreAndPopulate, PropertyName = "CustomRootIdentifier")]
        public Nullable<Int32> CustomRootIdentifier { get; set; }
    
        [JsonProperty(DefaultValueHandling = DefaultValueHandling.IgnoreAndPopulate, PropertyName = "RootIdentifierMismatch")]
        public Nullable<Int32> RootIdentifierMismatch { get; set; }
    
        [JsonProperty(DefaultValueHandling = DefaultValueHandling.IgnoreAndPopulate, PropertyName = "ExpTransformerIsSyntaxFree")]
        [RemoteIsCollection]
        public Boolean[] ExpTransformerIsSyntaxFree { get; set; }
    
        [JsonProperty(DefaultValueHandling = DefaultValueHandling.IgnoreAndPopulate, PropertyName = "IsActiveExp")]
        [RemoteIsCollection]
        public Boolean[] IsActiveExp { get; set; }
    
        [JsonProperty(DefaultValueHandling = DefaultValueHandling.IgnoreAndPopulate, PropertyName = "TransformerGenerationExpName")]
        [RemoteIsCollection]
        public String[] TransformerGenerationExpName { get; set; }
    
        [JsonProperty(DefaultValueHandling = DefaultValueHandling.IgnoreAndPopulate, PropertyName = "ExpValidationPrompt")]
        [RemoteIsCollection]
        public String[] ExpValidationPrompt { get; set; }
    
        [JsonProperty(DefaultValueHandling = DefaultValueHandling.IgnoreAndPopulate, PropertyName = "ExpAbstract")]
        [RemoteIsCollection]
        public String[] ExpAbstract { get; set; }
    

        

        
        
        
    }
}
