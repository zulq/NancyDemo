using System;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;
using Nancy;
using NancyDemo.Data;

namespace NancyDemo.Modules
{
    public class HomeModule : NancyModule
    {
        public HomeModule()
        {
            Get("/", async (args, ct) => await Task.FromResult($"Ponder over the long journey {DateTime.Now.Year}."));
           
        }
    }
}