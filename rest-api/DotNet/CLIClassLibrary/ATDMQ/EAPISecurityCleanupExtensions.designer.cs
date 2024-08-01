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
        
        // CRUDCoordinator Cleaning Extension Methods.  --
        
        // CRUDCoordinator Cleaning Extension Methods.  --
        
        // User Cleaning Extension Methods.  -CRUD-
        
        // TrialArtifact
        public static dc.TrialArtifact UserCleanForAdd(this dc.TrialArtifact cleanTrialArtifact)
        {
            var UserTrialArtifact = default(dc.TrialArtifact);

            if (!ReferenceEquals(cleanTrialArtifact, null))
            {
                UserTrialArtifact = new dc.TrialArtifact()
                {
                     // default value: . 
                    TrialArtifactId = cleanTrialArtifact.TrialArtifactId,
                     // default value: . 
                    ActualPrompt = cleanTrialArtifact.ActualPrompt,
                     // default value: . 
                    ActualValidationPrompt = cleanTrialArtifact.ActualValidationPrompt,
                     // default value: . 
                    ValidationResponse = cleanTrialArtifact.ValidationResponse,
                     // default value: . 
                    ExtensionOf = cleanTrialArtifact.ExtensionOf,
                     // default value: . 
                    AutoNumber = cleanTrialArtifact.AutoNumber,
                     // default value: . 
                    IsRetiredArtifact = cleanTrialArtifact.IsRetiredArtifact,
                     // default value: . 
                    CustomRootIdentifier = cleanTrialArtifact.CustomRootIdentifier,
                     // default value: . 
                    Trial = cleanTrialArtifact.Trial,
                     // default value: . 
                    GenerationTransformer = cleanTrialArtifact.GenerationTransformer,
                     // default value: . 
                    Response = cleanTrialArtifact.Response,
                     // default value: . 
                    PrimaryExtensionArtifact = cleanTrialArtifact.PrimaryExtensionArtifact,
                     // default value: . 
                    ArtifactAnalysis = cleanTrialArtifact.ArtifactAnalysis
                };
                
            }

            return UserTrialArtifact;
        }
        
        
        public static List<dc.TrialArtifact> UserCleanForGet(this IEnumerable<dc.TrialArtifact> cleanTrialArtifacts)
        {
            return cleanTrialArtifacts.Select(TrialArtifact => TrialArtifact.UserCleanForGet())
                            .ToList();
        }
        
        public static dc.TrialArtifact UserCleanForGet(this dc.TrialArtifact cleanTrialArtifact)
        {
            var UserTrialArtifact = default(dc.TrialArtifact);

            if (!ReferenceEquals(cleanTrialArtifact, null))
            {
                UserTrialArtifact = new dc.TrialArtifact()
                {
                    TrialArtifactId = cleanTrialArtifact.TrialArtifactId,
                    Name = cleanTrialArtifact.Name,
                    ActualPrompt = cleanTrialArtifact.ActualPrompt,
                    ActualValidationPrompt = cleanTrialArtifact.ActualValidationPrompt,
                    ValidationResponse = cleanTrialArtifact.ValidationResponse,
                    ExtensionOf = cleanTrialArtifact.ExtensionOf,
                    Created = cleanTrialArtifact.Created,
                    AutoNumber = cleanTrialArtifact.AutoNumber,
                    IsRetiredArtifact = cleanTrialArtifact.IsRetiredArtifact,
                    Modified = cleanTrialArtifact.Modified,
                    LongName = cleanTrialArtifact.LongName,
                    ArtifactIdentifier = cleanTrialArtifact.ArtifactIdentifier,
                    ExtensionOfArtifactIdentifier = cleanTrialArtifact.ExtensionOfArtifactIdentifier,
                    CustomRootIdentifier = cleanTrialArtifact.CustomRootIdentifier,
                    Trial = cleanTrialArtifact.Trial,
                    GenerationTransformer = cleanTrialArtifact.GenerationTransformer,
                    ExpTransformerIsSyntaxFree = cleanTrialArtifact.ExpTransformerIsSyntaxFree,
                    GenerationName = cleanTrialArtifact.GenerationName,
                    GeneratioNumber = cleanTrialArtifact.GeneratioNumber,
                    GenerationTransformerNumber = cleanTrialArtifact.GenerationTransformerNumber,
                    TransformerRawPrompt = cleanTrialArtifact.TransformerRawPrompt,
                    IsActiveExp = cleanTrialArtifact.IsActiveExp,
                    TransformerNumber = cleanTrialArtifact.TransformerNumber,
                    TransformerGeneratioNumber = cleanTrialArtifact.TransformerGeneratioNumber,
                    TransformerGenerationExpName = cleanTrialArtifact.TransformerGenerationExpName,
                    TransformerGenerationName = cleanTrialArtifact.TransformerGenerationName,
                    ExpValidationPrompt = cleanTrialArtifact.ExpValidationPrompt,
                    ExpAbstract = cleanTrialArtifact.ExpAbstract,
                    Response = cleanTrialArtifact.Response,
                    PrimaryExtensionArtifact = cleanTrialArtifact.PrimaryExtensionArtifact,
                    ResponseOfArtifactBeingExtended = cleanTrialArtifact.ResponseOfArtifactBeingExtended,
                    SuggestedPrompt = cleanTrialArtifact.SuggestedPrompt,
                    ResponseBeingValidated = cleanTrialArtifact.ResponseBeingValidated,
                    SuggestedValidationPrompt = cleanTrialArtifact.SuggestedValidationPrompt,
                    RootArtifactIdentifier = cleanTrialArtifact.RootArtifactIdentifier,
                    SuggestedRootIdentifier = cleanTrialArtifact.SuggestedRootIdentifier,
                    RootIdentifierMismatch = cleanTrialArtifact.RootIdentifierMismatch,
                    ArtifactAnalysis = cleanTrialArtifact.ArtifactAnalysis
                };
            }

            return UserTrialArtifact;
        }
        
        
        public static dc.TrialArtifact UserCleanForUpdate(this dc.TrialArtifact cleanTrialArtifact)
        {
            var UserTrialArtifact = default(dc.TrialArtifact);

            if (!ReferenceEquals(cleanTrialArtifact, null))
            {
                UserTrialArtifact = new dc.TrialArtifact()
                {
                    TrialArtifactId = cleanTrialArtifact.TrialArtifactId,
                    ActualPrompt = cleanTrialArtifact.ActualPrompt,
                    ActualValidationPrompt = cleanTrialArtifact.ActualValidationPrompt,
                    ValidationResponse = cleanTrialArtifact.ValidationResponse,
                    ExtensionOf = cleanTrialArtifact.ExtensionOf,
                    AutoNumber = cleanTrialArtifact.AutoNumber,
                    IsRetiredArtifact = cleanTrialArtifact.IsRetiredArtifact,
                    CustomRootIdentifier = cleanTrialArtifact.CustomRootIdentifier,
                    Trial = cleanTrialArtifact.Trial,
                    GenerationTransformer = cleanTrialArtifact.GenerationTransformer,
                    Response = cleanTrialArtifact.Response,
                    PrimaryExtensionArtifact = cleanTrialArtifact.PrimaryExtensionArtifact,
                    ArtifactAnalysis = cleanTrialArtifact.ArtifactAnalysis
                };
            }

            return UserTrialArtifact;
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
                    AutoNumber = cleanGenerationTransformer.AutoNumber,
                     // default value: . 
                    IsArtifactValidator = cleanGenerationTransformer.IsArtifactValidator,
                     // default value: . 
                    ParentTransformer = cleanGenerationTransformer.ParentTransformer,
                     // default value: . 
                    ExpTransformer = cleanGenerationTransformer.ExpTransformer,
                     // default value: . 
                    TrialArtifacts = cleanGenerationTransformer.TrialArtifacts
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
                    AutoNumber = cleanGenerationTransformer.AutoNumber,
                    TransformerNumber = cleanGenerationTransformer.TransformerNumber,
                    IsArtifactValidator = cleanGenerationTransformer.IsArtifactValidator,
                    ExpAbstract = cleanGenerationTransformer.ExpAbstract,
                    GenerationExp = cleanGenerationTransformer.GenerationExp,
                    GenerationExpName = cleanGenerationTransformer.GenerationExpName,
                    IsActiveExp = cleanGenerationTransformer.IsActiveExp,
                    ExpValidationPrompt = cleanGenerationTransformer.ExpValidationPrompt,
                    GenerationNumber = cleanGenerationTransformer.GenerationNumber,
                    ParentTransformer = cleanGenerationTransformer.ParentTransformer,
                    ParentTransformerNumber = cleanGenerationTransformer.ParentTransformerNumber,
                    AddDataCommand = cleanGenerationTransformer.AddDataCommand,
                    ExpTransformer = cleanGenerationTransformer.ExpTransformer,
                    TrialArtifacts = cleanGenerationTransformer.TrialArtifacts,
                    ExpTransformerIsSyntaxFree = cleanGenerationTransformer.ExpTransformerIsSyntaxFree
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
                    AutoNumber = cleanGenerationTransformer.AutoNumber,
                    IsArtifactValidator = cleanGenerationTransformer.IsArtifactValidator,
                    ParentTransformer = cleanGenerationTransformer.ParentTransformer,
                    ExpTransformer = cleanGenerationTransformer.ExpTransformer,
                    TrialArtifacts = cleanGenerationTransformer.TrialArtifacts
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
                    SyntaxLockedTransformerNumbers = cleanGeneration.SyntaxLockedTransformerNumbers,
                    GenerationTransformerAddDataCommands = cleanGeneration.GenerationTransformerAddDataCommands,
                    AddDataCommandScript = cleanGeneration.AddDataCommandScript
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
        
        // Trial
        public static dc.Trial UserCleanForAdd(this dc.Trial cleanTrial)
        {
            var UserTrial = default(dc.Trial);

            if (!ReferenceEquals(cleanTrial, null))
            {
                UserTrial = new dc.Trial()
                {
                     // default value: . 
                    TrialId = cleanTrial.TrialId,
                     // default value: . 
                    Experiement = cleanTrial.Experiement,
                     // default value: . 
                    TrialArtifacts = cleanTrial.TrialArtifacts,
                     // default value: . 
                    AutoNumber = cleanTrial.AutoNumber,
                     // default value: . 
                    DesiredPromptChainCount = cleanTrial.DesiredPromptChainCount,
                     // default value: . 
                    TrialArtifactCount = cleanTrial.TrialArtifactCount
                };
                
            }

            return UserTrial;
        }
        
        
        public static List<dc.Trial> UserCleanForGet(this IEnumerable<dc.Trial> cleanTrials)
        {
            return cleanTrials.Select(Trial => Trial.UserCleanForGet())
                            .ToList();
        }
        
        public static dc.Trial UserCleanForGet(this dc.Trial cleanTrial)
        {
            var UserTrial = default(dc.Trial);

            if (!ReferenceEquals(cleanTrial, null))
            {
                UserTrial = new dc.Trial()
                {
                    TrialId = cleanTrial.TrialId,
                    Name = cleanTrial.Name,
                    Experiement = cleanTrial.Experiement,
                    TrialArtifacts = cleanTrial.TrialArtifacts,
                    AutoNumber = cleanTrial.AutoNumber,
                    TrailIdentifier = cleanTrial.TrailIdentifier,
                    Created = cleanTrial.Created,
                    DesiredPromptChainCount = cleanTrial.DesiredPromptChainCount,
                    TrialArtifactCount = cleanTrial.TrialArtifactCount,
                    GatherTrialDataScript = cleanTrial.GatherTrialDataScript,
                    ExperimentRunTrialScript = cleanTrial.ExperimentRunTrialScript
                };
            }

            return UserTrial;
        }
        
        
        public static dc.Trial UserCleanForUpdate(this dc.Trial cleanTrial)
        {
            var UserTrial = default(dc.Trial);

            if (!ReferenceEquals(cleanTrial, null))
            {
                UserTrial = new dc.Trial()
                {
                    TrialId = cleanTrial.TrialId,
                    Experiement = cleanTrial.Experiement,
                    TrialArtifacts = cleanTrial.TrialArtifacts,
                    AutoNumber = cleanTrial.AutoNumber,
                    DesiredPromptChainCount = cleanTrial.DesiredPromptChainCount,
                    TrialArtifactCount = cleanTrial.TrialArtifactCount
                };
            }

            return UserTrial;
        }

        // User Cleaning Extension Methods.  -CRUD-
        
        // ArtifactAnalysi
        public static dc.ArtifactAnalysi UserCleanForAdd(this dc.ArtifactAnalysi cleanArtifactAnalysi)
        {
            var UserArtifactAnalysi = default(dc.ArtifactAnalysi);

            if (!ReferenceEquals(cleanArtifactAnalysi, null))
            {
                UserArtifactAnalysi = new dc.ArtifactAnalysi()
                {
                     // default value: . 
                    ArtifactAnalysiId = cleanArtifactAnalysi.ArtifactAnalysiId,
                     // default value: . 
                    PreviousGeneration = cleanArtifactAnalysi.PreviousGeneration,
                     // default value: . 
                    TrialArtifact = cleanArtifactAnalysi.TrialArtifact,
                     // default value: . 
                    CleanValidationJson = cleanArtifactAnalysi.CleanValidationJson,
                     // default value: . 
                    ToDoItems = cleanArtifactAnalysi.ToDoItems,
                     // default value: . 
                    ToDoItemsAKA = cleanArtifactAnalysi.ToDoItemsAKA,
                     // default value: . 
                    ToDoItemsMismatched = cleanArtifactAnalysi.ToDoItemsMismatched,
                     // default value: . 
                    Categories = cleanArtifactAnalysi.Categories,
                     // default value: . 
                    CategoriesAKA = cleanArtifactAnalysi.CategoriesAKA,
                     // default value: . 
                    CategoriesMismatched = cleanArtifactAnalysi.CategoriesMismatched,
                     // default value: . 
                    DueDates = cleanArtifactAnalysi.DueDates,
                     // default value: . 
                    DueDatesAKA = cleanArtifactAnalysi.DueDatesAKA,
                     // default value: . 
                    DueDatesMismatched = cleanArtifactAnalysi.DueDatesMismatched,
                     // default value: . 
                    Priorities = cleanArtifactAnalysi.Priorities,
                     // default value: . 
                    PrioritiesAKA = cleanArtifactAnalysi.PrioritiesAKA,
                     // default value: . 
                    PrioritiesMismatched = cleanArtifactAnalysi.PrioritiesMismatched,
                     // default value: . 
                    Progress = cleanArtifactAnalysi.Progress,
                     // default value: . 
                    ProgressAKA = cleanArtifactAnalysi.ProgressAKA,
                     // default value: . 
                    ProgressMismatched = cleanArtifactAnalysi.ProgressMismatched,
                     // default value: . 
                    Statuses = cleanArtifactAnalysi.Statuses,
                     // default value: . 
                    StatusesAKA = cleanArtifactAnalysi.StatusesAKA,
                     // default value: . 
                    StatusesMismatched = cleanArtifactAnalysi.StatusesMismatched,
                     // default value: . 
                    Reminders = cleanArtifactAnalysi.Reminders,
                     // default value: . 
                    RemindersAKA = cleanArtifactAnalysi.RemindersAKA,
                     // default value: . 
                    RemindersMismatched = cleanArtifactAnalysi.RemindersMismatched,
                     // default value: . 
                    Notifications = cleanArtifactAnalysi.Notifications,
                     // default value: . 
                    NotificationsAKA = cleanArtifactAnalysi.NotificationsAKA,
                     // default value: . 
                    NotificationsMismatched = cleanArtifactAnalysi.NotificationsMismatched,
                     // default value: . 
                    Completion = cleanArtifactAnalysi.Completion,
                     // default value: . 
                    CompletionAKA = cleanArtifactAnalysi.CompletionAKA,
                     // default value: . 
                    CompletionMismatched = cleanArtifactAnalysi.CompletionMismatched,
                     // default value: . 
                    ToDoEmployees = cleanArtifactAnalysi.ToDoEmployees,
                     // default value: . 
                    ToDoEmployeesAKA = cleanArtifactAnalysi.ToDoEmployeesAKA,
                     // default value: . 
                    ToDoEmployeesMismatched = cleanArtifactAnalysi.ToDoEmployeesMismatched,
                     // default value: . 
                    Duration = cleanArtifactAnalysi.Duration,
                     // default value: . 
                    DurationAKA = cleanArtifactAnalysi.DurationAKA,
                     // default value: . 
                    DurationMismatched = cleanArtifactAnalysi.DurationMismatched,
                     // default value: . 
                    CompletedDate = cleanArtifactAnalysi.CompletedDate,
                     // default value: . 
                    CompletedDateAKA = cleanArtifactAnalysi.CompletedDateAKA,
                     // default value: . 
                    CompletedDateMismatched = cleanArtifactAnalysi.CompletedDateMismatched,
                     // default value: . 
                    ToDoColors = cleanArtifactAnalysi.ToDoColors,
                     // default value: . 
                    ToDoColorsAKA = cleanArtifactAnalysi.ToDoColorsAKA,
                     // default value: . 
                    ToDoColorsMismatched = cleanArtifactAnalysi.ToDoColorsMismatched
                };
                
            }

            return UserArtifactAnalysi;
        }
        
        
        public static List<dc.ArtifactAnalysi> UserCleanForGet(this IEnumerable<dc.ArtifactAnalysi> cleanArtifactAnalysis)
        {
            return cleanArtifactAnalysis.Select(ArtifactAnalysi => ArtifactAnalysi.UserCleanForGet())
                            .ToList();
        }
        
        public static dc.ArtifactAnalysi UserCleanForGet(this dc.ArtifactAnalysi cleanArtifactAnalysi)
        {
            var UserArtifactAnalysi = default(dc.ArtifactAnalysi);

            if (!ReferenceEquals(cleanArtifactAnalysi, null))
            {
                UserArtifactAnalysi = new dc.ArtifactAnalysi()
                {
                    ArtifactAnalysiId = cleanArtifactAnalysi.ArtifactAnalysiId,
                    Name = cleanArtifactAnalysi.Name,
                    PreviousGeneration = cleanArtifactAnalysi.PreviousGeneration,
                    PrevGenName = cleanArtifactAnalysi.PrevGenName,
                    PrevGenArtifactIdentifier = cleanArtifactAnalysi.PrevGenArtifactIdentifier,
                    PrevGenTransformerNumber = cleanArtifactAnalysi.PrevGenTransformerNumber,
                    TrialArtifact = cleanArtifactAnalysi.TrialArtifact,
                    TrialArtifactExtensionOf = cleanArtifactAnalysi.TrialArtifactExtensionOf,
                    ExpTransformerIsSyntaxFree = cleanArtifactAnalysi.ExpTransformerIsSyntaxFree,
                    RootArtifactIdentifier = cleanArtifactAnalysi.RootArtifactIdentifier,
                    GenerationName = cleanArtifactAnalysi.GenerationName,
                    ArtifactIdentifier = cleanArtifactAnalysi.ArtifactIdentifier,
                    GenerationTransformerNumber = cleanArtifactAnalysi.GenerationTransformerNumber,
                    TrialArtifactLongName = cleanArtifactAnalysi.TrialArtifactLongName,
                    TrialArtifactGeneratioNumber = cleanArtifactAnalysi.TrialArtifactGeneratioNumber,
                    TransformerGeneratioNumber = cleanArtifactAnalysi.TransformerGeneratioNumber,
                    TransformerGenerationName = cleanArtifactAnalysi.TransformerGenerationName,
                    ResponseBeingValidated = cleanArtifactAnalysi.ResponseBeingValidated,
                    TrialArtifactActualPrompt = cleanArtifactAnalysi.TrialArtifactActualPrompt,
                    TrialArtifactResponse = cleanArtifactAnalysi.TrialArtifactResponse,
                    TrialArtifactActualValidationPrompt = cleanArtifactAnalysi.TrialArtifactActualValidationPrompt,
                    TrialArtifactValidationResponse = cleanArtifactAnalysi.TrialArtifactValidationResponse,
                    CleanValidationJson = cleanArtifactAnalysi.CleanValidationJson,
                    ToDoItems = cleanArtifactAnalysi.ToDoItems,
                    ToDoItemsAKA = cleanArtifactAnalysi.ToDoItemsAKA,
                    ToDoItemsMismatched = cleanArtifactAnalysi.ToDoItemsMismatched,
                    Categories = cleanArtifactAnalysi.Categories,
                    CategoriesAKA = cleanArtifactAnalysi.CategoriesAKA,
                    CategoriesMismatched = cleanArtifactAnalysi.CategoriesMismatched,
                    DueDates = cleanArtifactAnalysi.DueDates,
                    DueDatesAKA = cleanArtifactAnalysi.DueDatesAKA,
                    DueDatesMismatched = cleanArtifactAnalysi.DueDatesMismatched,
                    Priorities = cleanArtifactAnalysi.Priorities,
                    PrioritiesAKA = cleanArtifactAnalysi.PrioritiesAKA,
                    PrioritiesMismatched = cleanArtifactAnalysi.PrioritiesMismatched,
                    Progress = cleanArtifactAnalysi.Progress,
                    ProgressAKA = cleanArtifactAnalysi.ProgressAKA,
                    ProgressMismatched = cleanArtifactAnalysi.ProgressMismatched,
                    Statuses = cleanArtifactAnalysi.Statuses,
                    StatusesAKA = cleanArtifactAnalysi.StatusesAKA,
                    StatusesMismatched = cleanArtifactAnalysi.StatusesMismatched,
                    Reminders = cleanArtifactAnalysi.Reminders,
                    RemindersAKA = cleanArtifactAnalysi.RemindersAKA,
                    RemindersMismatched = cleanArtifactAnalysi.RemindersMismatched,
                    Notifications = cleanArtifactAnalysi.Notifications,
                    NotificationsAKA = cleanArtifactAnalysi.NotificationsAKA,
                    NotificationsMismatched = cleanArtifactAnalysi.NotificationsMismatched,
                    Completion = cleanArtifactAnalysi.Completion,
                    CompletionAKA = cleanArtifactAnalysi.CompletionAKA,
                    CompletionMismatched = cleanArtifactAnalysi.CompletionMismatched,
                    ToDoEmployees = cleanArtifactAnalysi.ToDoEmployees,
                    ToDoEmployeesAKA = cleanArtifactAnalysi.ToDoEmployeesAKA,
                    ToDoEmployeesMismatched = cleanArtifactAnalysi.ToDoEmployeesMismatched,
                    Duration = cleanArtifactAnalysi.Duration,
                    DurationAKA = cleanArtifactAnalysi.DurationAKA,
                    DurationMismatched = cleanArtifactAnalysi.DurationMismatched,
                    CompletedDate = cleanArtifactAnalysi.CompletedDate,
                    CompletedDateAKA = cleanArtifactAnalysi.CompletedDateAKA,
                    CompletedDateMismatched = cleanArtifactAnalysi.CompletedDateMismatched,
                    ToDoColors = cleanArtifactAnalysi.ToDoColors,
                    ToDoColorsAKA = cleanArtifactAnalysi.ToDoColorsAKA,
                    ToDoColorsMismatched = cleanArtifactAnalysi.ToDoColorsMismatched,
                    PrevGenToDoItems = cleanArtifactAnalysi.PrevGenToDoItems,
                    PrevGenToDoItemsAKA = cleanArtifactAnalysi.PrevGenToDoItemsAKA,
                    PrevGenToDoItemsMismatched = cleanArtifactAnalysi.PrevGenToDoItemsMismatched,
                    PrevGenCategories = cleanArtifactAnalysi.PrevGenCategories,
                    PrevGenCategoriesAKA = cleanArtifactAnalysi.PrevGenCategoriesAKA,
                    PrevGenCategoriesMismatched = cleanArtifactAnalysi.PrevGenCategoriesMismatched,
                    PrevGenDueDates = cleanArtifactAnalysi.PrevGenDueDates,
                    PrevGenDueDatesAKA = cleanArtifactAnalysi.PrevGenDueDatesAKA,
                    PrevGenDueDatesMismatched = cleanArtifactAnalysi.PrevGenDueDatesMismatched,
                    PrevGenPriorities = cleanArtifactAnalysi.PrevGenPriorities,
                    PrevGenPrioritiesAKA = cleanArtifactAnalysi.PrevGenPrioritiesAKA,
                    PrevGenPrioritiesMismatched = cleanArtifactAnalysi.PrevGenPrioritiesMismatched,
                    PrevGenProgress = cleanArtifactAnalysi.PrevGenProgress,
                    PrevGenProgressAKA = cleanArtifactAnalysi.PrevGenProgressAKA,
                    PrevGenProgressMismatched = cleanArtifactAnalysi.PrevGenProgressMismatched,
                    PrevGenStatuses = cleanArtifactAnalysi.PrevGenStatuses,
                    PrevGenStatusesAKA = cleanArtifactAnalysi.PrevGenStatusesAKA,
                    PrevGenStatusesMismatched = cleanArtifactAnalysi.PrevGenStatusesMismatched,
                    PrevGenReminders = cleanArtifactAnalysi.PrevGenReminders,
                    PrevGenRemindersAKA = cleanArtifactAnalysi.PrevGenRemindersAKA,
                    PrevGenRemindersMismatched = cleanArtifactAnalysi.PrevGenRemindersMismatched,
                    PrevGenNotifications = cleanArtifactAnalysi.PrevGenNotifications,
                    PrevGenNotificationsAKA = cleanArtifactAnalysi.PrevGenNotificationsAKA,
                    PrevGenNotificationsMismatched = cleanArtifactAnalysi.PrevGenNotificationsMismatched,
                    PrevGenCompletion = cleanArtifactAnalysi.PrevGenCompletion,
                    PrevGenCompletionAKA = cleanArtifactAnalysi.PrevGenCompletionAKA,
                    PrevGenCompletionMismatched = cleanArtifactAnalysi.PrevGenCompletionMismatched,
                    PrevGenToDoEmployees = cleanArtifactAnalysi.PrevGenToDoEmployees,
                    PrevGenToDoEmployeesAKA = cleanArtifactAnalysi.PrevGenToDoEmployeesAKA,
                    PrevGenToDoEmployeesMismatched = cleanArtifactAnalysi.PrevGenToDoEmployeesMismatched,
                    PrevGenDuration = cleanArtifactAnalysi.PrevGenDuration,
                    PrevGenDurationAKA = cleanArtifactAnalysi.PrevGenDurationAKA,
                    PrevGenDurationMismatched = cleanArtifactAnalysi.PrevGenDurationMismatched,
                    PrevGenCompletedDate = cleanArtifactAnalysi.PrevGenCompletedDate,
                    PrevGenCompletedDateAKA = cleanArtifactAnalysi.PrevGenCompletedDateAKA,
                    PrevGenCompletedDateMismatched = cleanArtifactAnalysi.PrevGenCompletedDateMismatched,
                    PrevGenToDoColors = cleanArtifactAnalysi.PrevGenToDoColors,
                    PrevGenToDoColorsAKA = cleanArtifactAnalysi.PrevGenToDoColorsAKA,
                    PrevGenToDoColorsMismatched = cleanArtifactAnalysi.PrevGenToDoColorsMismatched
                };
            }

            return UserArtifactAnalysi;
        }
        
        
        public static dc.ArtifactAnalysi UserCleanForUpdate(this dc.ArtifactAnalysi cleanArtifactAnalysi)
        {
            var UserArtifactAnalysi = default(dc.ArtifactAnalysi);

            if (!ReferenceEquals(cleanArtifactAnalysi, null))
            {
                UserArtifactAnalysi = new dc.ArtifactAnalysi()
                {
                    ArtifactAnalysiId = cleanArtifactAnalysi.ArtifactAnalysiId,
                    PreviousGeneration = cleanArtifactAnalysi.PreviousGeneration,
                    TrialArtifact = cleanArtifactAnalysi.TrialArtifact,
                    CleanValidationJson = cleanArtifactAnalysi.CleanValidationJson,
                    ToDoItems = cleanArtifactAnalysi.ToDoItems,
                    ToDoItemsAKA = cleanArtifactAnalysi.ToDoItemsAKA,
                    ToDoItemsMismatched = cleanArtifactAnalysi.ToDoItemsMismatched,
                    Categories = cleanArtifactAnalysi.Categories,
                    CategoriesAKA = cleanArtifactAnalysi.CategoriesAKA,
                    CategoriesMismatched = cleanArtifactAnalysi.CategoriesMismatched,
                    DueDates = cleanArtifactAnalysi.DueDates,
                    DueDatesAKA = cleanArtifactAnalysi.DueDatesAKA,
                    DueDatesMismatched = cleanArtifactAnalysi.DueDatesMismatched,
                    Priorities = cleanArtifactAnalysi.Priorities,
                    PrioritiesAKA = cleanArtifactAnalysi.PrioritiesAKA,
                    PrioritiesMismatched = cleanArtifactAnalysi.PrioritiesMismatched,
                    Progress = cleanArtifactAnalysi.Progress,
                    ProgressAKA = cleanArtifactAnalysi.ProgressAKA,
                    ProgressMismatched = cleanArtifactAnalysi.ProgressMismatched,
                    Statuses = cleanArtifactAnalysi.Statuses,
                    StatusesAKA = cleanArtifactAnalysi.StatusesAKA,
                    StatusesMismatched = cleanArtifactAnalysi.StatusesMismatched,
                    Reminders = cleanArtifactAnalysi.Reminders,
                    RemindersAKA = cleanArtifactAnalysi.RemindersAKA,
                    RemindersMismatched = cleanArtifactAnalysi.RemindersMismatched,
                    Notifications = cleanArtifactAnalysi.Notifications,
                    NotificationsAKA = cleanArtifactAnalysi.NotificationsAKA,
                    NotificationsMismatched = cleanArtifactAnalysi.NotificationsMismatched,
                    Completion = cleanArtifactAnalysi.Completion,
                    CompletionAKA = cleanArtifactAnalysi.CompletionAKA,
                    CompletionMismatched = cleanArtifactAnalysi.CompletionMismatched,
                    ToDoEmployees = cleanArtifactAnalysi.ToDoEmployees,
                    ToDoEmployeesAKA = cleanArtifactAnalysi.ToDoEmployeesAKA,
                    ToDoEmployeesMismatched = cleanArtifactAnalysi.ToDoEmployeesMismatched,
                    Duration = cleanArtifactAnalysi.Duration,
                    DurationAKA = cleanArtifactAnalysi.DurationAKA,
                    DurationMismatched = cleanArtifactAnalysi.DurationMismatched,
                    CompletedDate = cleanArtifactAnalysi.CompletedDate,
                    CompletedDateAKA = cleanArtifactAnalysi.CompletedDateAKA,
                    CompletedDateMismatched = cleanArtifactAnalysi.CompletedDateMismatched,
                    ToDoColors = cleanArtifactAnalysi.ToDoColors,
                    ToDoColorsAKA = cleanArtifactAnalysi.ToDoColorsAKA,
                    ToDoColorsMismatched = cleanArtifactAnalysi.ToDoColorsMismatched
                };
            }

            return UserArtifactAnalysi;
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
                    AutoNumber = cleanExperimentTransformer.AutoNumber,
                     // default value: . 
                    IsSyntaxFree = cleanExperimentTransformer.IsSyntaxFree,
                     // default value: . 
                    GenerationTransformer = cleanExperimentTransformer.GenerationTransformer
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
                    AutoNumber = cleanExperimentTransformer.AutoNumber,
                    TransformerIdentifier = cleanExperimentTransformer.TransformerIdentifier,
                    IsSyntaxFree = cleanExperimentTransformer.IsSyntaxFree,
                    GenerationTransformer = cleanExperimentTransformer.GenerationTransformer
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
                    AutoNumber = cleanExperimentTransformer.AutoNumber,
                    IsSyntaxFree = cleanExperimentTransformer.IsSyntaxFree,
                    GenerationTransformer = cleanExperimentTransformer.GenerationTransformer
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
                    Experiment = cleanExperimentFeature.Experiment,
                     // default value: . 
                    Variations = cleanExperimentFeature.Variations,
                     // default value: . 
                    PartialMatches = cleanExperimentFeature.PartialMatches
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
                    IsActiveExp = cleanExperimentFeature.IsActiveExp,
                    Variations = cleanExperimentFeature.Variations,
                    PartialMatches = cleanExperimentFeature.PartialMatches
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
                    Experiment = cleanExperimentFeature.Experiment,
                    Variations = cleanExperimentFeature.Variations,
                    PartialMatches = cleanExperimentFeature.PartialMatches
                };
            }

            return UserExperimentFeature;
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
                    AutoNumber = cleanExperiment.AutoNumber,
                     // default value: . 
                    Trials = cleanExperiment.Trials,
                     // default value: . 
                    PromptChainsToCreate = cleanExperiment.PromptChainsToCreate
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
                    AutoNumber = cleanExperiment.AutoNumber,
                    SyntaxLockedTransformerNumbers = cleanExperiment.SyntaxLockedTransformerNumbers,
                    SyntaxFreeTransformerNumbers = cleanExperiment.SyntaxFreeTransformerNumbers,
                    Trials = cleanExperiment.Trials,
                    RunTrialScript = cleanExperiment.RunTrialScript,
                    GenerationAddDataCommandScripts = cleanExperiment.GenerationAddDataCommandScripts,
                    PromptChainsToCreate = cleanExperiment.PromptChainsToCreate
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
                    AutoNumber = cleanExperiment.AutoNumber,
                    Trials = cleanExperiment.Trials,
                    PromptChainsToCreate = cleanExperiment.PromptChainsToCreate
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
        
        // TrialArtifact
        public static dc.TrialArtifact AdminCleanForAdd(this dc.TrialArtifact cleanTrialArtifact)
        {
            var AdminTrialArtifact = default(dc.TrialArtifact);

            if (!ReferenceEquals(cleanTrialArtifact, null))
            {
                AdminTrialArtifact = new dc.TrialArtifact()
                {
                     // default value: . 
                    TrialArtifactId = cleanTrialArtifact.TrialArtifactId,
                     // default value: . 
                    ActualPrompt = cleanTrialArtifact.ActualPrompt,
                     // default value: . 
                    ActualValidationPrompt = cleanTrialArtifact.ActualValidationPrompt,
                     // default value: . 
                    ValidationResponse = cleanTrialArtifact.ValidationResponse,
                     // default value: . 
                    ExtensionOf = cleanTrialArtifact.ExtensionOf,
                     // default value: . 
                    AutoNumber = cleanTrialArtifact.AutoNumber,
                     // default value: . 
                    IsRetiredArtifact = cleanTrialArtifact.IsRetiredArtifact,
                     // default value: . 
                    CustomRootIdentifier = cleanTrialArtifact.CustomRootIdentifier,
                     // default value: . 
                    Trial = cleanTrialArtifact.Trial,
                     // default value: . 
                    GenerationTransformer = cleanTrialArtifact.GenerationTransformer,
                     // default value: . 
                    Response = cleanTrialArtifact.Response,
                     // default value: . 
                    PrimaryExtensionArtifact = cleanTrialArtifact.PrimaryExtensionArtifact,
                     // default value: . 
                    ArtifactAnalysis = cleanTrialArtifact.ArtifactAnalysis
                };
                
            }

            return AdminTrialArtifact;
        }
        
        
        public static List<dc.TrialArtifact> AdminCleanForGet(this IEnumerable<dc.TrialArtifact> cleanTrialArtifacts)
        {
            return cleanTrialArtifacts.Select(TrialArtifact => TrialArtifact.AdminCleanForGet())
                            .ToList();
        }
        
        public static dc.TrialArtifact AdminCleanForGet(this dc.TrialArtifact cleanTrialArtifact)
        {
            var AdminTrialArtifact = default(dc.TrialArtifact);

            if (!ReferenceEquals(cleanTrialArtifact, null))
            {
                AdminTrialArtifact = new dc.TrialArtifact()
                {
                    TrialArtifactId = cleanTrialArtifact.TrialArtifactId,
                    Name = cleanTrialArtifact.Name,
                    ActualPrompt = cleanTrialArtifact.ActualPrompt,
                    ActualValidationPrompt = cleanTrialArtifact.ActualValidationPrompt,
                    ValidationResponse = cleanTrialArtifact.ValidationResponse,
                    ExtensionOf = cleanTrialArtifact.ExtensionOf,
                    Created = cleanTrialArtifact.Created,
                    AutoNumber = cleanTrialArtifact.AutoNumber,
                    IsRetiredArtifact = cleanTrialArtifact.IsRetiredArtifact,
                    Modified = cleanTrialArtifact.Modified,
                    LongName = cleanTrialArtifact.LongName,
                    ArtifactIdentifier = cleanTrialArtifact.ArtifactIdentifier,
                    ExtensionOfArtifactIdentifier = cleanTrialArtifact.ExtensionOfArtifactIdentifier,
                    CustomRootIdentifier = cleanTrialArtifact.CustomRootIdentifier,
                    Trial = cleanTrialArtifact.Trial,
                    GenerationTransformer = cleanTrialArtifact.GenerationTransformer,
                    ExpTransformerIsSyntaxFree = cleanTrialArtifact.ExpTransformerIsSyntaxFree,
                    GenerationName = cleanTrialArtifact.GenerationName,
                    GeneratioNumber = cleanTrialArtifact.GeneratioNumber,
                    GenerationTransformerNumber = cleanTrialArtifact.GenerationTransformerNumber,
                    TransformerRawPrompt = cleanTrialArtifact.TransformerRawPrompt,
                    IsActiveExp = cleanTrialArtifact.IsActiveExp,
                    TransformerNumber = cleanTrialArtifact.TransformerNumber,
                    TransformerGeneratioNumber = cleanTrialArtifact.TransformerGeneratioNumber,
                    TransformerGenerationExpName = cleanTrialArtifact.TransformerGenerationExpName,
                    TransformerGenerationName = cleanTrialArtifact.TransformerGenerationName,
                    ExpValidationPrompt = cleanTrialArtifact.ExpValidationPrompt,
                    ExpAbstract = cleanTrialArtifact.ExpAbstract,
                    Response = cleanTrialArtifact.Response,
                    PrimaryExtensionArtifact = cleanTrialArtifact.PrimaryExtensionArtifact,
                    ResponseOfArtifactBeingExtended = cleanTrialArtifact.ResponseOfArtifactBeingExtended,
                    SuggestedPrompt = cleanTrialArtifact.SuggestedPrompt,
                    ResponseBeingValidated = cleanTrialArtifact.ResponseBeingValidated,
                    SuggestedValidationPrompt = cleanTrialArtifact.SuggestedValidationPrompt,
                    RootArtifactIdentifier = cleanTrialArtifact.RootArtifactIdentifier,
                    SuggestedRootIdentifier = cleanTrialArtifact.SuggestedRootIdentifier,
                    RootIdentifierMismatch = cleanTrialArtifact.RootIdentifierMismatch,
                    ArtifactAnalysis = cleanTrialArtifact.ArtifactAnalysis
                };
            }

            return AdminTrialArtifact;
        }
        
        
        public static dc.TrialArtifact AdminCleanForUpdate(this dc.TrialArtifact cleanTrialArtifact)
        {
            var AdminTrialArtifact = default(dc.TrialArtifact);

            if (!ReferenceEquals(cleanTrialArtifact, null))
            {
                AdminTrialArtifact = new dc.TrialArtifact()
                {
                    TrialArtifactId = cleanTrialArtifact.TrialArtifactId,
                    ActualPrompt = cleanTrialArtifact.ActualPrompt,
                    ActualValidationPrompt = cleanTrialArtifact.ActualValidationPrompt,
                    ValidationResponse = cleanTrialArtifact.ValidationResponse,
                    ExtensionOf = cleanTrialArtifact.ExtensionOf,
                    AutoNumber = cleanTrialArtifact.AutoNumber,
                    IsRetiredArtifact = cleanTrialArtifact.IsRetiredArtifact,
                    CustomRootIdentifier = cleanTrialArtifact.CustomRootIdentifier,
                    Trial = cleanTrialArtifact.Trial,
                    GenerationTransformer = cleanTrialArtifact.GenerationTransformer,
                    Response = cleanTrialArtifact.Response,
                    PrimaryExtensionArtifact = cleanTrialArtifact.PrimaryExtensionArtifact,
                    ArtifactAnalysis = cleanTrialArtifact.ArtifactAnalysis
                };
            }

            return AdminTrialArtifact;
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
                    AutoNumber = cleanGenerationTransformer.AutoNumber,
                     // default value: . 
                    IsArtifactValidator = cleanGenerationTransformer.IsArtifactValidator,
                     // default value: . 
                    ParentTransformer = cleanGenerationTransformer.ParentTransformer,
                     // default value: . 
                    ExpTransformer = cleanGenerationTransformer.ExpTransformer,
                     // default value: . 
                    TrialArtifacts = cleanGenerationTransformer.TrialArtifacts
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
                    AutoNumber = cleanGenerationTransformer.AutoNumber,
                    TransformerNumber = cleanGenerationTransformer.TransformerNumber,
                    IsArtifactValidator = cleanGenerationTransformer.IsArtifactValidator,
                    ExpAbstract = cleanGenerationTransformer.ExpAbstract,
                    GenerationExp = cleanGenerationTransformer.GenerationExp,
                    GenerationExpName = cleanGenerationTransformer.GenerationExpName,
                    IsActiveExp = cleanGenerationTransformer.IsActiveExp,
                    ExpValidationPrompt = cleanGenerationTransformer.ExpValidationPrompt,
                    GenerationNumber = cleanGenerationTransformer.GenerationNumber,
                    ParentTransformer = cleanGenerationTransformer.ParentTransformer,
                    ParentTransformerNumber = cleanGenerationTransformer.ParentTransformerNumber,
                    AddDataCommand = cleanGenerationTransformer.AddDataCommand,
                    ExpTransformer = cleanGenerationTransformer.ExpTransformer,
                    TrialArtifacts = cleanGenerationTransformer.TrialArtifacts,
                    ExpTransformerIsSyntaxFree = cleanGenerationTransformer.ExpTransformerIsSyntaxFree
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
                    AutoNumber = cleanGenerationTransformer.AutoNumber,
                    IsArtifactValidator = cleanGenerationTransformer.IsArtifactValidator,
                    ParentTransformer = cleanGenerationTransformer.ParentTransformer,
                    ExpTransformer = cleanGenerationTransformer.ExpTransformer,
                    TrialArtifacts = cleanGenerationTransformer.TrialArtifacts
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
                    SyntaxLockedTransformerNumbers = cleanGeneration.SyntaxLockedTransformerNumbers,
                    GenerationTransformerAddDataCommands = cleanGeneration.GenerationTransformerAddDataCommands,
                    AddDataCommandScript = cleanGeneration.AddDataCommandScript
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
        
        // Trial
        public static dc.Trial AdminCleanForAdd(this dc.Trial cleanTrial)
        {
            var AdminTrial = default(dc.Trial);

            if (!ReferenceEquals(cleanTrial, null))
            {
                AdminTrial = new dc.Trial()
                {
                     // default value: . 
                    TrialId = cleanTrial.TrialId,
                     // default value: . 
                    Experiement = cleanTrial.Experiement,
                     // default value: . 
                    TrialArtifacts = cleanTrial.TrialArtifacts,
                     // default value: . 
                    AutoNumber = cleanTrial.AutoNumber,
                     // default value: . 
                    DesiredPromptChainCount = cleanTrial.DesiredPromptChainCount,
                     // default value: . 
                    TrialArtifactCount = cleanTrial.TrialArtifactCount
                };
                
            }

            return AdminTrial;
        }
        
        
        public static List<dc.Trial> AdminCleanForGet(this IEnumerable<dc.Trial> cleanTrials)
        {
            return cleanTrials.Select(Trial => Trial.AdminCleanForGet())
                            .ToList();
        }
        
        public static dc.Trial AdminCleanForGet(this dc.Trial cleanTrial)
        {
            var AdminTrial = default(dc.Trial);

            if (!ReferenceEquals(cleanTrial, null))
            {
                AdminTrial = new dc.Trial()
                {
                    TrialId = cleanTrial.TrialId,
                    Name = cleanTrial.Name,
                    Experiement = cleanTrial.Experiement,
                    TrialArtifacts = cleanTrial.TrialArtifacts,
                    AutoNumber = cleanTrial.AutoNumber,
                    TrailIdentifier = cleanTrial.TrailIdentifier,
                    Created = cleanTrial.Created,
                    DesiredPromptChainCount = cleanTrial.DesiredPromptChainCount,
                    TrialArtifactCount = cleanTrial.TrialArtifactCount,
                    GatherTrialDataScript = cleanTrial.GatherTrialDataScript,
                    ExperimentRunTrialScript = cleanTrial.ExperimentRunTrialScript
                };
            }

            return AdminTrial;
        }
        
        
        public static dc.Trial AdminCleanForUpdate(this dc.Trial cleanTrial)
        {
            var AdminTrial = default(dc.Trial);

            if (!ReferenceEquals(cleanTrial, null))
            {
                AdminTrial = new dc.Trial()
                {
                    TrialId = cleanTrial.TrialId,
                    Experiement = cleanTrial.Experiement,
                    TrialArtifacts = cleanTrial.TrialArtifacts,
                    AutoNumber = cleanTrial.AutoNumber,
                    DesiredPromptChainCount = cleanTrial.DesiredPromptChainCount,
                    TrialArtifactCount = cleanTrial.TrialArtifactCount
                };
            }

            return AdminTrial;
        }

        // Admin Cleaning Extension Methods.  -CRUD-
        
        // ArtifactAnalysi
        public static dc.ArtifactAnalysi AdminCleanForAdd(this dc.ArtifactAnalysi cleanArtifactAnalysi)
        {
            var AdminArtifactAnalysi = default(dc.ArtifactAnalysi);

            if (!ReferenceEquals(cleanArtifactAnalysi, null))
            {
                AdminArtifactAnalysi = new dc.ArtifactAnalysi()
                {
                     // default value: . 
                    ArtifactAnalysiId = cleanArtifactAnalysi.ArtifactAnalysiId,
                     // default value: . 
                    PreviousGeneration = cleanArtifactAnalysi.PreviousGeneration,
                     // default value: . 
                    TrialArtifact = cleanArtifactAnalysi.TrialArtifact,
                     // default value: . 
                    CleanValidationJson = cleanArtifactAnalysi.CleanValidationJson,
                     // default value: . 
                    ToDoItems = cleanArtifactAnalysi.ToDoItems,
                     // default value: . 
                    ToDoItemsAKA = cleanArtifactAnalysi.ToDoItemsAKA,
                     // default value: . 
                    ToDoItemsMismatched = cleanArtifactAnalysi.ToDoItemsMismatched,
                     // default value: . 
                    Categories = cleanArtifactAnalysi.Categories,
                     // default value: . 
                    CategoriesAKA = cleanArtifactAnalysi.CategoriesAKA,
                     // default value: . 
                    CategoriesMismatched = cleanArtifactAnalysi.CategoriesMismatched,
                     // default value: . 
                    DueDates = cleanArtifactAnalysi.DueDates,
                     // default value: . 
                    DueDatesAKA = cleanArtifactAnalysi.DueDatesAKA,
                     // default value: . 
                    DueDatesMismatched = cleanArtifactAnalysi.DueDatesMismatched,
                     // default value: . 
                    Priorities = cleanArtifactAnalysi.Priorities,
                     // default value: . 
                    PrioritiesAKA = cleanArtifactAnalysi.PrioritiesAKA,
                     // default value: . 
                    PrioritiesMismatched = cleanArtifactAnalysi.PrioritiesMismatched,
                     // default value: . 
                    Progress = cleanArtifactAnalysi.Progress,
                     // default value: . 
                    ProgressAKA = cleanArtifactAnalysi.ProgressAKA,
                     // default value: . 
                    ProgressMismatched = cleanArtifactAnalysi.ProgressMismatched,
                     // default value: . 
                    Statuses = cleanArtifactAnalysi.Statuses,
                     // default value: . 
                    StatusesAKA = cleanArtifactAnalysi.StatusesAKA,
                     // default value: . 
                    StatusesMismatched = cleanArtifactAnalysi.StatusesMismatched,
                     // default value: . 
                    Reminders = cleanArtifactAnalysi.Reminders,
                     // default value: . 
                    RemindersAKA = cleanArtifactAnalysi.RemindersAKA,
                     // default value: . 
                    RemindersMismatched = cleanArtifactAnalysi.RemindersMismatched,
                     // default value: . 
                    Notifications = cleanArtifactAnalysi.Notifications,
                     // default value: . 
                    NotificationsAKA = cleanArtifactAnalysi.NotificationsAKA,
                     // default value: . 
                    NotificationsMismatched = cleanArtifactAnalysi.NotificationsMismatched,
                     // default value: . 
                    Completion = cleanArtifactAnalysi.Completion,
                     // default value: . 
                    CompletionAKA = cleanArtifactAnalysi.CompletionAKA,
                     // default value: . 
                    CompletionMismatched = cleanArtifactAnalysi.CompletionMismatched,
                     // default value: . 
                    ToDoEmployees = cleanArtifactAnalysi.ToDoEmployees,
                     // default value: . 
                    ToDoEmployeesAKA = cleanArtifactAnalysi.ToDoEmployeesAKA,
                     // default value: . 
                    ToDoEmployeesMismatched = cleanArtifactAnalysi.ToDoEmployeesMismatched,
                     // default value: . 
                    Duration = cleanArtifactAnalysi.Duration,
                     // default value: . 
                    DurationAKA = cleanArtifactAnalysi.DurationAKA,
                     // default value: . 
                    DurationMismatched = cleanArtifactAnalysi.DurationMismatched,
                     // default value: . 
                    CompletedDate = cleanArtifactAnalysi.CompletedDate,
                     // default value: . 
                    CompletedDateAKA = cleanArtifactAnalysi.CompletedDateAKA,
                     // default value: . 
                    CompletedDateMismatched = cleanArtifactAnalysi.CompletedDateMismatched,
                     // default value: . 
                    ToDoColors = cleanArtifactAnalysi.ToDoColors,
                     // default value: . 
                    ToDoColorsAKA = cleanArtifactAnalysi.ToDoColorsAKA,
                     // default value: . 
                    ToDoColorsMismatched = cleanArtifactAnalysi.ToDoColorsMismatched
                };
                
            }

            return AdminArtifactAnalysi;
        }
        
        
        public static List<dc.ArtifactAnalysi> AdminCleanForGet(this IEnumerable<dc.ArtifactAnalysi> cleanArtifactAnalysis)
        {
            return cleanArtifactAnalysis.Select(ArtifactAnalysi => ArtifactAnalysi.AdminCleanForGet())
                            .ToList();
        }
        
        public static dc.ArtifactAnalysi AdminCleanForGet(this dc.ArtifactAnalysi cleanArtifactAnalysi)
        {
            var AdminArtifactAnalysi = default(dc.ArtifactAnalysi);

            if (!ReferenceEquals(cleanArtifactAnalysi, null))
            {
                AdminArtifactAnalysi = new dc.ArtifactAnalysi()
                {
                    ArtifactAnalysiId = cleanArtifactAnalysi.ArtifactAnalysiId,
                    Name = cleanArtifactAnalysi.Name,
                    PreviousGeneration = cleanArtifactAnalysi.PreviousGeneration,
                    PrevGenName = cleanArtifactAnalysi.PrevGenName,
                    PrevGenArtifactIdentifier = cleanArtifactAnalysi.PrevGenArtifactIdentifier,
                    PrevGenTransformerNumber = cleanArtifactAnalysi.PrevGenTransformerNumber,
                    TrialArtifact = cleanArtifactAnalysi.TrialArtifact,
                    TrialArtifactExtensionOf = cleanArtifactAnalysi.TrialArtifactExtensionOf,
                    ExpTransformerIsSyntaxFree = cleanArtifactAnalysi.ExpTransformerIsSyntaxFree,
                    RootArtifactIdentifier = cleanArtifactAnalysi.RootArtifactIdentifier,
                    GenerationName = cleanArtifactAnalysi.GenerationName,
                    ArtifactIdentifier = cleanArtifactAnalysi.ArtifactIdentifier,
                    GenerationTransformerNumber = cleanArtifactAnalysi.GenerationTransformerNumber,
                    TrialArtifactLongName = cleanArtifactAnalysi.TrialArtifactLongName,
                    TrialArtifactGeneratioNumber = cleanArtifactAnalysi.TrialArtifactGeneratioNumber,
                    TransformerGeneratioNumber = cleanArtifactAnalysi.TransformerGeneratioNumber,
                    TransformerGenerationName = cleanArtifactAnalysi.TransformerGenerationName,
                    ResponseBeingValidated = cleanArtifactAnalysi.ResponseBeingValidated,
                    TrialArtifactActualPrompt = cleanArtifactAnalysi.TrialArtifactActualPrompt,
                    TrialArtifactResponse = cleanArtifactAnalysi.TrialArtifactResponse,
                    TrialArtifactActualValidationPrompt = cleanArtifactAnalysi.TrialArtifactActualValidationPrompt,
                    TrialArtifactValidationResponse = cleanArtifactAnalysi.TrialArtifactValidationResponse,
                    CleanValidationJson = cleanArtifactAnalysi.CleanValidationJson,
                    ToDoItems = cleanArtifactAnalysi.ToDoItems,
                    ToDoItemsAKA = cleanArtifactAnalysi.ToDoItemsAKA,
                    ToDoItemsMismatched = cleanArtifactAnalysi.ToDoItemsMismatched,
                    Categories = cleanArtifactAnalysi.Categories,
                    CategoriesAKA = cleanArtifactAnalysi.CategoriesAKA,
                    CategoriesMismatched = cleanArtifactAnalysi.CategoriesMismatched,
                    DueDates = cleanArtifactAnalysi.DueDates,
                    DueDatesAKA = cleanArtifactAnalysi.DueDatesAKA,
                    DueDatesMismatched = cleanArtifactAnalysi.DueDatesMismatched,
                    Priorities = cleanArtifactAnalysi.Priorities,
                    PrioritiesAKA = cleanArtifactAnalysi.PrioritiesAKA,
                    PrioritiesMismatched = cleanArtifactAnalysi.PrioritiesMismatched,
                    Progress = cleanArtifactAnalysi.Progress,
                    ProgressAKA = cleanArtifactAnalysi.ProgressAKA,
                    ProgressMismatched = cleanArtifactAnalysi.ProgressMismatched,
                    Statuses = cleanArtifactAnalysi.Statuses,
                    StatusesAKA = cleanArtifactAnalysi.StatusesAKA,
                    StatusesMismatched = cleanArtifactAnalysi.StatusesMismatched,
                    Reminders = cleanArtifactAnalysi.Reminders,
                    RemindersAKA = cleanArtifactAnalysi.RemindersAKA,
                    RemindersMismatched = cleanArtifactAnalysi.RemindersMismatched,
                    Notifications = cleanArtifactAnalysi.Notifications,
                    NotificationsAKA = cleanArtifactAnalysi.NotificationsAKA,
                    NotificationsMismatched = cleanArtifactAnalysi.NotificationsMismatched,
                    Completion = cleanArtifactAnalysi.Completion,
                    CompletionAKA = cleanArtifactAnalysi.CompletionAKA,
                    CompletionMismatched = cleanArtifactAnalysi.CompletionMismatched,
                    ToDoEmployees = cleanArtifactAnalysi.ToDoEmployees,
                    ToDoEmployeesAKA = cleanArtifactAnalysi.ToDoEmployeesAKA,
                    ToDoEmployeesMismatched = cleanArtifactAnalysi.ToDoEmployeesMismatched,
                    Duration = cleanArtifactAnalysi.Duration,
                    DurationAKA = cleanArtifactAnalysi.DurationAKA,
                    DurationMismatched = cleanArtifactAnalysi.DurationMismatched,
                    CompletedDate = cleanArtifactAnalysi.CompletedDate,
                    CompletedDateAKA = cleanArtifactAnalysi.CompletedDateAKA,
                    CompletedDateMismatched = cleanArtifactAnalysi.CompletedDateMismatched,
                    ToDoColors = cleanArtifactAnalysi.ToDoColors,
                    ToDoColorsAKA = cleanArtifactAnalysi.ToDoColorsAKA,
                    ToDoColorsMismatched = cleanArtifactAnalysi.ToDoColorsMismatched,
                    PrevGenToDoItems = cleanArtifactAnalysi.PrevGenToDoItems,
                    PrevGenToDoItemsAKA = cleanArtifactAnalysi.PrevGenToDoItemsAKA,
                    PrevGenToDoItemsMismatched = cleanArtifactAnalysi.PrevGenToDoItemsMismatched,
                    PrevGenCategories = cleanArtifactAnalysi.PrevGenCategories,
                    PrevGenCategoriesAKA = cleanArtifactAnalysi.PrevGenCategoriesAKA,
                    PrevGenCategoriesMismatched = cleanArtifactAnalysi.PrevGenCategoriesMismatched,
                    PrevGenDueDates = cleanArtifactAnalysi.PrevGenDueDates,
                    PrevGenDueDatesAKA = cleanArtifactAnalysi.PrevGenDueDatesAKA,
                    PrevGenDueDatesMismatched = cleanArtifactAnalysi.PrevGenDueDatesMismatched,
                    PrevGenPriorities = cleanArtifactAnalysi.PrevGenPriorities,
                    PrevGenPrioritiesAKA = cleanArtifactAnalysi.PrevGenPrioritiesAKA,
                    PrevGenPrioritiesMismatched = cleanArtifactAnalysi.PrevGenPrioritiesMismatched,
                    PrevGenProgress = cleanArtifactAnalysi.PrevGenProgress,
                    PrevGenProgressAKA = cleanArtifactAnalysi.PrevGenProgressAKA,
                    PrevGenProgressMismatched = cleanArtifactAnalysi.PrevGenProgressMismatched,
                    PrevGenStatuses = cleanArtifactAnalysi.PrevGenStatuses,
                    PrevGenStatusesAKA = cleanArtifactAnalysi.PrevGenStatusesAKA,
                    PrevGenStatusesMismatched = cleanArtifactAnalysi.PrevGenStatusesMismatched,
                    PrevGenReminders = cleanArtifactAnalysi.PrevGenReminders,
                    PrevGenRemindersAKA = cleanArtifactAnalysi.PrevGenRemindersAKA,
                    PrevGenRemindersMismatched = cleanArtifactAnalysi.PrevGenRemindersMismatched,
                    PrevGenNotifications = cleanArtifactAnalysi.PrevGenNotifications,
                    PrevGenNotificationsAKA = cleanArtifactAnalysi.PrevGenNotificationsAKA,
                    PrevGenNotificationsMismatched = cleanArtifactAnalysi.PrevGenNotificationsMismatched,
                    PrevGenCompletion = cleanArtifactAnalysi.PrevGenCompletion,
                    PrevGenCompletionAKA = cleanArtifactAnalysi.PrevGenCompletionAKA,
                    PrevGenCompletionMismatched = cleanArtifactAnalysi.PrevGenCompletionMismatched,
                    PrevGenToDoEmployees = cleanArtifactAnalysi.PrevGenToDoEmployees,
                    PrevGenToDoEmployeesAKA = cleanArtifactAnalysi.PrevGenToDoEmployeesAKA,
                    PrevGenToDoEmployeesMismatched = cleanArtifactAnalysi.PrevGenToDoEmployeesMismatched,
                    PrevGenDuration = cleanArtifactAnalysi.PrevGenDuration,
                    PrevGenDurationAKA = cleanArtifactAnalysi.PrevGenDurationAKA,
                    PrevGenDurationMismatched = cleanArtifactAnalysi.PrevGenDurationMismatched,
                    PrevGenCompletedDate = cleanArtifactAnalysi.PrevGenCompletedDate,
                    PrevGenCompletedDateAKA = cleanArtifactAnalysi.PrevGenCompletedDateAKA,
                    PrevGenCompletedDateMismatched = cleanArtifactAnalysi.PrevGenCompletedDateMismatched,
                    PrevGenToDoColors = cleanArtifactAnalysi.PrevGenToDoColors,
                    PrevGenToDoColorsAKA = cleanArtifactAnalysi.PrevGenToDoColorsAKA,
                    PrevGenToDoColorsMismatched = cleanArtifactAnalysi.PrevGenToDoColorsMismatched
                };
            }

            return AdminArtifactAnalysi;
        }
        
        
        public static dc.ArtifactAnalysi AdminCleanForUpdate(this dc.ArtifactAnalysi cleanArtifactAnalysi)
        {
            var AdminArtifactAnalysi = default(dc.ArtifactAnalysi);

            if (!ReferenceEquals(cleanArtifactAnalysi, null))
            {
                AdminArtifactAnalysi = new dc.ArtifactAnalysi()
                {
                    ArtifactAnalysiId = cleanArtifactAnalysi.ArtifactAnalysiId,
                    PreviousGeneration = cleanArtifactAnalysi.PreviousGeneration,
                    TrialArtifact = cleanArtifactAnalysi.TrialArtifact,
                    CleanValidationJson = cleanArtifactAnalysi.CleanValidationJson,
                    ToDoItems = cleanArtifactAnalysi.ToDoItems,
                    ToDoItemsAKA = cleanArtifactAnalysi.ToDoItemsAKA,
                    ToDoItemsMismatched = cleanArtifactAnalysi.ToDoItemsMismatched,
                    Categories = cleanArtifactAnalysi.Categories,
                    CategoriesAKA = cleanArtifactAnalysi.CategoriesAKA,
                    CategoriesMismatched = cleanArtifactAnalysi.CategoriesMismatched,
                    DueDates = cleanArtifactAnalysi.DueDates,
                    DueDatesAKA = cleanArtifactAnalysi.DueDatesAKA,
                    DueDatesMismatched = cleanArtifactAnalysi.DueDatesMismatched,
                    Priorities = cleanArtifactAnalysi.Priorities,
                    PrioritiesAKA = cleanArtifactAnalysi.PrioritiesAKA,
                    PrioritiesMismatched = cleanArtifactAnalysi.PrioritiesMismatched,
                    Progress = cleanArtifactAnalysi.Progress,
                    ProgressAKA = cleanArtifactAnalysi.ProgressAKA,
                    ProgressMismatched = cleanArtifactAnalysi.ProgressMismatched,
                    Statuses = cleanArtifactAnalysi.Statuses,
                    StatusesAKA = cleanArtifactAnalysi.StatusesAKA,
                    StatusesMismatched = cleanArtifactAnalysi.StatusesMismatched,
                    Reminders = cleanArtifactAnalysi.Reminders,
                    RemindersAKA = cleanArtifactAnalysi.RemindersAKA,
                    RemindersMismatched = cleanArtifactAnalysi.RemindersMismatched,
                    Notifications = cleanArtifactAnalysi.Notifications,
                    NotificationsAKA = cleanArtifactAnalysi.NotificationsAKA,
                    NotificationsMismatched = cleanArtifactAnalysi.NotificationsMismatched,
                    Completion = cleanArtifactAnalysi.Completion,
                    CompletionAKA = cleanArtifactAnalysi.CompletionAKA,
                    CompletionMismatched = cleanArtifactAnalysi.CompletionMismatched,
                    ToDoEmployees = cleanArtifactAnalysi.ToDoEmployees,
                    ToDoEmployeesAKA = cleanArtifactAnalysi.ToDoEmployeesAKA,
                    ToDoEmployeesMismatched = cleanArtifactAnalysi.ToDoEmployeesMismatched,
                    Duration = cleanArtifactAnalysi.Duration,
                    DurationAKA = cleanArtifactAnalysi.DurationAKA,
                    DurationMismatched = cleanArtifactAnalysi.DurationMismatched,
                    CompletedDate = cleanArtifactAnalysi.CompletedDate,
                    CompletedDateAKA = cleanArtifactAnalysi.CompletedDateAKA,
                    CompletedDateMismatched = cleanArtifactAnalysi.CompletedDateMismatched,
                    ToDoColors = cleanArtifactAnalysi.ToDoColors,
                    ToDoColorsAKA = cleanArtifactAnalysi.ToDoColorsAKA,
                    ToDoColorsMismatched = cleanArtifactAnalysi.ToDoColorsMismatched
                };
            }

            return AdminArtifactAnalysi;
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
                    AutoNumber = cleanExperimentTransformer.AutoNumber,
                     // default value: . 
                    IsSyntaxFree = cleanExperimentTransformer.IsSyntaxFree,
                     // default value: . 
                    GenerationTransformer = cleanExperimentTransformer.GenerationTransformer
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
                    AutoNumber = cleanExperimentTransformer.AutoNumber,
                    TransformerIdentifier = cleanExperimentTransformer.TransformerIdentifier,
                    IsSyntaxFree = cleanExperimentTransformer.IsSyntaxFree,
                    GenerationTransformer = cleanExperimentTransformer.GenerationTransformer
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
                    AutoNumber = cleanExperimentTransformer.AutoNumber,
                    IsSyntaxFree = cleanExperimentTransformer.IsSyntaxFree,
                    GenerationTransformer = cleanExperimentTransformer.GenerationTransformer
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
                    Experiment = cleanExperimentFeature.Experiment,
                     // default value: . 
                    Variations = cleanExperimentFeature.Variations,
                     // default value: . 
                    PartialMatches = cleanExperimentFeature.PartialMatches
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
                    IsActiveExp = cleanExperimentFeature.IsActiveExp,
                    Variations = cleanExperimentFeature.Variations,
                    PartialMatches = cleanExperimentFeature.PartialMatches
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
                    Experiment = cleanExperimentFeature.Experiment,
                    Variations = cleanExperimentFeature.Variations,
                    PartialMatches = cleanExperimentFeature.PartialMatches
                };
            }

            return AdminExperimentFeature;
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
                    AutoNumber = cleanExperiment.AutoNumber,
                     // default value: . 
                    Trials = cleanExperiment.Trials,
                     // default value: . 
                    PromptChainsToCreate = cleanExperiment.PromptChainsToCreate
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
                    AutoNumber = cleanExperiment.AutoNumber,
                    SyntaxLockedTransformerNumbers = cleanExperiment.SyntaxLockedTransformerNumbers,
                    SyntaxFreeTransformerNumbers = cleanExperiment.SyntaxFreeTransformerNumbers,
                    Trials = cleanExperiment.Trials,
                    RunTrialScript = cleanExperiment.RunTrialScript,
                    GenerationAddDataCommandScripts = cleanExperiment.GenerationAddDataCommandScripts,
                    PromptChainsToCreate = cleanExperiment.PromptChainsToCreate
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
                    AutoNumber = cleanExperiment.AutoNumber,
                    Trials = cleanExperiment.Trials,
                    PromptChainsToCreate = cleanExperiment.PromptChainsToCreate
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
