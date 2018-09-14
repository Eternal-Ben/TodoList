using System;
using System.Collections.Generic;
using System.Data.Entity.Migrations;
using System.Linq;
using System.Web;
using TodoListe.Data;
/* */

namespace TodoListe.Migrations
{// Les":" indique que la classe Configuration herite de la class DbMigrationsConf
    public class Configuration : DbMigrationsConfiguration<TodoDbContext>
    {
        public Configuration() // le constructeur de la class Configuration
        {
            AutomaticMigrationsEnabled = false; // pour ne pas foirer al migration
        }
    }
}
/* Affichage>Autre fentre> add-migration "le nom de la migration" va creer une classe :
 PM> add-migration Init << nom de la migration que l'on a donné*/

