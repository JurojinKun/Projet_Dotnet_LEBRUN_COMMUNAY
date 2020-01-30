using System;
using System.Linq;
using Projet.Dotnet.Library.Context;
using Projet.Dotnet.Library.Model;
using Projet.Dotnet.Library.Services;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Logging;

namespace Projet.Dotnet.Web.Controllers
{
    public class PersonneController : BaseController<Personne>
    {
        public PersonneController(
            ILogger<PersonneController> logger,
            ApplicationDbContext context) : base(logger, context)
        {
        }  

        protected override IQueryable<Personne> BaseQuery() =>
            base.BaseQuery()
                // Inclure BirthCity lors d'une requête faite sur une ville
                .Include(pe => pe.TypeRole)
                .Include(pe => pe.TypeService)
                // Filtrer sur les villes qui commencent par Toul
                //.Where(p => p.BirthCity.StartsWith("Toul"))
                // Trier par ordre alpha des villes
                .OrderBy(pe => pe.TypeRole.NomRole);             
    }
}