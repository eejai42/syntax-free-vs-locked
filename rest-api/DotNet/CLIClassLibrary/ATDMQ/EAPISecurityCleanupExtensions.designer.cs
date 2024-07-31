using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using AirtableDirect.CLI.Lib.DataClasses;
using dc=AirtableDirect.CLI.Lib.DataClasses;



namespace CLIClassLibrary.ATDMQ
{
    public static partial class EAPISecurityCleanupExtensions
    {
    
        // Guest Cleaning Extension Methods.  --
        
        // Guest Cleaning Extension Methods.  --
        
        // Guest Cleaning Extension Methods.  --
        
        // Guest Cleaning Extension Methods.  --
        
        // Guest Cleaning Extension Methods.  --
        
        // Guest Cleaning Extension Methods.  --
        
        // Guest Cleaning Extension Methods.  --
        
        // Guest Cleaning Extension Methods.  --
        
        // Guest Cleaning Extension Methods.  --
        
        // CRUDCoordinator Cleaning Extension Methods.  --
        
        // CRUDCoordinator Cleaning Extension Methods.  --
        
        // CRUDCoordinator Cleaning Extension Methods.  --
        
        // CRUDCoordinator Cleaning Extension Methods.  --
        
        // CRUDCoordinator Cleaning Extension Methods.  --
        
        // CRUDCoordinator Cleaning Extension Methods.  --
        
        // CRUDCoordinator Cleaning Extension Methods.  --
        
        // CRUDCoordinator Cleaning Extension Methods.  --
        
        // CRUDCoordinator Cleaning Extension Methods.  --
        
        // User Cleaning Extension Methods.  -CRUD-
        
        // IdeaTransformer
        public static dc.IdeaTransformer UserCleanForAdd(this dc.IdeaTransformer cleanIdeaTransformer)
        {
            var UserIdeaTransformer = default(dc.IdeaTransformer);

            if (!ReferenceEquals(cleanIdeaTransformer, null))
            {
                UserIdeaTransformer = new dc.IdeaTransformer()
                {
                     // default value: . 
                    IdeaTransformerId = cleanIdeaTransformer.IdeaTransformerId,
                     // default value: . 
                    Idea = cleanIdeaTransformer.Idea,
                     // default value: . 
                    FullPrompt = cleanIdeaTransformer.FullPrompt,
                     // default value: . 
                    TransformedTransformers = cleanIdeaTransformer.TransformedTransformers,
                     // default value: . 
                    AutoNumber = cleanIdeaTransformer.AutoNumber,
                     // default value: . 
                    IsSyntaxFree = cleanIdeaTransformer.IsSyntaxFree
                };
                
            }

            return UserIdeaTransformer;
        }
        
        
        public static List<dc.IdeaTransformer> UserCleanForGet(this IEnumerable<dc.IdeaTransformer> cleanIdeaTransformers)
        {
            return cleanIdeaTransformers.Select(IdeaTransformer => IdeaTransformer.UserCleanForGet())
                            .ToList();
        }
        
        public static dc.IdeaTransformer UserCleanForGet(this dc.IdeaTransformer cleanIdeaTransformer)
        {
            var UserIdeaTransformer = default(dc.IdeaTransformer);

            if (!ReferenceEquals(cleanIdeaTransformer, null))
            {
                UserIdeaTransformer = new dc.IdeaTransformer()
                {
                    IdeaTransformerId = cleanIdeaTransformer.IdeaTransformerId,
                    Name = cleanIdeaTransformer.Name,
                    Idea = cleanIdeaTransformer.Idea,
                    IdeaName = cleanIdeaTransformer.IdeaName,
                    IdeasSourceIdea = cleanIdeaTransformer.IdeasSourceIdea,
                    IsActiveIdea = cleanIdeaTransformer.IsActiveIdea,
                    FullPrompt = cleanIdeaTransformer.FullPrompt,
                    TransformedTransformers = cleanIdeaTransformer.TransformedTransformers,
                    AutoNumber = cleanIdeaTransformer.AutoNumber,
                    IdeaIdentifier = cleanIdeaTransformer.IdeaIdentifier,
                    IsSyntaxFree = cleanIdeaTransformer.IsSyntaxFree
                };
            }

            return UserIdeaTransformer;
        }
        
        
        public static dc.IdeaTransformer UserCleanForUpdate(this dc.IdeaTransformer cleanIdeaTransformer)
        {
            var UserIdeaTransformer = default(dc.IdeaTransformer);

            if (!ReferenceEquals(cleanIdeaTransformer, null))
            {
                UserIdeaTransformer = new dc.IdeaTransformer()
                {
                    IdeaTransformerId = cleanIdeaTransformer.IdeaTransformerId,
                    Idea = cleanIdeaTransformer.Idea,
                    FullPrompt = cleanIdeaTransformer.FullPrompt,
                    TransformedTransformers = cleanIdeaTransformer.TransformedTransformers,
                    AutoNumber = cleanIdeaTransformer.AutoNumber,
                    IsSyntaxFree = cleanIdeaTransformer.IsSyntaxFree
                };
            }

            return UserIdeaTransformer;
        }

        // User Cleaning Extension Methods.  -CRUD-
        
        // AppUser
        public static dc.AppUser UserCleanForAdd(this dc.AppUser cleanAppUser)
        {
            var UserAppUser = default(dc.AppUser);

            if (!ReferenceEquals(cleanAppUser, null))
            {
                UserAppUser = new dc.AppUser()
                {
                     // default value: . 
                    AppUserId = cleanAppUser.AppUserId,
                     // default value: . 
                    Name = cleanAppUser.Name,
                     // default value: . 
                    Roles = cleanAppUser.Roles,
                     // default value: . 
                    EmailAddress = cleanAppUser.EmailAddress
                };
                
            }

            return UserAppUser;
        }
        
        
        public static List<dc.AppUser> UserCleanForGet(this IEnumerable<dc.AppUser> cleanAppUsers)
        {
            return cleanAppUsers.Select(AppUser => AppUser.UserCleanForGet())
                            .ToList();
        }
        
        public static dc.AppUser UserCleanForGet(this dc.AppUser cleanAppUser)
        {
            var UserAppUser = default(dc.AppUser);

            if (!ReferenceEquals(cleanAppUser, null))
            {
                UserAppUser = new dc.AppUser()
                {
                    AppUserId = cleanAppUser.AppUserId,
                    Name = cleanAppUser.Name,
                    Roles = cleanAppUser.Roles,
                    EmailAddress = cleanAppUser.EmailAddress
                };
            }

            return UserAppUser;
        }
        
        
        public static dc.AppUser UserCleanForUpdate(this dc.AppUser cleanAppUser)
        {
            var UserAppUser = default(dc.AppUser);

            if (!ReferenceEquals(cleanAppUser, null))
            {
                UserAppUser = new dc.AppUser()
                {
                    AppUserId = cleanAppUser.AppUserId,
                    Name = cleanAppUser.Name,
                    Roles = cleanAppUser.Roles,
                    EmailAddress = cleanAppUser.EmailAddress
                };
            }

            return UserAppUser;
        }

        // User Cleaning Extension Methods.  -CRUD-
        
        // GenerationTransformer
        public static dc.GenerationTransformer UserCleanForAdd(this dc.GenerationTransformer cleanGenerationTransformer)
        {
            var UserGenerationTransformer = default(dc.GenerationTransformer);

            if (!ReferenceEquals(cleanGenerationTransformer, null))
            {
                UserGenerationTransformer = new dc.GenerationTransformer()
                {
                     // default value: . 
                    GenerationTransformerId = cleanGenerationTransformer.GenerationTransformerId,
                     // default value: . 
                    Generation = cleanGenerationTransformer.Generation,
                     // default value: . 
                    TransformedArtifacts = cleanGenerationTransformer.TransformedArtifacts,
                     // default value: . 
                    AutoNumber = cleanGenerationTransformer.AutoNumber,
                     // default value: . 
                    IsArtifactValidator = cleanGenerationTransformer.IsArtifactValidator,
                     // default value: . 
                    IdeaTransformer = cleanGenerationTransformer.IdeaTransformer
                };
                
            }

            return UserGenerationTransformer;
        }
        
        
        public static List<dc.GenerationTransformer> UserCleanForGet(this IEnumerable<dc.GenerationTransformer> cleanGenerationTransformers)
        {
            return cleanGenerationTransformers.Select(GenerationTransformer => GenerationTransformer.UserCleanForGet())
                            .ToList();
        }
        
        public static dc.GenerationTransformer UserCleanForGet(this dc.GenerationTransformer cleanGenerationTransformer)
        {
            var UserGenerationTransformer = default(dc.GenerationTransformer);

            if (!ReferenceEquals(cleanGenerationTransformer, null))
            {
                UserGenerationTransformer = new dc.GenerationTransformer()
                {
                    GenerationTransformerId = cleanGenerationTransformer.GenerationTransformerId,
                    Name = cleanGenerationTransformer.Name,
                    Generation = cleanGenerationTransformer.Generation,
                    RawPrompt = cleanGenerationTransformer.RawPrompt,
                    SourceIdea = cleanGenerationTransformer.SourceIdea,
                    GenerationName = cleanGenerationTransformer.GenerationName,
                    GenerationIdea = cleanGenerationTransformer.GenerationIdea,
                    GenerationIdeaName = cleanGenerationTransformer.GenerationIdeaName,
                    GeneratioNumber = cleanGenerationTransformer.GeneratioNumber,
                    IsActiveIdea = cleanGenerationTransformer.IsActiveIdea,
                    TransformedArtifacts = cleanGenerationTransformer.TransformedArtifacts,
                    AutoNumber = cleanGenerationTransformer.AutoNumber,
                    TransformerNumber = cleanGenerationTransformer.TransformerNumber,
                    IsArtifactValidator = cleanGenerationTransformer.IsArtifactValidator,
                    IdeaValidationPrompt = cleanGenerationTransformer.IdeaValidationPrompt,
                    IdeaTransformer = cleanGenerationTransformer.IdeaTransformer,
                    IdeaTransformerIsSyntaxFree = cleanGenerationTransformer.IdeaTransformerIsSyntaxFree
                };
            }

            return UserGenerationTransformer;
        }
        
        
        public static dc.GenerationTransformer UserCleanForUpdate(this dc.GenerationTransformer cleanGenerationTransformer)
        {
            var UserGenerationTransformer = default(dc.GenerationTransformer);

            if (!ReferenceEquals(cleanGenerationTransformer, null))
            {
                UserGenerationTransformer = new dc.GenerationTransformer()
                {
                    GenerationTransformerId = cleanGenerationTransformer.GenerationTransformerId,
                    Generation = cleanGenerationTransformer.Generation,
                    TransformedArtifacts = cleanGenerationTransformer.TransformedArtifacts,
                    AutoNumber = cleanGenerationTransformer.AutoNumber,
                    IsArtifactValidator = cleanGenerationTransformer.IsArtifactValidator,
                    IdeaTransformer = cleanGenerationTransformer.IdeaTransformer
                };
            }

            return UserGenerationTransformer;
        }

        // User Cleaning Extension Methods.  -CRUD-
        
        // Generation
        public static dc.Generation UserCleanForAdd(this dc.Generation cleanGeneration)
        {
            var UserGeneration = default(dc.Generation);

            if (!ReferenceEquals(cleanGeneration, null))
            {
                UserGeneration = new dc.Generation()
                {
                     // default value: . 
                    GenerationId = cleanGeneration.GenerationId,
                     // default value: . 
                    Idea = cleanGeneration.Idea,
                     // default value: . 
                    GeneratioNumber = cleanGeneration.GeneratioNumber,
                     // default value: . 
                    TransformedArtifacts = cleanGeneration.TransformedArtifacts,
                     // default value: . 
                    Model = cleanGeneration.Model
                };
                
            }

            return UserGeneration;
        }
        
        
        public static List<dc.Generation> UserCleanForGet(this IEnumerable<dc.Generation> cleanGenerations)
        {
            return cleanGenerations.Select(Generation => Generation.UserCleanForGet())
                            .ToList();
        }
        
        public static dc.Generation UserCleanForGet(this dc.Generation cleanGeneration)
        {
            var UserGeneration = default(dc.Generation);

            if (!ReferenceEquals(cleanGeneration, null))
            {
                UserGeneration = new dc.Generation()
                {
                    GenerationId = cleanGeneration.GenerationId,
                    Name = cleanGeneration.Name,
                    Idea = cleanGeneration.Idea,
                    IdeaName = cleanGeneration.IdeaName,
                    GeneratioNumber = cleanGeneration.GeneratioNumber,
                    TransformedArtifacts = cleanGeneration.TransformedArtifacts,
                    IsActiveIdea = cleanGeneration.IsActiveIdea,
                    IdeaSourceIdea = cleanGeneration.IdeaSourceIdea,
                    Model = cleanGeneration.Model,
                    IdeaValidationPrompt = cleanGeneration.IdeaValidationPrompt,
                    TransformedArtifactRawPrompts = cleanGeneration.TransformedArtifactRawPrompts
                };
            }

            return UserGeneration;
        }
        
        
        public static dc.Generation UserCleanForUpdate(this dc.Generation cleanGeneration)
        {
            var UserGeneration = default(dc.Generation);

            if (!ReferenceEquals(cleanGeneration, null))
            {
                UserGeneration = new dc.Generation()
                {
                    GenerationId = cleanGeneration.GenerationId,
                    Idea = cleanGeneration.Idea,
                    GeneratioNumber = cleanGeneration.GeneratioNumber,
                    TransformedArtifacts = cleanGeneration.TransformedArtifacts,
                    Model = cleanGeneration.Model
                };
            }

            return UserGeneration;
        }

        // User Cleaning Extension Methods.  -CRUD-
        
        // IdeaFeature
        public static dc.IdeaFeature UserCleanForAdd(this dc.IdeaFeature cleanIdeaFeature)
        {
            var UserIdeaFeature = default(dc.IdeaFeature);

            if (!ReferenceEquals(cleanIdeaFeature, null))
            {
                UserIdeaFeature = new dc.IdeaFeature()
                {
                     // default value: . 
                    IdeaFeatureId = cleanIdeaFeature.IdeaFeatureId,
                     // default value: . 
                    Name = cleanIdeaFeature.Name,
                     // default value: . 
                    LowerName = cleanIdeaFeature.LowerName,
                     // default value: . 
                    Description = cleanIdeaFeature.Description,
                     // default value: . 
                    RequiredStartingAtGeneration = cleanIdeaFeature.RequiredStartingAtGeneration,
                     // default value: . 
                    ExplicitlyRemovedAtGeneration = cleanIdeaFeature.ExplicitlyRemovedAtGeneration,
                     // default value: . 
                    Idea = cleanIdeaFeature.Idea
                };
                
            }

            return UserIdeaFeature;
        }
        
        
        public static List<dc.IdeaFeature> UserCleanForGet(this IEnumerable<dc.IdeaFeature> cleanIdeaFeatures)
        {
            return cleanIdeaFeatures.Select(IdeaFeature => IdeaFeature.UserCleanForGet())
                            .ToList();
        }
        
        public static dc.IdeaFeature UserCleanForGet(this dc.IdeaFeature cleanIdeaFeature)
        {
            var UserIdeaFeature = default(dc.IdeaFeature);

            if (!ReferenceEquals(cleanIdeaFeature, null))
            {
                UserIdeaFeature = new dc.IdeaFeature()
                {
                    IdeaFeatureId = cleanIdeaFeature.IdeaFeatureId,
                    Name = cleanIdeaFeature.Name,
                    LowerName = cleanIdeaFeature.LowerName,
                    Description = cleanIdeaFeature.Description,
                    RequiredStartingAtGeneration = cleanIdeaFeature.RequiredStartingAtGeneration,
                    ExplicitlyRemovedAtGeneration = cleanIdeaFeature.ExplicitlyRemovedAtGeneration,
                    SourceIdea = cleanIdeaFeature.SourceIdea,
                    Idea = cleanIdeaFeature.Idea,
                    IsActiveIdea = cleanIdeaFeature.IsActiveIdea
                };
            }

            return UserIdeaFeature;
        }
        
        
        public static dc.IdeaFeature UserCleanForUpdate(this dc.IdeaFeature cleanIdeaFeature)
        {
            var UserIdeaFeature = default(dc.IdeaFeature);

            if (!ReferenceEquals(cleanIdeaFeature, null))
            {
                UserIdeaFeature = new dc.IdeaFeature()
                {
                    IdeaFeatureId = cleanIdeaFeature.IdeaFeatureId,
                    Name = cleanIdeaFeature.Name,
                    LowerName = cleanIdeaFeature.LowerName,
                    Description = cleanIdeaFeature.Description,
                    RequiredStartingAtGeneration = cleanIdeaFeature.RequiredStartingAtGeneration,
                    ExplicitlyRemovedAtGeneration = cleanIdeaFeature.ExplicitlyRemovedAtGeneration,
                    Idea = cleanIdeaFeature.Idea
                };
            }

            return UserIdeaFeature;
        }

        // User Cleaning Extension Methods.  -CRUD-
        
        // TransformedArtifact
        public static dc.TransformedArtifact UserCleanForAdd(this dc.TransformedArtifact cleanTransformedArtifact)
        {
            var UserTransformedArtifact = default(dc.TransformedArtifact);

            if (!ReferenceEquals(cleanTransformedArtifact, null))
            {
                UserTransformedArtifact = new dc.TransformedArtifact()
                {
                     // default value: . 
                    TransformedArtifactId = cleanTransformedArtifact.TransformedArtifactId,
                     // default value: . 
                    GenerationTransformer = cleanTransformedArtifact.GenerationTransformer,
                     // default value: . 
                    ActualPrompt = cleanTransformedArtifact.ActualPrompt,
                     // default value: . 
                    Response = cleanTransformedArtifact.Response,
                     // default value: . 
                    AutoNumber = cleanTransformedArtifact.AutoNumber,
                     // default value: . 
                    IsRetiredArtifact = cleanTransformedArtifact.IsRetiredArtifact,
                     // default value: . 
                    ExtensionOf = cleanTransformedArtifact.ExtensionOf,
                     // default value: . 
                    PrimaryExtensionArtifact = cleanTransformedArtifact.PrimaryExtensionArtifact,
                     // default value: . 
                    ToDoItems = cleanTransformedArtifact.ToDoItems,
                     // default value: . 
                    ToDoItemsAKA = cleanTransformedArtifact.ToDoItemsAKA,
                     // default value: . 
                    ToDoItemsMismatched = cleanTransformedArtifact.ToDoItemsMismatched,
                     // default value: . 
                    Categories = cleanTransformedArtifact.Categories,
                     // default value: . 
                    CategoriesAKA = cleanTransformedArtifact.CategoriesAKA,
                     // default value: . 
                    CategoriesMismatched = cleanTransformedArtifact.CategoriesMismatched,
                     // default value: . 
                    DueDates = cleanTransformedArtifact.DueDates,
                     // default value: . 
                    DueDatesAKA = cleanTransformedArtifact.DueDatesAKA,
                     // default value: . 
                    DueDatesMismatched = cleanTransformedArtifact.DueDatesMismatched,
                     // default value: . 
                    Priorities = cleanTransformedArtifact.Priorities,
                     // default value: . 
                    PrioritiesAKA = cleanTransformedArtifact.PrioritiesAKA,
                     // default value: . 
                    PrioritiesMismatched = cleanTransformedArtifact.PrioritiesMismatched,
                     // default value: . 
                    Progress = cleanTransformedArtifact.Progress,
                     // default value: . 
                    ProgressAKA = cleanTransformedArtifact.ProgressAKA,
                     // default value: . 
                    ProgressMismatched = cleanTransformedArtifact.ProgressMismatched,
                     // default value: . 
                    Statuses = cleanTransformedArtifact.Statuses,
                     // default value: . 
                    StatusesAKA = cleanTransformedArtifact.StatusesAKA,
                     // default value: . 
                    StatusesMismatched = cleanTransformedArtifact.StatusesMismatched,
                     // default value: . 
                    Reminders = cleanTransformedArtifact.Reminders,
                     // default value: . 
                    RemindersAKA = cleanTransformedArtifact.RemindersAKA,
                     // default value: . 
                    RemindersMismatched = cleanTransformedArtifact.RemindersMismatched,
                     // default value: . 
                    Notifications = cleanTransformedArtifact.Notifications,
                     // default value: . 
                    NotificationsAKA = cleanTransformedArtifact.NotificationsAKA,
                     // default value: . 
                    NotificationsMismatched = cleanTransformedArtifact.NotificationsMismatched,
                     // default value: . 
                    Completion = cleanTransformedArtifact.Completion,
                     // default value: . 
                    CompletionAKA = cleanTransformedArtifact.CompletionAKA,
                     // default value: . 
                    CompletionMismatched = cleanTransformedArtifact.CompletionMismatched,
                     // default value: . 
                    ToDoEmployees = cleanTransformedArtifact.ToDoEmployees,
                     // default value: . 
                    ToDoEmployeesAKA = cleanTransformedArtifact.ToDoEmployeesAKA,
                     // default value: . 
                    ToDoEmployeesMismatched = cleanTransformedArtifact.ToDoEmployeesMismatched,
                     // default value: . 
                    Duration = cleanTransformedArtifact.Duration,
                     // default value: . 
                    DurationAKA = cleanTransformedArtifact.DurationAKA,
                     // default value: . 
                    DurationMismatched = cleanTransformedArtifact.DurationMismatched,
                     // default value: . 
                    CompletedDate = cleanTransformedArtifact.CompletedDate,
                     // default value: . 
                    CompletedDateAKA = cleanTransformedArtifact.CompletedDateAKA,
                     // default value: . 
                    CompletedDateMismatched = cleanTransformedArtifact.CompletedDateMismatched,
                     // default value: . 
                    ToDoColors = cleanTransformedArtifact.ToDoColors,
                     // default value: . 
                    ToDoColorsAKA = cleanTransformedArtifact.ToDoColorsAKA,
                     // default value: . 
                    ToDoColorsMismatched = cleanTransformedArtifact.ToDoColorsMismatched,
                     // default value: . 
                    ActualValidationPrompt = cleanTransformedArtifact.ActualValidationPrompt,
                     // default value: . 
                    ValidationResponse = cleanTransformedArtifact.ValidationResponse,
                     // default value: . 
                    CustomRootIdentifier = cleanTransformedArtifact.CustomRootIdentifier
                };
                
            }

            return UserTransformedArtifact;
        }
        
        
        public static List<dc.TransformedArtifact> UserCleanForGet(this IEnumerable<dc.TransformedArtifact> cleanTransformedArtifacts)
        {
            return cleanTransformedArtifacts.Select(TransformedArtifact => TransformedArtifact.UserCleanForGet())
                            .ToList();
        }
        
        public static dc.TransformedArtifact UserCleanForGet(this dc.TransformedArtifact cleanTransformedArtifact)
        {
            var UserTransformedArtifact = default(dc.TransformedArtifact);

            if (!ReferenceEquals(cleanTransformedArtifact, null))
            {
                UserTransformedArtifact = new dc.TransformedArtifact()
                {
                    TransformedArtifactId = cleanTransformedArtifact.TransformedArtifactId,
                    Name = cleanTransformedArtifact.Name,
                    GenerationTransformer = cleanTransformedArtifact.GenerationTransformer,
                    SuggestedPrompt = cleanTransformedArtifact.SuggestedPrompt,
                    ActualPrompt = cleanTransformedArtifact.ActualPrompt,
                    Response = cleanTransformedArtifact.Response,
                    Created = cleanTransformedArtifact.Created,
                    AutoNumber = cleanTransformedArtifact.AutoNumber,
                    ResponseOfArtifactBeingExtended = cleanTransformedArtifact.ResponseOfArtifactBeingExtended,
                    TransformerRawPrompt = cleanTransformedArtifact.TransformerRawPrompt,
                    IsRetiredArtifact = cleanTransformedArtifact.IsRetiredArtifact,
                    IsActiveIdea = cleanTransformedArtifact.IsActiveIdea,
                    Modified = cleanTransformedArtifact.Modified,
                    ExtensionOf = cleanTransformedArtifact.ExtensionOf,
                    TransformerNumber = cleanTransformedArtifact.TransformerNumber,
                    LongName = cleanTransformedArtifact.LongName,
                    TransformerGeneratioNumber = cleanTransformedArtifact.TransformerGeneratioNumber,
                    TransformerGenerationIdeaName = cleanTransformedArtifact.TransformerGenerationIdeaName,
                    TransformerGenerationName = cleanTransformedArtifact.TransformerGenerationName,
                    ArtifactIdentifier = cleanTransformedArtifact.ArtifactIdentifier,
                    PrimaryExtensionArtifact = cleanTransformedArtifact.PrimaryExtensionArtifact,
                    ToDoItems = cleanTransformedArtifact.ToDoItems,
                    ToDoItemsAKA = cleanTransformedArtifact.ToDoItemsAKA,
                    ToDoItemsMismatched = cleanTransformedArtifact.ToDoItemsMismatched,
                    Categories = cleanTransformedArtifact.Categories,
                    CategoriesAKA = cleanTransformedArtifact.CategoriesAKA,
                    CategoriesMismatched = cleanTransformedArtifact.CategoriesMismatched,
                    DueDates = cleanTransformedArtifact.DueDates,
                    DueDatesAKA = cleanTransformedArtifact.DueDatesAKA,
                    DueDatesMismatched = cleanTransformedArtifact.DueDatesMismatched,
                    Priorities = cleanTransformedArtifact.Priorities,
                    PrioritiesAKA = cleanTransformedArtifact.PrioritiesAKA,
                    PrioritiesMismatched = cleanTransformedArtifact.PrioritiesMismatched,
                    Progress = cleanTransformedArtifact.Progress,
                    ProgressAKA = cleanTransformedArtifact.ProgressAKA,
                    ProgressMismatched = cleanTransformedArtifact.ProgressMismatched,
                    Statuses = cleanTransformedArtifact.Statuses,
                    StatusesAKA = cleanTransformedArtifact.StatusesAKA,
                    StatusesMismatched = cleanTransformedArtifact.StatusesMismatched,
                    Reminders = cleanTransformedArtifact.Reminders,
                    RemindersAKA = cleanTransformedArtifact.RemindersAKA,
                    RemindersMismatched = cleanTransformedArtifact.RemindersMismatched,
                    Notifications = cleanTransformedArtifact.Notifications,
                    NotificationsAKA = cleanTransformedArtifact.NotificationsAKA,
                    NotificationsMismatched = cleanTransformedArtifact.NotificationsMismatched,
                    Completion = cleanTransformedArtifact.Completion,
                    CompletionAKA = cleanTransformedArtifact.CompletionAKA,
                    CompletionMismatched = cleanTransformedArtifact.CompletionMismatched,
                    ToDoEmployees = cleanTransformedArtifact.ToDoEmployees,
                    ToDoEmployeesAKA = cleanTransformedArtifact.ToDoEmployeesAKA,
                    ToDoEmployeesMismatched = cleanTransformedArtifact.ToDoEmployeesMismatched,
                    Duration = cleanTransformedArtifact.Duration,
                    DurationAKA = cleanTransformedArtifact.DurationAKA,
                    DurationMismatched = cleanTransformedArtifact.DurationMismatched,
                    CompletedDate = cleanTransformedArtifact.CompletedDate,
                    CompletedDateAKA = cleanTransformedArtifact.CompletedDateAKA,
                    CompletedDateMismatched = cleanTransformedArtifact.CompletedDateMismatched,
                    ToDoColors = cleanTransformedArtifact.ToDoColors,
                    ToDoColorsAKA = cleanTransformedArtifact.ToDoColorsAKA,
                    ToDoColorsMismatched = cleanTransformedArtifact.ToDoColorsMismatched,
                    IdeaValidationPrompt = cleanTransformedArtifact.IdeaValidationPrompt,
                    ResponseBeingValidated = cleanTransformedArtifact.ResponseBeingValidated,
                    GenerationSourceIdea = cleanTransformedArtifact.GenerationSourceIdea,
                    SuggestedValidationPrompt = cleanTransformedArtifact.SuggestedValidationPrompt,
                    ActualValidationPrompt = cleanTransformedArtifact.ActualValidationPrompt,
                    ValidationResponse = cleanTransformedArtifact.ValidationResponse,
                    IdeaTransformerIsSyntaxFreefromGenerationTransformer = cleanTransformedArtifact.IdeaTransformerIsSyntaxFreefromGenerationTransformer,
                    GenerationName = cleanTransformedArtifact.GenerationName,
                    GeneratioNumber = cleanTransformedArtifact.GeneratioNumber,
                    GenerationTransformerNumber = cleanTransformedArtifact.GenerationTransformerNumber,
                    ExtensionOfArtifactIdentifier = cleanTransformedArtifact.ExtensionOfArtifactIdentifier,
                    RootArtifactIdentifier = cleanTransformedArtifact.RootArtifactIdentifier,
                    SuggestedRootIdentifier = cleanTransformedArtifact.SuggestedRootIdentifier,
                    CustomRootIdentifier = cleanTransformedArtifact.CustomRootIdentifier,
                    RootIdentifierMismatch = cleanTransformedArtifact.RootIdentifierMismatch
                };
            }

            return UserTransformedArtifact;
        }
        
        
        public static dc.TransformedArtifact UserCleanForUpdate(this dc.TransformedArtifact cleanTransformedArtifact)
        {
            var UserTransformedArtifact = default(dc.TransformedArtifact);

            if (!ReferenceEquals(cleanTransformedArtifact, null))
            {
                UserTransformedArtifact = new dc.TransformedArtifact()
                {
                    TransformedArtifactId = cleanTransformedArtifact.TransformedArtifactId,
                    GenerationTransformer = cleanTransformedArtifact.GenerationTransformer,
                    ActualPrompt = cleanTransformedArtifact.ActualPrompt,
                    Response = cleanTransformedArtifact.Response,
                    AutoNumber = cleanTransformedArtifact.AutoNumber,
                    IsRetiredArtifact = cleanTransformedArtifact.IsRetiredArtifact,
                    ExtensionOf = cleanTransformedArtifact.ExtensionOf,
                    PrimaryExtensionArtifact = cleanTransformedArtifact.PrimaryExtensionArtifact,
                    ToDoItems = cleanTransformedArtifact.ToDoItems,
                    ToDoItemsAKA = cleanTransformedArtifact.ToDoItemsAKA,
                    ToDoItemsMismatched = cleanTransformedArtifact.ToDoItemsMismatched,
                    Categories = cleanTransformedArtifact.Categories,
                    CategoriesAKA = cleanTransformedArtifact.CategoriesAKA,
                    CategoriesMismatched = cleanTransformedArtifact.CategoriesMismatched,
                    DueDates = cleanTransformedArtifact.DueDates,
                    DueDatesAKA = cleanTransformedArtifact.DueDatesAKA,
                    DueDatesMismatched = cleanTransformedArtifact.DueDatesMismatched,
                    Priorities = cleanTransformedArtifact.Priorities,
                    PrioritiesAKA = cleanTransformedArtifact.PrioritiesAKA,
                    PrioritiesMismatched = cleanTransformedArtifact.PrioritiesMismatched,
                    Progress = cleanTransformedArtifact.Progress,
                    ProgressAKA = cleanTransformedArtifact.ProgressAKA,
                    ProgressMismatched = cleanTransformedArtifact.ProgressMismatched,
                    Statuses = cleanTransformedArtifact.Statuses,
                    StatusesAKA = cleanTransformedArtifact.StatusesAKA,
                    StatusesMismatched = cleanTransformedArtifact.StatusesMismatched,
                    Reminders = cleanTransformedArtifact.Reminders,
                    RemindersAKA = cleanTransformedArtifact.RemindersAKA,
                    RemindersMismatched = cleanTransformedArtifact.RemindersMismatched,
                    Notifications = cleanTransformedArtifact.Notifications,
                    NotificationsAKA = cleanTransformedArtifact.NotificationsAKA,
                    NotificationsMismatched = cleanTransformedArtifact.NotificationsMismatched,
                    Completion = cleanTransformedArtifact.Completion,
                    CompletionAKA = cleanTransformedArtifact.CompletionAKA,
                    CompletionMismatched = cleanTransformedArtifact.CompletionMismatched,
                    ToDoEmployees = cleanTransformedArtifact.ToDoEmployees,
                    ToDoEmployeesAKA = cleanTransformedArtifact.ToDoEmployeesAKA,
                    ToDoEmployeesMismatched = cleanTransformedArtifact.ToDoEmployeesMismatched,
                    Duration = cleanTransformedArtifact.Duration,
                    DurationAKA = cleanTransformedArtifact.DurationAKA,
                    DurationMismatched = cleanTransformedArtifact.DurationMismatched,
                    CompletedDate = cleanTransformedArtifact.CompletedDate,
                    CompletedDateAKA = cleanTransformedArtifact.CompletedDateAKA,
                    CompletedDateMismatched = cleanTransformedArtifact.CompletedDateMismatched,
                    ToDoColors = cleanTransformedArtifact.ToDoColors,
                    ToDoColorsAKA = cleanTransformedArtifact.ToDoColorsAKA,
                    ToDoColorsMismatched = cleanTransformedArtifact.ToDoColorsMismatched,
                    ActualValidationPrompt = cleanTransformedArtifact.ActualValidationPrompt,
                    ValidationResponse = cleanTransformedArtifact.ValidationResponse,
                    CustomRootIdentifier = cleanTransformedArtifact.CustomRootIdentifier
                };
            }

            return UserTransformedArtifact;
        }

        // User Cleaning Extension Methods.  -CRUD-
        
        // DesignDecision
        public static dc.DesignDecision UserCleanForAdd(this dc.DesignDecision cleanDesignDecision)
        {
            var UserDesignDecision = default(dc.DesignDecision);

            if (!ReferenceEquals(cleanDesignDecision, null))
            {
                UserDesignDecision = new dc.DesignDecision()
                {
                     // default value: . 
                    DesignDecisionId = cleanDesignDecision.DesignDecisionId,
                     // default value: . 
                    Name = cleanDesignDecision.Name,
                     // default value: . 
                    Notes = cleanDesignDecision.Notes,
                     // default value: . 
                    TypeOfDecision = cleanDesignDecision.TypeOfDecision
                };
                
            }

            return UserDesignDecision;
        }
        
        
        public static List<dc.DesignDecision> UserCleanForGet(this IEnumerable<dc.DesignDecision> cleanDesignDecisions)
        {
            return cleanDesignDecisions.Select(DesignDecision => DesignDecision.UserCleanForGet())
                            .ToList();
        }
        
        public static dc.DesignDecision UserCleanForGet(this dc.DesignDecision cleanDesignDecision)
        {
            var UserDesignDecision = default(dc.DesignDecision);

            if (!ReferenceEquals(cleanDesignDecision, null))
            {
                UserDesignDecision = new dc.DesignDecision()
                {
                    DesignDecisionId = cleanDesignDecision.DesignDecisionId,
                    Name = cleanDesignDecision.Name,
                    Notes = cleanDesignDecision.Notes,
                    TypeOfDecision = cleanDesignDecision.TypeOfDecision
                };
            }

            return UserDesignDecision;
        }
        
        
        public static dc.DesignDecision UserCleanForUpdate(this dc.DesignDecision cleanDesignDecision)
        {
            var UserDesignDecision = default(dc.DesignDecision);

            if (!ReferenceEquals(cleanDesignDecision, null))
            {
                UserDesignDecision = new dc.DesignDecision()
                {
                    DesignDecisionId = cleanDesignDecision.DesignDecisionId,
                    Name = cleanDesignDecision.Name,
                    Notes = cleanDesignDecision.Notes,
                    TypeOfDecision = cleanDesignDecision.TypeOfDecision
                };
            }

            return UserDesignDecision;
        }

        // User Cleaning Extension Methods.  -CRUD-
        
        // LLM
        public static dc.LLM UserCleanForAdd(this dc.LLM cleanLLM)
        {
            var UserLLM = default(dc.LLM);

            if (!ReferenceEquals(cleanLLM, null))
            {
                UserLLM = new dc.LLM()
                {
                     // default value: . 
                    LLMId = cleanLLM.LLMId,
                     // default value: . 
                    Name = cleanLLM.Name,
                     // default value: . 
                    Notes = cleanLLM.Notes,
                     // default value: . 
                    TestRuns = cleanLLM.TestRuns,
                     // default value: . 
                    Generations = cleanLLM.Generations
                };
                
            }

            return UserLLM;
        }
        
        
        public static List<dc.LLM> UserCleanForGet(this IEnumerable<dc.LLM> cleanLLMs)
        {
            return cleanLLMs.Select(LLM => LLM.UserCleanForGet())
                            .ToList();
        }
        
        public static dc.LLM UserCleanForGet(this dc.LLM cleanLLM)
        {
            var UserLLM = default(dc.LLM);

            if (!ReferenceEquals(cleanLLM, null))
            {
                UserLLM = new dc.LLM()
                {
                    LLMId = cleanLLM.LLMId,
                    Name = cleanLLM.Name,
                    Notes = cleanLLM.Notes,
                    TestRuns = cleanLLM.TestRuns,
                    Generations = cleanLLM.Generations
                };
            }

            return UserLLM;
        }
        
        
        public static dc.LLM UserCleanForUpdate(this dc.LLM cleanLLM)
        {
            var UserLLM = default(dc.LLM);

            if (!ReferenceEquals(cleanLLM, null))
            {
                UserLLM = new dc.LLM()
                {
                    LLMId = cleanLLM.LLMId,
                    Name = cleanLLM.Name,
                    Notes = cleanLLM.Notes,
                    TestRuns = cleanLLM.TestRuns,
                    Generations = cleanLLM.Generations
                };
            }

            return UserLLM;
        }

        // User Cleaning Extension Methods.  -CRUD-
        
        // Idea
        public static dc.Idea UserCleanForAdd(this dc.Idea cleanIdea)
        {
            var UserIdea = default(dc.Idea);

            if (!ReferenceEquals(cleanIdea, null))
            {
                UserIdea = new dc.Idea()
                {
                     // default value: . 
                    IdeaId = cleanIdea.IdeaId,
                     // default value: . 
                    Name = cleanIdea.Name,
                     // default value: . 
                    SourceIdea = cleanIdea.SourceIdea,
                     // default value: . 
                    Generations = cleanIdea.Generations,
                     // default value: . 
                    IsActiveIdea = cleanIdea.IsActiveIdea,
                     // default value: . 
                    IdeaTransformers = cleanIdea.IdeaTransformers,
                     // default value: . 
                    IdeaFeatures = cleanIdea.IdeaFeatures
                };
                
            }

            return UserIdea;
        }
        
        
        public static List<dc.Idea> UserCleanForGet(this IEnumerable<dc.Idea> cleanIdeas)
        {
            return cleanIdeas.Select(Idea => Idea.UserCleanForGet())
                            .ToList();
        }
        
        public static dc.Idea UserCleanForGet(this dc.Idea cleanIdea)
        {
            var UserIdea = default(dc.Idea);

            if (!ReferenceEquals(cleanIdea, null))
            {
                UserIdea = new dc.Idea()
                {
                    IdeaId = cleanIdea.IdeaId,
                    Name = cleanIdea.Name,
                    SourceIdea = cleanIdea.SourceIdea,
                    Generations = cleanIdea.Generations,
                    IsActiveIdea = cleanIdea.IsActiveIdea,
                    IdeaTransformers = cleanIdea.IdeaTransformers,
                    IdeaTransformerNames = cleanIdea.IdeaTransformerNames,
                    IdeaTransformerFullPrompts = cleanIdea.IdeaTransformerFullPrompts,
                    IdeaFeatures = cleanIdea.IdeaFeatures,
                    IdeaFeatureLowerNames = cleanIdea.IdeaFeatureLowerNames,
                    IdeaFeatureNames = cleanIdea.IdeaFeatureNames,
                    FeaturesArray = cleanIdea.FeaturesArray,
                    ValidationPrompt = cleanIdea.ValidationPrompt
                };
            }

            return UserIdea;
        }
        
        
        public static dc.Idea UserCleanForUpdate(this dc.Idea cleanIdea)
        {
            var UserIdea = default(dc.Idea);

            if (!ReferenceEquals(cleanIdea, null))
            {
                UserIdea = new dc.Idea()
                {
                    IdeaId = cleanIdea.IdeaId,
                    Name = cleanIdea.Name,
                    SourceIdea = cleanIdea.SourceIdea,
                    Generations = cleanIdea.Generations,
                    IsActiveIdea = cleanIdea.IsActiveIdea,
                    IdeaTransformers = cleanIdea.IdeaTransformers,
                    IdeaFeatures = cleanIdea.IdeaFeatures
                };
            }

            return UserIdea;
        }

        // Admin Cleaning Extension Methods.  -CRUD-
        
        // IdeaTransformer
        public static dc.IdeaTransformer AdminCleanForAdd(this dc.IdeaTransformer cleanIdeaTransformer)
        {
            var AdminIdeaTransformer = default(dc.IdeaTransformer);

            if (!ReferenceEquals(cleanIdeaTransformer, null))
            {
                AdminIdeaTransformer = new dc.IdeaTransformer()
                {
                     // default value: . 
                    IdeaTransformerId = cleanIdeaTransformer.IdeaTransformerId,
                     // default value: . 
                    Idea = cleanIdeaTransformer.Idea,
                     // default value: . 
                    FullPrompt = cleanIdeaTransformer.FullPrompt,
                     // default value: . 
                    TransformedTransformers = cleanIdeaTransformer.TransformedTransformers,
                     // default value: . 
                    AutoNumber = cleanIdeaTransformer.AutoNumber,
                     // default value: . 
                    IsSyntaxFree = cleanIdeaTransformer.IsSyntaxFree
                };
                
            }

            return AdminIdeaTransformer;
        }
        
        
        public static List<dc.IdeaTransformer> AdminCleanForGet(this IEnumerable<dc.IdeaTransformer> cleanIdeaTransformers)
        {
            return cleanIdeaTransformers.Select(IdeaTransformer => IdeaTransformer.AdminCleanForGet())
                            .ToList();
        }
        
        public static dc.IdeaTransformer AdminCleanForGet(this dc.IdeaTransformer cleanIdeaTransformer)
        {
            var AdminIdeaTransformer = default(dc.IdeaTransformer);

            if (!ReferenceEquals(cleanIdeaTransformer, null))
            {
                AdminIdeaTransformer = new dc.IdeaTransformer()
                {
                    IdeaTransformerId = cleanIdeaTransformer.IdeaTransformerId,
                    Name = cleanIdeaTransformer.Name,
                    Idea = cleanIdeaTransformer.Idea,
                    IdeaName = cleanIdeaTransformer.IdeaName,
                    IdeasSourceIdea = cleanIdeaTransformer.IdeasSourceIdea,
                    IsActiveIdea = cleanIdeaTransformer.IsActiveIdea,
                    FullPrompt = cleanIdeaTransformer.FullPrompt,
                    TransformedTransformers = cleanIdeaTransformer.TransformedTransformers,
                    AutoNumber = cleanIdeaTransformer.AutoNumber,
                    IdeaIdentifier = cleanIdeaTransformer.IdeaIdentifier,
                    IsSyntaxFree = cleanIdeaTransformer.IsSyntaxFree
                };
            }

            return AdminIdeaTransformer;
        }
        
        
        public static dc.IdeaTransformer AdminCleanForUpdate(this dc.IdeaTransformer cleanIdeaTransformer)
        {
            var AdminIdeaTransformer = default(dc.IdeaTransformer);

            if (!ReferenceEquals(cleanIdeaTransformer, null))
            {
                AdminIdeaTransformer = new dc.IdeaTransformer()
                {
                    IdeaTransformerId = cleanIdeaTransformer.IdeaTransformerId,
                    Idea = cleanIdeaTransformer.Idea,
                    FullPrompt = cleanIdeaTransformer.FullPrompt,
                    TransformedTransformers = cleanIdeaTransformer.TransformedTransformers,
                    AutoNumber = cleanIdeaTransformer.AutoNumber,
                    IsSyntaxFree = cleanIdeaTransformer.IsSyntaxFree
                };
            }

            return AdminIdeaTransformer;
        }

        // Admin Cleaning Extension Methods.  -CRUD-
        
        // AppUser
        public static dc.AppUser AdminCleanForAdd(this dc.AppUser cleanAppUser)
        {
            var AdminAppUser = default(dc.AppUser);

            if (!ReferenceEquals(cleanAppUser, null))
            {
                AdminAppUser = new dc.AppUser()
                {
                     // default value: . 
                    AppUserId = cleanAppUser.AppUserId,
                     // default value: . 
                    Name = cleanAppUser.Name,
                     // default value: . 
                    Roles = cleanAppUser.Roles,
                     // default value: . 
                    EmailAddress = cleanAppUser.EmailAddress
                };
                
            }

            return AdminAppUser;
        }
        
        
        public static List<dc.AppUser> AdminCleanForGet(this IEnumerable<dc.AppUser> cleanAppUsers)
        {
            return cleanAppUsers.Select(AppUser => AppUser.AdminCleanForGet())
                            .ToList();
        }
        
        public static dc.AppUser AdminCleanForGet(this dc.AppUser cleanAppUser)
        {
            var AdminAppUser = default(dc.AppUser);

            if (!ReferenceEquals(cleanAppUser, null))
            {
                AdminAppUser = new dc.AppUser()
                {
                    AppUserId = cleanAppUser.AppUserId,
                    Name = cleanAppUser.Name,
                    Roles = cleanAppUser.Roles,
                    EmailAddress = cleanAppUser.EmailAddress
                };
            }

            return AdminAppUser;
        }
        
        
        public static dc.AppUser AdminCleanForUpdate(this dc.AppUser cleanAppUser)
        {
            var AdminAppUser = default(dc.AppUser);

            if (!ReferenceEquals(cleanAppUser, null))
            {
                AdminAppUser = new dc.AppUser()
                {
                    AppUserId = cleanAppUser.AppUserId,
                    Name = cleanAppUser.Name,
                    Roles = cleanAppUser.Roles,
                    EmailAddress = cleanAppUser.EmailAddress
                };
            }

            return AdminAppUser;
        }

        // Admin Cleaning Extension Methods.  -CRUD-
        
        // GenerationTransformer
        public static dc.GenerationTransformer AdminCleanForAdd(this dc.GenerationTransformer cleanGenerationTransformer)
        {
            var AdminGenerationTransformer = default(dc.GenerationTransformer);

            if (!ReferenceEquals(cleanGenerationTransformer, null))
            {
                AdminGenerationTransformer = new dc.GenerationTransformer()
                {
                     // default value: . 
                    GenerationTransformerId = cleanGenerationTransformer.GenerationTransformerId,
                     // default value: . 
                    Generation = cleanGenerationTransformer.Generation,
                     // default value: . 
                    TransformedArtifacts = cleanGenerationTransformer.TransformedArtifacts,
                     // default value: . 
                    AutoNumber = cleanGenerationTransformer.AutoNumber,
                     // default value: . 
                    IsArtifactValidator = cleanGenerationTransformer.IsArtifactValidator,
                     // default value: . 
                    IdeaTransformer = cleanGenerationTransformer.IdeaTransformer
                };
                
            }

            return AdminGenerationTransformer;
        }
        
        
        public static List<dc.GenerationTransformer> AdminCleanForGet(this IEnumerable<dc.GenerationTransformer> cleanGenerationTransformers)
        {
            return cleanGenerationTransformers.Select(GenerationTransformer => GenerationTransformer.AdminCleanForGet())
                            .ToList();
        }
        
        public static dc.GenerationTransformer AdminCleanForGet(this dc.GenerationTransformer cleanGenerationTransformer)
        {
            var AdminGenerationTransformer = default(dc.GenerationTransformer);

            if (!ReferenceEquals(cleanGenerationTransformer, null))
            {
                AdminGenerationTransformer = new dc.GenerationTransformer()
                {
                    GenerationTransformerId = cleanGenerationTransformer.GenerationTransformerId,
                    Name = cleanGenerationTransformer.Name,
                    Generation = cleanGenerationTransformer.Generation,
                    RawPrompt = cleanGenerationTransformer.RawPrompt,
                    SourceIdea = cleanGenerationTransformer.SourceIdea,
                    GenerationName = cleanGenerationTransformer.GenerationName,
                    GenerationIdea = cleanGenerationTransformer.GenerationIdea,
                    GenerationIdeaName = cleanGenerationTransformer.GenerationIdeaName,
                    GeneratioNumber = cleanGenerationTransformer.GeneratioNumber,
                    IsActiveIdea = cleanGenerationTransformer.IsActiveIdea,
                    TransformedArtifacts = cleanGenerationTransformer.TransformedArtifacts,
                    AutoNumber = cleanGenerationTransformer.AutoNumber,
                    TransformerNumber = cleanGenerationTransformer.TransformerNumber,
                    IsArtifactValidator = cleanGenerationTransformer.IsArtifactValidator,
                    IdeaValidationPrompt = cleanGenerationTransformer.IdeaValidationPrompt,
                    IdeaTransformer = cleanGenerationTransformer.IdeaTransformer,
                    IdeaTransformerIsSyntaxFree = cleanGenerationTransformer.IdeaTransformerIsSyntaxFree
                };
            }

            return AdminGenerationTransformer;
        }
        
        
        public static dc.GenerationTransformer AdminCleanForUpdate(this dc.GenerationTransformer cleanGenerationTransformer)
        {
            var AdminGenerationTransformer = default(dc.GenerationTransformer);

            if (!ReferenceEquals(cleanGenerationTransformer, null))
            {
                AdminGenerationTransformer = new dc.GenerationTransformer()
                {
                    GenerationTransformerId = cleanGenerationTransformer.GenerationTransformerId,
                    Generation = cleanGenerationTransformer.Generation,
                    TransformedArtifacts = cleanGenerationTransformer.TransformedArtifacts,
                    AutoNumber = cleanGenerationTransformer.AutoNumber,
                    IsArtifactValidator = cleanGenerationTransformer.IsArtifactValidator,
                    IdeaTransformer = cleanGenerationTransformer.IdeaTransformer
                };
            }

            return AdminGenerationTransformer;
        }

        // Admin Cleaning Extension Methods.  -CRUD-
        
        // Generation
        public static dc.Generation AdminCleanForAdd(this dc.Generation cleanGeneration)
        {
            var AdminGeneration = default(dc.Generation);

            if (!ReferenceEquals(cleanGeneration, null))
            {
                AdminGeneration = new dc.Generation()
                {
                     // default value: . 
                    GenerationId = cleanGeneration.GenerationId,
                     // default value: . 
                    Idea = cleanGeneration.Idea,
                     // default value: . 
                    GeneratioNumber = cleanGeneration.GeneratioNumber,
                     // default value: . 
                    TransformedArtifacts = cleanGeneration.TransformedArtifacts,
                     // default value: . 
                    Model = cleanGeneration.Model
                };
                
            }

            return AdminGeneration;
        }
        
        
        public static List<dc.Generation> AdminCleanForGet(this IEnumerable<dc.Generation> cleanGenerations)
        {
            return cleanGenerations.Select(Generation => Generation.AdminCleanForGet())
                            .ToList();
        }
        
        public static dc.Generation AdminCleanForGet(this dc.Generation cleanGeneration)
        {
            var AdminGeneration = default(dc.Generation);

            if (!ReferenceEquals(cleanGeneration, null))
            {
                AdminGeneration = new dc.Generation()
                {
                    GenerationId = cleanGeneration.GenerationId,
                    Name = cleanGeneration.Name,
                    Idea = cleanGeneration.Idea,
                    IdeaName = cleanGeneration.IdeaName,
                    GeneratioNumber = cleanGeneration.GeneratioNumber,
                    TransformedArtifacts = cleanGeneration.TransformedArtifacts,
                    IsActiveIdea = cleanGeneration.IsActiveIdea,
                    IdeaSourceIdea = cleanGeneration.IdeaSourceIdea,
                    Model = cleanGeneration.Model,
                    IdeaValidationPrompt = cleanGeneration.IdeaValidationPrompt,
                    TransformedArtifactRawPrompts = cleanGeneration.TransformedArtifactRawPrompts
                };
            }

            return AdminGeneration;
        }
        
        
        public static dc.Generation AdminCleanForUpdate(this dc.Generation cleanGeneration)
        {
            var AdminGeneration = default(dc.Generation);

            if (!ReferenceEquals(cleanGeneration, null))
            {
                AdminGeneration = new dc.Generation()
                {
                    GenerationId = cleanGeneration.GenerationId,
                    Idea = cleanGeneration.Idea,
                    GeneratioNumber = cleanGeneration.GeneratioNumber,
                    TransformedArtifacts = cleanGeneration.TransformedArtifacts,
                    Model = cleanGeneration.Model
                };
            }

            return AdminGeneration;
        }

        // Admin Cleaning Extension Methods.  -CRUD-
        
        // IdeaFeature
        public static dc.IdeaFeature AdminCleanForAdd(this dc.IdeaFeature cleanIdeaFeature)
        {
            var AdminIdeaFeature = default(dc.IdeaFeature);

            if (!ReferenceEquals(cleanIdeaFeature, null))
            {
                AdminIdeaFeature = new dc.IdeaFeature()
                {
                     // default value: . 
                    IdeaFeatureId = cleanIdeaFeature.IdeaFeatureId,
                     // default value: . 
                    Name = cleanIdeaFeature.Name,
                     // default value: . 
                    LowerName = cleanIdeaFeature.LowerName,
                     // default value: . 
                    Description = cleanIdeaFeature.Description,
                     // default value: . 
                    RequiredStartingAtGeneration = cleanIdeaFeature.RequiredStartingAtGeneration,
                     // default value: . 
                    ExplicitlyRemovedAtGeneration = cleanIdeaFeature.ExplicitlyRemovedAtGeneration,
                     // default value: . 
                    Idea = cleanIdeaFeature.Idea
                };
                
            }

            return AdminIdeaFeature;
        }
        
        
        public static List<dc.IdeaFeature> AdminCleanForGet(this IEnumerable<dc.IdeaFeature> cleanIdeaFeatures)
        {
            return cleanIdeaFeatures.Select(IdeaFeature => IdeaFeature.AdminCleanForGet())
                            .ToList();
        }
        
        public static dc.IdeaFeature AdminCleanForGet(this dc.IdeaFeature cleanIdeaFeature)
        {
            var AdminIdeaFeature = default(dc.IdeaFeature);

            if (!ReferenceEquals(cleanIdeaFeature, null))
            {
                AdminIdeaFeature = new dc.IdeaFeature()
                {
                    IdeaFeatureId = cleanIdeaFeature.IdeaFeatureId,
                    Name = cleanIdeaFeature.Name,
                    LowerName = cleanIdeaFeature.LowerName,
                    Description = cleanIdeaFeature.Description,
                    RequiredStartingAtGeneration = cleanIdeaFeature.RequiredStartingAtGeneration,
                    ExplicitlyRemovedAtGeneration = cleanIdeaFeature.ExplicitlyRemovedAtGeneration,
                    SourceIdea = cleanIdeaFeature.SourceIdea,
                    Idea = cleanIdeaFeature.Idea,
                    IsActiveIdea = cleanIdeaFeature.IsActiveIdea
                };
            }

            return AdminIdeaFeature;
        }
        
        
        public static dc.IdeaFeature AdminCleanForUpdate(this dc.IdeaFeature cleanIdeaFeature)
        {
            var AdminIdeaFeature = default(dc.IdeaFeature);

            if (!ReferenceEquals(cleanIdeaFeature, null))
            {
                AdminIdeaFeature = new dc.IdeaFeature()
                {
                    IdeaFeatureId = cleanIdeaFeature.IdeaFeatureId,
                    Name = cleanIdeaFeature.Name,
                    LowerName = cleanIdeaFeature.LowerName,
                    Description = cleanIdeaFeature.Description,
                    RequiredStartingAtGeneration = cleanIdeaFeature.RequiredStartingAtGeneration,
                    ExplicitlyRemovedAtGeneration = cleanIdeaFeature.ExplicitlyRemovedAtGeneration,
                    Idea = cleanIdeaFeature.Idea
                };
            }

            return AdminIdeaFeature;
        }

        // Admin Cleaning Extension Methods.  -CRUD-
        
        // TransformedArtifact
        public static dc.TransformedArtifact AdminCleanForAdd(this dc.TransformedArtifact cleanTransformedArtifact)
        {
            var AdminTransformedArtifact = default(dc.TransformedArtifact);

            if (!ReferenceEquals(cleanTransformedArtifact, null))
            {
                AdminTransformedArtifact = new dc.TransformedArtifact()
                {
                     // default value: . 
                    TransformedArtifactId = cleanTransformedArtifact.TransformedArtifactId,
                     // default value: . 
                    GenerationTransformer = cleanTransformedArtifact.GenerationTransformer,
                     // default value: . 
                    ActualPrompt = cleanTransformedArtifact.ActualPrompt,
                     // default value: . 
                    Response = cleanTransformedArtifact.Response,
                     // default value: . 
                    AutoNumber = cleanTransformedArtifact.AutoNumber,
                     // default value: . 
                    IsRetiredArtifact = cleanTransformedArtifact.IsRetiredArtifact,
                     // default value: . 
                    ExtensionOf = cleanTransformedArtifact.ExtensionOf,
                     // default value: . 
                    PrimaryExtensionArtifact = cleanTransformedArtifact.PrimaryExtensionArtifact,
                     // default value: . 
                    ToDoItems = cleanTransformedArtifact.ToDoItems,
                     // default value: . 
                    ToDoItemsAKA = cleanTransformedArtifact.ToDoItemsAKA,
                     // default value: . 
                    ToDoItemsMismatched = cleanTransformedArtifact.ToDoItemsMismatched,
                     // default value: . 
                    Categories = cleanTransformedArtifact.Categories,
                     // default value: . 
                    CategoriesAKA = cleanTransformedArtifact.CategoriesAKA,
                     // default value: . 
                    CategoriesMismatched = cleanTransformedArtifact.CategoriesMismatched,
                     // default value: . 
                    DueDates = cleanTransformedArtifact.DueDates,
                     // default value: . 
                    DueDatesAKA = cleanTransformedArtifact.DueDatesAKA,
                     // default value: . 
                    DueDatesMismatched = cleanTransformedArtifact.DueDatesMismatched,
                     // default value: . 
                    Priorities = cleanTransformedArtifact.Priorities,
                     // default value: . 
                    PrioritiesAKA = cleanTransformedArtifact.PrioritiesAKA,
                     // default value: . 
                    PrioritiesMismatched = cleanTransformedArtifact.PrioritiesMismatched,
                     // default value: . 
                    Progress = cleanTransformedArtifact.Progress,
                     // default value: . 
                    ProgressAKA = cleanTransformedArtifact.ProgressAKA,
                     // default value: . 
                    ProgressMismatched = cleanTransformedArtifact.ProgressMismatched,
                     // default value: . 
                    Statuses = cleanTransformedArtifact.Statuses,
                     // default value: . 
                    StatusesAKA = cleanTransformedArtifact.StatusesAKA,
                     // default value: . 
                    StatusesMismatched = cleanTransformedArtifact.StatusesMismatched,
                     // default value: . 
                    Reminders = cleanTransformedArtifact.Reminders,
                     // default value: . 
                    RemindersAKA = cleanTransformedArtifact.RemindersAKA,
                     // default value: . 
                    RemindersMismatched = cleanTransformedArtifact.RemindersMismatched,
                     // default value: . 
                    Notifications = cleanTransformedArtifact.Notifications,
                     // default value: . 
                    NotificationsAKA = cleanTransformedArtifact.NotificationsAKA,
                     // default value: . 
                    NotificationsMismatched = cleanTransformedArtifact.NotificationsMismatched,
                     // default value: . 
                    Completion = cleanTransformedArtifact.Completion,
                     // default value: . 
                    CompletionAKA = cleanTransformedArtifact.CompletionAKA,
                     // default value: . 
                    CompletionMismatched = cleanTransformedArtifact.CompletionMismatched,
                     // default value: . 
                    ToDoEmployees = cleanTransformedArtifact.ToDoEmployees,
                     // default value: . 
                    ToDoEmployeesAKA = cleanTransformedArtifact.ToDoEmployeesAKA,
                     // default value: . 
                    ToDoEmployeesMismatched = cleanTransformedArtifact.ToDoEmployeesMismatched,
                     // default value: . 
                    Duration = cleanTransformedArtifact.Duration,
                     // default value: . 
                    DurationAKA = cleanTransformedArtifact.DurationAKA,
                     // default value: . 
                    DurationMismatched = cleanTransformedArtifact.DurationMismatched,
                     // default value: . 
                    CompletedDate = cleanTransformedArtifact.CompletedDate,
                     // default value: . 
                    CompletedDateAKA = cleanTransformedArtifact.CompletedDateAKA,
                     // default value: . 
                    CompletedDateMismatched = cleanTransformedArtifact.CompletedDateMismatched,
                     // default value: . 
                    ToDoColors = cleanTransformedArtifact.ToDoColors,
                     // default value: . 
                    ToDoColorsAKA = cleanTransformedArtifact.ToDoColorsAKA,
                     // default value: . 
                    ToDoColorsMismatched = cleanTransformedArtifact.ToDoColorsMismatched,
                     // default value: . 
                    ActualValidationPrompt = cleanTransformedArtifact.ActualValidationPrompt,
                     // default value: . 
                    ValidationResponse = cleanTransformedArtifact.ValidationResponse,
                     // default value: . 
                    CustomRootIdentifier = cleanTransformedArtifact.CustomRootIdentifier
                };
                
            }

            return AdminTransformedArtifact;
        }
        
        
        public static List<dc.TransformedArtifact> AdminCleanForGet(this IEnumerable<dc.TransformedArtifact> cleanTransformedArtifacts)
        {
            return cleanTransformedArtifacts.Select(TransformedArtifact => TransformedArtifact.AdminCleanForGet())
                            .ToList();
        }
        
        public static dc.TransformedArtifact AdminCleanForGet(this dc.TransformedArtifact cleanTransformedArtifact)
        {
            var AdminTransformedArtifact = default(dc.TransformedArtifact);

            if (!ReferenceEquals(cleanTransformedArtifact, null))
            {
                AdminTransformedArtifact = new dc.TransformedArtifact()
                {
                    TransformedArtifactId = cleanTransformedArtifact.TransformedArtifactId,
                    Name = cleanTransformedArtifact.Name,
                    GenerationTransformer = cleanTransformedArtifact.GenerationTransformer,
                    SuggestedPrompt = cleanTransformedArtifact.SuggestedPrompt,
                    ActualPrompt = cleanTransformedArtifact.ActualPrompt,
                    Response = cleanTransformedArtifact.Response,
                    Created = cleanTransformedArtifact.Created,
                    AutoNumber = cleanTransformedArtifact.AutoNumber,
                    ResponseOfArtifactBeingExtended = cleanTransformedArtifact.ResponseOfArtifactBeingExtended,
                    TransformerRawPrompt = cleanTransformedArtifact.TransformerRawPrompt,
                    IsRetiredArtifact = cleanTransformedArtifact.IsRetiredArtifact,
                    IsActiveIdea = cleanTransformedArtifact.IsActiveIdea,
                    Modified = cleanTransformedArtifact.Modified,
                    ExtensionOf = cleanTransformedArtifact.ExtensionOf,
                    TransformerNumber = cleanTransformedArtifact.TransformerNumber,
                    LongName = cleanTransformedArtifact.LongName,
                    TransformerGeneratioNumber = cleanTransformedArtifact.TransformerGeneratioNumber,
                    TransformerGenerationIdeaName = cleanTransformedArtifact.TransformerGenerationIdeaName,
                    TransformerGenerationName = cleanTransformedArtifact.TransformerGenerationName,
                    ArtifactIdentifier = cleanTransformedArtifact.ArtifactIdentifier,
                    PrimaryExtensionArtifact = cleanTransformedArtifact.PrimaryExtensionArtifact,
                    ToDoItems = cleanTransformedArtifact.ToDoItems,
                    ToDoItemsAKA = cleanTransformedArtifact.ToDoItemsAKA,
                    ToDoItemsMismatched = cleanTransformedArtifact.ToDoItemsMismatched,
                    Categories = cleanTransformedArtifact.Categories,
                    CategoriesAKA = cleanTransformedArtifact.CategoriesAKA,
                    CategoriesMismatched = cleanTransformedArtifact.CategoriesMismatched,
                    DueDates = cleanTransformedArtifact.DueDates,
                    DueDatesAKA = cleanTransformedArtifact.DueDatesAKA,
                    DueDatesMismatched = cleanTransformedArtifact.DueDatesMismatched,
                    Priorities = cleanTransformedArtifact.Priorities,
                    PrioritiesAKA = cleanTransformedArtifact.PrioritiesAKA,
                    PrioritiesMismatched = cleanTransformedArtifact.PrioritiesMismatched,
                    Progress = cleanTransformedArtifact.Progress,
                    ProgressAKA = cleanTransformedArtifact.ProgressAKA,
                    ProgressMismatched = cleanTransformedArtifact.ProgressMismatched,
                    Statuses = cleanTransformedArtifact.Statuses,
                    StatusesAKA = cleanTransformedArtifact.StatusesAKA,
                    StatusesMismatched = cleanTransformedArtifact.StatusesMismatched,
                    Reminders = cleanTransformedArtifact.Reminders,
                    RemindersAKA = cleanTransformedArtifact.RemindersAKA,
                    RemindersMismatched = cleanTransformedArtifact.RemindersMismatched,
                    Notifications = cleanTransformedArtifact.Notifications,
                    NotificationsAKA = cleanTransformedArtifact.NotificationsAKA,
                    NotificationsMismatched = cleanTransformedArtifact.NotificationsMismatched,
                    Completion = cleanTransformedArtifact.Completion,
                    CompletionAKA = cleanTransformedArtifact.CompletionAKA,
                    CompletionMismatched = cleanTransformedArtifact.CompletionMismatched,
                    ToDoEmployees = cleanTransformedArtifact.ToDoEmployees,
                    ToDoEmployeesAKA = cleanTransformedArtifact.ToDoEmployeesAKA,
                    ToDoEmployeesMismatched = cleanTransformedArtifact.ToDoEmployeesMismatched,
                    Duration = cleanTransformedArtifact.Duration,
                    DurationAKA = cleanTransformedArtifact.DurationAKA,
                    DurationMismatched = cleanTransformedArtifact.DurationMismatched,
                    CompletedDate = cleanTransformedArtifact.CompletedDate,
                    CompletedDateAKA = cleanTransformedArtifact.CompletedDateAKA,
                    CompletedDateMismatched = cleanTransformedArtifact.CompletedDateMismatched,
                    ToDoColors = cleanTransformedArtifact.ToDoColors,
                    ToDoColorsAKA = cleanTransformedArtifact.ToDoColorsAKA,
                    ToDoColorsMismatched = cleanTransformedArtifact.ToDoColorsMismatched,
                    IdeaValidationPrompt = cleanTransformedArtifact.IdeaValidationPrompt,
                    ResponseBeingValidated = cleanTransformedArtifact.ResponseBeingValidated,
                    GenerationSourceIdea = cleanTransformedArtifact.GenerationSourceIdea,
                    SuggestedValidationPrompt = cleanTransformedArtifact.SuggestedValidationPrompt,
                    ActualValidationPrompt = cleanTransformedArtifact.ActualValidationPrompt,
                    ValidationResponse = cleanTransformedArtifact.ValidationResponse,
                    IdeaTransformerIsSyntaxFreefromGenerationTransformer = cleanTransformedArtifact.IdeaTransformerIsSyntaxFreefromGenerationTransformer,
                    GenerationName = cleanTransformedArtifact.GenerationName,
                    GeneratioNumber = cleanTransformedArtifact.GeneratioNumber,
                    GenerationTransformerNumber = cleanTransformedArtifact.GenerationTransformerNumber,
                    ExtensionOfArtifactIdentifier = cleanTransformedArtifact.ExtensionOfArtifactIdentifier,
                    RootArtifactIdentifier = cleanTransformedArtifact.RootArtifactIdentifier,
                    SuggestedRootIdentifier = cleanTransformedArtifact.SuggestedRootIdentifier,
                    CustomRootIdentifier = cleanTransformedArtifact.CustomRootIdentifier,
                    RootIdentifierMismatch = cleanTransformedArtifact.RootIdentifierMismatch
                };
            }

            return AdminTransformedArtifact;
        }
        
        
        public static dc.TransformedArtifact AdminCleanForUpdate(this dc.TransformedArtifact cleanTransformedArtifact)
        {
            var AdminTransformedArtifact = default(dc.TransformedArtifact);

            if (!ReferenceEquals(cleanTransformedArtifact, null))
            {
                AdminTransformedArtifact = new dc.TransformedArtifact()
                {
                    TransformedArtifactId = cleanTransformedArtifact.TransformedArtifactId,
                    GenerationTransformer = cleanTransformedArtifact.GenerationTransformer,
                    ActualPrompt = cleanTransformedArtifact.ActualPrompt,
                    Response = cleanTransformedArtifact.Response,
                    AutoNumber = cleanTransformedArtifact.AutoNumber,
                    IsRetiredArtifact = cleanTransformedArtifact.IsRetiredArtifact,
                    ExtensionOf = cleanTransformedArtifact.ExtensionOf,
                    PrimaryExtensionArtifact = cleanTransformedArtifact.PrimaryExtensionArtifact,
                    ToDoItems = cleanTransformedArtifact.ToDoItems,
                    ToDoItemsAKA = cleanTransformedArtifact.ToDoItemsAKA,
                    ToDoItemsMismatched = cleanTransformedArtifact.ToDoItemsMismatched,
                    Categories = cleanTransformedArtifact.Categories,
                    CategoriesAKA = cleanTransformedArtifact.CategoriesAKA,
                    CategoriesMismatched = cleanTransformedArtifact.CategoriesMismatched,
                    DueDates = cleanTransformedArtifact.DueDates,
                    DueDatesAKA = cleanTransformedArtifact.DueDatesAKA,
                    DueDatesMismatched = cleanTransformedArtifact.DueDatesMismatched,
                    Priorities = cleanTransformedArtifact.Priorities,
                    PrioritiesAKA = cleanTransformedArtifact.PrioritiesAKA,
                    PrioritiesMismatched = cleanTransformedArtifact.PrioritiesMismatched,
                    Progress = cleanTransformedArtifact.Progress,
                    ProgressAKA = cleanTransformedArtifact.ProgressAKA,
                    ProgressMismatched = cleanTransformedArtifact.ProgressMismatched,
                    Statuses = cleanTransformedArtifact.Statuses,
                    StatusesAKA = cleanTransformedArtifact.StatusesAKA,
                    StatusesMismatched = cleanTransformedArtifact.StatusesMismatched,
                    Reminders = cleanTransformedArtifact.Reminders,
                    RemindersAKA = cleanTransformedArtifact.RemindersAKA,
                    RemindersMismatched = cleanTransformedArtifact.RemindersMismatched,
                    Notifications = cleanTransformedArtifact.Notifications,
                    NotificationsAKA = cleanTransformedArtifact.NotificationsAKA,
                    NotificationsMismatched = cleanTransformedArtifact.NotificationsMismatched,
                    Completion = cleanTransformedArtifact.Completion,
                    CompletionAKA = cleanTransformedArtifact.CompletionAKA,
                    CompletionMismatched = cleanTransformedArtifact.CompletionMismatched,
                    ToDoEmployees = cleanTransformedArtifact.ToDoEmployees,
                    ToDoEmployeesAKA = cleanTransformedArtifact.ToDoEmployeesAKA,
                    ToDoEmployeesMismatched = cleanTransformedArtifact.ToDoEmployeesMismatched,
                    Duration = cleanTransformedArtifact.Duration,
                    DurationAKA = cleanTransformedArtifact.DurationAKA,
                    DurationMismatched = cleanTransformedArtifact.DurationMismatched,
                    CompletedDate = cleanTransformedArtifact.CompletedDate,
                    CompletedDateAKA = cleanTransformedArtifact.CompletedDateAKA,
                    CompletedDateMismatched = cleanTransformedArtifact.CompletedDateMismatched,
                    ToDoColors = cleanTransformedArtifact.ToDoColors,
                    ToDoColorsAKA = cleanTransformedArtifact.ToDoColorsAKA,
                    ToDoColorsMismatched = cleanTransformedArtifact.ToDoColorsMismatched,
                    ActualValidationPrompt = cleanTransformedArtifact.ActualValidationPrompt,
                    ValidationResponse = cleanTransformedArtifact.ValidationResponse,
                    CustomRootIdentifier = cleanTransformedArtifact.CustomRootIdentifier
                };
            }

            return AdminTransformedArtifact;
        }

        // Admin Cleaning Extension Methods.  -CRUD-
        
        // DesignDecision
        public static dc.DesignDecision AdminCleanForAdd(this dc.DesignDecision cleanDesignDecision)
        {
            var AdminDesignDecision = default(dc.DesignDecision);

            if (!ReferenceEquals(cleanDesignDecision, null))
            {
                AdminDesignDecision = new dc.DesignDecision()
                {
                     // default value: . 
                    DesignDecisionId = cleanDesignDecision.DesignDecisionId,
                     // default value: . 
                    Name = cleanDesignDecision.Name,
                     // default value: . 
                    Notes = cleanDesignDecision.Notes,
                     // default value: . 
                    TypeOfDecision = cleanDesignDecision.TypeOfDecision
                };
                
            }

            return AdminDesignDecision;
        }
        
        
        public static List<dc.DesignDecision> AdminCleanForGet(this IEnumerable<dc.DesignDecision> cleanDesignDecisions)
        {
            return cleanDesignDecisions.Select(DesignDecision => DesignDecision.AdminCleanForGet())
                            .ToList();
        }
        
        public static dc.DesignDecision AdminCleanForGet(this dc.DesignDecision cleanDesignDecision)
        {
            var AdminDesignDecision = default(dc.DesignDecision);

            if (!ReferenceEquals(cleanDesignDecision, null))
            {
                AdminDesignDecision = new dc.DesignDecision()
                {
                    DesignDecisionId = cleanDesignDecision.DesignDecisionId,
                    Name = cleanDesignDecision.Name,
                    Notes = cleanDesignDecision.Notes,
                    TypeOfDecision = cleanDesignDecision.TypeOfDecision
                };
            }

            return AdminDesignDecision;
        }
        
        
        public static dc.DesignDecision AdminCleanForUpdate(this dc.DesignDecision cleanDesignDecision)
        {
            var AdminDesignDecision = default(dc.DesignDecision);

            if (!ReferenceEquals(cleanDesignDecision, null))
            {
                AdminDesignDecision = new dc.DesignDecision()
                {
                    DesignDecisionId = cleanDesignDecision.DesignDecisionId,
                    Name = cleanDesignDecision.Name,
                    Notes = cleanDesignDecision.Notes,
                    TypeOfDecision = cleanDesignDecision.TypeOfDecision
                };
            }

            return AdminDesignDecision;
        }

        // Admin Cleaning Extension Methods.  -CRUD-
        
        // LLM
        public static dc.LLM AdminCleanForAdd(this dc.LLM cleanLLM)
        {
            var AdminLLM = default(dc.LLM);

            if (!ReferenceEquals(cleanLLM, null))
            {
                AdminLLM = new dc.LLM()
                {
                     // default value: . 
                    LLMId = cleanLLM.LLMId,
                     // default value: . 
                    Name = cleanLLM.Name,
                     // default value: . 
                    Notes = cleanLLM.Notes,
                     // default value: . 
                    TestRuns = cleanLLM.TestRuns,
                     // default value: . 
                    Generations = cleanLLM.Generations
                };
                
            }

            return AdminLLM;
        }
        
        
        public static List<dc.LLM> AdminCleanForGet(this IEnumerable<dc.LLM> cleanLLMs)
        {
            return cleanLLMs.Select(LLM => LLM.AdminCleanForGet())
                            .ToList();
        }
        
        public static dc.LLM AdminCleanForGet(this dc.LLM cleanLLM)
        {
            var AdminLLM = default(dc.LLM);

            if (!ReferenceEquals(cleanLLM, null))
            {
                AdminLLM = new dc.LLM()
                {
                    LLMId = cleanLLM.LLMId,
                    Name = cleanLLM.Name,
                    Notes = cleanLLM.Notes,
                    TestRuns = cleanLLM.TestRuns,
                    Generations = cleanLLM.Generations
                };
            }

            return AdminLLM;
        }
        
        
        public static dc.LLM AdminCleanForUpdate(this dc.LLM cleanLLM)
        {
            var AdminLLM = default(dc.LLM);

            if (!ReferenceEquals(cleanLLM, null))
            {
                AdminLLM = new dc.LLM()
                {
                    LLMId = cleanLLM.LLMId,
                    Name = cleanLLM.Name,
                    Notes = cleanLLM.Notes,
                    TestRuns = cleanLLM.TestRuns,
                    Generations = cleanLLM.Generations
                };
            }

            return AdminLLM;
        }

        // Admin Cleaning Extension Methods.  -CRUD-
        
        // Idea
        public static dc.Idea AdminCleanForAdd(this dc.Idea cleanIdea)
        {
            var AdminIdea = default(dc.Idea);

            if (!ReferenceEquals(cleanIdea, null))
            {
                AdminIdea = new dc.Idea()
                {
                     // default value: . 
                    IdeaId = cleanIdea.IdeaId,
                     // default value: . 
                    Name = cleanIdea.Name,
                     // default value: . 
                    SourceIdea = cleanIdea.SourceIdea,
                     // default value: . 
                    Generations = cleanIdea.Generations,
                     // default value: . 
                    IsActiveIdea = cleanIdea.IsActiveIdea,
                     // default value: . 
                    IdeaTransformers = cleanIdea.IdeaTransformers,
                     // default value: . 
                    IdeaFeatures = cleanIdea.IdeaFeatures
                };
                
            }

            return AdminIdea;
        }
        
        
        public static List<dc.Idea> AdminCleanForGet(this IEnumerable<dc.Idea> cleanIdeas)
        {
            return cleanIdeas.Select(Idea => Idea.AdminCleanForGet())
                            .ToList();
        }
        
        public static dc.Idea AdminCleanForGet(this dc.Idea cleanIdea)
        {
            var AdminIdea = default(dc.Idea);

            if (!ReferenceEquals(cleanIdea, null))
            {
                AdminIdea = new dc.Idea()
                {
                    IdeaId = cleanIdea.IdeaId,
                    Name = cleanIdea.Name,
                    SourceIdea = cleanIdea.SourceIdea,
                    Generations = cleanIdea.Generations,
                    IsActiveIdea = cleanIdea.IsActiveIdea,
                    IdeaTransformers = cleanIdea.IdeaTransformers,
                    IdeaTransformerNames = cleanIdea.IdeaTransformerNames,
                    IdeaTransformerFullPrompts = cleanIdea.IdeaTransformerFullPrompts,
                    IdeaFeatures = cleanIdea.IdeaFeatures,
                    IdeaFeatureLowerNames = cleanIdea.IdeaFeatureLowerNames,
                    IdeaFeatureNames = cleanIdea.IdeaFeatureNames,
                    FeaturesArray = cleanIdea.FeaturesArray,
                    ValidationPrompt = cleanIdea.ValidationPrompt
                };
            }

            return AdminIdea;
        }
        
        
        public static dc.Idea AdminCleanForUpdate(this dc.Idea cleanIdea)
        {
            var AdminIdea = default(dc.Idea);

            if (!ReferenceEquals(cleanIdea, null))
            {
                AdminIdea = new dc.Idea()
                {
                    IdeaId = cleanIdea.IdeaId,
                    Name = cleanIdea.Name,
                    SourceIdea = cleanIdea.SourceIdea,
                    Generations = cleanIdea.Generations,
                    IsActiveIdea = cleanIdea.IsActiveIdea,
                    IdeaTransformers = cleanIdea.IdeaTransformers,
                    IdeaFeatures = cleanIdea.IdeaFeatures
                };
            }

            return AdminIdea;
        }

    }
}
