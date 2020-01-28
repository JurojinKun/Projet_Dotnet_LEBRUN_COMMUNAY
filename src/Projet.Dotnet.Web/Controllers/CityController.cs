using System;
using System.Linq;
using Projet.Dotnet.Library.Context;
using Projet.Dotnet.Library.Model;
using Projet.Dotnet.Library.Services;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;

namespace Projet.Dotnet.Web.Controllers
{
    public class CityController : BaseController<City>
    {
        public CityController(
            ILogger<CityController> logger,
            ApplicationDbContext context) : base(logger, context)
        {
        }
    }
}