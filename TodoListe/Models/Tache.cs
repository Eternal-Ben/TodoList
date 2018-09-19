using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Data.Entity;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace TodoList.Models
{
    public class Tache
    {// Ce que l'on a dans une tache :
        public int ID { get; set; }
        [Required] // "Required" precise que sa presence est obligatoir
        [StringLength(30)] //precise le nombre de d'entier max precisé par le diag de class ou sprintBackLog

        public string Nom { get; set; }
        [StringLength(250)]

        public string Description { get; set; }

        public DateTime ? Datefin { get; set; } // s'ecrit toujours de ce format, DateTime"?" Datefin
        [Required]

        public bool Statut { get; set; }

        public int Priorite { get; set; }

        public int CategorieID { get; set; }
        [ForeignKey("CategorieID")] // pour la creation d'une clee etrangere; [ForeignKey("nom de la ForeignKey")], cela correspondant a la clee primaire de la table Categorie et permet la relation entre ces tables.

        public Categorie Categorie { get; set; }
    }
}