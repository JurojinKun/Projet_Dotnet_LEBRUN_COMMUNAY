  
using System.Collections.Generic;
using Projet.Dotnet.Library.Model;

namespace Projet.Dotnet.Library.Services
{
    public interface IDataInitializer
    {
         List<Person> GetPersons(int size);
         void DropDatabase();
         void CreateDatabase();
         void AddPersons();
         void AddCities();
    }
}