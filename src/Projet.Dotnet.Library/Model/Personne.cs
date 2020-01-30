using System;
using System.ComponentModel.DataAnnotations.Schema;

namespace Projet.Dotnet.Library.Model
{

    public class Personne : BaseEntity
    {
        public string Nom {get;set;}
        public string Prenom {get;set;}
        public DateTime? Anniversaire {get;set;}
        public string Telephone {get;set;}
        public string Mail {get;set;}

        public Role TypeRole {get;set;}
        public int? TypeRoleId {get;set;}

        //Relation avec le service
        public Service TypeService {get;set;}
        public int? TypeServiceId {get;set;}


        [NotMapped]
        public int? Age => Anniversaire.HasValue ?

            (int)((DateTime.Now - Anniversaire.Value).TotalDays / 365) :
            new int?();

        public override string ToString() =>
            $"{Nom} {Prenom} | {Anniversaire} ({Age}) | {TypeRole} / {TypeService}";
        
    }

}