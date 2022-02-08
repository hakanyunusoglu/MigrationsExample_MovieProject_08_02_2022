using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace MigrationExample08_02_2022.Entity
{
    public class Movie
    {
        public int MovieID { get; set; }
        public string MovieName { get; set; }
        public string MovieDescription { get; set; }
        public string MovieTitle { get; set; }
        public string MovieImage { get; set; }

        public Category Category { get; set; }
    }
}