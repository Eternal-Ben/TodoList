using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Data.Entity;
using TodoListe.Models;

namespace TodoListe.Data
{
    public class TodoDbContext:DbContext
    {
      public TodoDbContext(): base("TodoListConnectionString")
        {

        } 
        
        public DbSet<Categorie> GetCategories { get; set; } // une interface
    }
}