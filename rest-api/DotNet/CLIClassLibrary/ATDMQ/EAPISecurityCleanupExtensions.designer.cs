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
                    ExpTransformer = cleanGenerationTransformer.ExpTransformer
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
                    GenerationName = cleanGenerationTransformer.GenerationName,
                    GeneratioNumber = cleanGenerationTransformer.GeneratioNumber,
                    TransformedArtifacts = cleanGenerationTransformer.TransformedArtifacts,
                    AutoNumber = cleanGenerationTransformer.AutoNumber,
                    TransformerNumber = cleanGenerationTransformer.TransformerNumber,
                    IsArtifactValidator = cleanGenerationTransformer.IsArtifactValidator,
                    ExpAbstract = cleanGenerationTransformer.ExpAbstract,
                    ExpTransformer = cleanGenerationTransformer.ExpTransformer,
                    GenerationExp = cleanGenerationTransformer.GenerationExp,
                    GenerationExpName = cleanGenerationTransformer.GenerationExpName,
                    IsActiveExp = cleanGenerationTransformer.IsActiveExp,
                    ExpTransformerIsSyntaxFree = cleanGenerationTransformer.ExpTransformerIsSyntaxFree,
                    ExpValidationPrompt = cleanGenerationTransformer.ExpValidationPrompt
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
                    ExpTransformer = cleanGenerationTransformer.ExpTransformer
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
                    GeneratioNumber = cleanGeneration.GeneratioNumber,
                     // default value: . 
                    Model = cleanGeneration.Model,
                     // default value: . 
                    Experiment = cleanGeneration.Experiment,
                     // default value: . 
                    GenerationTransformers = cleanGeneration.GenerationTransformers
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
                    GeneratioNumber = cleanGeneration.GeneratioNumber,
                    Model = cleanGeneration.Model,
                    Experiment = cleanGeneration.Experiment,
                    ExpName = cleanGeneration.ExpName,
                    GenerationTransformers = cleanGeneration.GenerationTransformers,
                    IsActiveExp = cleanGeneration.IsActiveExp,
                    ExpAbstract = cleanGeneration.ExpAbstract,
                    ExpValidationPrompt = cleanGeneration.ExpValidationPrompt,
                    GenerationTransformRawPrompts = cleanGeneration.GenerationTransformRawPrompts,
                    TransformerNumbers = cleanGeneration.TransformerNumbers,
                    SyntaxFreeTransformerNumbers = cleanGeneration.SyntaxFreeTransformerNumbers,
                    SyntaxLockedTransformerNumbers = cleanGeneration.SyntaxLockedTransformerNumbers
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
                    GeneratioNumber = cleanGeneration.GeneratioNumber,
                    Model = cleanGeneration.Model,
                    Experiment = cleanGeneration.Experiment,
                    GenerationTransformers = cleanGeneration.GenerationTransformers
                };
            }

            return UserGeneration;
        }

        // User Cleaning Extension Methods.  -CRUD-
        
        // ExperimentTransformer
        public static dc.ExperimentTransformer UserCleanForAdd(this dc.ExperimentTransformer cleanExperimentTransformer)
        {
            var UserExperimentTransformer = default(dc.ExperimentTransformer);

            if (!ReferenceEquals(cleanExperimentTransformer, null))
            {
                UserExperimentTransformer = new dc.ExperimentTransformer()
                {
                     // default value: . 
                    ExperimentTransformerId = cleanExperimentTransformer.ExperimentTransformerId,
                     // default value: . 
                    Experiment = cleanExperimentTransformer.Experiment,
                     // default value: . 
                    FullPrompt = cleanExperimentTransformer.FullPrompt,
                     // default value: . 
                    TransformedTransformers = cleanExperimentTransformer.TransformedTransformers,
                     // default value: . 
                    AutoNumber = cleanExperimentTransformer.AutoNumber,
                     // default value: . 
                    IsSyntaxFree = cleanExperimentTransformer.IsSyntaxFree
                };
                
            }

            return UserExperimentTransformer;
        }
        
        
        public static List<dc.ExperimentTransformer> UserCleanForGet(this IEnumerable<dc.ExperimentTransformer> cleanExperimentTransformers)
        {
            return cleanExperimentTransformers.Select(ExperimentTransformer => ExperimentTransformer.UserCleanForGet())
                            .ToList();
        }
        
        public static dc.ExperimentTransformer UserCleanForGet(this dc.ExperimentTransformer cleanExperimentTransformer)
        {
            var UserExperimentTransformer = default(dc.ExperimentTransformer);

            if (!ReferenceEquals(cleanExperimentTransformer, null))
            {
                UserExperimentTransformer = new dc.ExperimentTransformer()
                {
                    ExperimentTransformerId = cleanExperimentTransformer.ExperimentTransformerId,
                    Name = cleanExperimentTransformer.Name,
                    Experiment = cleanExperimentTransformer.Experiment,
                    ExpName = cleanExperimentTransformer.ExpName,
                    ExpAbstract = cleanExperimentTransformer.ExpAbstract,
                    IsActiveExp = cleanExperimentTransformer.IsActiveExp,
                    FullPrompt = cleanExperimentTransformer.FullPrompt,
                    TransformedTransformers = cleanExperimentTransformer.TransformedTransformers,
                    AutoNumber = cleanExperimentTransformer.AutoNumber,
                    TransformerIdentifier = cleanExperimentTransformer.TransformerIdentifier,
                    IsSyntaxFree = cleanExperimentTransformer.IsSyntaxFree
                };
            }

            return UserExperimentTransformer;
        }
        
        
        public static dc.ExperimentTransformer UserCleanForUpdate(this dc.ExperimentTransformer cleanExperimentTransformer)
        {
            var UserExperimentTransformer = default(dc.ExperimentTransformer);

            if (!ReferenceEquals(cleanExperimentTransformer, null))
            {
                UserExperimentTransformer = new dc.ExperimentTransformer()
                {
                    ExperimentTransformerId = cleanExperimentTransformer.ExperimentTransformerId,
                    Experiment = cleanExperimentTransformer.Experiment,
                    FullPrompt = cleanExperimentTransformer.FullPrompt,
                    TransformedTransformers = cleanExperimentTransformer.TransformedTransformers,
                    AutoNumber = cleanExperimentTransformer.AutoNumber,
                    IsSyntaxFree = cleanExperimentTransformer.IsSyntaxFree
                };
            }

            return UserExperimentTransformer;
        }

        // User Cleaning Extension Methods.  -CRUD-
        
        // ExperimentFeature
        public static dc.ExperimentFeature UserCleanForAdd(this dc.ExperimentFeature cleanExperimentFeature)
        {
            var UserExperimentFeature = default(dc.ExperimentFeature);

            if (!ReferenceEquals(cleanExperimentFeature, null))
            {
                UserExperimentFeature = new dc.ExperimentFeature()
                {
                     // default value: . 
                    ExperimentFeatureId = cleanExperimentFeature.ExperimentFeatureId,
                     // default value: . 
                    Name = cleanExperimentFeature.Name,
                     // default value: . 
                    LowerName = cleanExperimentFeature.LowerName,
                     // default value: . 
                    Description = cleanExperimentFeature.Description,
                     // default value: . 
                    RequiredStartingAtGeneration = cleanExperimentFeature.RequiredStartingAtGeneration,
                     // default value: . 
                    ExplicitlyRemovedAtGeneration = cleanExperimentFeature.ExplicitlyRemovedAtGeneration,
                     // default value: . 
                    Experiment = cleanExperimentFeature.Experiment
                };
                
            }

            return UserExperimentFeature;
        }
        
        
        public static List<dc.ExperimentFeature> UserCleanForGet(this IEnumerable<dc.ExperimentFeature> cleanExperimentFeatures)
        {
            return cleanExperimentFeatures.Select(ExperimentFeature => ExperimentFeature.UserCleanForGet())
                            .ToList();
        }
        
        public static dc.ExperimentFeature UserCleanForGet(this dc.ExperimentFeature cleanExperimentFeature)
        {
            var UserExperimentFeature = default(dc.ExperimentFeature);

            if (!ReferenceEquals(cleanExperimentFeature, null))
            {
                UserExperimentFeature = new dc.ExperimentFeature()
                {
                    ExperimentFeatureId = cleanExperimentFeature.ExperimentFeatureId,
                    Name = cleanExperimentFeature.Name,
                    LowerName = cleanExperimentFeature.LowerName,
                    Description = cleanExperimentFeature.Description,
                    RequiredStartingAtGeneration = cleanExperimentFeature.RequiredStartingAtGeneration,
                    ExplicitlyRemovedAtGeneration = cleanExperimentFeature.ExplicitlyRemovedAtGeneration,
                    ExpAbstract = cleanExperimentFeature.ExpAbstract,
                    Experiment = cleanExperimentFeature.Experiment,
                    IsActiveExp = cleanExperimentFeature.IsActiveExp
                };
            }

            return UserExperimentFeature;
        }
        
        
        public static dc.ExperimentFeature UserCleanForUpdate(this dc.ExperimentFeature cleanExperimentFeature)
        {
            var UserExperimentFeature = default(dc.ExperimentFeature);

            if (!ReferenceEquals(cleanExperimentFeature, null))
            {
                UserExperimentFeature = new dc.ExperimentFeature()
                {
                    ExperimentFeatureId = cleanExperimentFeature.ExperimentFeatureId,
                    Name = cleanExperimentFeature.Name,
                    LowerName = cleanExperimentFeature.LowerName,
                    Description = cleanExperimentFeature.Description,
                    RequiredStartingAtGeneration = cleanExperimentFeature.RequiredStartingAtGeneration,
                    ExplicitlyRemovedAtGeneration = cleanExperimentFeature.ExplicitlyRemovedAtGeneration,
                    Experiment = cleanExperimentFeature.Experiment
                };
            }

            return UserExperimentFeature;
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
                    Modified = cleanTransformedArtifact.Modified,
                    ExtensionOf = cleanTransformedArtifact.ExtensionOf,
                    TransformerNumber = cleanTransformedArtifact.TransformerNumber,
                    LongName = cleanTransformedArtifact.LongName,
                    TransformerGeneratioNumber = cleanTransformedArtifact.TransformerGeneratioNumber,
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
                    ResponseBeingValidated = cleanTransformedArtifact.ResponseBeingValidated,
                    SuggestedValidationPrompt = cleanTransformedArtifact.SuggestedValidationPrompt,
                    ActualValidationPrompt = cleanTransformedArtifact.ActualValidationPrompt,
                    ValidationResponse = cleanTransformedArtifact.ValidationResponse,
                    GenerationName = cleanTransformedArtifact.GenerationName,
                    GeneratioNumber = cleanTransformedArtifact.GeneratioNumber,
                    GenerationTransformerNumber = cleanTransformedArtifact.GenerationTransformerNumber,
                    ExtensionOfArtifactIdentifier = cleanTransformedArtifact.ExtensionOfArtifactIdentifier,
                    RootArtifactIdentifier = cleanTransformedArtifact.RootArtifactIdentifier,
                    SuggestedRootIdentifier = cleanTransformedArtifact.SuggestedRootIdentifier,
                    CustomRootIdentifier = cleanTransformedArtifact.CustomRootIdentifier,
                    RootIdentifierMismatch = cleanTransformedArtifact.RootIdentifierMismatch,
                    ExpTransformerIsSyntaxFree = cleanTransformedArtifact.ExpTransformerIsSyntaxFree,
                    IsActiveExp = cleanTransformedArtifact.IsActiveExp,
                    TransformerGenerationExpName = cleanTransformedArtifact.TransformerGenerationExpName,
                    ExpValidationPrompt = cleanTransformedArtifact.ExpValidationPrompt,
                    ExpAbstract = cleanTransformedArtifact.ExpAbstract
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
        
        // Experiment
        public static dc.Experiment UserCleanForAdd(this dc.Experiment cleanExperiment)
        {
            var UserExperiment = default(dc.Experiment);

            if (!ReferenceEquals(cleanExperiment, null))
            {
                UserExperiment = new dc.Experiment()
                {
                     // default value: . 
                    ExperimentId = cleanExperiment.ExperimentId,
                     // default value: . 
                    ExpName = cleanExperiment.ExpName,
                     // default value: . 
                    ExpAbstract = cleanExperiment.ExpAbstract,
                     // default value: . 
                    Generations = cleanExperiment.Generations,
                     // default value: . 
                    ExpTransformers = cleanExperiment.ExpTransformers,
                     // default value: . 
                    IsActiveExp = cleanExperiment.IsActiveExp,
                     // default value: . 
                    ExpFeatures = cleanExperiment.ExpFeatures,
                     // default value: . 
                    AutoNumber = cleanExperiment.AutoNumber
                };
                
            }

            return UserExperiment;
        }
        
        
        public static List<dc.Experiment> UserCleanForGet(this IEnumerable<dc.Experiment> cleanExperiments)
        {
            return cleanExperiments.Select(Experiment => Experiment.UserCleanForGet())
                            .ToList();
        }
        
        public static dc.Experiment UserCleanForGet(this dc.Experiment cleanExperiment)
        {
            var UserExperiment = default(dc.Experiment);

            if (!ReferenceEquals(cleanExperiment, null))
            {
                UserExperiment = new dc.Experiment()
                {
                    ExperimentId = cleanExperiment.ExperimentId,
                    Name = cleanExperiment.Name,
                    ExpName = cleanExperiment.ExpName,
                    ExpIdentifier = cleanExperiment.ExpIdentifier,
                    ExpAbstract = cleanExperiment.ExpAbstract,
                    Generations = cleanExperiment.Generations,
                    ExpTransformers = cleanExperiment.ExpTransformers,
                    ExpTransformerNames = cleanExperiment.ExpTransformerNames,
                    ExpTransformerFullPrompts = cleanExperiment.ExpTransformerFullPrompts,
                    IsActiveExp = cleanExperiment.IsActiveExp,
                    ExpFeatures = cleanExperiment.ExpFeatures,
                    ExpFeatureLowerNames = cleanExperiment.ExpFeatureLowerNames,
                    ExpFeatureNames = cleanExperiment.ExpFeatureNames,
                    FeaturesArray = cleanExperiment.FeaturesArray,
                    ValidationPrompt = cleanExperiment.ValidationPrompt,
                    AutoNumber = cleanExperiment.AutoNumber
                };
            }

            return UserExperiment;
        }
        
        
        public static dc.Experiment UserCleanForUpdate(this dc.Experiment cleanExperiment)
        {
            var UserExperiment = default(dc.Experiment);

            if (!ReferenceEquals(cleanExperiment, null))
            {
                UserExperiment = new dc.Experiment()
                {
                    ExperimentId = cleanExperiment.ExperimentId,
                    ExpName = cleanExperiment.ExpName,
                    ExpAbstract = cleanExperiment.ExpAbstract,
                    Generations = cleanExperiment.Generations,
                    ExpTransformers = cleanExperiment.ExpTransformers,
                    IsActiveExp = cleanExperiment.IsActiveExp,
                    ExpFeatures = cleanExperiment.ExpFeatures,
                    AutoNumber = cleanExperiment.AutoNumber
                };
            }

            return UserExperiment;
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
                    ExpTransformer = cleanGenerationTransformer.ExpTransformer
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
                    GenerationName = cleanGenerationTransformer.GenerationName,
                    GeneratioNumber = cleanGenerationTransformer.GeneratioNumber,
                    TransformedArtifacts = cleanGenerationTransformer.TransformedArtifacts,
                    AutoNumber = cleanGenerationTransformer.AutoNumber,
                    TransformerNumber = cleanGenerationTransformer.TransformerNumber,
                    IsArtifactValidator = cleanGenerationTransformer.IsArtifactValidator,
                    ExpAbstract = cleanGenerationTransformer.ExpAbstract,
                    ExpTransformer = cleanGenerationTransformer.ExpTransformer,
                    GenerationExp = cleanGenerationTransformer.GenerationExp,
                    GenerationExpName = cleanGenerationTransformer.GenerationExpName,
                    IsActiveExp = cleanGenerationTransformer.IsActiveExp,
                    ExpTransformerIsSyntaxFree = cleanGenerationTransformer.ExpTransformerIsSyntaxFree,
                    ExpValidationPrompt = cleanGenerationTransformer.ExpValidationPrompt
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
                    ExpTransformer = cleanGenerationTransformer.ExpTransformer
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
                    GeneratioNumber = cleanGeneration.GeneratioNumber,
                     // default value: . 
                    Model = cleanGeneration.Model,
                     // default value: . 
                    Experiment = cleanGeneration.Experiment,
                     // default value: . 
                    GenerationTransformers = cleanGeneration.GenerationTransformers
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
                    GeneratioNumber = cleanGeneration.GeneratioNumber,
                    Model = cleanGeneration.Model,
                    Experiment = cleanGeneration.Experiment,
                    ExpName = cleanGeneration.ExpName,
                    GenerationTransformers = cleanGeneration.GenerationTransformers,
                    IsActiveExp = cleanGeneration.IsActiveExp,
                    ExpAbstract = cleanGeneration.ExpAbstract,
                    ExpValidationPrompt = cleanGeneration.ExpValidationPrompt,
                    GenerationTransformRawPrompts = cleanGeneration.GenerationTransformRawPrompts,
                    TransformerNumbers = cleanGeneration.TransformerNumbers,
                    SyntaxFreeTransformerNumbers = cleanGeneration.SyntaxFreeTransformerNumbers,
                    SyntaxLockedTransformerNumbers = cleanGeneration.SyntaxLockedTransformerNumbers
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
                    GeneratioNumber = cleanGeneration.GeneratioNumber,
                    Model = cleanGeneration.Model,
                    Experiment = cleanGeneration.Experiment,
                    GenerationTransformers = cleanGeneration.GenerationTransformers
                };
            }

            return AdminGeneration;
        }

        // Admin Cleaning Extension Methods.  -CRUD-
        
        // ExperimentTransformer
        public static dc.ExperimentTransformer AdminCleanForAdd(this dc.ExperimentTransformer cleanExperimentTransformer)
        {
            var AdminExperimentTransformer = default(dc.ExperimentTransformer);

            if (!ReferenceEquals(cleanExperimentTransformer, null))
            {
                AdminExperimentTransformer = new dc.ExperimentTransformer()
                {
                     // default value: . 
                    ExperimentTransformerId = cleanExperimentTransformer.ExperimentTransformerId,
                     // default value: . 
                    Experiment = cleanExperimentTransformer.Experiment,
                     // default value: . 
                    FullPrompt = cleanExperimentTransformer.FullPrompt,
                     // default value: . 
                    TransformedTransformers = cleanExperimentTransformer.TransformedTransformers,
                     // default value: . 
                    AutoNumber = cleanExperimentTransformer.AutoNumber,
                     // default value: . 
                    IsSyntaxFree = cleanExperimentTransformer.IsSyntaxFree
                };
                
            }

            return AdminExperimentTransformer;
        }
        
        
        public static List<dc.ExperimentTransformer> AdminCleanForGet(this IEnumerable<dc.ExperimentTransformer> cleanExperimentTransformers)
        {
            return cleanExperimentTransformers.Select(ExperimentTransformer => ExperimentTransformer.AdminCleanForGet())
                            .ToList();
        }
        
        public static dc.ExperimentTransformer AdminCleanForGet(this dc.ExperimentTransformer cleanExperimentTransformer)
        {
            var AdminExperimentTransformer = default(dc.ExperimentTransformer);

            if (!ReferenceEquals(cleanExperimentTransformer, null))
            {
                AdminExperimentTransformer = new dc.ExperimentTransformer()
                {
                    ExperimentTransformerId = cleanExperimentTransformer.ExperimentTransformerId,
                    Name = cleanExperimentTransformer.Name,
                    Experiment = cleanExperimentTransformer.Experiment,
                    ExpName = cleanExperimentTransformer.ExpName,
                    ExpAbstract = cleanExperimentTransformer.ExpAbstract,
                    IsActiveExp = cleanExperimentTransformer.IsActiveExp,
                    FullPrompt = cleanExperimentTransformer.FullPrompt,
                    TransformedTransformers = cleanExperimentTransformer.TransformedTransformers,
                    AutoNumber = cleanExperimentTransformer.AutoNumber,
                    TransformerIdentifier = cleanExperimentTransformer.TransformerIdentifier,
                    IsSyntaxFree = cleanExperimentTransformer.IsSyntaxFree
                };
            }

            return AdminExperimentTransformer;
        }
        
        
        public static dc.ExperimentTransformer AdminCleanForUpdate(this dc.ExperimentTransformer cleanExperimentTransformer)
        {
            var AdminExperimentTransformer = default(dc.ExperimentTransformer);

            if (!ReferenceEquals(cleanExperimentTransformer, null))
            {
                AdminExperimentTransformer = new dc.ExperimentTransformer()
                {
                    ExperimentTransformerId = cleanExperimentTransformer.ExperimentTransformerId,
                    Experiment = cleanExperimentTransformer.Experiment,
                    FullPrompt = cleanExperimentTransformer.FullPrompt,
                    TransformedTransformers = cleanExperimentTransformer.TransformedTransformers,
                    AutoNumber = cleanExperimentTransformer.AutoNumber,
                    IsSyntaxFree = cleanExperimentTransformer.IsSyntaxFree
                };
            }

            return AdminExperimentTransformer;
        }

        // Admin Cleaning Extension Methods.  -CRUD-
        
        // ExperimentFeature
        public static dc.ExperimentFeature AdminCleanForAdd(this dc.ExperimentFeature cleanExperimentFeature)
        {
            var AdminExperimentFeature = default(dc.ExperimentFeature);

            if (!ReferenceEquals(cleanExperimentFeature, null))
            {
                AdminExperimentFeature = new dc.ExperimentFeature()
                {
                     // default value: . 
                    ExperimentFeatureId = cleanExperimentFeature.ExperimentFeatureId,
                     // default value: . 
                    Name = cleanExperimentFeature.Name,
                     // default value: . 
                    LowerName = cleanExperimentFeature.LowerName,
                     // default value: . 
                    Description = cleanExperimentFeature.Description,
                     // default value: . 
                    RequiredStartingAtGeneration = cleanExperimentFeature.RequiredStartingAtGeneration,
                     // default value: . 
                    ExplicitlyRemovedAtGeneration = cleanExperimentFeature.ExplicitlyRemovedAtGeneration,
                     // default value: . 
                    Experiment = cleanExperimentFeature.Experiment
                };
                
            }

            return AdminExperimentFeature;
        }
        
        
        public static List<dc.ExperimentFeature> AdminCleanForGet(this IEnumerable<dc.ExperimentFeature> cleanExperimentFeatures)
        {
            return cleanExperimentFeatures.Select(ExperimentFeature => ExperimentFeature.AdminCleanForGet())
                            .ToList();
        }
        
        public static dc.ExperimentFeature AdminCleanForGet(this dc.ExperimentFeature cleanExperimentFeature)
        {
            var AdminExperimentFeature = default(dc.ExperimentFeature);

            if (!ReferenceEquals(cleanExperimentFeature, null))
            {
                AdminExperimentFeature = new dc.ExperimentFeature()
                {
                    ExperimentFeatureId = cleanExperimentFeature.ExperimentFeatureId,
                    Name = cleanExperimentFeature.Name,
                    LowerName = cleanExperimentFeature.LowerName,
                    Description = cleanExperimentFeature.Description,
                    RequiredStartingAtGeneration = cleanExperimentFeature.RequiredStartingAtGeneration,
                    ExplicitlyRemovedAtGeneration = cleanExperimentFeature.ExplicitlyRemovedAtGeneration,
                    ExpAbstract = cleanExperimentFeature.ExpAbstract,
                    Experiment = cleanExperimentFeature.Experiment,
                    IsActiveExp = cleanExperimentFeature.IsActiveExp
                };
            }

            return AdminExperimentFeature;
        }
        
        
        public static dc.ExperimentFeature AdminCleanForUpdate(this dc.ExperimentFeature cleanExperimentFeature)
        {
            var AdminExperimentFeature = default(dc.ExperimentFeature);

            if (!ReferenceEquals(cleanExperimentFeature, null))
            {
                AdminExperimentFeature = new dc.ExperimentFeature()
                {
                    ExperimentFeatureId = cleanExperimentFeature.ExperimentFeatureId,
                    Name = cleanExperimentFeature.Name,
                    LowerName = cleanExperimentFeature.LowerName,
                    Description = cleanExperimentFeature.Description,
                    RequiredStartingAtGeneration = cleanExperimentFeature.RequiredStartingAtGeneration,
                    ExplicitlyRemovedAtGeneration = cleanExperimentFeature.ExplicitlyRemovedAtGeneration,
                    Experiment = cleanExperimentFeature.Experiment
                };
            }

            return AdminExperimentFeature;
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
                    Modified = cleanTransformedArtifact.Modified,
                    ExtensionOf = cleanTransformedArtifact.ExtensionOf,
                    TransformerNumber = cleanTransformedArtifact.TransformerNumber,
                    LongName = cleanTransformedArtifact.LongName,
                    TransformerGeneratioNumber = cleanTransformedArtifact.TransformerGeneratioNumber,
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
                    ResponseBeingValidated = cleanTransformedArtifact.ResponseBeingValidated,
                    SuggestedValidationPrompt = cleanTransformedArtifact.SuggestedValidationPrompt,
                    ActualValidationPrompt = cleanTransformedArtifact.ActualValidationPrompt,
                    ValidationResponse = cleanTransformedArtifact.ValidationResponse,
                    GenerationName = cleanTransformedArtifact.GenerationName,
                    GeneratioNumber = cleanTransformedArtifact.GeneratioNumber,
                    GenerationTransformerNumber = cleanTransformedArtifact.GenerationTransformerNumber,
                    ExtensionOfArtifactIdentifier = cleanTransformedArtifact.ExtensionOfArtifactIdentifier,
                    RootArtifactIdentifier = cleanTransformedArtifact.RootArtifactIdentifier,
                    SuggestedRootIdentifier = cleanTransformedArtifact.SuggestedRootIdentifier,
                    CustomRootIdentifier = cleanTransformedArtifact.CustomRootIdentifier,
                    RootIdentifierMismatch = cleanTransformedArtifact.RootIdentifierMismatch,
                    ExpTransformerIsSyntaxFree = cleanTransformedArtifact.ExpTransformerIsSyntaxFree,
                    IsActiveExp = cleanTransformedArtifact.IsActiveExp,
                    TransformerGenerationExpName = cleanTransformedArtifact.TransformerGenerationExpName,
                    ExpValidationPrompt = cleanTransformedArtifact.ExpValidationPrompt,
                    ExpAbstract = cleanTransformedArtifact.ExpAbstract
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
        
        // Experiment
        public static dc.Experiment AdminCleanForAdd(this dc.Experiment cleanExperiment)
        {
            var AdminExperiment = default(dc.Experiment);

            if (!ReferenceEquals(cleanExperiment, null))
            {
                AdminExperiment = new dc.Experiment()
                {
                     // default value: . 
                    ExperimentId = cleanExperiment.ExperimentId,
                     // default value: . 
                    ExpName = cleanExperiment.ExpName,
                     // default value: . 
                    ExpAbstract = cleanExperiment.ExpAbstract,
                     // default value: . 
                    Generations = cleanExperiment.Generations,
                     // default value: . 
                    ExpTransformers = cleanExperiment.ExpTransformers,
                     // default value: . 
                    IsActiveExp = cleanExperiment.IsActiveExp,
                     // default value: . 
                    ExpFeatures = cleanExperiment.ExpFeatures,
                     // default value: . 
                    AutoNumber = cleanExperiment.AutoNumber
                };
                
            }

            return AdminExperiment;
        }
        
        
        public static List<dc.Experiment> AdminCleanForGet(this IEnumerable<dc.Experiment> cleanExperiments)
        {
            return cleanExperiments.Select(Experiment => Experiment.AdminCleanForGet())
                            .ToList();
        }
        
        public static dc.Experiment AdminCleanForGet(this dc.Experiment cleanExperiment)
        {
            var AdminExperiment = default(dc.Experiment);

            if (!ReferenceEquals(cleanExperiment, null))
            {
                AdminExperiment = new dc.Experiment()
                {
                    ExperimentId = cleanExperiment.ExperimentId,
                    Name = cleanExperiment.Name,
                    ExpName = cleanExperiment.ExpName,
                    ExpIdentifier = cleanExperiment.ExpIdentifier,
                    ExpAbstract = cleanExperiment.ExpAbstract,
                    Generations = cleanExperiment.Generations,
                    ExpTransformers = cleanExperiment.ExpTransformers,
                    ExpTransformerNames = cleanExperiment.ExpTransformerNames,
                    ExpTransformerFullPrompts = cleanExperiment.ExpTransformerFullPrompts,
                    IsActiveExp = cleanExperiment.IsActiveExp,
                    ExpFeatures = cleanExperiment.ExpFeatures,
                    ExpFeatureLowerNames = cleanExperiment.ExpFeatureLowerNames,
                    ExpFeatureNames = cleanExperiment.ExpFeatureNames,
                    FeaturesArray = cleanExperiment.FeaturesArray,
                    ValidationPrompt = cleanExperiment.ValidationPrompt,
                    AutoNumber = cleanExperiment.AutoNumber
                };
            }

            return AdminExperiment;
        }
        
        
        public static dc.Experiment AdminCleanForUpdate(this dc.Experiment cleanExperiment)
        {
            var AdminExperiment = default(dc.Experiment);

            if (!ReferenceEquals(cleanExperiment, null))
            {
                AdminExperiment = new dc.Experiment()
                {
                    ExperimentId = cleanExperiment.ExperimentId,
                    ExpName = cleanExperiment.ExpName,
                    ExpAbstract = cleanExperiment.ExpAbstract,
                    Generations = cleanExperiment.Generations,
                    ExpTransformers = cleanExperiment.ExpTransformers,
                    IsActiveExp = cleanExperiment.IsActiveExp,
                    ExpFeatures = cleanExperiment.ExpFeatures,
                    AutoNumber = cleanExperiment.AutoNumber
                };
            }

            return AdminExperiment;
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

    }
}
