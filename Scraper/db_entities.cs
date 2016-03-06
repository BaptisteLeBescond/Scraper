using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Scraper
{
    // DBcontext class : handles all interaction with the MySQL DB
    public class db_Entities : DbContext
    {
        public db_Entities() : base(nameOrConnectionString: "DBconnection") { }

        public DbSet<Article> Article { get; set; }
    }
}
