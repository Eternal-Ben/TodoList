using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Data.Entity;
/* Le Polymorphisme : Permet d'instancier un objet à partir d'une forme et lui en donner une autre
 Un Type est donc une forme*/



namespace TodoListe.Models
{
    public class Categorie
    {
        public int ID { get; set; }

        public string Nom { get; set; }
    }
}