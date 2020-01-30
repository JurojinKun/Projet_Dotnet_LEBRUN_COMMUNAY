using System;
using System.Linq;
using Projet.Dotnet.Library.Context;
using Projet.Dotnet.Library.Model;
using Projet.Dotnet.Library.Services;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;

namespace Projet.Dotnet.Web.Controllers
{
    public class ServiceController : BaseController<Service>
    {
        public ServiceController(
            ILogger<ServiceController> logger,
            ApplicationDbContext context) : base(logger, context)
        {
        }
    }
}