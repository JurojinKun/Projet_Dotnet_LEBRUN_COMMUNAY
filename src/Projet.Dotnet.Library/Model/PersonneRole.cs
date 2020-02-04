namespace Projet.Dotnet.Library.Model
{
    public class RolePerson : BaseEntity
    {
        public Personne Personne { get;set; }
        public int PersonneId { get;set; }
        public Role Role { get;set; }
        public int RoleId { get;set; }
    }
}