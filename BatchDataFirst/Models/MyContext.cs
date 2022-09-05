using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BatchDataFirst.Models
{
    //class MyContext
    public class MyContext : DbContext
    {
        public MyContext() : base()
        {

        }

        public DbSet<am_ant_sys> am_ant_sys { get; set; }
        //public DbSet<Grade> Grades { get; set; }
    }
}
