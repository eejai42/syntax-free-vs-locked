using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Text;

namespace CLIClassLibrary.Controllers
{
    public partial class HomeController : Controller
    {
        public IActionResult Index()
        {
            var actions = new List<Endpoint>(new Endpoint[]
            {
                new Endpoint()
                {
                    Name = "Invoices",
                    Method = "GET",
                    Url = "/Invoices",
                    Description = "Get's a list of invoices from the data source."
                },
                new Endpoint()
                {
                    Name = "PromptInputAnswerKeies",
                    Method = "GET",
                    Url = "/PromptInputAnswerKeies",
                    Description = "Get's a list of PromptInputAnswerKeies from the data source."
                }
            ,
                new Endpoint()
                {
                    Name = "GenerationTransformers",
                    Method = "GET",
                    Url = "/GenerationTransformers",
                    Description = "Get's a list of GenerationTransformers from the data source."
                }
            ,
                new Endpoint()
                {
                    Name = "IdeaTransformers",
                    Method = "GET",
                    Url = "/IdeaTransformers",
                    Description = "Get's a list of IdeaTransformers from the data source."
                }
            ,
                new Endpoint()
                {
                    Name = "MOFNodes",
                    Method = "GET",
                    Url = "/MOFNodes",
                    Description = "Get's a list of MOFNodes from the data source."
                }
            ,
                new Endpoint()
                {
                    Name = "MOFChoices",
                    Method = "GET",
                    Url = "/MOFChoices",
                    Description = "Get's a list of MOFChoices from the data source."
                }
            ,
                new Endpoint()
                {
                    Name = "DataFormats",
                    Method = "GET",
                    Url = "/DataFormats",
                    Description = "Get's a list of DataFormats from the data source."
                }
            ,
                new Endpoint()
                {
                    Name = "Generations",
                    Method = "GET",
                    Url = "/Generations",
                    Description = "Get's a list of Generations from the data source."
                }
            ,
                new Endpoint()
                {
                    Name = "AppUsers",
                    Method = "GET",
                    Url = "/AppUsers",
                    Description = "Get's a list of AppUsers from the data source."
                }
            ,
                new Endpoint()
                {
                    Name = "MOFLayers",
                    Method = "GET",
                    Url = "/MOFLayers",
                    Description = "Get's a list of MOFLayers from the data source."
                }
            ,
                new Endpoint()
                {
                    Name = "LLMs",
                    Method = "GET",
                    Url = "/LLMs",
                    Description = "Get's a list of LLMs from the data source."
                }
            ,
                new Endpoint()
                {
                    Name = "OutputFormatRequests",
                    Method = "GET",
                    Url = "/OutputFormatRequests",
                    Description = "Get's a list of OutputFormatRequests from the data source."
                }
            ,
                new Endpoint()
                {
                    Name = "TransformedArtifacts",
                    Method = "GET",
                    Url = "/TransformedArtifacts",
                    Description = "Get's a list of TransformedArtifacts from the data source."
                }
            ,
                new Endpoint()
                {
                    Name = "Ideas",
                    Method = "GET",
                    Url = "/Ideas",
                    Description = "Get's a list of Ideas from the data source."
                }
            
            });
            return Json(actions);
        }
    }
}