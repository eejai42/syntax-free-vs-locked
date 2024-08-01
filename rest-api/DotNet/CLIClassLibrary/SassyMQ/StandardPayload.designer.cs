
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
        
        public TrialArtifact TrialArtifact { get; set; }
        public List<TrialArtifact> TrialArtifacts { get; set; }
        
        public AppUser AppUser { get; set; }
        public List<AppUser> AppUsers { get; set; }
        
        public GenerationTransformer GenerationTransformer { get; set; }
        public List<GenerationTransformer> GenerationTransformers { get; set; }
        
        public Generation Generation { get; set; }
        public List<Generation> Generations { get; set; }
        
        public Trial Trial { get; set; }
        public List<Trial> Trials { get; set; }
        
        public ArtifactAnalysi ArtifactAnalysi { get; set; }
        public List<ArtifactAnalysi> ArtifactAnalysis { get; set; }
        
        public ExperimentTransformer ExperimentTransformer { get; set; }
        public List<ExperimentTransformer> ExperimentTransformers { get; set; }
        
        public ExperimentFeature ExperimentFeature { get; set; }
        public List<ExperimentFeature> ExperimentFeatures { get; set; }
        
        public DesignDecision DesignDecision { get; set; }
        public List<DesignDecision> DesignDecisions { get; set; }
        
        public Experiment Experiment { get; set; }
        public List<Experiment> Experiments { get; set; }
        
        public LLM LLM { get; set; }
        public List<LLM> LLMs { get; set; }
        

    }
}