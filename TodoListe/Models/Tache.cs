using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Data.Entity;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace TodoListe.Models
{
    public class Tache
    {// Ce que l'on a dans une tache :
        public int ID { get; set; }
        [Required]
        [StringLength(30)]

        public string Nom { get; set; }
        [StringLength(250)]

        public string Description { get; set; }

        public DateTime ? Datefin { get; set; }
        [Required]

        public bool Statut { get; set; }

        public int Priorite { get; set; }

        public int CategorieID { get; set; }
        [ForeignKey("CategorieID")] // pour la creation d'une clee etrangere; [ForeignKey("nom de la ForeignKey")], cela correspondant a la clee primaire de la table Categorie

        public Categorie Categorie { get; set; }
    }
}