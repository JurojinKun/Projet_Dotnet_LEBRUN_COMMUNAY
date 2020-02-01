using System;
using System.Collections.Generic;
using System.Linq;
using Projet.Dotnet.Library.Context;
using Projet.Dotnet.Library.Model;
using Microsoft.Extensions.Logging;

namespace Projet.Dotnet.Library.Services
{
    public class DataInitializer : IDataInitializer
    { 
        private List<string> _firstNames => new List<string>
        {
            "Sang", 
            "Anne",
            "Boris",
            "Pierre",
            "Laura",
            "Hadrien",
            "Camille",
            "Louis",
            "Alicia"
        };
        private List<string> _lastNames => new List<string>
        {
            "Schuck",
            "Arbousset",
            "Lopasso",
            "Jubert",
            "Lebrun",
            "Dutaud",
            "Sarrazin",
            "Vu Dinh"
        };

        private List<string> _telephone => new List<string>
        {
            "0615452578",
            "0785452114"
        };

        private List<string> _mail => new List<string>
        {
            "random1@gmail.com",
            "random2@gmail.com"
        };

        // Générateur aléatoire
        private readonly Random _random;

        // DI de ApplicationDbContext
        private readonly ApplicationDbContext _context;
        private readonly ILogger<DataInitializer> _logger;
        public DataInitializer(
            ILogger<DataInitializer> logger,
            ApplicationDbContext context)
        {
            _context = context;
            _logger = logger;
            _random = new Random();
        }

        // Générateur de prénom
        private string RandomFirstName => 
            _firstNames[_random.Next(_firstNames.Count)];
        // Générateur de nom
        private string RandomLastName => 
            _lastNames[_random.Next(_lastNames.Count)];

        private string RandomTelephone => 
            _telephone[_random.Next(_telephone.Count)];

        private string RandomMail => 
            _mail[_random.Next(_mail.Count)];
        
        private Role RandomRole
        {
            get
            {
                var roles = _context.RoleCollection.ToList();
                return roles[_random.Next(roles.Count)];
            }
        }

        private Service RandomService
        {
            get
            {
                var services = _context.ServiceCollection.ToList();
                return services[_random.Next(services.Count)];
            }
        }

        // Générateur de date
        private DateTime RandomDate =>
            new DateTime(_random.Next(1980, 2010), 1, 1)
                .AddDays(_random.Next(0, 365));

         private Personne RandomPersonne => new Personne()
        {
            Prenom = RandomFirstName,
            Nom = RandomLastName,
            Anniversaire = RandomDate,
            Telephone = RandomTelephone,
            Mail = RandomMail,
            TypeRole = RandomRole,
            TypeService = RandomService
        };

        public List<Personne> GetPersonnes(int size)
        {
            var personnes = new List<Personne>();
            for(var i = 0 ; i < size ; i++)
            {
                personnes.Add(RandomPersonne);
            }
            return personnes;
        }

        public List<Role> GetRole()
        {
            return new List<Role>
            {
                new Role { NomRole = "Utilisateur" },
                new Role { NomRole = "Manager" },
                new Role { NomRole = "Administrateur" },
                new Role { NomRole = "Superadministrateur" },
                new Role { NomRole = "PDG" },
                new Role { NomRole = "Client" },
                new Role { NomRole = "Assistant" }
            };
        }

        public List<Service> GetService()
        {
            return new List<Service>
            {
                new Service { NomService = "Marketing" },
                new Service { NomService = "Production"}
            };
        }

        public void DropDatabase()
        {
            _logger.LogWarning("Dropping database");
            _context.Database.EnsureDeleted();
        }
            

        public void CreateDatabase()
        {
            _logger.LogWarning("Creating database");
            _context.Database.EnsureCreated();
        }

        public void AddPersonnes()
        {
            _logger.LogWarning("Adding personnes...");
            if (_context.PersonneCollection.Any()) return;
            var personnes = GetPersonnes(50);
            _context.AddRange(personnes);
            _context.SaveChanges();
        }

        public void AddRoles()
        {
            _logger.LogWarning("Adding roles...");
            if (_context.RoleCollection.Any()) return;
            var roles = GetRole();
            _context.AddRange(roles);
            _context.SaveChanges();
        }

        public void AddServices()
        {
            _logger.LogWarning("Adding services...");
            if (_context.ServiceCollection.Any()) return;
            var services = GetService();
            _context.AddRange(services);
            _context.SaveChanges();
        }
    }
}