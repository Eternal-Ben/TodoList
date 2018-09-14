using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Web.Http;
using TodoListe.Data;
using TodoListe.Models;

/*
 A chaque dbcontext on doit liberer dispo le context pour liberer la memoire
 une instance par db controller puis le liberer via dispose du dbcontext pour le liberer
 */

namespace TodoListe.Controllers
{
    public class CategoriesController : ApiController
    {
        private TodoDbContext db = new TodoDbContext();

        public IQueryable<Categorie> GetCategories()
        {
            using (TodoDbContext db2=new TodoDbContext())
            {
            return db.Categories.OrderBy(x=>x.Nom); // permet une remise à disposition de la zone memoire ... à confirmer
            }
        }
        public IHttpActionResult PostCategories(Categorie categorie)
        {
            db.Categories.Add(categorie);
            db.SaveChanges();

            return Ok(categorie); // return "..." permet de retourner le code d'acces du server à la connexion de la base de donnée Ok = Status 200)
        }

        protected override void Dispose(bool disposing) // override permet de reecrir la methode parente qui est en privat
        {
            base.Dispose(disposing);
            db.Dispose(); // On doit liberer la connexion au serveur apres istruction
        }
    }/* Ensuite on passe a postMann pour la gestion des tableau en Post : on va dans l'onglet Body apres avoir lancer l'app, puis tape {nom: "Categorie 1"}*/
}
