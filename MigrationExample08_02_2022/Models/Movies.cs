using MigrationExample08_02_2022.Entity;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace MigrationExample08_02_2022.Models
{
    public class Movies
    {
        public List<Movie> movies { get; set; }
        public List<Category> categories { get; set; }
        public Movie movie { get; set; }
        public Category category { get; set; }
    }
}