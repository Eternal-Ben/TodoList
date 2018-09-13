using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace TodoListe.Models
{
    public class Tache
    {// Ce que l'ion a dans une tahe :
        public int ID { get; set; }

        public string Nom { get; set; }

        public DateTime Datefin { get; set; }

        public bool Statut { get; set; }

        public int Priorite { get; set; }

    }
}