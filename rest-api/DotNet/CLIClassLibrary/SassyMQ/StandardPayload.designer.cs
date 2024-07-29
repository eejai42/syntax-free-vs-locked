
using AirtableDirect.CLI.Lib.DataClasses;
using Newtonsoft.Json;
using RabbitMQ.Client.Events;
using System;
using System.Collections.Generic;
using System.IO;
using System.Net;
using System.Text.RegularExpressions;
using System.Threading;
using System.Threading.Tasks;

namespace YP.SassyMQ.Lib.RabbitMQ
{
    public partial class StandardPayload
    {
        
        public PromptInputAnswerKey PromptInputAnswerKey { get; set; }
        public List<PromptInputAnswerKey> PromptInputAnswerKeies { get; set; }
        
        public GenerationTransformer GenerationTransformer { get; set; }
        public List<GenerationTransformer> GenerationTransformers { get; set; }
        
        public IdeaTransformer IdeaTransformer { get; set; }
        public List<IdeaTransformer> IdeaTransformers { get; set; }
        
        public MOFNode MOFNode { get; set; }
        public List<MOFNode> MOFNodes { get; set; }
        
        public MOFChoice MOFChoice { get; set; }
        public List<MOFChoice> MOFChoices { get; set; }
        
        public DataFormat DataFormat { get; set; }
        public List<DataFormat> DataFormats { get; set; }
        
        public Generation Generation { get; set; }
        public List<Generation> Generations { get; set; }
        
        public AppUser AppUser { get; set; }
        public List<AppUser> AppUsers { get; set; }
        
        public MOFLayer MOFLayer { get; set; }
        public List<MOFLayer> MOFLayers { get; set; }
        
        public LLM LLM { get; set; }
        public List<LLM> LLMs { get; set; }
        
        public OutputFormatRequest OutputFormatRequest { get; set; }
        public List<OutputFormatRequest> OutputFormatRequests { get; set; }
        
        public TransformedArtifact TransformedArtifact { get; set; }
        public List<TransformedArtifact> TransformedArtifacts { get; set; }
        
        public Idea Idea { get; set; }
        public List<Idea> Ideas { get; set; }
        

    }
}