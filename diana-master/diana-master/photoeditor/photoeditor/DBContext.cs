using photoeditor;
using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace photoeditor
{
    class DBContext : DbContext
    {
        public DBContext() : base("DefaultConnection")
        {
        }
        public DbSet<User>       Users  { get; set; }
        public DbSet<Log>        Logs   { get; set; }
        public DbSet<img2.Image> Images { get; set; }
    }

}

