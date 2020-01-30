  
using System.Collections.Generic;
using Projet.Dotnet.Library.Model;

namespace Projet.Dotnet.Library.Services
{
    public interface IDataInitializer
    {
         List<Person> GetPersons(int size);
         List<Personne> GetPersonnes(int size);
         void DropDatabase();
         void CreateDatabase();
         void AddPersons();
         void AddCities();
         void AddPersonnes();
         void AddRoles();
         void AddServices();
    }
}