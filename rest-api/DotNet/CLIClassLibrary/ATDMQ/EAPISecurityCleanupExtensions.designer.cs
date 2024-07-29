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
        
        // CRUDCoordinator Cleaning Extension Methods.  --
        
        // CRUDCoordinator Cleaning Extension Methods.  --
        
        // User Cleaning Extension Methods.  -CRUD-
        
        // PromptInputAnswerKey
        public static dc.PromptInputAnswerKey UserCleanForAdd(this dc.PromptInputAnswerKey cleanPromptInputAnswerKey)
        {
            var UserPromptInputAnswerKey = default(dc.PromptInputAnswerKey);

            if (!ReferenceEquals(cleanPromptInputAnswerKey, null))
            {
                UserPromptInputAnswerKey = new dc.PromptInputAnswerKey()
                {
                     // default value: . 
                    PromptInputAnswerKeyId = cleanPromptInputAnswerKey.PromptInputAnswerKeyId,
                     // default value: . 
                    Name = cleanPromptInputAnswerKey.Name,
                     // default value: . 
                    Question = cleanPromptInputAnswerKey.Question,
                     // default value: . 
                    Answer = cleanPromptInputAnswerKey.Answer,
                     // default value: . 
                    PromptInput = cleanPromptInputAnswerKey.PromptInput
                };
                
            }

            return UserPromptInputAnswerKey;
        }
        
        
        public static List<dc.PromptInputAnswerKey> UserCleanForGet(this IEnumerable<dc.PromptInputAnswerKey> cleanPromptInputAnswerKeies)
        {
            return cleanPromptInputAnswerKeies.Select(PromptInputAnswerKey => PromptInputAnswerKey.UserCleanForGet())
                            .ToList();
        }
        
        public static dc.PromptInputAnswerKey UserCleanForGet(this dc.PromptInputAnswerKey cleanPromptInputAnswerKey)
        {
            var UserPromptInputAnswerKey = default(dc.PromptInputAnswerKey);

            if (!ReferenceEquals(cleanPromptInputAnswerKey, null))
            {
                UserPromptInputAnswerKey = new dc.PromptInputAnswerKey()
                {
                    PromptInputAnswerKeyId = cleanPromptInputAnswerKey.PromptInputAnswerKeyId,
                    Name = cleanPromptInputAnswerKey.Name,
                    Question = cleanPromptInputAnswerKey.Question,
                    Answer = cleanPromptInputAnswerKey.Answer,
                    PromptInput = cleanPromptInputAnswerKey.PromptInput,
                    AnswerKey = cleanPromptInputAnswerKey.AnswerKey,
                    AnswerKeycopy = cleanPromptInputAnswerKey.AnswerKeycopy
                };
            }

            return UserPromptInputAnswerKey;
        }
        
        
        public static dc.PromptInputAnswerKey UserCleanForUpdate(this dc.PromptInputAnswerKey cleanPromptInputAnswerKey)
        {
            var UserPromptInputAnswerKey = default(dc.PromptInputAnswerKey);

            if (!ReferenceEquals(cleanPromptInputAnswerKey, null))
            {
                UserPromptInputAnswerKey = new dc.PromptInputAnswerKey()
                {
                    PromptInputAnswerKeyId = cleanPromptInputAnswerKey.PromptInputAnswerKeyId,
                    Name = cleanPromptInputAnswerKey.Name,
                    Question = cleanPromptInputAnswerKey.Question,
                    Answer = cleanPromptInputAnswerKey.Answer,
                    PromptInput = cleanPromptInputAnswerKey.PromptInput
                };
            }

            return UserPromptInputAnswerKey;
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
                    Transformer = cleanGenerationTransformer.Transformer,
                     // default value: . 
                    TransformedArtifacts = cleanGenerationTransformer.TransformedArtifacts,
                     // default value: . 
                    AutoNumber = cleanGenerationTransformer.AutoNumber,
                     // default value: . 
                    IsArtifactValidator = cleanGenerationTransformer.IsArtifactValidator
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
                    IdeaPrompt = cleanGenerationTransformer.IdeaPrompt,
                    GenerationSourceIdea = cleanGenerationTransformer.GenerationSourceIdea,
                    Transformer = cleanGenerationTransformer.Transformer,
                    GenerationName = cleanGenerationTransformer.GenerationName,
                    GenerationIdea = cleanGenerationTransformer.GenerationIdea,
                    GenerationIdeaName = cleanGenerationTransformer.GenerationIdeaName,
                    GeneratioNumber = cleanGenerationTransformer.GeneratioNumber,
                    IsActiveIdea = cleanGenerationTransformer.IsActiveIdea,
                    TransformedArtifacts = cleanGenerationTransformer.TransformedArtifacts,
                    AutoNumber = cleanGenerationTransformer.AutoNumber,
                    TransformerNumber = cleanGenerationTransformer.TransformerNumber,
                    IsArtifactValidator = cleanGenerationTransformer.IsArtifactValidator
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
                    Transformer = cleanGenerationTransformer.Transformer,
                    TransformedArtifacts = cleanGenerationTransformer.TransformedArtifacts,
                    AutoNumber = cleanGenerationTransformer.AutoNumber,
                    IsArtifactValidator = cleanGenerationTransformer.IsArtifactValidator
                };
            }

            return UserGenerationTransformer;
        }

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
                    Name = cleanIdeaTransformer.Name,
                     // default value: . 
                    Idea = cleanIdeaTransformer.Idea,
                     // default value: . 
                    FullPrompt = cleanIdeaTransformer.FullPrompt,
                     // default value: . 
                    TransformedArtifacts = cleanIdeaTransformer.TransformedArtifacts
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
                    TransformedArtifacts = cleanIdeaTransformer.TransformedArtifacts
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
                    Name = cleanIdeaTransformer.Name,
                    Idea = cleanIdeaTransformer.Idea,
                    FullPrompt = cleanIdeaTransformer.FullPrompt,
                    TransformedArtifacts = cleanIdeaTransformer.TransformedArtifacts
                };
            }

            return UserIdeaTransformer;
        }

        // User Cleaning Extension Methods.  -CRUD-
        
        // MOFNode
        public static dc.MOFNode UserCleanForAdd(this dc.MOFNode cleanMOFNode)
        {
            var UserMOFNode = default(dc.MOFNode);

            if (!ReferenceEquals(cleanMOFNode, null))
            {
                UserMOFNode = new dc.MOFNode()
                {
                     // default value: . 
                    MOFNodeId = cleanMOFNode.MOFNodeId,
                     // default value: . 
                    NodeName = cleanMOFNode.NodeName,
                     // default value: . 
                    NodeType = cleanMOFNode.NodeType,
                     // default value: . 
                    Attachments = cleanMOFNode.Attachments,
                     // default value: . 
                    PlatformAttachments = cleanMOFNode.PlatformAttachments,
                     // default value: . 
                    FileExtensions = cleanMOFNode.FileExtensions,
                     // default value: . 
                    FromNodes = cleanMOFNode.FromNodes,
                     // default value: . 
                    ToNodes = cleanMOFNode.ToNodes,
                     // default value: . 
                    ToNodeEdges = cleanMOFNode.ToNodeEdges,
                     // default value: . 
                    TranspilerForEdge = cleanMOFNode.TranspilerForEdge,
                     // default value: . 
                    Notes = cleanMOFNode.Notes,
                     // default value: . 
                    SortOrder = cleanMOFNode.SortOrder,
                     // default value: . 
                    IsQueriable = cleanMOFNode.IsQueriable,
                     // default value: . 
                    DesiredColor = cleanMOFNode.DesiredColor,
                     // default value: . 
                    CurrentCodeFor = cleanMOFNode.CurrentCodeFor,
                     // default value: . 
                    CurrentDocsFor = cleanMOFNode.CurrentDocsFor,
                     // default value: . 
                    OutputIsDocs = cleanMOFNode.OutputIsDocs,
                     // default value: . 
                    OutputIsCode = cleanMOFNode.OutputIsCode,
                     // default value: . 
                    NodeEdges = cleanMOFNode.NodeEdges,
                     // default value: . 
                    NodeChoices = cleanMOFNode.NodeChoices,
                     // default value: . 
                    DefaultFileName = cleanMOFNode.DefaultFileName,
                     // default value: . 
                    ToolForChoices = cleanMOFNode.ToolForChoices,
                     // default value: . 
                    ToolTransformerForChoices = cleanMOFNode.ToolTransformerForChoices
                };
                
            }

            return UserMOFNode;
        }
        
        
        public static List<dc.MOFNode> UserCleanForGet(this IEnumerable<dc.MOFNode> cleanMOFNodes)
        {
            return cleanMOFNodes.Select(MOFNode => MOFNode.UserCleanForGet())
                            .ToList();
        }
        
        public static dc.MOFNode UserCleanForGet(this dc.MOFNode cleanMOFNode)
        {
            var UserMOFNode = default(dc.MOFNode);

            if (!ReferenceEquals(cleanMOFNode, null))
            {
                UserMOFNode = new dc.MOFNode()
                {
                    MOFNodeId = cleanMOFNode.MOFNodeId,
                    Name = cleanMOFNode.Name,
                    NodeName = cleanMOFNode.NodeName,
                    NodeType = cleanMOFNode.NodeType,
                    Attachments = cleanMOFNode.Attachments,
                    PlatformAttachments = cleanMOFNode.PlatformAttachments,
                    FileExtensions = cleanMOFNode.FileExtensions,
                    FromNodes = cleanMOFNode.FromNodes,
                    ToNodes = cleanMOFNode.ToNodes,
                    ToNodeEdges = cleanMOFNode.ToNodeEdges,
                    TranspilerForEdge = cleanMOFNode.TranspilerForEdge,
                    Notes = cleanMOFNode.Notes,
                    SortOrder = cleanMOFNode.SortOrder,
                    IsQueriable = cleanMOFNode.IsQueriable,
                    DesiredColor = cleanMOFNode.DesiredColor,
                    CurrentCodeFor = cleanMOFNode.CurrentCodeFor,
                    CurrentDocsFor = cleanMOFNode.CurrentDocsFor,
                    OutputIsDocs = cleanMOFNode.OutputIsDocs,
                    OutputIsCode = cleanMOFNode.OutputIsCode,
                    NodeEdges = cleanMOFNode.NodeEdges,
                    NodeChoices = cleanMOFNode.NodeChoices,
                    DefaultFileName = cleanMOFNode.DefaultFileName,
                    ToolForChoices = cleanMOFNode.ToolForChoices,
                    ToolTransformerForChoices = cleanMOFNode.ToolTransformerForChoices
                };
            }

            return UserMOFNode;
        }
        
        
        public static dc.MOFNode UserCleanForUpdate(this dc.MOFNode cleanMOFNode)
        {
            var UserMOFNode = default(dc.MOFNode);

            if (!ReferenceEquals(cleanMOFNode, null))
            {
                UserMOFNode = new dc.MOFNode()
                {
                    MOFNodeId = cleanMOFNode.MOFNodeId,
                    NodeName = cleanMOFNode.NodeName,
                    NodeType = cleanMOFNode.NodeType,
                    Attachments = cleanMOFNode.Attachments,
                    PlatformAttachments = cleanMOFNode.PlatformAttachments,
                    FileExtensions = cleanMOFNode.FileExtensions,
                    FromNodes = cleanMOFNode.FromNodes,
                    ToNodes = cleanMOFNode.ToNodes,
                    ToNodeEdges = cleanMOFNode.ToNodeEdges,
                    TranspilerForEdge = cleanMOFNode.TranspilerForEdge,
                    Notes = cleanMOFNode.Notes,
                    SortOrder = cleanMOFNode.SortOrder,
                    IsQueriable = cleanMOFNode.IsQueriable,
                    DesiredColor = cleanMOFNode.DesiredColor,
                    CurrentCodeFor = cleanMOFNode.CurrentCodeFor,
                    CurrentDocsFor = cleanMOFNode.CurrentDocsFor,
                    OutputIsDocs = cleanMOFNode.OutputIsDocs,
                    OutputIsCode = cleanMOFNode.OutputIsCode,
                    NodeEdges = cleanMOFNode.NodeEdges,
                    NodeChoices = cleanMOFNode.NodeChoices,
                    DefaultFileName = cleanMOFNode.DefaultFileName,
                    ToolForChoices = cleanMOFNode.ToolForChoices,
                    ToolTransformerForChoices = cleanMOFNode.ToolTransformerForChoices
                };
            }

            return UserMOFNode;
        }

        // User Cleaning Extension Methods.  -CRUD-
        
        // MOFChoice
        public static dc.MOFChoice UserCleanForAdd(this dc.MOFChoice cleanMOFChoice)
        {
            var UserMOFChoice = default(dc.MOFChoice);

            if (!ReferenceEquals(cleanMOFChoice, null))
            {
                UserMOFChoice = new dc.MOFChoice()
                {
                     // default value: . 
                    MOFChoiceId = cleanMOFChoice.MOFChoiceId,
                     // default value: . 
                    Layers = cleanMOFChoice.Layers,
                     // default value: . 
                    Node = cleanMOFChoice.Node,
                     // default value: . 
                    ToolInputChoice = cleanMOFChoice.ToolInputChoice,
                     // default value: . 
                    Tool = cleanMOFChoice.Tool,
                     // default value: . 
                    ToolTransformer = cleanMOFChoice.ToolTransformer,
                     // default value: . 
                    Notes = cleanMOFChoice.Notes,
                     // default value: . 
                    ParentChoice = cleanMOFChoice.ParentChoice,
                     // default value: . 
                    IsSyntaxFree = cleanMOFChoice.IsSyntaxFree,
                     // default value: . 
                    MixedColor = cleanMOFChoice.MixedColor,
                     // default value: . 
                    ExpectedColor = cleanMOFChoice.ExpectedColor,
                     // default value: . 
                    DesiredColor = cleanMOFChoice.DesiredColor
                };
                
            }

            return UserMOFChoice;
        }
        
        
        public static List<dc.MOFChoice> UserCleanForGet(this IEnumerable<dc.MOFChoice> cleanMOFChoices)
        {
            return cleanMOFChoices.Select(MOFChoice => MOFChoice.UserCleanForGet())
                            .ToList();
        }
        
        public static dc.MOFChoice UserCleanForGet(this dc.MOFChoice cleanMOFChoice)
        {
            var UserMOFChoice = default(dc.MOFChoice);

            if (!ReferenceEquals(cleanMOFChoice, null))
            {
                UserMOFChoice = new dc.MOFChoice()
                {
                    MOFChoiceId = cleanMOFChoice.MOFChoiceId,
                    Name = cleanMOFChoice.Name,
                    Layers = cleanMOFChoice.Layers,
                    FQNChoiceName = cleanMOFChoice.FQNChoiceName,
                    Node = cleanMOFChoice.Node,
                    NodeName = cleanMOFChoice.NodeName,
                    ToolInputChoice = cleanMOFChoice.ToolInputChoice,
                    ToolDefaultFileName = cleanMOFChoice.ToolDefaultFileName,
                    ToolName = cleanMOFChoice.ToolName,
                    InputChoiceFileName = cleanMOFChoice.InputChoiceFileName,
                    NodeDefaultFileName = cleanMOFChoice.NodeDefaultFileName,
                    NodeAttachments = cleanMOFChoice.NodeAttachments,
                    ParentNodeDesiredColor = cleanMOFChoice.ParentNodeDesiredColor,
                    NodeDesiredColor = cleanMOFChoice.NodeDesiredColor,
                    Tool = cleanMOFChoice.Tool,
                    ParentNodeAttachments = cleanMOFChoice.ParentNodeAttachments,
                    ToolTransformer = cleanMOFChoice.ToolTransformer,
                    ParentChoiceName = cleanMOFChoice.ParentChoiceName,
                    Notes = cleanMOFChoice.Notes,
                    ParentChoice = cleanMOFChoice.ParentChoice,
                    IsSyntaxFree = cleanMOFChoice.IsSyntaxFree,
                    MOFLayerNumber = cleanMOFChoice.MOFLayerNumber,
                    ParentMOFLayerNumber = cleanMOFChoice.ParentMOFLayerNumber,
                    MixedColor = cleanMOFChoice.MixedColor,
                    ExpectedColor = cleanMOFChoice.ExpectedColor,
                    ToolTransformerFileName = cleanMOFChoice.ToolTransformerFileName,
                    IsInSync = cleanMOFChoice.IsInSync,
                    IsInSyncImage = cleanMOFChoice.IsInSyncImage,
                    ToolAttachments = cleanMOFChoice.ToolAttachments,
                    ToolInputAttachments = cleanMOFChoice.ToolInputAttachments,
                    ToolInputChoiceNodeAttachments = cleanMOFChoice.ToolInputChoiceNodeAttachments,
                    MOFDisplayOrder = cleanMOFChoice.MOFDisplayOrder,
                    ParentMOFDisplayOrder = cleanMOFChoice.ParentMOFDisplayOrder,
                    OutputIsDocs = cleanMOFChoice.OutputIsDocs,
                    DesiredColor = cleanMOFChoice.DesiredColor,
                    ToolPlatformAttachments = cleanMOFChoice.ToolPlatformAttachments,
                    NodePlatformAttachments = cleanMOFChoice.NodePlatformAttachments
                };
            }

            return UserMOFChoice;
        }
        
        
        public static dc.MOFChoice UserCleanForUpdate(this dc.MOFChoice cleanMOFChoice)
        {
            var UserMOFChoice = default(dc.MOFChoice);

            if (!ReferenceEquals(cleanMOFChoice, null))
            {
                UserMOFChoice = new dc.MOFChoice()
                {
                    MOFChoiceId = cleanMOFChoice.MOFChoiceId,
                    Layers = cleanMOFChoice.Layers,
                    Node = cleanMOFChoice.Node,
                    ToolInputChoice = cleanMOFChoice.ToolInputChoice,
                    Tool = cleanMOFChoice.Tool,
                    ToolTransformer = cleanMOFChoice.ToolTransformer,
                    Notes = cleanMOFChoice.Notes,
                    ParentChoice = cleanMOFChoice.ParentChoice,
                    IsSyntaxFree = cleanMOFChoice.IsSyntaxFree,
                    MixedColor = cleanMOFChoice.MixedColor,
                    ExpectedColor = cleanMOFChoice.ExpectedColor,
                    DesiredColor = cleanMOFChoice.DesiredColor
                };
            }

            return UserMOFChoice;
        }

        // User Cleaning Extension Methods.  -CRUD-
        
        // DataFormat
        public static dc.DataFormat UserCleanForAdd(this dc.DataFormat cleanDataFormat)
        {
            var UserDataFormat = default(dc.DataFormat);

            if (!ReferenceEquals(cleanDataFormat, null))
            {
                UserDataFormat = new dc.DataFormat()
                {
                     // default value: . 
                    DataFormatId = cleanDataFormat.DataFormatId,
                     // default value: . 
                    Name = cleanDataFormat.Name,
                     // default value: . 
                    PromptInputs = cleanDataFormat.PromptInputs,
                     // default value: . 
                    PromptVariations = cleanDataFormat.PromptVariations,
                     // default value: . 
                    OutputFormatRequests = cleanDataFormat.OutputFormatRequests
                };
                
            }

            return UserDataFormat;
        }
        
        
        public static List<dc.DataFormat> UserCleanForGet(this IEnumerable<dc.DataFormat> cleanDataFormats)
        {
            return cleanDataFormats.Select(DataFormat => DataFormat.UserCleanForGet())
                            .ToList();
        }
        
        public static dc.DataFormat UserCleanForGet(this dc.DataFormat cleanDataFormat)
        {
            var UserDataFormat = default(dc.DataFormat);

            if (!ReferenceEquals(cleanDataFormat, null))
            {
                UserDataFormat = new dc.DataFormat()
                {
                    DataFormatId = cleanDataFormat.DataFormatId,
                    Name = cleanDataFormat.Name,
                    PromptInputs = cleanDataFormat.PromptInputs,
                    PromptVariations = cleanDataFormat.PromptVariations,
                    OutputFormatRequests = cleanDataFormat.OutputFormatRequests
                };
            }

            return UserDataFormat;
        }
        
        
        public static dc.DataFormat UserCleanForUpdate(this dc.DataFormat cleanDataFormat)
        {
            var UserDataFormat = default(dc.DataFormat);

            if (!ReferenceEquals(cleanDataFormat, null))
            {
                UserDataFormat = new dc.DataFormat()
                {
                    DataFormatId = cleanDataFormat.DataFormatId,
                    Name = cleanDataFormat.Name,
                    PromptInputs = cleanDataFormat.PromptInputs,
                    PromptVariations = cleanDataFormat.PromptVariations,
                    OutputFormatRequests = cleanDataFormat.OutputFormatRequests
                };
            }

            return UserDataFormat;
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
                    Model = cleanGeneration.Model
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
        
        // MOFLayer
        public static dc.MOFLayer UserCleanForAdd(this dc.MOFLayer cleanMOFLayer)
        {
            var UserMOFLayer = default(dc.MOFLayer);

            if (!ReferenceEquals(cleanMOFLayer, null))
            {
                UserMOFLayer = new dc.MOFLayer()
                {
                     // default value: . 
                    MOFLayerId = cleanMOFLayer.MOFLayerId,
                     // default value: . 
                    MOFLayerName = cleanMOFLayer.MOFLayerName,
                     // default value: . 
                    Notes = cleanMOFLayer.Notes,
                     // default value: . 
                    MOFLayerNumber = cleanMOFLayer.MOFLayerNumber,
                     // default value: . 
                    LayerChoices = cleanMOFLayer.LayerChoices,
                     // default value: . 
                    MOFDisplayOrder = cleanMOFLayer.MOFDisplayOrder
                };
                
            }

            return UserMOFLayer;
        }
        
        
        public static List<dc.MOFLayer> UserCleanForGet(this IEnumerable<dc.MOFLayer> cleanMOFLayers)
        {
            return cleanMOFLayers.Select(MOFLayer => MOFLayer.UserCleanForGet())
                            .ToList();
        }
        
        public static dc.MOFLayer UserCleanForGet(this dc.MOFLayer cleanMOFLayer)
        {
            var UserMOFLayer = default(dc.MOFLayer);

            if (!ReferenceEquals(cleanMOFLayer, null))
            {
                UserMOFLayer = new dc.MOFLayer()
                {
                    MOFLayerId = cleanMOFLayer.MOFLayerId,
                    Name = cleanMOFLayer.Name,
                    MOFLayerName = cleanMOFLayer.MOFLayerName,
                    Notes = cleanMOFLayer.Notes,
                    MOFLayerNumber = cleanMOFLayer.MOFLayerNumber,
                    LayerChoices = cleanMOFLayer.LayerChoices,
                    MOFDisplayOrder = cleanMOFLayer.MOFDisplayOrder
                };
            }

            return UserMOFLayer;
        }
        
        
        public static dc.MOFLayer UserCleanForUpdate(this dc.MOFLayer cleanMOFLayer)
        {
            var UserMOFLayer = default(dc.MOFLayer);

            if (!ReferenceEquals(cleanMOFLayer, null))
            {
                UserMOFLayer = new dc.MOFLayer()
                {
                    MOFLayerId = cleanMOFLayer.MOFLayerId,
                    MOFLayerName = cleanMOFLayer.MOFLayerName,
                    Notes = cleanMOFLayer.Notes,
                    MOFLayerNumber = cleanMOFLayer.MOFLayerNumber,
                    LayerChoices = cleanMOFLayer.LayerChoices,
                    MOFDisplayOrder = cleanMOFLayer.MOFDisplayOrder
                };
            }

            return UserMOFLayer;
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
        
        // OutputFormatRequest
        public static dc.OutputFormatRequest UserCleanForAdd(this dc.OutputFormatRequest cleanOutputFormatRequest)
        {
            var UserOutputFormatRequest = default(dc.OutputFormatRequest);

            if (!ReferenceEquals(cleanOutputFormatRequest, null))
            {
                UserOutputFormatRequest = new dc.OutputFormatRequest()
                {
                     // default value: . 
                    OutputFormatRequestId = cleanOutputFormatRequest.OutputFormatRequestId,
                     // default value: . 
                    Name = cleanOutputFormatRequest.Name,
                     // default value: . 
                    Prompt = cleanOutputFormatRequest.Prompt,
                     // default value: . 
                    PromptVariations = cleanOutputFormatRequest.PromptVariations,
                     // default value: . 
                    OutputFormat = cleanOutputFormatRequest.OutputFormat
                };
                
            }

            return UserOutputFormatRequest;
        }
        
        
        public static List<dc.OutputFormatRequest> UserCleanForGet(this IEnumerable<dc.OutputFormatRequest> cleanOutputFormatRequests)
        {
            return cleanOutputFormatRequests.Select(OutputFormatRequest => OutputFormatRequest.UserCleanForGet())
                            .ToList();
        }
        
        public static dc.OutputFormatRequest UserCleanForGet(this dc.OutputFormatRequest cleanOutputFormatRequest)
        {
            var UserOutputFormatRequest = default(dc.OutputFormatRequest);

            if (!ReferenceEquals(cleanOutputFormatRequest, null))
            {
                UserOutputFormatRequest = new dc.OutputFormatRequest()
                {
                    OutputFormatRequestId = cleanOutputFormatRequest.OutputFormatRequestId,
                    Name = cleanOutputFormatRequest.Name,
                    Prompt = cleanOutputFormatRequest.Prompt,
                    PromptVariations = cleanOutputFormatRequest.PromptVariations,
                    OutputFormat = cleanOutputFormatRequest.OutputFormat
                };
            }

            return UserOutputFormatRequest;
        }
        
        
        public static dc.OutputFormatRequest UserCleanForUpdate(this dc.OutputFormatRequest cleanOutputFormatRequest)
        {
            var UserOutputFormatRequest = default(dc.OutputFormatRequest);

            if (!ReferenceEquals(cleanOutputFormatRequest, null))
            {
                UserOutputFormatRequest = new dc.OutputFormatRequest()
                {
                    OutputFormatRequestId = cleanOutputFormatRequest.OutputFormatRequestId,
                    Name = cleanOutputFormatRequest.Name,
                    Prompt = cleanOutputFormatRequest.Prompt,
                    PromptVariations = cleanOutputFormatRequest.PromptVariations,
                    OutputFormat = cleanOutputFormatRequest.OutputFormat
                };
            }

            return UserOutputFormatRequest;
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
                    ValidationArtifact = cleanTransformedArtifact.ValidationArtifact,
                     // default value: . 
                    ActualPrompt = cleanTransformedArtifact.ActualPrompt,
                     // default value: . 
                    Response = cleanTransformedArtifact.Response,
                     // default value: . 
                    AutoNumber = cleanTransformedArtifact.AutoNumber,
                     // default value: . 
                    IsRetiredArtifact = cleanTransformedArtifact.IsRetiredArtifact,
                     // default value: . 
                    ExtensionOf = cleanTransformedArtifact.ExtensionOf
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
                    ValidationArtifact = cleanTransformedArtifact.ValidationArtifact,
                    ResponseOfArtifactBeingValidated = cleanTransformedArtifact.ResponseOfArtifactBeingValidated,
                    TransformerRawPrompt = cleanTransformedArtifact.TransformerRawPrompt,
                    TransformerIdeaPrompt = cleanTransformedArtifact.TransformerIdeaPrompt,
                    ActualPrompt = cleanTransformedArtifact.ActualPrompt,
                    Response = cleanTransformedArtifact.Response,
                    Created = cleanTransformedArtifact.Created,
                    AutoNumber = cleanTransformedArtifact.AutoNumber,
                    IsRetiredArtifact = cleanTransformedArtifact.IsRetiredArtifact,
                    IsActiveIdea = cleanTransformedArtifact.IsActiveIdea,
                    Modified = cleanTransformedArtifact.Modified,
                    SuggestedPrompt = cleanTransformedArtifact.SuggestedPrompt,
                    ExtensionOf = cleanTransformedArtifact.ExtensionOf,
                    TransformerNumber = cleanTransformedArtifact.TransformerNumber
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
                    ValidationArtifact = cleanTransformedArtifact.ValidationArtifact,
                    ActualPrompt = cleanTransformedArtifact.ActualPrompt,
                    Response = cleanTransformedArtifact.Response,
                    AutoNumber = cleanTransformedArtifact.AutoNumber,
                    IsRetiredArtifact = cleanTransformedArtifact.IsRetiredArtifact,
                    ExtensionOf = cleanTransformedArtifact.ExtensionOf
                };
            }

            return UserTransformedArtifact;
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
                    GenerationTransformers = cleanIdea.GenerationTransformers,
                     // default value: . 
                    IsActiveIdea = cleanIdea.IsActiveIdea
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
                    GenerationTransformers = cleanIdea.GenerationTransformers,
                    GenerationTransformerNames = cleanIdea.GenerationTransformerNames,
                    GenerationTransformerFullPrompts = cleanIdea.GenerationTransformerFullPrompts,
                    IsActiveIdea = cleanIdea.IsActiveIdea
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
                    GenerationTransformers = cleanIdea.GenerationTransformers,
                    IsActiveIdea = cleanIdea.IsActiveIdea
                };
            }

            return UserIdea;
        }

        // Admin Cleaning Extension Methods.  -CRUD-
        
        // PromptInputAnswerKey
        public static dc.PromptInputAnswerKey AdminCleanForAdd(this dc.PromptInputAnswerKey cleanPromptInputAnswerKey)
        {
            var AdminPromptInputAnswerKey = default(dc.PromptInputAnswerKey);

            if (!ReferenceEquals(cleanPromptInputAnswerKey, null))
            {
                AdminPromptInputAnswerKey = new dc.PromptInputAnswerKey()
                {
                     // default value: . 
                    PromptInputAnswerKeyId = cleanPromptInputAnswerKey.PromptInputAnswerKeyId,
                     // default value: . 
                    Name = cleanPromptInputAnswerKey.Name,
                     // default value: . 
                    Question = cleanPromptInputAnswerKey.Question,
                     // default value: . 
                    Answer = cleanPromptInputAnswerKey.Answer,
                     // default value: . 
                    PromptInput = cleanPromptInputAnswerKey.PromptInput
                };
                
            }

            return AdminPromptInputAnswerKey;
        }
        
        
        public static List<dc.PromptInputAnswerKey> AdminCleanForGet(this IEnumerable<dc.PromptInputAnswerKey> cleanPromptInputAnswerKeies)
        {
            return cleanPromptInputAnswerKeies.Select(PromptInputAnswerKey => PromptInputAnswerKey.AdminCleanForGet())
                            .ToList();
        }
        
        public static dc.PromptInputAnswerKey AdminCleanForGet(this dc.PromptInputAnswerKey cleanPromptInputAnswerKey)
        {
            var AdminPromptInputAnswerKey = default(dc.PromptInputAnswerKey);

            if (!ReferenceEquals(cleanPromptInputAnswerKey, null))
            {
                AdminPromptInputAnswerKey = new dc.PromptInputAnswerKey()
                {
                    PromptInputAnswerKeyId = cleanPromptInputAnswerKey.PromptInputAnswerKeyId,
                    Name = cleanPromptInputAnswerKey.Name,
                    Question = cleanPromptInputAnswerKey.Question,
                    Answer = cleanPromptInputAnswerKey.Answer,
                    PromptInput = cleanPromptInputAnswerKey.PromptInput,
                    AnswerKey = cleanPromptInputAnswerKey.AnswerKey,
                    AnswerKeycopy = cleanPromptInputAnswerKey.AnswerKeycopy
                };
            }

            return AdminPromptInputAnswerKey;
        }
        
        
        public static dc.PromptInputAnswerKey AdminCleanForUpdate(this dc.PromptInputAnswerKey cleanPromptInputAnswerKey)
        {
            var AdminPromptInputAnswerKey = default(dc.PromptInputAnswerKey);

            if (!ReferenceEquals(cleanPromptInputAnswerKey, null))
            {
                AdminPromptInputAnswerKey = new dc.PromptInputAnswerKey()
                {
                    PromptInputAnswerKeyId = cleanPromptInputAnswerKey.PromptInputAnswerKeyId,
                    Name = cleanPromptInputAnswerKey.Name,
                    Question = cleanPromptInputAnswerKey.Question,
                    Answer = cleanPromptInputAnswerKey.Answer,
                    PromptInput = cleanPromptInputAnswerKey.PromptInput
                };
            }

            return AdminPromptInputAnswerKey;
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
                    Transformer = cleanGenerationTransformer.Transformer,
                     // default value: . 
                    TransformedArtifacts = cleanGenerationTransformer.TransformedArtifacts,
                     // default value: . 
                    AutoNumber = cleanGenerationTransformer.AutoNumber,
                     // default value: . 
                    IsArtifactValidator = cleanGenerationTransformer.IsArtifactValidator
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
                    IdeaPrompt = cleanGenerationTransformer.IdeaPrompt,
                    GenerationSourceIdea = cleanGenerationTransformer.GenerationSourceIdea,
                    Transformer = cleanGenerationTransformer.Transformer,
                    GenerationName = cleanGenerationTransformer.GenerationName,
                    GenerationIdea = cleanGenerationTransformer.GenerationIdea,
                    GenerationIdeaName = cleanGenerationTransformer.GenerationIdeaName,
                    GeneratioNumber = cleanGenerationTransformer.GeneratioNumber,
                    IsActiveIdea = cleanGenerationTransformer.IsActiveIdea,
                    TransformedArtifacts = cleanGenerationTransformer.TransformedArtifacts,
                    AutoNumber = cleanGenerationTransformer.AutoNumber,
                    TransformerNumber = cleanGenerationTransformer.TransformerNumber,
                    IsArtifactValidator = cleanGenerationTransformer.IsArtifactValidator
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
                    Transformer = cleanGenerationTransformer.Transformer,
                    TransformedArtifacts = cleanGenerationTransformer.TransformedArtifacts,
                    AutoNumber = cleanGenerationTransformer.AutoNumber,
                    IsArtifactValidator = cleanGenerationTransformer.IsArtifactValidator
                };
            }

            return AdminGenerationTransformer;
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
                    Name = cleanIdeaTransformer.Name,
                     // default value: . 
                    Idea = cleanIdeaTransformer.Idea,
                     // default value: . 
                    FullPrompt = cleanIdeaTransformer.FullPrompt,
                     // default value: . 
                    TransformedArtifacts = cleanIdeaTransformer.TransformedArtifacts
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
                    TransformedArtifacts = cleanIdeaTransformer.TransformedArtifacts
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
                    Name = cleanIdeaTransformer.Name,
                    Idea = cleanIdeaTransformer.Idea,
                    FullPrompt = cleanIdeaTransformer.FullPrompt,
                    TransformedArtifacts = cleanIdeaTransformer.TransformedArtifacts
                };
            }

            return AdminIdeaTransformer;
        }

        // Admin Cleaning Extension Methods.  -CRUD-
        
        // MOFNode
        public static dc.MOFNode AdminCleanForAdd(this dc.MOFNode cleanMOFNode)
        {
            var AdminMOFNode = default(dc.MOFNode);

            if (!ReferenceEquals(cleanMOFNode, null))
            {
                AdminMOFNode = new dc.MOFNode()
                {
                     // default value: . 
                    MOFNodeId = cleanMOFNode.MOFNodeId,
                     // default value: . 
                    NodeName = cleanMOFNode.NodeName,
                     // default value: . 
                    NodeType = cleanMOFNode.NodeType,
                     // default value: . 
                    Attachments = cleanMOFNode.Attachments,
                     // default value: . 
                    PlatformAttachments = cleanMOFNode.PlatformAttachments,
                     // default value: . 
                    FileExtensions = cleanMOFNode.FileExtensions,
                     // default value: . 
                    FromNodes = cleanMOFNode.FromNodes,
                     // default value: . 
                    ToNodes = cleanMOFNode.ToNodes,
                     // default value: . 
                    ToNodeEdges = cleanMOFNode.ToNodeEdges,
                     // default value: . 
                    TranspilerForEdge = cleanMOFNode.TranspilerForEdge,
                     // default value: . 
                    Notes = cleanMOFNode.Notes,
                     // default value: . 
                    SortOrder = cleanMOFNode.SortOrder,
                     // default value: . 
                    IsQueriable = cleanMOFNode.IsQueriable,
                     // default value: . 
                    DesiredColor = cleanMOFNode.DesiredColor,
                     // default value: . 
                    CurrentCodeFor = cleanMOFNode.CurrentCodeFor,
                     // default value: . 
                    CurrentDocsFor = cleanMOFNode.CurrentDocsFor,
                     // default value: . 
                    OutputIsDocs = cleanMOFNode.OutputIsDocs,
                     // default value: . 
                    OutputIsCode = cleanMOFNode.OutputIsCode,
                     // default value: . 
                    NodeEdges = cleanMOFNode.NodeEdges,
                     // default value: . 
                    NodeChoices = cleanMOFNode.NodeChoices,
                     // default value: . 
                    DefaultFileName = cleanMOFNode.DefaultFileName,
                     // default value: . 
                    ToolForChoices = cleanMOFNode.ToolForChoices,
                     // default value: . 
                    ToolTransformerForChoices = cleanMOFNode.ToolTransformerForChoices
                };
                
            }

            return AdminMOFNode;
        }
        
        
        public static List<dc.MOFNode> AdminCleanForGet(this IEnumerable<dc.MOFNode> cleanMOFNodes)
        {
            return cleanMOFNodes.Select(MOFNode => MOFNode.AdminCleanForGet())
                            .ToList();
        }
        
        public static dc.MOFNode AdminCleanForGet(this dc.MOFNode cleanMOFNode)
        {
            var AdminMOFNode = default(dc.MOFNode);

            if (!ReferenceEquals(cleanMOFNode, null))
            {
                AdminMOFNode = new dc.MOFNode()
                {
                    MOFNodeId = cleanMOFNode.MOFNodeId,
                    Name = cleanMOFNode.Name,
                    NodeName = cleanMOFNode.NodeName,
                    NodeType = cleanMOFNode.NodeType,
                    Attachments = cleanMOFNode.Attachments,
                    PlatformAttachments = cleanMOFNode.PlatformAttachments,
                    FileExtensions = cleanMOFNode.FileExtensions,
                    FromNodes = cleanMOFNode.FromNodes,
                    ToNodes = cleanMOFNode.ToNodes,
                    ToNodeEdges = cleanMOFNode.ToNodeEdges,
                    TranspilerForEdge = cleanMOFNode.TranspilerForEdge,
                    Notes = cleanMOFNode.Notes,
                    SortOrder = cleanMOFNode.SortOrder,
                    IsQueriable = cleanMOFNode.IsQueriable,
                    DesiredColor = cleanMOFNode.DesiredColor,
                    CurrentCodeFor = cleanMOFNode.CurrentCodeFor,
                    CurrentDocsFor = cleanMOFNode.CurrentDocsFor,
                    OutputIsDocs = cleanMOFNode.OutputIsDocs,
                    OutputIsCode = cleanMOFNode.OutputIsCode,
                    NodeEdges = cleanMOFNode.NodeEdges,
                    NodeChoices = cleanMOFNode.NodeChoices,
                    DefaultFileName = cleanMOFNode.DefaultFileName,
                    ToolForChoices = cleanMOFNode.ToolForChoices,
                    ToolTransformerForChoices = cleanMOFNode.ToolTransformerForChoices
                };
            }

            return AdminMOFNode;
        }
        
        
        public static dc.MOFNode AdminCleanForUpdate(this dc.MOFNode cleanMOFNode)
        {
            var AdminMOFNode = default(dc.MOFNode);

            if (!ReferenceEquals(cleanMOFNode, null))
            {
                AdminMOFNode = new dc.MOFNode()
                {
                    MOFNodeId = cleanMOFNode.MOFNodeId,
                    NodeName = cleanMOFNode.NodeName,
                    NodeType = cleanMOFNode.NodeType,
                    Attachments = cleanMOFNode.Attachments,
                    PlatformAttachments = cleanMOFNode.PlatformAttachments,
                    FileExtensions = cleanMOFNode.FileExtensions,
                    FromNodes = cleanMOFNode.FromNodes,
                    ToNodes = cleanMOFNode.ToNodes,
                    ToNodeEdges = cleanMOFNode.ToNodeEdges,
                    TranspilerForEdge = cleanMOFNode.TranspilerForEdge,
                    Notes = cleanMOFNode.Notes,
                    SortOrder = cleanMOFNode.SortOrder,
                    IsQueriable = cleanMOFNode.IsQueriable,
                    DesiredColor = cleanMOFNode.DesiredColor,
                    CurrentCodeFor = cleanMOFNode.CurrentCodeFor,
                    CurrentDocsFor = cleanMOFNode.CurrentDocsFor,
                    OutputIsDocs = cleanMOFNode.OutputIsDocs,
                    OutputIsCode = cleanMOFNode.OutputIsCode,
                    NodeEdges = cleanMOFNode.NodeEdges,
                    NodeChoices = cleanMOFNode.NodeChoices,
                    DefaultFileName = cleanMOFNode.DefaultFileName,
                    ToolForChoices = cleanMOFNode.ToolForChoices,
                    ToolTransformerForChoices = cleanMOFNode.ToolTransformerForChoices
                };
            }

            return AdminMOFNode;
        }

        // Admin Cleaning Extension Methods.  -CRUD-
        
        // MOFChoice
        public static dc.MOFChoice AdminCleanForAdd(this dc.MOFChoice cleanMOFChoice)
        {
            var AdminMOFChoice = default(dc.MOFChoice);

            if (!ReferenceEquals(cleanMOFChoice, null))
            {
                AdminMOFChoice = new dc.MOFChoice()
                {
                     // default value: . 
                    MOFChoiceId = cleanMOFChoice.MOFChoiceId,
                     // default value: . 
                    Layers = cleanMOFChoice.Layers,
                     // default value: . 
                    Node = cleanMOFChoice.Node,
                     // default value: . 
                    ToolInputChoice = cleanMOFChoice.ToolInputChoice,
                     // default value: . 
                    Tool = cleanMOFChoice.Tool,
                     // default value: . 
                    ToolTransformer = cleanMOFChoice.ToolTransformer,
                     // default value: . 
                    Notes = cleanMOFChoice.Notes,
                     // default value: . 
                    ParentChoice = cleanMOFChoice.ParentChoice,
                     // default value: . 
                    IsSyntaxFree = cleanMOFChoice.IsSyntaxFree,
                     // default value: . 
                    MixedColor = cleanMOFChoice.MixedColor,
                     // default value: . 
                    ExpectedColor = cleanMOFChoice.ExpectedColor,
                     // default value: . 
                    DesiredColor = cleanMOFChoice.DesiredColor
                };
                
            }

            return AdminMOFChoice;
        }
        
        
        public static List<dc.MOFChoice> AdminCleanForGet(this IEnumerable<dc.MOFChoice> cleanMOFChoices)
        {
            return cleanMOFChoices.Select(MOFChoice => MOFChoice.AdminCleanForGet())
                            .ToList();
        }
        
        public static dc.MOFChoice AdminCleanForGet(this dc.MOFChoice cleanMOFChoice)
        {
            var AdminMOFChoice = default(dc.MOFChoice);

            if (!ReferenceEquals(cleanMOFChoice, null))
            {
                AdminMOFChoice = new dc.MOFChoice()
                {
                    MOFChoiceId = cleanMOFChoice.MOFChoiceId,
                    Name = cleanMOFChoice.Name,
                    Layers = cleanMOFChoice.Layers,
                    FQNChoiceName = cleanMOFChoice.FQNChoiceName,
                    Node = cleanMOFChoice.Node,
                    NodeName = cleanMOFChoice.NodeName,
                    ToolInputChoice = cleanMOFChoice.ToolInputChoice,
                    ToolDefaultFileName = cleanMOFChoice.ToolDefaultFileName,
                    ToolName = cleanMOFChoice.ToolName,
                    InputChoiceFileName = cleanMOFChoice.InputChoiceFileName,
                    NodeDefaultFileName = cleanMOFChoice.NodeDefaultFileName,
                    NodeAttachments = cleanMOFChoice.NodeAttachments,
                    ParentNodeDesiredColor = cleanMOFChoice.ParentNodeDesiredColor,
                    NodeDesiredColor = cleanMOFChoice.NodeDesiredColor,
                    Tool = cleanMOFChoice.Tool,
                    ParentNodeAttachments = cleanMOFChoice.ParentNodeAttachments,
                    ToolTransformer = cleanMOFChoice.ToolTransformer,
                    ParentChoiceName = cleanMOFChoice.ParentChoiceName,
                    Notes = cleanMOFChoice.Notes,
                    ParentChoice = cleanMOFChoice.ParentChoice,
                    IsSyntaxFree = cleanMOFChoice.IsSyntaxFree,
                    MOFLayerNumber = cleanMOFChoice.MOFLayerNumber,
                    ParentMOFLayerNumber = cleanMOFChoice.ParentMOFLayerNumber,
                    MixedColor = cleanMOFChoice.MixedColor,
                    ExpectedColor = cleanMOFChoice.ExpectedColor,
                    ToolTransformerFileName = cleanMOFChoice.ToolTransformerFileName,
                    IsInSync = cleanMOFChoice.IsInSync,
                    IsInSyncImage = cleanMOFChoice.IsInSyncImage,
                    ToolAttachments = cleanMOFChoice.ToolAttachments,
                    ToolInputAttachments = cleanMOFChoice.ToolInputAttachments,
                    ToolInputChoiceNodeAttachments = cleanMOFChoice.ToolInputChoiceNodeAttachments,
                    MOFDisplayOrder = cleanMOFChoice.MOFDisplayOrder,
                    ParentMOFDisplayOrder = cleanMOFChoice.ParentMOFDisplayOrder,
                    OutputIsDocs = cleanMOFChoice.OutputIsDocs,
                    DesiredColor = cleanMOFChoice.DesiredColor,
                    ToolPlatformAttachments = cleanMOFChoice.ToolPlatformAttachments,
                    NodePlatformAttachments = cleanMOFChoice.NodePlatformAttachments
                };
            }

            return AdminMOFChoice;
        }
        
        
        public static dc.MOFChoice AdminCleanForUpdate(this dc.MOFChoice cleanMOFChoice)
        {
            var AdminMOFChoice = default(dc.MOFChoice);

            if (!ReferenceEquals(cleanMOFChoice, null))
            {
                AdminMOFChoice = new dc.MOFChoice()
                {
                    MOFChoiceId = cleanMOFChoice.MOFChoiceId,
                    Layers = cleanMOFChoice.Layers,
                    Node = cleanMOFChoice.Node,
                    ToolInputChoice = cleanMOFChoice.ToolInputChoice,
                    Tool = cleanMOFChoice.Tool,
                    ToolTransformer = cleanMOFChoice.ToolTransformer,
                    Notes = cleanMOFChoice.Notes,
                    ParentChoice = cleanMOFChoice.ParentChoice,
                    IsSyntaxFree = cleanMOFChoice.IsSyntaxFree,
                    MixedColor = cleanMOFChoice.MixedColor,
                    ExpectedColor = cleanMOFChoice.ExpectedColor,
                    DesiredColor = cleanMOFChoice.DesiredColor
                };
            }

            return AdminMOFChoice;
        }

        // Admin Cleaning Extension Methods.  -CRUD-
        
        // DataFormat
        public static dc.DataFormat AdminCleanForAdd(this dc.DataFormat cleanDataFormat)
        {
            var AdminDataFormat = default(dc.DataFormat);

            if (!ReferenceEquals(cleanDataFormat, null))
            {
                AdminDataFormat = new dc.DataFormat()
                {
                     // default value: . 
                    DataFormatId = cleanDataFormat.DataFormatId,
                     // default value: . 
                    Name = cleanDataFormat.Name,
                     // default value: . 
                    PromptInputs = cleanDataFormat.PromptInputs,
                     // default value: . 
                    PromptVariations = cleanDataFormat.PromptVariations,
                     // default value: . 
                    OutputFormatRequests = cleanDataFormat.OutputFormatRequests
                };
                
            }

            return AdminDataFormat;
        }
        
        
        public static List<dc.DataFormat> AdminCleanForGet(this IEnumerable<dc.DataFormat> cleanDataFormats)
        {
            return cleanDataFormats.Select(DataFormat => DataFormat.AdminCleanForGet())
                            .ToList();
        }
        
        public static dc.DataFormat AdminCleanForGet(this dc.DataFormat cleanDataFormat)
        {
            var AdminDataFormat = default(dc.DataFormat);

            if (!ReferenceEquals(cleanDataFormat, null))
            {
                AdminDataFormat = new dc.DataFormat()
                {
                    DataFormatId = cleanDataFormat.DataFormatId,
                    Name = cleanDataFormat.Name,
                    PromptInputs = cleanDataFormat.PromptInputs,
                    PromptVariations = cleanDataFormat.PromptVariations,
                    OutputFormatRequests = cleanDataFormat.OutputFormatRequests
                };
            }

            return AdminDataFormat;
        }
        
        
        public static dc.DataFormat AdminCleanForUpdate(this dc.DataFormat cleanDataFormat)
        {
            var AdminDataFormat = default(dc.DataFormat);

            if (!ReferenceEquals(cleanDataFormat, null))
            {
                AdminDataFormat = new dc.DataFormat()
                {
                    DataFormatId = cleanDataFormat.DataFormatId,
                    Name = cleanDataFormat.Name,
                    PromptInputs = cleanDataFormat.PromptInputs,
                    PromptVariations = cleanDataFormat.PromptVariations,
                    OutputFormatRequests = cleanDataFormat.OutputFormatRequests
                };
            }

            return AdminDataFormat;
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
                    Model = cleanGeneration.Model
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
        
        // MOFLayer
        public static dc.MOFLayer AdminCleanForAdd(this dc.MOFLayer cleanMOFLayer)
        {
            var AdminMOFLayer = default(dc.MOFLayer);

            if (!ReferenceEquals(cleanMOFLayer, null))
            {
                AdminMOFLayer = new dc.MOFLayer()
                {
                     // default value: . 
                    MOFLayerId = cleanMOFLayer.MOFLayerId,
                     // default value: . 
                    MOFLayerName = cleanMOFLayer.MOFLayerName,
                     // default value: . 
                    Notes = cleanMOFLayer.Notes,
                     // default value: . 
                    MOFLayerNumber = cleanMOFLayer.MOFLayerNumber,
                     // default value: . 
                    LayerChoices = cleanMOFLayer.LayerChoices,
                     // default value: . 
                    MOFDisplayOrder = cleanMOFLayer.MOFDisplayOrder
                };
                
            }

            return AdminMOFLayer;
        }
        
        
        public static List<dc.MOFLayer> AdminCleanForGet(this IEnumerable<dc.MOFLayer> cleanMOFLayers)
        {
            return cleanMOFLayers.Select(MOFLayer => MOFLayer.AdminCleanForGet())
                            .ToList();
        }
        
        public static dc.MOFLayer AdminCleanForGet(this dc.MOFLayer cleanMOFLayer)
        {
            var AdminMOFLayer = default(dc.MOFLayer);

            if (!ReferenceEquals(cleanMOFLayer, null))
            {
                AdminMOFLayer = new dc.MOFLayer()
                {
                    MOFLayerId = cleanMOFLayer.MOFLayerId,
                    Name = cleanMOFLayer.Name,
                    MOFLayerName = cleanMOFLayer.MOFLayerName,
                    Notes = cleanMOFLayer.Notes,
                    MOFLayerNumber = cleanMOFLayer.MOFLayerNumber,
                    LayerChoices = cleanMOFLayer.LayerChoices,
                    MOFDisplayOrder = cleanMOFLayer.MOFDisplayOrder
                };
            }

            return AdminMOFLayer;
        }
        
        
        public static dc.MOFLayer AdminCleanForUpdate(this dc.MOFLayer cleanMOFLayer)
        {
            var AdminMOFLayer = default(dc.MOFLayer);

            if (!ReferenceEquals(cleanMOFLayer, null))
            {
                AdminMOFLayer = new dc.MOFLayer()
                {
                    MOFLayerId = cleanMOFLayer.MOFLayerId,
                    MOFLayerName = cleanMOFLayer.MOFLayerName,
                    Notes = cleanMOFLayer.Notes,
                    MOFLayerNumber = cleanMOFLayer.MOFLayerNumber,
                    LayerChoices = cleanMOFLayer.LayerChoices,
                    MOFDisplayOrder = cleanMOFLayer.MOFDisplayOrder
                };
            }

            return AdminMOFLayer;
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
        
        // OutputFormatRequest
        public static dc.OutputFormatRequest AdminCleanForAdd(this dc.OutputFormatRequest cleanOutputFormatRequest)
        {
            var AdminOutputFormatRequest = default(dc.OutputFormatRequest);

            if (!ReferenceEquals(cleanOutputFormatRequest, null))
            {
                AdminOutputFormatRequest = new dc.OutputFormatRequest()
                {
                     // default value: . 
                    OutputFormatRequestId = cleanOutputFormatRequest.OutputFormatRequestId,
                     // default value: . 
                    Name = cleanOutputFormatRequest.Name,
                     // default value: . 
                    Prompt = cleanOutputFormatRequest.Prompt,
                     // default value: . 
                    PromptVariations = cleanOutputFormatRequest.PromptVariations,
                     // default value: . 
                    OutputFormat = cleanOutputFormatRequest.OutputFormat
                };
                
            }

            return AdminOutputFormatRequest;
        }
        
        
        public static List<dc.OutputFormatRequest> AdminCleanForGet(this IEnumerable<dc.OutputFormatRequest> cleanOutputFormatRequests)
        {
            return cleanOutputFormatRequests.Select(OutputFormatRequest => OutputFormatRequest.AdminCleanForGet())
                            .ToList();
        }
        
        public static dc.OutputFormatRequest AdminCleanForGet(this dc.OutputFormatRequest cleanOutputFormatRequest)
        {
            var AdminOutputFormatRequest = default(dc.OutputFormatRequest);

            if (!ReferenceEquals(cleanOutputFormatRequest, null))
            {
                AdminOutputFormatRequest = new dc.OutputFormatRequest()
                {
                    OutputFormatRequestId = cleanOutputFormatRequest.OutputFormatRequestId,
                    Name = cleanOutputFormatRequest.Name,
                    Prompt = cleanOutputFormatRequest.Prompt,
                    PromptVariations = cleanOutputFormatRequest.PromptVariations,
                    OutputFormat = cleanOutputFormatRequest.OutputFormat
                };
            }

            return AdminOutputFormatRequest;
        }
        
        
        public static dc.OutputFormatRequest AdminCleanForUpdate(this dc.OutputFormatRequest cleanOutputFormatRequest)
        {
            var AdminOutputFormatRequest = default(dc.OutputFormatRequest);

            if (!ReferenceEquals(cleanOutputFormatRequest, null))
            {
                AdminOutputFormatRequest = new dc.OutputFormatRequest()
                {
                    OutputFormatRequestId = cleanOutputFormatRequest.OutputFormatRequestId,
                    Name = cleanOutputFormatRequest.Name,
                    Prompt = cleanOutputFormatRequest.Prompt,
                    PromptVariations = cleanOutputFormatRequest.PromptVariations,
                    OutputFormat = cleanOutputFormatRequest.OutputFormat
                };
            }

            return AdminOutputFormatRequest;
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
                    ValidationArtifact = cleanTransformedArtifact.ValidationArtifact,
                     // default value: . 
                    ActualPrompt = cleanTransformedArtifact.ActualPrompt,
                     // default value: . 
                    Response = cleanTransformedArtifact.Response,
                     // default value: . 
                    AutoNumber = cleanTransformedArtifact.AutoNumber,
                     // default value: . 
                    IsRetiredArtifact = cleanTransformedArtifact.IsRetiredArtifact,
                     // default value: . 
                    ExtensionOf = cleanTransformedArtifact.ExtensionOf
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
                    ValidationArtifact = cleanTransformedArtifact.ValidationArtifact,
                    ResponseOfArtifactBeingValidated = cleanTransformedArtifact.ResponseOfArtifactBeingValidated,
                    TransformerRawPrompt = cleanTransformedArtifact.TransformerRawPrompt,
                    TransformerIdeaPrompt = cleanTransformedArtifact.TransformerIdeaPrompt,
                    ActualPrompt = cleanTransformedArtifact.ActualPrompt,
                    Response = cleanTransformedArtifact.Response,
                    Created = cleanTransformedArtifact.Created,
                    AutoNumber = cleanTransformedArtifact.AutoNumber,
                    IsRetiredArtifact = cleanTransformedArtifact.IsRetiredArtifact,
                    IsActiveIdea = cleanTransformedArtifact.IsActiveIdea,
                    Modified = cleanTransformedArtifact.Modified,
                    SuggestedPrompt = cleanTransformedArtifact.SuggestedPrompt,
                    ExtensionOf = cleanTransformedArtifact.ExtensionOf,
                    TransformerNumber = cleanTransformedArtifact.TransformerNumber
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
                    ValidationArtifact = cleanTransformedArtifact.ValidationArtifact,
                    ActualPrompt = cleanTransformedArtifact.ActualPrompt,
                    Response = cleanTransformedArtifact.Response,
                    AutoNumber = cleanTransformedArtifact.AutoNumber,
                    IsRetiredArtifact = cleanTransformedArtifact.IsRetiredArtifact,
                    ExtensionOf = cleanTransformedArtifact.ExtensionOf
                };
            }

            return AdminTransformedArtifact;
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
                    GenerationTransformers = cleanIdea.GenerationTransformers,
                     // default value: . 
                    IsActiveIdea = cleanIdea.IsActiveIdea
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
                    GenerationTransformers = cleanIdea.GenerationTransformers,
                    GenerationTransformerNames = cleanIdea.GenerationTransformerNames,
                    GenerationTransformerFullPrompts = cleanIdea.GenerationTransformerFullPrompts,
                    IsActiveIdea = cleanIdea.IsActiveIdea
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
                    GenerationTransformers = cleanIdea.GenerationTransformers,
                    IsActiveIdea = cleanIdea.IsActiveIdea
                };
            }

            return AdminIdea;
        }

    }
}
