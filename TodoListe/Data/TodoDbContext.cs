/* Ne jamais suprimer un fichier de migration de base de donnee.
 * 
 * 
 * Systeme de migration, permet le transfert de la structure de la BD
 * Ligne de creation dans la console visual studio:
 *  add-migration Init
 * 
 */
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Data.Entity;
using TodoList.Models;

namespace TodoList.Data
{
    public class TodoDbContext:DbContext
    {

	// On passe en parrametre le nom de nôtre connection String (qui correspond à notre BD) dans l'objet base du DbContext qui herite de TodoDbContext
	// Permet alors ensuite la mise à disposition ou la recupération d'objet à travers la class DbSet (est une class qui generalise)
		public TodoDbContext(): base("TodoListConnectionString")
        {
        }

		// "DbSet<T 'le type'qui peut etre une class donc>" Une classe generique car elle aplique la generissité : heritage de class
		// pluriel dans les DbContext | on generise la class qui va servir de model de structure pour les tables
		public DbSet<Categorie> Categories { get; set; }
        public DbSet<Tache> Taches { get; set; }
		// on integre le model de la table Taches, une fois ecrit on fait l'integration de cette table "add-migration Init" ou si dejà créé un "update-database"
		public DbSet<User> Users { get; set; }
	}
}

/*	
 *	DbSet<T> Une classe générique ne sait pas q'l type q'l va manip, mais une fois en memo on va lui fournir le type a manip puis elle va s'adaptater au type	
 */
