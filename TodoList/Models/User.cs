using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Web;

namespace TodoList.Models
{
	public class User
	{
		public int ID {get; set;}

        [Required] // on precise q'l sont les parametre, ci dessous, que l'on souhaite avoir 
        [StringLength(30)] // on limit le string à 20 char
        [Column("Name")] // renommage de nom de colonne propre à code Firts
        public string Nom { get; set; }

        [Required] // on precise q'l sont les parametre, ci dessous, que l'on souhaite avoir 
        public string Groupe { get; set; }

        [StringLength(4)]
        [Required] // on precise q'l sont les parametre, ci dessous, que l'on souhaite avoir 
        public string MotDePasse { get; set; }
    }
}

//reste a voir si une PK ou FK est necessaire ici puis creer