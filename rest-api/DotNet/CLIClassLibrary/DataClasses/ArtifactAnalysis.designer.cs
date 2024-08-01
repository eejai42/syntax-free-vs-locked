using System;
using System.ComponentModel;
using Newtonsoft.Json;
using System.Collections.Generic;
using System.Linq;
using CoreLibrary.Extensions;

namespace AirtableDirect.CLI.Lib.DataClasses
{                            
    public partial class ArtifactAnalysis
    {
        private void InitPoco()
        {
        }
        
        partial void AfterGet();
        partial void BeforeInsert();
        partial void AfterInsert();
        partial void BeforeUpdate();
        partial void AfterUpdate();

        

        
        [JsonProperty(DefaultValueHandling = DefaultValueHandling.IgnoreAndPopulate, PropertyName = "ArtifactAnalysisId")]
        public String ArtifactAnalysisId { get; set; }
    
        [JsonProperty(DefaultValueHandling = DefaultValueHandling.IgnoreAndPopulate, PropertyName = "Name")]
        public String Name { get; set; }
    
        [JsonProperty(DefaultValueHandling = DefaultValueHandling.IgnoreAndPopulate, PropertyName = "PreviousGeneration")]
        [RemoteIsCollection]
        public String PreviousGeneration { get; set; }
    
        [JsonProperty(DefaultValueHandling = DefaultValueHandling.IgnoreAndPopulate, PropertyName = "PrevGenName")]
        [RemoteIsCollection]
        public String PrevGenName { get; set; }
    
        [JsonProperty(DefaultValueHandling = DefaultValueHandling.IgnoreAndPopulate, PropertyName = "PrevGenArtifactIdentifier")]
        [RemoteIsCollection]
        public Nullable<Int32> PrevGenArtifactIdentifier { get; set; }
    
        [JsonProperty(DefaultValueHandling = DefaultValueHandling.IgnoreAndPopulate, PropertyName = "PrevGenTransformerNumber")]
        [RemoteIsCollection]
        public Nullable<Int32> PrevGenTransformerNumber { get; set; }
    
        [JsonProperty(DefaultValueHandling = DefaultValueHandling.IgnoreAndPopulate, PropertyName = "TrialArtifact")]
        [RemoteIsCollection]
        public String TrialArtifact { get; set; }
    
        [JsonProperty(DefaultValueHandling = DefaultValueHandling.IgnoreAndPopulate, PropertyName = "TrialArtifactExtensionOf")]
        [RemoteIsCollection]
        public String TrialArtifactExtensionOf { get; set; }
    
        [JsonProperty(DefaultValueHandling = DefaultValueHandling.IgnoreAndPopulate, PropertyName = "ExpTransformerIsSyntaxFree")]
        [RemoteIsCollection]
        public Nullable<Boolean> ExpTransformerIsSyntaxFree { get; set; }
    
        [JsonProperty(DefaultValueHandling = DefaultValueHandling.IgnoreAndPopulate, PropertyName = "RootArtifactIdentifier")]
        [RemoteIsCollection]
        public Nullable<Int32> RootArtifactIdentifier { get; set; }
    
        [JsonProperty(DefaultValueHandling = DefaultValueHandling.IgnoreAndPopulate, PropertyName = "GenerationName")]
        [RemoteIsCollection]
        public String GenerationName { get; set; }
    
        [JsonProperty(DefaultValueHandling = DefaultValueHandling.IgnoreAndPopulate, PropertyName = "ArtifactIdentifier")]
        [RemoteIsCollection]
        public Nullable<Int32> ArtifactIdentifier { get; set; }
    
        [JsonProperty(DefaultValueHandling = DefaultValueHandling.IgnoreAndPopulate, PropertyName = "GenerationTransformerNumber")]
        [RemoteIsCollection]
        public Nullable<Int32> GenerationTransformerNumber { get; set; }
    
        [JsonProperty(DefaultValueHandling = DefaultValueHandling.IgnoreAndPopulate, PropertyName = "TrialArtifactLongName")]
        [RemoteIsCollection]
        public String TrialArtifactLongName { get; set; }
    
        [JsonProperty(DefaultValueHandling = DefaultValueHandling.IgnoreAndPopulate, PropertyName = "TrialArtifactGeneratioNumber")]
        [RemoteIsCollection]
        public Nullable<Int32> TrialArtifactGeneratioNumber { get; set; }
    
        [JsonProperty(DefaultValueHandling = DefaultValueHandling.IgnoreAndPopulate, PropertyName = "TransformerGeneratioNumber")]
        [RemoteIsCollection]
        public Nullable<Int32> TransformerGeneratioNumber { get; set; }
    
        [JsonProperty(DefaultValueHandling = DefaultValueHandling.IgnoreAndPopulate, PropertyName = "TransformerGenerationName")]
        [RemoteIsCollection]
        public String TransformerGenerationName { get; set; }
    
        [JsonProperty(DefaultValueHandling = DefaultValueHandling.IgnoreAndPopulate, PropertyName = "ResponseBeingValidated")]
        [RemoteIsCollection]
        public String ResponseBeingValidated { get; set; }
    
        [JsonProperty(DefaultValueHandling = DefaultValueHandling.IgnoreAndPopulate, PropertyName = "TrialArtifactActualPrompt")]
        [RemoteIsCollection]
        public String TrialArtifactActualPrompt { get; set; }
    
        [JsonProperty(DefaultValueHandling = DefaultValueHandling.IgnoreAndPopulate, PropertyName = "TrialArtifactResponse")]
        [RemoteIsCollection]
        public String TrialArtifactResponse { get; set; }
    
        [JsonProperty(DefaultValueHandling = DefaultValueHandling.IgnoreAndPopulate, PropertyName = "TrialArtifactActualValidationPrompt")]
        [RemoteIsCollection]
        public String TrialArtifactActualValidationPrompt { get; set; }
    
        [JsonProperty(DefaultValueHandling = DefaultValueHandling.IgnoreAndPopulate, PropertyName = "TrialArtifactValidationResponse")]
        [RemoteIsCollection]
        public String TrialArtifactValidationResponse { get; set; }
    
        [JsonProperty(DefaultValueHandling = DefaultValueHandling.IgnoreAndPopulate, PropertyName = "CleanValidationJson")]
        public String CleanValidationJson { get; set; }
    
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
    
        [JsonProperty(DefaultValueHandling = DefaultValueHandling.IgnoreAndPopulate, PropertyName = "PrevGenToDoItems")]
        [RemoteIsCollection]
        public Nullable<Boolean> PrevGenToDoItems { get; set; }
    
        [JsonProperty(DefaultValueHandling = DefaultValueHandling.IgnoreAndPopulate, PropertyName = "PrevGenToDoItemsAKA")]
        [RemoteIsCollection]
        public String PrevGenToDoItemsAKA { get; set; }
    
        [JsonProperty(DefaultValueHandling = DefaultValueHandling.IgnoreAndPopulate, PropertyName = "PrevGenToDoItemsMismatched")]
        [RemoteIsCollection]
        public Nullable<Boolean> PrevGenToDoItemsMismatched { get; set; }
    
        [JsonProperty(DefaultValueHandling = DefaultValueHandling.IgnoreAndPopulate, PropertyName = "PrevGenCategories")]
        [RemoteIsCollection]
        public Nullable<Boolean> PrevGenCategories { get; set; }
    
        [JsonProperty(DefaultValueHandling = DefaultValueHandling.IgnoreAndPopulate, PropertyName = "PrevGenCategoriesAKA")]
        [RemoteIsCollection]
        public String PrevGenCategoriesAKA { get; set; }
    
        [JsonProperty(DefaultValueHandling = DefaultValueHandling.IgnoreAndPopulate, PropertyName = "PrevGenCategoriesMismatched")]
        [RemoteIsCollection]
        public Nullable<Boolean> PrevGenCategoriesMismatched { get; set; }
    
        [JsonProperty(DefaultValueHandling = DefaultValueHandling.IgnoreAndPopulate, PropertyName = "PrevGenDueDates")]
        [RemoteIsCollection]
        public Nullable<Boolean> PrevGenDueDates { get; set; }
    
        [JsonProperty(DefaultValueHandling = DefaultValueHandling.IgnoreAndPopulate, PropertyName = "PrevGenDueDatesAKA")]
        [RemoteIsCollection]
        public String PrevGenDueDatesAKA { get; set; }
    
        [JsonProperty(DefaultValueHandling = DefaultValueHandling.IgnoreAndPopulate, PropertyName = "PrevGenDueDatesMismatched")]
        [RemoteIsCollection]
        public Nullable<Boolean> PrevGenDueDatesMismatched { get; set; }
    
        [JsonProperty(DefaultValueHandling = DefaultValueHandling.IgnoreAndPopulate, PropertyName = "PrevGenPriorities")]
        [RemoteIsCollection]
        public Nullable<Boolean> PrevGenPriorities { get; set; }
    
        [JsonProperty(DefaultValueHandling = DefaultValueHandling.IgnoreAndPopulate, PropertyName = "PrevGenPrioritiesAKA")]
        [RemoteIsCollection]
        public String PrevGenPrioritiesAKA { get; set; }
    
        [JsonProperty(DefaultValueHandling = DefaultValueHandling.IgnoreAndPopulate, PropertyName = "PrevGenPrioritiesMismatched")]
        [RemoteIsCollection]
        public Nullable<Boolean> PrevGenPrioritiesMismatched { get; set; }
    
        [JsonProperty(DefaultValueHandling = DefaultValueHandling.IgnoreAndPopulate, PropertyName = "PrevGenProgress")]
        [RemoteIsCollection]
        public Nullable<Boolean> PrevGenProgress { get; set; }
    
        [JsonProperty(DefaultValueHandling = DefaultValueHandling.IgnoreAndPopulate, PropertyName = "PrevGenProgressAKA")]
        [RemoteIsCollection]
        public String PrevGenProgressAKA { get; set; }
    
        [JsonProperty(DefaultValueHandling = DefaultValueHandling.IgnoreAndPopulate, PropertyName = "PrevGenProgressMismatched")]
        [RemoteIsCollection]
        public Nullable<Boolean> PrevGenProgressMismatched { get; set; }
    
        [JsonProperty(DefaultValueHandling = DefaultValueHandling.IgnoreAndPopulate, PropertyName = "PrevGenStatuses")]
        [RemoteIsCollection]
        public Nullable<Boolean> PrevGenStatuses { get; set; }
    
        [JsonProperty(DefaultValueHandling = DefaultValueHandling.IgnoreAndPopulate, PropertyName = "PrevGenStatusesAKA")]
        [RemoteIsCollection]
        public String PrevGenStatusesAKA { get; set; }
    
        [JsonProperty(DefaultValueHandling = DefaultValueHandling.IgnoreAndPopulate, PropertyName = "PrevGenStatusesMismatched")]
        [RemoteIsCollection]
        public Nullable<Boolean> PrevGenStatusesMismatched { get; set; }
    
        [JsonProperty(DefaultValueHandling = DefaultValueHandling.IgnoreAndPopulate, PropertyName = "PrevGenReminders")]
        [RemoteIsCollection]
        public Nullable<Boolean> PrevGenReminders { get; set; }
    
        [JsonProperty(DefaultValueHandling = DefaultValueHandling.IgnoreAndPopulate, PropertyName = "PrevGenRemindersAKA")]
        [RemoteIsCollection]
        public String PrevGenRemindersAKA { get; set; }
    
        [JsonProperty(DefaultValueHandling = DefaultValueHandling.IgnoreAndPopulate, PropertyName = "PrevGenRemindersMismatched")]
        [RemoteIsCollection]
        public Nullable<Boolean> PrevGenRemindersMismatched { get; set; }
    
        [JsonProperty(DefaultValueHandling = DefaultValueHandling.IgnoreAndPopulate, PropertyName = "PrevGenNotifications")]
        [RemoteIsCollection]
        public Nullable<Boolean> PrevGenNotifications { get; set; }
    
        [JsonProperty(DefaultValueHandling = DefaultValueHandling.IgnoreAndPopulate, PropertyName = "PrevGenNotificationsAKA")]
        [RemoteIsCollection]
        public String PrevGenNotificationsAKA { get; set; }
    
        [JsonProperty(DefaultValueHandling = DefaultValueHandling.IgnoreAndPopulate, PropertyName = "PrevGenNotificationsMismatched")]
        [RemoteIsCollection]
        public Nullable<Boolean> PrevGenNotificationsMismatched { get; set; }
    
        [JsonProperty(DefaultValueHandling = DefaultValueHandling.IgnoreAndPopulate, PropertyName = "PrevGenCompletion")]
        [RemoteIsCollection]
        public Nullable<Boolean> PrevGenCompletion { get; set; }
    
        [JsonProperty(DefaultValueHandling = DefaultValueHandling.IgnoreAndPopulate, PropertyName = "PrevGenCompletionAKA")]
        [RemoteIsCollection]
        public String PrevGenCompletionAKA { get; set; }
    
        [JsonProperty(DefaultValueHandling = DefaultValueHandling.IgnoreAndPopulate, PropertyName = "PrevGenCompletionMismatched")]
        [RemoteIsCollection]
        public Nullable<Boolean> PrevGenCompletionMismatched { get; set; }
    
        [JsonProperty(DefaultValueHandling = DefaultValueHandling.IgnoreAndPopulate, PropertyName = "PrevGenToDoEmployees")]
        [RemoteIsCollection]
        public Nullable<Boolean> PrevGenToDoEmployees { get; set; }
    
        [JsonProperty(DefaultValueHandling = DefaultValueHandling.IgnoreAndPopulate, PropertyName = "PrevGenToDoEmployeesAKA")]
        [RemoteIsCollection]
        public String PrevGenToDoEmployeesAKA { get; set; }
    
        [JsonProperty(DefaultValueHandling = DefaultValueHandling.IgnoreAndPopulate, PropertyName = "PrevGenToDoEmployeesMismatched")]
        [RemoteIsCollection]
        public String PrevGenToDoEmployeesMismatched { get; set; }
    
        [JsonProperty(DefaultValueHandling = DefaultValueHandling.IgnoreAndPopulate, PropertyName = "PrevGenDuration")]
        [RemoteIsCollection]
        public Nullable<Boolean> PrevGenDuration { get; set; }
    
        [JsonProperty(DefaultValueHandling = DefaultValueHandling.IgnoreAndPopulate, PropertyName = "PrevGenDurationAKA")]
        [RemoteIsCollection]
        public String PrevGenDurationAKA { get; set; }
    
        [JsonProperty(DefaultValueHandling = DefaultValueHandling.IgnoreAndPopulate, PropertyName = "PrevGenDurationMismatched")]
        [RemoteIsCollection]
        public Nullable<Boolean> PrevGenDurationMismatched { get; set; }
    
        [JsonProperty(DefaultValueHandling = DefaultValueHandling.IgnoreAndPopulate, PropertyName = "PrevGenCompletedDate")]
        [RemoteIsCollection]
        public Nullable<Boolean> PrevGenCompletedDate { get; set; }
    
        [JsonProperty(DefaultValueHandling = DefaultValueHandling.IgnoreAndPopulate, PropertyName = "PrevGenCompletedDateAKA")]
        [RemoteIsCollection]
        public String PrevGenCompletedDateAKA { get; set; }
    
        [JsonProperty(DefaultValueHandling = DefaultValueHandling.IgnoreAndPopulate, PropertyName = "PrevGenCompletedDateMismatched")]
        [RemoteIsCollection]
        public Nullable<Boolean> PrevGenCompletedDateMismatched { get; set; }
    
        [JsonProperty(DefaultValueHandling = DefaultValueHandling.IgnoreAndPopulate, PropertyName = "PrevGenToDoColors")]
        [RemoteIsCollection]
        public Nullable<Boolean> PrevGenToDoColors { get; set; }
    
        [JsonProperty(DefaultValueHandling = DefaultValueHandling.IgnoreAndPopulate, PropertyName = "PrevGenToDoColorsAKA")]
        [RemoteIsCollection]
        public String PrevGenToDoColorsAKA { get; set; }
    
        [JsonProperty(DefaultValueHandling = DefaultValueHandling.IgnoreAndPopulate, PropertyName = "PrevGenToDoColorsMismatched")]
        [RemoteIsCollection]
        public Nullable<Boolean> PrevGenToDoColorsMismatched { get; set; }
    
        [JsonProperty(DefaultValueHandling = DefaultValueHandling.IgnoreAndPopulate, PropertyName = "Modified")]
        public Nullable<DateTime> Modified { get; set; }
    
        [JsonProperty(DefaultValueHandling = DefaultValueHandling.IgnoreAndPopulate, PropertyName = "TrailIdentifier")]
        [RemoteIsCollection]
        public Nullable<Int32> TrailIdentifier { get; set; }
    
        [JsonProperty(DefaultValueHandling = DefaultValueHandling.IgnoreAndPopulate, PropertyName = "Ready")]
        public Nullable<Boolean> Ready { get; set; }
    
        [JsonProperty(DefaultValueHandling = DefaultValueHandling.IgnoreAndPopulate, PropertyName = "HasBeenAnalyzed")]
        public Nullable<Boolean> HasBeenAnalyzed { get; set; }
    

        

        
        
        
    }
}
