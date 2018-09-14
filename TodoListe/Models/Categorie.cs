using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Data.Entity;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
/* Le Polymorphisme : Permet d'instancier un objet à partir d'une forme et lui en donner une autre
Un Type est donc une forme*/



namespace TodoListe.Models
{
    public class Categorie
    {
        public int ID { get; set; }

        [Required] // on precise q'l sont les parametre, ci dessous, que l'on souhaite avoir 
        [StringLength(20)] // on limit le nombre de char à 20
        [Column("Name")] // selection de la colonne Name
        public string Nom { get; set; }
    }
}