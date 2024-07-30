
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
        
        public IdeaTransformer IdeaTransformer { get; set; }
        public List<IdeaTransformer> IdeaTransformers { get; set; }
        
        public AppUser AppUser { get; set; }
        public List<AppUser> AppUsers { get; set; }
        
        public GenerationTransformer GenerationTransformer { get; set; }
        public List<GenerationTransformer> GenerationTransformers { get; set; }
        
        public Generation Generation { get; set; }
        public List<Generation> Generations { get; set; }
        
        public IdeaFeature IdeaFeature { get; set; }
        public List<IdeaFeature> IdeaFeatures { get; set; }
        
        public TransformedArtifact TransformedArtifact { get; set; }
        public List<TransformedArtifact> TransformedArtifacts { get; set; }
        
        public DesignDecision DesignDecision { get; set; }
        public List<DesignDecision> DesignDecisions { get; set; }
        
        public LLM LLM { get; set; }
        public List<LLM> LLMs { get; set; }
        
        public Idea Idea { get; set; }
        public List<Idea> Ideas { get; set; }
        

    }
}