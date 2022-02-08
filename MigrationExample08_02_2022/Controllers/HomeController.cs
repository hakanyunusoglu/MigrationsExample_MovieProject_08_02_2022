using MigrationExample08_02_2022.Entity;
using MigrationExample08_02_2022.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace MigrationExample08_02_2022.Controllers
{
    public class HomeController : Controller
    {
        DatabaseContext db = new DatabaseContext();
        public ActionResult Index()
        {
            Movies m = new Movies();
            m.movies = db.Movies.ToList();
            m.categories = db.Categories.ToList();
            return View(m);
        }
    }
}