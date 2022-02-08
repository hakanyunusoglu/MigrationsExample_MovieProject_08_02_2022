using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace MigrationExample08_02_2022.Entity
{
    public class Category
    {
        public int CategoryID { get; set; }
        public string CategoryName { get; set; }

        ICollection<Movie> Movie { get; set; }
    }
}