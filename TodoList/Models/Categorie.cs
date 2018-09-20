using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Data.Entity;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
/* Le Polymorphisme : Permet d'instancier un objet à partir d'une forme et lui en donner une autre
Un Type est donc une forme*/



namespace TodoList.Models
{
    public class Categorie
    {
        public int ID { get; set; }

        /* Ligne suivante indique les propriétés de la table qui precise que sa presence est requise avec un string de taille de 20char max et nom de la colonne est nommé "Name"*/
        [Required] // on precise q'l sont les parametre, ci dessous, que l'on souhaite avoir 
        [StringLength(20)] // on limit le string à 20 char
        [Column("Name")] // selection de la colonne Name qui est la propriete
        public string Nom { get; set; }
    }
}