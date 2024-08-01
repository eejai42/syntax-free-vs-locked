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
                    Name = "TrialArtifacts",
                    Method = "GET",
                    Url = "/TrialArtifacts",
                    Description = "Get's a list of TrialArtifacts from the data source."
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
                    Name = "GenerationTransformers",
                    Method = "GET",
                    Url = "/GenerationTransformers",
                    Description = "Get's a list of GenerationTransformers from the data source."
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
                    Name = "Trials",
                    Method = "GET",
                    Url = "/Trials",
                    Description = "Get's a list of Trials from the data source."
                }
            ,
                new Endpoint()
                {
                    Name = "ExperimentTransformers",
                    Method = "GET",
                    Url = "/ExperimentTransformers",
                    Description = "Get's a list of ExperimentTransformers from the data source."
                }
            ,
                new Endpoint()
                {
                    Name = "ExperimentFeatures",
                    Method = "GET",
                    Url = "/ExperimentFeatures",
                    Description = "Get's a list of ExperimentFeatures from the data source."
                }
            ,
                new Endpoint()
                {
                    Name = "DesignDecisions",
                    Method = "GET",
                    Url = "/DesignDecisions",
                    Description = "Get's a list of DesignDecisions from the data source."
                }
            ,
                new Endpoint()
                {
                    Name = "Experiments",
                    Method = "GET",
                    Url = "/Experiments",
                    Description = "Get's a list of Experiments from the data source."
                }
            ,
                new Endpoint()
                {
                    Name = "LLMs",
                    Method = "GET",
                    Url = "/LLMs",
                    Description = "Get's a list of LLMs from the data source."
                }
            
            });
            return Json(actions);
        }
    }
}