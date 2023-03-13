using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entity_Framework_Core_Code_first_forum_13_03_2023
{
    internal class StudentContext:DbContext
    {
        public DbSet<Student> Students { get; set; } = null!;

        string connection;
        public StudentContext()
        {
            connection = @" Data sourse = (localdb)\MSSQLocalDB; Initial catalog = School; integrated security = True";
        }

        protected override void  OnConfiguring (DbContextOptionsBuilder optionsBilder)
        {
            optionsBilder.UseSqlServer(connection);
        }

    }
}
