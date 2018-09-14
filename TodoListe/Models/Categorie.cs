using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Data.Entity;


namespace TodoListe.Models
{
    public class Categorie // nom de la classe qui est visible et accessible par les autres classe du programme et du systeme
    {
        public int ID { get; set; }  //nom des parametres declarés accessible grace public

        public string Nom { get; set; } // get afin de recupere et set pour mettre a dispo
    }
}