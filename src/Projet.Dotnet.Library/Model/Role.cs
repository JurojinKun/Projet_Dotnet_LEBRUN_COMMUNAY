namespace Projet.Dotnet.Library.Model
{
    public class Role : BaseEntity
    {
        public string NomRole {get;set;}

        //public Personne Personne {get;set;}
        //public int? PersonneId {get;set;}

        public override string ToString() =>
            $"{NomRole}";
    }
}