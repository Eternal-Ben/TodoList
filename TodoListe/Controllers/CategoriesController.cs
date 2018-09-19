using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Web.Http;
using TodoList.Data;
using TodoList.Models;

/*
 A chaque dbcontext on doit liberer dispo le context pour liberer la memoire
 une instance par db controller puis le liberer via dispose du dbcontext pour le liberer
 
     Attention à la syntax JSON, les virgule etc */

namespace TodoList.Controllers
{
    public class CategoriesController : ApiController
    {
        private TodoDbContext db = new TodoDbContext();

        public IQueryable<Categorie> GetCategories() //<> est un controleur donc aucun paramtre dans la methode car n'attend que le "GETxxx"
        {
            
            return db.Categories.OrderBy(x=>x.Nom); // permet une remise à disposition de la zone memoire ... à confirmer
       
        }

        public IHttpActionResult GetCategorie(int id) // permet de recuperes la categorie qui nous interress
        {
            var categorie = db.Categories.Find(id);
            if (categorie == null)
                return NotFound();
            return Ok(categorie);
        }

        public IHttpActionResult PostCategories(Categorie categorie)
        {
            // afin de verifier les models de la table crée il faut la ligne suivante
            if (ModelState.IsValid)
            {
                db.Categories.Add(categorie);
                db.SaveChanges();

                return Ok(categorie); // return "..." permet de retourner le code d'acces du server à la connexion de la base de donnée Ok = Status 200)

            }
            else
                return BadRequest(ModelState); //Permet de sortir l'ereur 400 dans la console web ainsi avec un resumé de l'erreure
        }
        public IHttpActionResult PutCategories(int id, Categorie categorie)
        {
            if (id != categorie.ID) // test que l'objet ID fait partit de "categorie"
                return BadRequest();

            if (!ModelState.IsValid) // le ! est un operateur implicite
                return BadRequest(ModelState); // "return" permet de ne pas solliciter un else car apres la condition, on retourne le "return"

            if (db.Categories.Count(x=> x.ID == id)!=1)
                return BadRequest();

            db.Entry(categorie).State = System.Data.Entity.EntityState.Modified;
            db.SaveChanges();

            return StatusCode(HttpStatusCode.NoContent); // pour renvoyer un message d'erreur 204 si pas de contenu dans la table
            // puis Postman afin de modifier les données de la table********
        }
        public IHttpActionResult DeleteCategories(int id) // Pour delete dans la table
        {
            var categorie = db.Categories.Find(id);
            if (categorie ==null)
                return NotFound();

            db.Entry(categorie).State = System.Data.Entity.EntityState.Deleted;
            db.SaveChanges();

            return Ok(categorie); // toujours un return ici 
        }

        protected override void Dispose(bool disposing) // override permet de reecrir la methode parente qui est en privat
        {
            base.Dispose(disposing);
            db.Dispose(); // On doit liberer la connexion au serveur apres istruction
        }
    }/* Ensuite on passe a postMann pour la gestion des tableau en Post : on va dans l'onglet Body apres avoir lancer l'app, puis tape {nom: "Categorie 1"}*/
}
