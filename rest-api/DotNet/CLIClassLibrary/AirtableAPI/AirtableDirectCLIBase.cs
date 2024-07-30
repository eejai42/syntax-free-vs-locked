
using CLIClassLibrary.RoleHandlers;
using Newtonsoft.Json;
using Plossum.CommandLine;
using System;
using System.Diagnostics;
using System.IO;
using System.Linq;
using System.Reflection;
using System.Text;

namespace AirtableDirect.CLI.Lib.Handlers
{
/*
    public abstract partial class AirtableDirectCLIHandlerBase<T> : AirtableDirectCLIHandlerBase
    {
        private RoleHandlerBase _roleHandler;
        private T _loggedInUser;

        public EAPICLIHandlerBase(string[] args)
        {
            var list = args.ToList();
            list.Insert(0, "cli");
            this.Parser = new CommandLineParser(this);
            this.Parser.Parse(list.ToArray());
        }

        
        protected abstract string HandleCreateIdeaTransformer();
        protected abstract string HandleReadIdeaTransformer();
        protected abstract string HandleUpdateIdeaTransformer();
        protected abstract string HandleDeleteIdeaTransformer();
        
        protected abstract string HandleCreateAppUser();
        protected abstract string HandleReadAppUser();
        protected abstract string HandleUpdateAppUser();
        protected abstract string HandleDeleteAppUser();
        
        protected abstract string HandleCreateGenerationTransformer();
        protected abstract string HandleReadGenerationTransformer();
        protected abstract string HandleUpdateGenerationTransformer();
        protected abstract string HandleDeleteGenerationTransformer();
        
        protected abstract string HandleCreateGeneration();
        protected abstract string HandleReadGeneration();
        protected abstract string HandleUpdateGeneration();
        protected abstract string HandleDeleteGeneration();
        
        protected abstract string HandleCreateIdeaFeature();
        protected abstract string HandleReadIdeaFeature();
        protected abstract string HandleUpdateIdeaFeature();
        protected abstract string HandleDeleteIdeaFeature();
        
        protected abstract string HandleCreateTransformedArtifact();
        protected abstract string HandleReadTransformedArtifact();
        protected abstract string HandleUpdateTransformedArtifact();
        protected abstract string HandleDeleteTransformedArtifact();
        
        protected abstract string HandleCreateDesignDecision();
        protected abstract string HandleReadDesignDecision();
        protected abstract string HandleUpdateDesignDecision();
        protected abstract string HandleDeleteDesignDecision();
        
        protected abstract string HandleCreateLLM();
        protected abstract string HandleReadLLM();
        protected abstract string HandleUpdateLLM();
        protected abstract string HandleDeleteLLM();
        
        protected abstract string HandleCreateIdea();
        protected abstract string HandleReadIdea();
        protected abstract string HandleUpdateIdea();
        protected abstract string HandleDeleteIdea();
        

        protected abstract string HandleCustomRequest();

        private string CheckWhoIAmNow()
        {
            if (!this.AccountFileInfo.Exists) throw new Exception($"Must must first authenticate as {runas}");
            else
            {
                var json = File.ReadAllText(this.AccountFileInfo.FullName);
                return JsonConvert.SerializeObject(new { WhoAmI = JsonConvert.DeserializeObject(json), Role = this.runas }, Formatting.Indented);
            }
        }

        public T LoggedInUser
        {
            get
            {
                if (_loggedInUser is null)
                {
                    if (!AccountFileInfo.Exists) throw new Exception("Must authenticate and check who-am-i before this will work.");

                    var accountJson = File.ReadAllText(AccountFileInfo.FullName);
                    _loggedInUser = JsonConvert.DeserializeObject<T>(accountJson);
                }
                return _loggedInUser;
            }
            set => _loggedInUser = value;
        }

        private string ReloadCacheNow()
        {
            // Load Static Data Here
            var success = this.CustomReloadCache();

            return "{\"Success\":true}";
        }

        protected abstract bool CustomReloadCache();

        public static DirectoryInfo RootFileInfo
        {
            get
            {
                var di = new DirectoryInfo(Path.Combine(Environment.GetFolderPath(Environment.SpecialFolder.UserProfile), ".eapi"));
                if (!di.Exists) di.Create();
                return di;
            }
        }

        public FileInfo AccountFileInfo
        {
            get { return new FileInfo(Path.Combine(ProjectRootPath, $"{runas}.json")); }
        }

        public string ShowHelp()
        {
            var customHelp = this.GetCustomHelp();
            if (!string.IsNullOrEmpty(customHelp)) return customHelp; 
            else return GetStandardHelp();
        }

        protected virtual string GetCustomHelp()
        {
            return null;
        }

        public string GetStandardHelp()
        {
            var sbHelpBuilder = new StringBuilder();
            var currentAssembly = Assembly.GetExecutingAssembly();
            var fvi = FileVersionInfo.GetVersionInfo(currentAssembly.Location);
            sbHelpBuilder.AppendLine($"{EAPICLIHandler.C_PROJECT_NAME} CLI Help: {fvi.FileVersion}.");
            sbHelpBuilder.AppendLine();
            var helpTerm = this.Parser.RemainingArguments.FirstOrDefault();
            if (String.IsNullOrEmpty(helpTerm)) helpTerm = "general";
            this.RoleHandler.AddHelp(sbHelpBuilder, helpTerm);
            if (helpTerm == "general")
            {
                sbHelpBuilder.AppendLine();
                sbHelpBuilder.AppendLine();
                sbHelpBuilder.AppendLine($"Syntax:");
                sbHelpBuilder.AppendLine(this.Parser.UsageInfo.ToString());
                sbHelpBuilder.AppendLine();
                sbHelpBuilder.AppendLine($"Available Roles:");
                RoleHandlerFactory.ListRoles(sbHelpBuilder);
            }
            return sbHelpBuilder.ToString();
        }

        private void SetDefaultCLIParameters()
        {
            var firstArgument = this.Parser.RemainingArguments.FirstOrDefault();

            if (String.Equals(firstArgument, "help", StringComparison.OrdinalIgnoreCase))
            {
                this.help = true;
                this.Parser.RemainingArguments.RemoveAt(0);
            }
            if (String.Equals(firstArgument, "reloadCache", StringComparison.OrdinalIgnoreCase))
            {
                this.reloadCache = true;
                this.Parser.RemainingArguments.RemoveAt(0);
            }

            if (String.IsNullOrEmpty(this.runas)) this.runas = GetMostRecentUser();
            if (String.IsNullOrEmpty(this.runas)) this.runas = "guest";
            this.runas = this.runas.ToLower();

            firstArgument = this.Parser.RemainingArguments.FirstOrDefault();
            this.CheckDefaultCLIParameters(firstArgument);
        }

        protected abstract void CheckDefaultCLIParameters(string firstArgument);

        public CommandLineParser Parser { get; protected set; }

        public static void HandleRequest(string[] args)
        {
            var handler = new EAPICLIHandler(args);
            Console.WriteLine(handler.ProcessRequest());
        }
    }
*/
    public partial class EAPICLIHandlerBase
    {

    }
}

                    