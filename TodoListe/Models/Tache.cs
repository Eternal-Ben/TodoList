using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Data.Entity;


namespace TodoListe.Models
{
    public class Tache
    {// Les attribues que l'on donne à cette une tâche : (s'aider de l'uml de classe, du tableau crée et du product backlog)
        public int ID { get; set; }

        public string Nom { get; set; }

        public DateTime Datefin { get; set; }

        public bool Statut { get; set; }

        public int Priorite { get; set; }

    }
}