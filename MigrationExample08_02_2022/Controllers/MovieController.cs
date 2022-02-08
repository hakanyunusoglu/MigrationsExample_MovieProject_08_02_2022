using MigrationExample08_02_2022.Entity;
using MigrationExample08_02_2022.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace MigrationExample08_02_2022.Controllers
{
    public class MovieController : Controller
    {
        DatabaseContext db = new DatabaseContext();
        Movies model = new Movies();
        public ActionResult Detail(int? id)
        {
            model.movie = db.Movies.Find(id);
            model.categories = db.Categories.ToList();
            return View(model);
        }
    }
}